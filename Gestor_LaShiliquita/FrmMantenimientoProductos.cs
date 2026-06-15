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
            cmbCategoriaP.Items.Clear();
            cmbCategoriaP.Items.Add("Barras de Chocolate");
            cmbCategoriaP.Items.Add("Chocolates Rellenos");
            cmbCategoriaP.Items.Add("Trufas y Bombones");
            cmbCategoriaP.Items.Add("Bebidas de Cacao");
            cmbCategoriaP.Items.Add("Packs y Regalos");
            cmbCategoriaP.Items.Add("Otros");
            cmbCategoriaP.SelectedIndex = 5;
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
            if (string.IsNullOrWhiteSpace(txtbIDProducto.Text) ||
        string.IsNullOrWhiteSpace(txtbNombreProducto.Text) ||
        string.IsNullOrWhiteSpace(txtbPrecioProducto.Text) ||
        string.IsNullOrWhiteSpace(txtbStockProducto.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios del producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtbPrecioProducto.Text.Trim(), out decimal precioConvertido))
            {
                MessageBox.Show("Por favor, ingrese un precio numérico válido (Ejemplo: 15.00).", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtbStockProducto.Text.Trim(), out int stockConvertido))
            {
                MessageBox.Show("Por favor, ingrese un número entero válido para el Stock (Ejemplo: 12).", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbProveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un proveedor válido para este producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO PRODUCTOS (IDProducto, nomProd, descripcion, categoria, precio, stock, nroDocProveedor) " +
                           "VALUES (@id, @nombre, @descripcion, @categoria, @precio, @stock, @nroDocProveedor)";
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", txtbIDProducto.Text.Trim());
                    cmd.Parameters.AddWithValue("@nombre", txtbNombreProducto.Text.Trim());
                    cmd.Parameters.AddWithValue("@descripcion", string.IsNullOrWhiteSpace(txtbDescripcionProducto.Text) ? (object)DBNull.Value : txtbDescripcionProducto.Text.Trim());
                    cmd.Parameters.AddWithValue("@categoria", string.IsNullOrWhiteSpace(cmbCategoriaP.Text) ? "Otros" : cmbCategoriaP.Text);
                    cmd.Parameters.AddWithValue("@precio", precioConvertido);
                    cmd.Parameters.AddWithValue("@stock", stockConvertido);
                    cmd.Parameters.AddWithValue("@nroDocProveedor", cmbProveedor.SelectedValue != null ? cmbProveedor.SelectedValue.ToString() : (object)DBNull.Value);
                    try
                    {
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("¡Producto registrado con éxito en el inventario!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarProductos();
                        LimpiarProductos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void LimpiarProductos()
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
            LimpiarProductos();
        }
        private void CargarComboBoxProveedores()
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    
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
    }
}
