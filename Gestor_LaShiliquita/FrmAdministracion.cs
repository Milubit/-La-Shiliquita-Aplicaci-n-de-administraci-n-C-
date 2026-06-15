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
    public partial class FrmAdministracion : Form
    {
        private readonly string conexionString = ConfigurationManager.ConnectionStrings["CadenaShiliquita"].ConnectionString;
        
        public FrmAdministracion()
        {
            InitializeComponent();
        }
        private void FrmAdministracion_Load(object sender, EventArgs e)
        {
            ConfigurarCombosDocumentos();
            CargarTodasLasTablas();

            //CARGOS DEL EMPLEADO
            cmbCargoE.Items.Clear();
            cmbCargoE.Items.Add("Administradora");
            cmbCargoE.Items.Add("Cajero");
            cmbCargoE.Items.Add("Encargado de almacén");
            cmbCargoE.Items.Add("Reponedor");
            cmbCargoE.Items.Add("Limpieza");

            cmbCargoE.SelectedIndex = 3;
        }
        private void ConfigurarCombosDocumentos()
        {
            string[] opcionesDoc = { "DNI", "RUC", "Carnet de Extranjería" };


            cmbTipoDocC.Items.Clear();
            cmbTipoDocC.Items.AddRange(opcionesDoc);
            cmbTipoDocC.SelectedIndex = 0;


            cmbTipoDocE.Items.Clear();
            cmbTipoDocE.Items.AddRange(opcionesDoc);
            cmbTipoDocE.SelectedIndex = 0;


            cmbTipoDocProv.Items.Clear();
            cmbTipoDocProv.Items.AddRange(opcionesDoc);
            cmbTipoDocProv.SelectedIndex = 1; // Selecciona RUC por defecto para empresas
        }
        private void CargarTodasLasTablas()
        {
            ListarClientes();
            ListarEmpleados();
            ListarProveedores();
        }

        //CLIENTES
        private void ListarClientes()
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    // Ajusta los nombres de columnas según tu tabla CLIENTES
                    string query = "SELECT nroDocC, tipoDoc, primerNom, apellidoP, apellidoM, direccion FROM CLIENTES";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvClientes.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LimpiarClientes()
        {
            cmbTipoDocC.SelectedIndex = 0;
            txtbNroDocClientes.Clear();
            txtbNombresClientes.Clear();
            txtbApellidoPClientes.Clear();
            txtbApellidoMClientes.Clear();
            txtbDireccionCliente.Clear();
            txtbNroDocClientes.Focus();
        }
        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            LimpiarClientes();
        }
        private void cmbTipoDocC_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbNroDocClientes.Clear();

            if (cmbTipoDocC.Text == "DNI")
                txtbNroDocClientes.MaxLength = 8;
            else if (cmbTipoDocC.Text == "RUC")
                txtbNroDocClientes.MaxLength = 11;
            else
                txtbNroDocClientes.MaxLength = 15;
        }
        private void txtbNroDocClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //EMPLEADOS
        private void ListarEmpleados()
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT nroDocE, tipoDoc, primerNom, apellidoP, apellidoM, nroContacto, fechaContrato, cargo, salarioMen FROM EMPLEADO";
                    SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvEmpleados.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LimpiarEmpleados()
        {
            cmbTipoDocE.SelectedIndex = 0;
            txtbNroDocE.Clear();
            txtbNombreE.Clear();
            txtbApellidoPE.Clear();
            txtbApellidoME.Clear();
            txtbTelefonoE.Clear();
            txtbNroDocE.Focus();
        }
        private decimal ObtenerSalarioPorCargo(string cargo)
        {
            switch (cargo)
            {
                case "Administradora":
                    return 2500.00m;
                case "Encargado de almacén":
                    return 1500.00m;
                case "Cajero":
                case "Reponedor":
                case "Limpieza":
                    return 1200.00m;
                default:
                    return 1200.00m;
            }
        }
        private void btnLimpiarPersonal_Click(object sender, EventArgs e)
        {
            LimpiarEmpleados();
        }
        private void cmbTipoDocE_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbNroDocE.Clear();

            if (cmbTipoDocE.Text == "DNI")
                txtbNroDocE.MaxLength = 8;
            else if (cmbTipoDocE.Text == "RUC")
                txtbNroDocE.MaxLength = 11;
            else
                txtbNroDocE.MaxLength = 15;
        }
        private void txtbNroDocE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void txtbTelefonoE_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtbTelefonoE.MaxLength = 9;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //PROVEEDORES
        private void ListarProveedores()
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    
                    string query = "SELECT nroDocProveedor, tipoDoc, nomEmpresa, nroContacto1, nroContacto2, correo, direccion FROM PROVEEDOR"; SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProveedores.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LimpiarProveedores()
        {
            cmbTipoDocProv.SelectedIndex = 1; // RUC por defecto
            txtbNroDocP.Clear();
            txtbNombreEmpP.Clear();
            txtbDireccionP.Clear();
            txtbContacto1P.Clear();
            txtbContacto2P.Clear();
            txtbgmailP.Clear();
            txtbNroDocP.Focus();
        }
        private void btnLimpiarProveedor_Click(object sender, EventArgs e)
        {
            LimpiarProveedores();
        }
        private void cmbTipoDocProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbNroDocP.Clear();

            if (cmbTipoDocProv.Text == "DNI")
                txtbNroDocP.MaxLength = 8;
            else if (cmbTipoDocProv.Text == "RUC")
                txtbNroDocP.MaxLength = 11;
            else
                txtbNroDocP.MaxLength = 15;
        }
        private void txtbNroDocP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        
        //BOTONES PARA GUARDAR
        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbNroDocP.Text) || string.IsNullOrEmpty(txtbNombreEmpP.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios (Número de Documento/RUC y Nombre de la Empresa).", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO PROVEEDOR (nroDocProveedor, tipoDoc, nomEmpresa, direccion, nroContacto1, nroContacto2, correo) " + "VALUES (@nroDocProv, @tipoDoc, @nomEmpresa, @direccion, @nroContacto1, @nroContacto2, @correo)"; 
                        
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                        cmd.Parameters.AddWithValue("@nroDocProv", txtbNroDocP.Text.Trim());
                        cmd.Parameters.AddWithValue("@tipoDoc", cmbTipoDocProv.Text);
                        cmd.Parameters.AddWithValue("@nomEmpresa", txtbNombreEmpP.Text.Trim());

                        cmd.Parameters.AddWithValue("@direccion", string.IsNullOrWhiteSpace(txtbDireccionP.Text) ? (object)DBNull.Value : txtbDireccionP.Text.Trim());
                        cmd.Parameters.AddWithValue("@nroContacto1", string.IsNullOrWhiteSpace(txtbContacto1P.Text) ? (object)DBNull.Value : txtbContacto1P.Text.Trim());
                        cmd.Parameters.AddWithValue("@nroContacto2", string.IsNullOrWhiteSpace(txtbContacto2P.Text) ? (object)DBNull.Value : txtbContacto2P.Text.Trim());
                        cmd.Parameters.AddWithValue("@correo", string.IsNullOrWhiteSpace(txtbgmailP.Text) ? (object)DBNull.Value : txtbgmailP.Text.Trim());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("¡Proveedor registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListarProveedores();
                        LimpiarProveedores();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("El RUC/Documento de este proveedor ya está registrado.", "Proveedor Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error de base de datos: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbNroDocE.Text) || string.IsNullOrEmpty(txtbNombreE.Text) || string.IsNullOrEmpty(txtbApellidoPE.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios (Documento, Nombre y Apellido Paterno del empleado).", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO EMPLEADO (nroDocE, tipoDoc, primerNom, apellidoP, apellidoM, nroContacto, fechaContrato, cargo, salarioMen) " + "VALUES (@nroDocE, @tipoDoc, @primerNom, @apellidoP, @apellidoM, @nroContacto, @fechaContrato, @cargo, @salarioMen)";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nroDocE", txtbNroDocE.Text.Trim());
                        cmd.Parameters.AddWithValue("@tipoDoc", cmbTipoDocE.Text);
                        cmd.Parameters.AddWithValue("@primerNom", txtbNombreE.Text.Trim());
                        cmd.Parameters.AddWithValue("@apellidoP", txtbApellidoPE.Text.Trim());
                        cmd.Parameters.AddWithValue("@apellidoM", string.IsNullOrWhiteSpace(txtbApellidoME.Text) ? (object)DBNull.Value : txtbApellidoME.Text.Trim());
                        cmd.Parameters.AddWithValue("@nroContacto", string.IsNullOrWhiteSpace(txtbTelefonoE.Text) ? (object)DBNull.Value : txtbTelefonoE.Text.Trim());
                        //FECHA DE CONTRATO HOY
                        cmd.Parameters.AddWithValue("@fechaContrato", DateTime.Now.Date);
                        //Guardamos el texto en cbx
                        string cargoSeleccionado = cmbCargoE.Text;
                        cmd.Parameters.AddWithValue("@cargo", cargoSeleccionado); 
                        //Calculamos el sueldo
                        decimal salarioCalculado = ObtenerSalarioPorCargo(cargoSeleccionado);
                        cmd.Parameters.AddWithValue("@salarioMen", salarioCalculado);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("¡Empleado registrado con éxito para La Shiliquita!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListarEmpleados();
                        LimpiarEmpleados();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("El DNI/Documento de este empleado ya existe.", "Empleado Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error de base de datos: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbNroDocClientes.Text) || string.IsNullOrWhiteSpace(txtbNombresClientes.Text) || string.IsNullOrWhiteSpace(txtbApellidoPClientes.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios (Documento, Nombre y Apellido Paterno).", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO CLIENTES (nroDocC, tipoDoc, primerNom, apellidoP, apellidoM, direccion) " +
                                   "VALUES (@nroDocC, @tipoDoc, @primerNom, @apellidoP, @apellidoM, @direccion)";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nroDocC", txtbNroDocClientes.Text.Trim());
                        cmd.Parameters.AddWithValue("@tipoDoc", cmbTipoDocC.Text);
                        cmd.Parameters.AddWithValue("@primerNom", txtbNombresClientes.Text.Trim());
                        cmd.Parameters.AddWithValue("@apellidoP", txtbApellidoPClientes.Text.Trim());

                        cmd.Parameters.AddWithValue("@apellidoM", string.IsNullOrWhiteSpace(txtbApellidoMClientes.Text) ? (object)DBNull.Value : txtbApellidoMClientes.Text.Trim());
                        cmd.Parameters.AddWithValue("@direccion", string.IsNullOrWhiteSpace(txtbDireccionCliente.Text) ? (object)DBNull.Value : txtbDireccionCliente.Text.Trim());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("¡Cliente registrado con éxito en La Shiliquita!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientes();
                        LimpiarClientes();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("El número de documento ingresado ya se encuentra registrado.", "Documento Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error en la base de datos al guardar: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbCargoE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabEmpleados_Click(object sender, EventArgs e)
        {

        }
    }
}
