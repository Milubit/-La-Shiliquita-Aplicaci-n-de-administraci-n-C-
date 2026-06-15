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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMenuVentas = new System.Windows.Forms.Button();
            this.btnMenuProductos = new System.Windows.Forms.Button();
            this.btnMenuAdmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bOLETABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laShiliquitaBDDataSet = new Gestor_LaShiliquita.LaShiliquitaBDDataSet();
            this.bOLETATableAdapter = new Gestor_LaShiliquita.LaShiliquitaBDDataSetTableAdapters.BOLETATableAdapter();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVentasRealizadas = new System.Windows.Forms.DataGridView();
            this.iDBoletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOLETABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laShiliquitaBDDataSet)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasRealizadas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(34)))), ((int)(((byte)(23)))));
            this.pnlMenu.Controls.Add(this.btnSalir);
            this.pnlMenu.Controls.Add(this.btnMenuVentas);
            this.pnlMenu.Controls.Add(this.btnMenuProductos);
            this.pnlMenu.Controls.Add(this.btnMenuAdmin);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 600);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(74)))), ((int)(((byte)(63)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(34)))), ((int)(((byte)(23)))));
            this.btnSalir.Location = new System.Drawing.Point(-13, 445);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(220, 45);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMenuVentas
            // 
            this.btnMenuVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(74)))), ((int)(((byte)(63)))));
            this.btnMenuVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuVentas.FlatAppearance.BorderSize = 0;
            this.btnMenuVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuVentas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenuVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(34)))), ((int)(((byte)(23)))));
            this.btnMenuVentas.Location = new System.Drawing.Point(-13, 372);
            this.btnMenuVentas.Name = "btnMenuVentas";
            this.btnMenuVentas.Size = new System.Drawing.Size(220, 45);
            this.btnMenuVentas.TabIndex = 5;
            this.btnMenuVentas.Text = "VENTA";
            this.btnMenuVentas.UseVisualStyleBackColor = false;
            this.btnMenuVentas.Click += new System.EventHandler(this.btnMenuVentas_Click);
            // 
            // btnMenuProductos
            // 
            this.btnMenuProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(74)))), ((int)(((byte)(63)))));
            this.btnMenuProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuProductos.FlatAppearance.BorderSize = 0;
            this.btnMenuProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuProductos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenuProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(34)))), ((int)(((byte)(23)))));
            this.btnMenuProductos.Location = new System.Drawing.Point(-13, 300);
            this.btnMenuProductos.Name = "btnMenuProductos";
            this.btnMenuProductos.Size = new System.Drawing.Size(220, 45);
            this.btnMenuProductos.TabIndex = 4;
            this.btnMenuProductos.Text = "INVENTARIO";
            this.btnMenuProductos.UseVisualStyleBackColor = false;
            this.btnMenuProductos.Click += new System.EventHandler(this.btnMenuProductos_Click);
            // 
            // btnMenuAdmin
            // 
            this.btnMenuAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(74)))), ((int)(((byte)(63)))));
            this.btnMenuAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuAdmin.FlatAppearance.BorderSize = 0;
            this.btnMenuAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenuAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(34)))), ((int)(((byte)(23)))));
            this.btnMenuAdmin.Location = new System.Drawing.Point(-13, 226);
            this.btnMenuAdmin.Name = "btnMenuAdmin";
            this.btnMenuAdmin.Size = new System.Drawing.Size(220, 45);
            this.btnMenuAdmin.TabIndex = 3;
            this.btnMenuAdmin.Text = "ADMINISTRACION";
            this.btnMenuAdmin.UseVisualStyleBackColor = false;
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
            // bOLETABindingSource
            // 
            this.bOLETABindingSource.DataMember = "BOLETA";
            this.bOLETABindingSource.DataSource = this.laShiliquitaBDDataSet;
            // 
            // laShiliquitaBDDataSet
            // 
            this.laShiliquitaBDDataSet.DataSetName = "LaShiliquitaBDDataSet";
            this.laShiliquitaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOLETATableAdapter
            // 
            this.bOLETATableAdapter.ClearBeforeFill = true;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(225)))), ((int)(((byte)(210)))));
            this.panelContenedor.Controls.Add(this.label3);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.dgvVentasRealizadas);
            this.panelContenedor.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContenedor.Location = new System.Drawing.Point(198, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(804, 600);
            this.panelContenedor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Aca podras visualizar las boletas cada vez que ingreses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 29.88679F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENIDO/A a La Shiliquita";
            // 
            // dgvVentasRealizadas
            // 
            this.dgvVentasRealizadas.AutoGenerateColumns = false;
            this.dgvVentasRealizadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(74)))), ((int)(((byte)(63)))));
            this.dgvVentasRealizadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentasRealizadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVentasRealizadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(34)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentasRealizadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentasRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasRealizadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBoletaDataGridViewTextBoxColumn,
            this.fechahoraDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.nroDocCDataGridViewTextBoxColumn,
            this.nroDocEDataGridViewTextBoxColumn});
            this.dgvVentasRealizadas.DataSource = this.bOLETABindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(74)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentasRealizadas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentasRealizadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVentasRealizadas.EnableHeadersVisualStyles = false;
            this.dgvVentasRealizadas.Location = new System.Drawing.Point(121, 158);
            this.dgvVentasRealizadas.Name = "dgvVentasRealizadas";
            this.dgvVentasRealizadas.RowHeadersWidth = 45;
            this.dgvVentasRealizadas.Size = new System.Drawing.Size(596, 387);
            this.dgvVentasRealizadas.TabIndex = 0;
            // 
            // iDBoletaDataGridViewTextBoxColumn
            // 
            this.iDBoletaDataGridViewTextBoxColumn.DataPropertyName = "IDBoleta";
            this.iDBoletaDataGridViewTextBoxColumn.HeaderText = "IDBoleta";
            this.iDBoletaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDBoletaDataGridViewTextBoxColumn.Name = "iDBoletaDataGridViewTextBoxColumn";
            this.iDBoletaDataGridViewTextBoxColumn.Width = 110;
            // 
            // fechahoraDataGridViewTextBoxColumn
            // 
            this.fechahoraDataGridViewTextBoxColumn.DataPropertyName = "Fecha_hora";
            this.fechahoraDataGridViewTextBoxColumn.HeaderText = "Fecha_hora";
            this.fechahoraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechahoraDataGridViewTextBoxColumn.Name = "fechahoraDataGridViewTextBoxColumn";
            this.fechahoraDataGridViewTextBoxColumn.Width = 110;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 110;
            // 
            // nroDocCDataGridViewTextBoxColumn
            // 
            this.nroDocCDataGridViewTextBoxColumn.DataPropertyName = "nroDocC";
            this.nroDocCDataGridViewTextBoxColumn.HeaderText = "nroDocC";
            this.nroDocCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nroDocCDataGridViewTextBoxColumn.Name = "nroDocCDataGridViewTextBoxColumn";
            this.nroDocCDataGridViewTextBoxColumn.Width = 110;
            // 
            // nroDocEDataGridViewTextBoxColumn
            // 
            this.nroDocEDataGridViewTextBoxColumn.DataPropertyName = "nroDocE";
            this.nroDocEDataGridViewTextBoxColumn.HeaderText = "nroDocE";
            this.nroDocEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nroDocEDataGridViewTextBoxColumn.Name = "nroDocEDataGridViewTextBoxColumn";
            this.nroDocEDataGridViewTextBoxColumn.Width = 110;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La Shiliquita ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOLETABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laShiliquitaBDDataSet)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasRealizadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenuVentas;
        private System.Windows.Forms.Button btnMenuProductos;
        private System.Windows.Forms.Button btnMenuAdmin;
        private LaShiliquitaBDDataSet laShiliquitaBDDataSet;
        private System.Windows.Forms.BindingSource bOLETABindingSource;
        private LaShiliquitaBDDataSetTableAdapters.BOLETATableAdapter bOLETATableAdapter;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVentasRealizadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBoletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocEDataGridViewTextBoxColumn;
    }
}

