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
        public FrmVenta()
        {
            InitializeComponent();
        }
        private void InicializarCarrito()
        {
            // Estructura del dgv y operacion
            tablaCarrito = new DataTable();
            tablaCarrito.Columns.Add("ID_Producto", typeof(string));
            tablaCarrito.Columns.Add("Nombre_Producto", typeof(string));
            tablaCarrito.Columns.Add("Cantidad_Vendida", typeof(int));
            tablaCarrito.Columns.Add("Precio_Unid", typeof(decimal));
            tablaCarrito.Columns.Add("Subtotal", typeof(decimal), "Cantidad_Vendida * Precio_Unid");

            dgvDetalle.DataSource = tablaCarrito;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDProducto.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del producto y la cantidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT nomProd, precio, stock FROM PRODUCTOS WHERE IDProducto = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@ID", txtIDProducto.Text.Trim().ToUpper());
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nombre = reader["nomProd"].ToString();
                                decimal precio = Convert.ToDecimal(reader["precio"]);
                                int stockActual = Convert.ToInt32(reader["stock"]);
                                int cantidadPedida = Convert.ToInt32(txtCantidad.Text);

                                // Validamos si hay stock
                                if (cantidadPedida > stockActual)
                                {
                                    MessageBox.Show($"Stock insuficiente. Solo quedan {stockActual} unidades.", "Control de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                // Añadimos la fila al dgv temporal
                                tablaCarrito.Rows.Add(txtIDProducto.Text.Trim().ToUpper(), nombre, cantidadPedida, precio);

                                CalcularTotal();

                                // Limpiamos campos de producto para el siguiente elemento
                                txtbIDProducto.Clear();
                                txtbCantidad.Clear();
                                txtbIDProducto.Focus();
                            }
                            else
                            {
                                MessageBox.Show("El código del producto no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnTerminarVenta_Click(object sender, EventArgs e)
        {
            if (tablaCarrito.Rows.Count == 0)
            {
                MessageBox.Show("El carrito está vacío. Añada al menos un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIDBoleta.Text) || string.IsNullOrWhiteSpace(txtNumDocCliente.Text) || string.IsNullOrWhiteSpace(txtDniEmpleado.Text))
            {
                MessageBox.Show("Complete todos los campos de la cabecera (Boleta, Cliente y Empleado).", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    string queryValidar = "SELECT COUNT(*) FROM BOLETA WHERE ID_Boleta = @ID";
                    using (SqlCommand cmdV = new SqlCommand(queryValidar, conexion, transaccion))
                    {
                        cmdV.Parameters.AddWithValue("@ID", txtIDBoleta.Text.Trim().ToUpper());
                        if ((int)cmdV.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("El ID de Boleta ya existe. Genere uno nuevo.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaccion.Rollback();
                            return;
                        }
                    }

                    string queryBoleta = "INSERT INTO BOLETA (ID_Boleta, Fecha_hora, Total, Num_Doc_Cliente, DNI_Empleado) VALUES (@ID, @Fecha, @Total, @Cliente, @Empleado)";
                    using (SqlCommand cmdB = new SqlCommand(queryBoleta, conexion, transaccion))
                    {
                        cmdB.Parameters.AddWithValue("@ID", txtIDBoleta.Text.Trim().ToUpper());
                        cmdB.Parameters.AddWithValue("@Fecha", DateTime.Now);
                        cmdB.Parameters.AddWithValue("@Total", totalAcumulado);
                        cmdB.Parameters.AddWithValue("@Cliente", txtNumDocCliente.Text.Trim());
                        cmdB.Parameters.AddWithValue("@Empleado", txtDniEmpleado.Text.Trim());
                        cmdB.ExecuteNonQuery();
                    }
                    foreach (DataRow fila in tablaCarrito.Rows)
                    {
                        string queryDetalle = "INSERT INTO DETALLE_BOLETA (ID_Boleta, ID_Producto, Cantidad_Vendida, Precio_Unid) VALUES (@IDBoleta, @IDProd, @Cant, @Precio)";
                        using (SqlCommand cmdD = new SqlCommand(queryDetalle, conexion, transaccion))
                        {
                            cmdD.Parameters.AddWithValue("@IDBoleta", txtIDBoleta.Text.Trim().ToUpper());
                            cmdD.Parameters.AddWithValue("@IDProd", fila["ID_Producto"]);
                            cmdD.Parameters.AddWithValue("@Cant", fila["Cantidad_Vendida"]);
                            cmdD.Parameters.AddWithValue("@Precio", fila["Precio_Unid"]);
                            cmdD.ExecuteNonQuery();
                        }

                        string queryStock = "UPDATE PRODUCTOS SET Stock = Stock - @Cant WHERE ID_Productos = @IDProd";
                        using (SqlCommand cmdS = new SqlCommand(queryStock, conexion, transaccion))
                        {
                            cmdS.Parameters.AddWithValue("@Cant", fila["Cantidad_Vendida"]);
                            cmdS.Parameters.AddWithValue("@IDProd", fila["ID_Producto"]);
                            cmdS.ExecuteNonQuery();
                        }
                    }

                    transaccion.Commit();
                    MessageBox.Show("¡Venta registrada con éxito en La Shiliquita!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormularioVenta();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error crítico en la transacción: " + ex.Message, "Venta Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarFormularioVenta()
        {
            txtbIDBoleta.Clear();
            txtbNumDocCliente.Clear();
            txtbDniEmpleado.Clear();
            tablaCarrito.Rows.Clear();
            lblTotal.Text = "0.00";
            totalAcumulado = 0;
        }

        private void txtbIDBoleta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
