using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_LaShiliquita
{
    public partial class Form1 : Form
    {
        private Form formularioActivo = null;
        
        public Form1()
        {
            InitializeComponent();
            
        }
        private void AbrirFormHijo(Form formHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None; 
            formHijo.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
        private void AbrirFormularioEnPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false;             
            fh.FormBorderStyle = FormBorderStyle.None; 
            fh.Dock = DockStyle.Fill;      

            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnMenuVentas_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            AbrirFormularioEnPanel(new FrmVenta());
        }
        private void btnMenuProductos_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            AbrirFormularioEnPanel(new FrmMantenimientoProductos());
        }
        private void btnMenuAdmin_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            AbrirFormularioEnPanel(new FrmAdministracion());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'laShiliquitaBDDataSet.BOLETA' Puede moverla o quitarla según sea necesario.
            this.bOLETATableAdapter.Fill(this.laShiliquitaBDDataSet.BOLETA);

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EstilizarBotones(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 180, 165);
            btn.ForeColor = Color.White;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(10, 0, 0, 0);
        }
    }
}
