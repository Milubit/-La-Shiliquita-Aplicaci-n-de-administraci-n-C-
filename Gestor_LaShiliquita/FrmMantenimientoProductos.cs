using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Gestor_LaShiliquita
{
    public partial class FrmMantenimientoProductos : Form
    {
        private readonly string conexionString = ConfigurationManager.ConnectionStrings["CadenaShiliquita"].ConnectionString;
        public FrmMantenimientoProductos()
        {
            InitializeComponent();
            CargarDatosIniciales();
        }
        private void CargarDatosIniciales()
        {
            ListarProductos();
            CargarProveedores();
        }
        private void ListarProductos()
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    // Usamos los nombres exactos de tus columnas
                    string query = "SELECT IDProducto, nomProd, descripcion, categoria, precio, stock, nroDocProveedor FROM PRODUCTOS";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvProductos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al listar productos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CargarProveedores()
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT nroDocProveedor, nomEmpresa FROM PROVEEDOR";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cmbProveedor.DataSource = dt;
                    cmbProveedor.DisplayMember = "nomEmpresa";     
                    cmbProveedor.ValueMember = "nroDocProveedor";   

                    // Opcional: iniciar sin ningún proveedor seleccionado
                    cmbProveedor.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDProducto.Text) ||
                string.IsNullOrWhiteSpace(txtNomProd.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios del producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que se haya seleccionado un proveedor real de la lista
            if (cmbProveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un proveedor válido para este producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string queryValidar = "SELECT COUNT(*) FROM PRODUCTOS WHERE IDProducto = @IDProducto";
                    using (SqlCommand cmdValidar = new SqlCommand(queryValidar, conexion))
                    {
                        cmdValidar.Parameters.AddWithValue("@IDProducto", txtIDProducto.Text.Trim().ToUpper());
                        int existe = (int)cmdValidar.ExecuteScalar();

                        if (existe > 0)
                        {
                            MessageBox.Show("Error: El ID del producto ya se encuentra registrado en el sistema.", "Control de Duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    string queryInsert = @"INSERT INTO PRODUCTOS (IDProducto, nomProd, descripcion, categoria, precio, stock, nroDocProveedor)  
                                          VALUES (@IDProducto, @nomProd, @descripcion, @categoria, @precio, @stock, @nroDocProveedor)";

                    using (SqlCommand cmdInsert = new SqlCommand(queryInsert, conexion))
                    {
                        cmdInsert.Parameters.AddWithValue("@IDProducto", txtIDProducto.Text.Trim().ToUpper());
                        cmdInsert.Parameters.AddWithValue("@nomProd", txtNomProd.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());

                        // Si manejas un txtCategoria, lo mapeas aquí. Si no lo usas, mandamos un valor general o DBNull
                        cmdInsert.Parameters.AddWithValue("@categoria", "General");

                        cmdInsert.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text.Trim()));
                        cmdInsert.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text.Trim()));
                        cmdInsert.Parameters.AddWithValue("@nroDocProveedor", cmbProveedor.SelectedValue.ToString());

                        cmdInsert.ExecuteNonQuery();
                    }

                    MessageBox.Show("¡Producto guardado exitosamente en La Shiliquita!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarProductos(); // Refresca la tabla visual
                    LimpiarCampos();   // Limpia los campos de texto
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LimpiarCampos()
        {
            txtbIDProducto.Clear();
            txtbNombreProducto.Clear();
            txtbDescripcionProducto.Clear();
            txtbPrecioProducto.Clear();
            txtbStockProducto.Clear();

            cmbProveedor.SelectedIndex = -1;

            txtIDProducto.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void CargarComboBoxProveedores()
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    // Traemos el Nro de Documento (como ID único) y el Nombre de la Empresa
                    string query = "SELECT nroDocProveedor, nomEmpresa FROM PROVEEDOR";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbProveedor.DataSource = dt;
                    cmbProveedor.ValueMember = "nroDocProveedor";
                    cmbProveedor.DisplayMember = "nomEmpresa";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la lista de proveedores: " + ex.Message,
                                    "Error de Inicialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
