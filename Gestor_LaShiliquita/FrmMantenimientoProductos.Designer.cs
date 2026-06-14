namespace Gestor_LaShiliquita
{
    partial class FrmMantenimientoProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimientoProductos));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laShiliquitaBDDataSet = new Gestor_LaShiliquita.LaShiliquitaBDDataSet();
            this.txtIDProducto = new System.Windows.Forms.Label();
            this.txtNomProd = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.txtProveedor = new System.Windows.Forms.Label();
            this.txtbIDProducto = new System.Windows.Forms.TextBox();
            this.txtbNombreProducto = new System.Windows.Forms.TextBox();
            this.txtbDescripcionProducto = new System.Windows.Forms.TextBox();
            this.txtbPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtbStockProducto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pRODUCTOSTableAdapter = new Gestor_LaShiliquita.LaShiliquitaBDDataSetTableAdapters.PRODUCTOSTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laShiliquitaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoGenerateColumns = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(98)))), ((int)(((byte)(74)))));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProductoDataGridViewTextBoxColumn,
            this.nomProdDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.nroDocProveedorDataGridViewTextBoxColumn});
            this.dgvProductos.DataSource = this.pRODUCTOSBindingSource;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvProductos.Location = new System.Drawing.Point(285, 0);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 45;
            this.dgvProductos.Size = new System.Drawing.Size(499, 559);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            // 
            // nomProdDataGridViewTextBoxColumn
            // 
            this.nomProdDataGridViewTextBoxColumn.DataPropertyName = "nomProd";
            this.nomProdDataGridViewTextBoxColumn.HeaderText = "nomProd";
            this.nomProdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomProdDataGridViewTextBoxColumn.Name = "nomProdDataGridViewTextBoxColumn";
            this.nomProdDataGridViewTextBoxColumn.Width = 89;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 102;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "categoria";
            this.categoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.Width = 90;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Width = 72;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.Width = 65;
            // 
            // nroDocProveedorDataGridViewTextBoxColumn
            // 
            this.nroDocProveedorDataGridViewTextBoxColumn.DataPropertyName = "nroDocProveedor";
            this.nroDocProveedorDataGridViewTextBoxColumn.HeaderText = "nroDocProveedor";
            this.nroDocProveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nroDocProveedorDataGridViewTextBoxColumn.Name = "nroDocProveedorDataGridViewTextBoxColumn";
            this.nroDocProveedorDataGridViewTextBoxColumn.Width = 139;
            // 
            // pRODUCTOSBindingSource
            // 
            this.pRODUCTOSBindingSource.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource.DataSource = this.laShiliquitaBDDataSet;
            // 
            // laShiliquitaBDDataSet
            // 
            this.laShiliquitaBDDataSet.DataSetName = "LaShiliquitaBDDataSet";
            this.laShiliquitaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.AutoSize = true;
            this.txtIDProducto.Location = new System.Drawing.Point(23, 17);
            this.txtIDProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Size = new System.Drawing.Size(23, 17);
            this.txtIDProducto.TabIndex = 1;
            this.txtIDProducto.Text = "ID:";
            // 
            // txtNomProd
            // 
            this.txtNomProd.AutoSize = true;
            this.txtNomProd.Location = new System.Drawing.Point(23, 81);
            this.txtNomProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNomProd.Name = "txtNomProd";
            this.txtNomProd.Size = new System.Drawing.Size(60, 17);
            this.txtNomProd.TabIndex = 2;
            this.txtNomProd.Text = "Nombre:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoSize = true;
            this.txtPrecio.Location = new System.Drawing.Point(23, 206);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(47, 17);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.Location = new System.Drawing.Point(23, 145);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(79, 17);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Text = "Descripcion:";
            // 
            // txtStock
            // 
            this.txtStock.AutoSize = true;
            this.txtStock.Location = new System.Drawing.Point(23, 269);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(42, 17);
            this.txtStock.TabIndex = 5;
            this.txtStock.Text = "Stock:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(26, 353);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(245, 23);
            this.cmbProveedor.TabIndex = 6;
            // 
            // txtProveedor
            // 
            this.txtProveedor.AutoSize = true;
            this.txtProveedor.Location = new System.Drawing.Point(23, 334);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(137, 17);
            this.txtProveedor.TabIndex = 7;
            this.txtProveedor.Text = "Proveedor disponible:";
            // 
            // txtbIDProducto
            // 
            this.txtbIDProducto.Location = new System.Drawing.Point(26, 36);
            this.txtbIDProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtbIDProducto.Name = "txtbIDProducto";
            this.txtbIDProducto.Size = new System.Drawing.Size(245, 24);
            this.txtbIDProducto.TabIndex = 8;
            // 
            // txtbNombreProducto
            // 
            this.txtbNombreProducto.Location = new System.Drawing.Point(26, 100);
            this.txtbNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtbNombreProducto.Name = "txtbNombreProducto";
            this.txtbNombreProducto.Size = new System.Drawing.Size(245, 24);
            this.txtbNombreProducto.TabIndex = 9;
            // 
            // txtbDescripcionProducto
            // 
            this.txtbDescripcionProducto.Location = new System.Drawing.Point(26, 163);
            this.txtbDescripcionProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtbDescripcionProducto.Name = "txtbDescripcionProducto";
            this.txtbDescripcionProducto.Size = new System.Drawing.Size(245, 24);
            this.txtbDescripcionProducto.TabIndex = 10;
            // 
            // txtbPrecioProducto
            // 
            this.txtbPrecioProducto.Location = new System.Drawing.Point(26, 225);
            this.txtbPrecioProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtbPrecioProducto.Name = "txtbPrecioProducto";
            this.txtbPrecioProducto.Size = new System.Drawing.Size(245, 24);
            this.txtbPrecioProducto.TabIndex = 11;
            // 
            // txtbStockProducto
            // 
            this.txtbStockProducto.Location = new System.Drawing.Point(26, 287);
            this.txtbStockProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtbStockProducto.Name = "txtbStockProducto";
            this.txtbStockProducto.Size = new System.Drawing.Size(245, 24);
            this.txtbStockProducto.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(146, 400);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 26);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(146, 491);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 26);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(146, 444);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 26);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pRODUCTOSTableAdapter
            // 
            this.pRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMantenimientoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtbStockProducto);
            this.Controls.Add(this.txtbPrecioProducto);
            this.Controls.Add(this.txtbDescripcionProducto);
            this.Controls.Add(this.txtbNombreProducto);
            this.Controls.Add(this.txtbIDProducto);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNomProd);
            this.Controls.Add(this.txtIDProducto);
            this.Controls.Add(this.dgvProductos);
            this.Font = new System.Drawing.Font("Segoe UI", 8.18868F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMantenimientoProductos";
            this.Text = "FrmMantenimientoProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laShiliquitaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label txtIDProducto;
        private System.Windows.Forms.Label txtNomProd;
        private System.Windows.Forms.Label txtPrecio;
        private System.Windows.Forms.Label txtDescripcion;
        private System.Windows.Forms.Label txtStock;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label txtProveedor;
        private System.Windows.Forms.TextBox txtbIDProducto;
        private System.Windows.Forms.TextBox txtbNombreProducto;
        private System.Windows.Forms.TextBox txtbDescripcionProducto;
        private System.Windows.Forms.TextBox txtbPrecioProducto;
        private System.Windows.Forms.TextBox txtbStockProducto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private LaShiliquitaBDDataSet laShiliquitaBDDataSet;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource;
        private LaShiliquitaBDDataSetTableAdapters.PRODUCTOSTableAdapter pRODUCTOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}