using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_LaShiliquita
{
    public partial class FrmVenta : Form
    {
        private readonly string conexionString = ConfigurationManager.ConnectionStrings["CadenaShiliquita"].ConnectionString;

        private DataTable tablaCarrito;
        private decimal totalAcumulado = 0;
        private string numeroBoletaActual = "";
        public FrmVenta()
        {
            InitializeComponent();
            InicializarCarrito();
            GenerarNumeroBoleta();
        }
        private void InicializarCarrito()
        {
            tablaCarrito = new DataTable();
            tablaCarrito.Columns.Add("IDBoleta", typeof(string));
            tablaCarrito.Columns.Add("IDProducto", typeof(string));
            tablaCarrito.Columns.Add("nomProd", typeof(string));
            tablaCarrito.Columns.Add("precioUnit", typeof(decimal));
            tablaCarrito.Columns.Add("cantVendida", typeof(int));
            tablaCarrito.Columns.Add("Subtotal", typeof(decimal), "cantVendida * precioUnit");
            dgvDetalle.DataSource = tablaCarrito;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbIDProducto.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del producto a añadir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string idBuscar = txtbIDProducto.Text.Trim().ToUpper();
            string query = "SELECT IDProducto, nomProd, precio FROM PRODUCTOS WHERE RTRIM(IDProducto) = @id";
            
            using (SqlConnection conexion = new SqlConnection(conexionString)) 
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", idBuscar);
                    try
                    {
                        conexion.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string nombreProducto = reader["nomProd"].ToString();
                            decimal precioUnitario = Convert.ToDecimal(reader["precio"]);

                            if (!int.TryParse(txtbCantidad.Text.Trim(), out int cantidadVendida) || cantidadVendida <= 0)
                            {
                                MessageBox.Show("Por favor, ingrese una cantidad válida y mayor a cero.", "Cantidad Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            tablaCarrito.Rows.Add(idBuscar, nombreProducto, precioUnitario, cantidadVendida);
                            CalcularTotal();

                            txtbIDProducto.Clear();
                            txtbCantidad.Text = "1";
                            txtbIDProducto.Focus();
                        }
                        else
                        {
                            MessageBox.Show("El código del producto no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar el producto: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void CargarAutocompletados()
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string queryClientes = "SELECT nroDocC FROM CLIENTE"; 
                    using (SqlCommand cmd = new SqlCommand(queryClientes, conexion))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbxNumC.Items.Add(reader["nroDocC"].ToString());
                            }
                        }
                    }

                    string queryEmpleados = "SELECT nroDocE FROM EMPLEADO"; 
                    using (SqlCommand cmd = new SqlCommand(queryEmpleados, conexion))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbxNumE.Items.Add(reader["nroDocE"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos de autocompletado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void GenerarNumeroBoleta()
        {
            string query = "SELECT MAX(IDBoleta) FROM BOLETA";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    try
                    {
                        conexion.Open();
                        object resultado = cmd.ExecuteScalar();

                        if (resultado == null || resultado == DBNull.Value)
                        {
                            numeroBoletaActual = "B0001";
                        }
                        else
                        {
                            string ultimoCodigo = resultado.ToString(); 
                            int numero = int.Parse(ultimoCodigo.Substring(1));
                            numero++;

                            numeroBoletaActual = "B" + numero.ToString("D4"); 
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el número de boleta correlativo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void CalcularTotal()
        {
            totalAcumulado = 0;
            foreach (DataRow fila in tablaCarrito.Rows)
            {
                totalAcumulado += Convert.ToDecimal(fila["Subtotal"]);
            }
            lblTotal.Text = totalAcumulado.ToString("0.00");
        }
        private void btnTerminarVenta_Click(object sender, EventArgs e) {

            if (tablaCarrito.Rows.Count == 0)
            {
                MessageBox.Show("El carrito está vacío. Añada al menos un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cbxNumC.Text) || string.IsNullOrWhiteSpace(cbxNumE.Text) || string.IsNullOrWhiteSpace(cbxNumE.Text))
            {
                MessageBox.Show("Complete todos los campos de la cabecera (Boleta, Cliente y Empleado).", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlTransaction transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            string idBoletaGenerado = "";
                            string queryBoleta = "INSERT INTO BOLETA (Fecha_hora, Total, nroDocC, nroDocE) " + "OUTPUT INSERTED.IDBoleta " + "VALUES (@Fecha, @Total, @Cliente, @Empleado)";

                            using (SqlCommand cmdB = new SqlCommand(queryBoleta, conexion, transaccion))
                            {
                                cmdB.Parameters.AddWithValue("@Fecha", DateTime.Now);
                                cmdB.Parameters.AddWithValue("@Total", totalAcumulado);
                                cmdB.Parameters.AddWithValue("@Cliente", cbxNumC.Text.Trim());
                                cmdB.Parameters.AddWithValue("@Empleado", cbxNumE.Text.Trim());

                                idBoletaGenerado = cmdB.ExecuteScalar()?.ToString();
                            }

                            foreach (DataRow fila in tablaCarrito.Rows)
                            {
                                string queryDetalle = "INSERT INTO DETALLE_BOLETA (IDBoleta, IDProducto, nomProd, precioUnit, cantVendida) " + "VALUES (@IdB, @IdP, @Nom, @Precio, @Cant)";
                                using (SqlCommand cmdD = new SqlCommand(queryDetalle, conexion, transaccion))
                                {
                                    cmdD.Parameters.AddWithValue("@IdB", idBoletaGenerado);
                                    cmdD.Parameters.AddWithValue("@IdP", fila["IDProducto"]);
                                    cmdD.Parameters.AddWithValue("@Nom", fila["nomProd"]);
                                    cmdD.Parameters.AddWithValue("@Precio", fila["precioUnit"]);
                                    cmdD.Parameters.AddWithValue("@Cant", fila["cantVendida"]);

                                    cmdD.ExecuteNonQuery();
                                }

                                string queryStock = "UPDATE PRODUCTOS SET Stock = Stock - @CantStock WHERE IDProducto = @IdPStock";
                                using (SqlCommand cmdS = new SqlCommand(queryStock, conexion, transaccion))
                                {
                                    cmdS.Parameters.AddWithValue("@CantStock", fila["cantVendida"]);
                                    cmdS.Parameters.AddWithValue("@IdPStock", fila["IDProducto"]);

                                    cmdS.ExecuteNonQuery();
                                }
                            }
                           transaccion.Commit();
                            MessageBox.Show("¡Venta registrada con éxito en La Shiliquita!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback();
                            MessageBox.Show("Error crítico en la transacción: " + ex.Message, "Venta Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar abrir la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LimpiarFormularioVenta();
        }
        private void LimpiarFormularioVenta()
        {
            GenerarNumeroBoleta();
            cbxNumC.SelectedIndex = -1; 
            cbxNumE.SelectedIndex = -1;

            txtbCantidad.Text = "1";
            tablaCarrito.Rows.Clear();
            lblTotal.Text = "S/. 0.00";
            totalAcumulado = 0;

            txtbIDProducto.Focus();
        }

    }
}
