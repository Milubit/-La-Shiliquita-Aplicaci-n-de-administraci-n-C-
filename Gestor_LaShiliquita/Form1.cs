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
            AbrirFormularioEnPanel(new FrmVenta());
        }

        private void btnMenuProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmMantenimientoProductos());
        }

        private void btnMenuAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmAdministracion());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
