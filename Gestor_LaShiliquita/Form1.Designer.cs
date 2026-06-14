namespace Gestor_LaShiliquita
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMenuVentas = new System.Windows.Forms.Button();
            this.btnMenuProductos = new System.Windows.Forms.Button();
            this.btnMenuAdmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(34)))), ((int)(((byte)(23)))));
            this.pnlMenu.Controls.Add(this.btnMenuVentas);
            this.pnlMenu.Controls.Add(this.btnMenuProductos);
            this.pnlMenu.Controls.Add(this.btnMenuAdmin);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 600);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnMenuVentas
            // 
            this.btnMenuVentas.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnMenuVentas.Location = new System.Drawing.Point(29, 490);
            this.btnMenuVentas.Name = "btnMenuVentas";
            this.btnMenuVentas.Size = new System.Drawing.Size(133, 45);
            this.btnMenuVentas.TabIndex = 5;
            this.btnMenuVentas.Text = "VENTA";
            this.btnMenuVentas.UseVisualStyleBackColor = true;
            this.btnMenuVentas.Click += new System.EventHandler(this.btnMenuVentas_Click);
            // 
            // btnMenuProductos
            // 
            this.btnMenuProductos.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnMenuProductos.Location = new System.Drawing.Point(29, 339);
            this.btnMenuProductos.Name = "btnMenuProductos";
            this.btnMenuProductos.Size = new System.Drawing.Size(133, 45);
            this.btnMenuProductos.TabIndex = 4;
            this.btnMenuProductos.Text = "INVENTARIO";
            this.btnMenuProductos.UseVisualStyleBackColor = true;
            this.btnMenuProductos.Click += new System.EventHandler(this.btnMenuProductos_Click);
            // 
            // btnMenuAdmin
            // 
            this.btnMenuAdmin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMenuAdmin.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnMenuAdmin.Location = new System.Drawing.Point(29, 194);
            this.btnMenuAdmin.Name = "btnMenuAdmin";
            this.btnMenuAdmin.Size = new System.Drawing.Size(133, 45);
            this.btnMenuAdmin.TabIndex = 3;
            this.btnMenuAdmin.Text = "ADMINISTRACION";
            this.btnMenuAdmin.UseVisualStyleBackColor = true;
            this.btnMenuAdmin.Click += new System.EventHandler(this.btnMenuAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-108, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(198, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(800, 600);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenuVentas;
        private System.Windows.Forms.Button btnMenuProductos;
        private System.Windows.Forms.Button btnMenuAdmin;
        private System.Windows.Forms.Panel panelContenedor;
    }
}

