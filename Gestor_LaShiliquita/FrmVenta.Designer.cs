namespace Gestor_LaShiliquita
{
    partial class FrmVenta
    {
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
            this.txtbIDBoleta = new System.Windows.Forms.TextBox();
            this.txtIDBoleta = new System.Windows.Forms.Label();
            this.txtNumDocCliente = new System.Windows.Forms.Label();
            this.txtbNumDocCliente = new System.Windows.Forms.TextBox();
            this.txtDniEmpleado = new System.Windows.Forms.Label();
            this.txtbDniEmpleado = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.Label();
            this.txtbCantidad = new System.Windows.Forms.TextBox();
            this.txtIDProducto = new System.Windows.Forms.Label();
            this.txtbIDProducto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTitulo1 = new System.Windows.Forms.Label();
            this.txtTitulo2 = new System.Windows.Forms.Label();
            this.PanelVenta = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTerminarVenta = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.iDBoletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantVendidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dETALLEBOLETABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laShiliquitaBDDataSet = new Gestor_LaShiliquita.LaShiliquitaBDDataSet();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dETALLE_BOLETATableAdapter = new Gestor_LaShiliquita.LaShiliquitaBDDataSetTableAdapters.DETALLE_BOLETATableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelVenta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETALLEBOLETABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laShiliquitaBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbIDBoleta
            // 
            this.txtbIDBoleta.Location = new System.Drawing.Point(22, 53);
            this.txtbIDBoleta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbIDBoleta.Name = "txtbIDBoleta";
            this.txtbIDBoleta.Size = new System.Drawing.Size(208, 23);
            this.txtbIDBoleta.TabIndex = 0;
            this.txtbIDBoleta.TextChanged += new System.EventHandler(this.txtbIDBoleta_TextChanged);
            // 
            // txtIDBoleta
            // 
            this.txtIDBoleta.AutoSize = true;
            this.txtIDBoleta.Location = new System.Drawing.Point(19, 35);
            this.txtIDBoleta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtIDBoleta.Name = "txtIDBoleta";
            this.txtIDBoleta.Size = new System.Drawing.Size(119, 17);
            this.txtIDBoleta.TabIndex = 1;
            this.txtIDBoleta.Text = "Numero de boleta:";
            // 
            // txtNumDocCliente
            // 
            this.txtNumDocCliente.AutoSize = true;
            this.txtNumDocCliente.Location = new System.Drawing.Point(19, 85);
            this.txtNumDocCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNumDocCliente.Name = "txtNumDocCliente";
            this.txtNumDocCliente.Size = new System.Drawing.Size(119, 17);
            this.txtNumDocCliente.TabIndex = 3;
            this.txtNumDocCliente.Text = "Numero de cliente:";
            // 
            // txtbNumDocCliente
            // 
            this.txtbNumDocCliente.Location = new System.Drawing.Point(22, 103);
            this.txtbNumDocCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbNumDocCliente.Name = "txtbNumDocCliente";
            this.txtbNumDocCliente.Size = new System.Drawing.Size(208, 23);
            this.txtbNumDocCliente.TabIndex = 2;
            // 
            // txtDniEmpleado
            // 
            this.txtDniEmpleado.AutoSize = true;
            this.txtDniEmpleado.Location = new System.Drawing.Point(19, 138);
            this.txtDniEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDniEmpleado.Name = "txtDniEmpleado";
            this.txtDniEmpleado.Size = new System.Drawing.Size(230, 17);
            this.txtDniEmpleado.TabIndex = 5;
            this.txtDniEmpleado.Text = "Numero de documento de empleado:";
            // 
            // txtbDniEmpleado
            // 
            this.txtbDniEmpleado.Location = new System.Drawing.Point(22, 157);
            this.txtbDniEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbDniEmpleado.Name = "txtbDniEmpleado";
            this.txtbDniEmpleado.Size = new System.Drawing.Size(208, 23);
            this.txtbDniEmpleado.TabIndex = 4;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoSize = true;
            this.txtCantidad.Location = new System.Drawing.Point(15, 85);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(146, 17);
            this.txtCantidad.TabIndex = 9;
            this.txtCantidad.Text = "Cantidad de productos:";
            // 
            // txtbCantidad
            // 
            this.txtbCantidad.Location = new System.Drawing.Point(19, 103);
            this.txtbCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbCantidad.Name = "txtbCantidad";
            this.txtbCantidad.Size = new System.Drawing.Size(208, 23);
            this.txtbCantidad.TabIndex = 8;
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.AutoSize = true;
            this.txtIDProducto.Location = new System.Drawing.Point(15, 36);
            this.txtIDProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Size = new System.Drawing.Size(103, 17);
            this.txtIDProducto.TabIndex = 7;
            this.txtIDProducto.Text = "ID del producto:";
            // 
            // txtbIDProducto
            // 
            this.txtbIDProducto.Location = new System.Drawing.Point(19, 54);
            this.txtbIDProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbIDProducto.Name = "txtbIDProducto";
            this.txtbIDProducto.Size = new System.Drawing.Size(208, 23);
            this.txtbIDProducto.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(649, 18);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 27);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTitulo1
            // 
            this.txtTitulo1.AutoSize = true;
            this.txtTitulo1.Location = new System.Drawing.Point(19, 10);
            this.txtTitulo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitulo1.Name = "txtTitulo1";
            this.txtTitulo1.Size = new System.Drawing.Size(133, 17);
            this.txtTitulo1.TabIndex = 11;
            this.txtTitulo1.Text = "DATOS DE LA BOLETA";
            // 
            // txtTitulo2
            // 
            this.txtTitulo2.AutoSize = true;
            this.txtTitulo2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.txtTitulo2.Location = new System.Drawing.Point(15, 8);
            this.txtTitulo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitulo2.Name = "txtTitulo2";
            this.txtTitulo2.Size = new System.Drawing.Size(205, 17);
            this.txtTitulo2.TabIndex = 12;
            this.txtTitulo2.Text = "AÑADIR PRODUCTOS A LA VENTA";
            // 
            // PanelVenta
            // 
            this.PanelVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.PanelVenta.Controls.Add(this.txtTitulo1);
            this.PanelVenta.Controls.Add(this.txtDniEmpleado);
            this.PanelVenta.Controls.Add(this.txtbDniEmpleado);
            this.PanelVenta.Controls.Add(this.txtNumDocCliente);
            this.PanelVenta.Controls.Add(this.txtbNumDocCliente);
            this.PanelVenta.Controls.Add(this.txtIDBoleta);
            this.PanelVenta.Controls.Add(this.txtbIDBoleta);
            this.PanelVenta.Location = new System.Drawing.Point(14, 14);
            this.PanelVenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelVenta.Name = "PanelVenta";
            this.PanelVenta.Size = new System.Drawing.Size(272, 205);
            this.PanelVenta.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.txtTitulo2);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.txtbCantidad);
            this.panel1.Controls.Add(this.txtIDProducto);
            this.panel1.Controls.Add(this.txtbIDProducto);
            this.panel1.Location = new System.Drawing.Point(313, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 205);
            this.panel1.TabIndex = 14;
            // 
            // btnTerminarVenta
            // 
            this.btnTerminarVenta.Location = new System.Drawing.Point(649, 89);
            this.btnTerminarVenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTerminarVenta.Name = "btnTerminarVenta";
            this.btnTerminarVenta.Size = new System.Drawing.Size(88, 27);
            this.btnTerminarVenta.TabIndex = 13;
            this.btnTerminarVenta.Text = "Comprar";
            this.btnTerminarVenta.UseVisualStyleBackColor = true;
            this.btnTerminarVenta.Click += new System.EventHandler(this.btnTerminarVenta_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AutoGenerateColumns = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBoletaDataGridViewTextBoxColumn,
            this.iDProductoDataGridViewTextBoxColumn,
            this.nomProdDataGridViewTextBoxColumn,
            this.precioUnitDataGridViewTextBoxColumn,
            this.cantVendidaDataGridViewTextBoxColumn});
            this.dgvDetalle.DataSource = this.dETALLEBOLETABindingSource;
            this.dgvDetalle.Location = new System.Drawing.Point(0, 243);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersWidth = 45;
            this.dgvDetalle.Size = new System.Drawing.Size(801, 357);
            this.dgvDetalle.TabIndex = 15;
            // 
            // iDBoletaDataGridViewTextBoxColumn
            // 
            this.iDBoletaDataGridViewTextBoxColumn.DataPropertyName = "IDBoleta";
            this.iDBoletaDataGridViewTextBoxColumn.HeaderText = "IDBoleta";
            this.iDBoletaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDBoletaDataGridViewTextBoxColumn.Name = "iDBoletaDataGridViewTextBoxColumn";
            this.iDBoletaDataGridViewTextBoxColumn.Width = 110;
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            this.iDProductoDataGridViewTextBoxColumn.Width = 110;
            // 
            // nomProdDataGridViewTextBoxColumn
            // 
            this.nomProdDataGridViewTextBoxColumn.DataPropertyName = "nomProd";
            this.nomProdDataGridViewTextBoxColumn.HeaderText = "nomProd";
            this.nomProdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomProdDataGridViewTextBoxColumn.Name = "nomProdDataGridViewTextBoxColumn";
            this.nomProdDataGridViewTextBoxColumn.Width = 110;
            // 
            // precioUnitDataGridViewTextBoxColumn
            // 
            this.precioUnitDataGridViewTextBoxColumn.DataPropertyName = "precioUnit";
            this.precioUnitDataGridViewTextBoxColumn.HeaderText = "precioUnit";
            this.precioUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioUnitDataGridViewTextBoxColumn.Name = "precioUnitDataGridViewTextBoxColumn";
            this.precioUnitDataGridViewTextBoxColumn.Width = 110;
            // 
            // cantVendidaDataGridViewTextBoxColumn
            // 
            this.cantVendidaDataGridViewTextBoxColumn.DataPropertyName = "cantVendida";
            this.cantVendidaDataGridViewTextBoxColumn.HeaderText = "cantVendida";
            this.cantVendidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantVendidaDataGridViewTextBoxColumn.Name = "cantVendidaDataGridViewTextBoxColumn";
            this.cantVendidaDataGridViewTextBoxColumn.Width = 110;
            // 
            // dETALLEBOLETABindingSource
            // 
            this.dETALLEBOLETABindingSource.DataMember = "DETALLE_BOLETA";
            this.dETALLEBOLETABindingSource.DataSource = this.laShiliquitaBDDataSet;
            // 
            // laShiliquitaBDDataSet
            // 
            this.laShiliquitaBDDataSet.DataSetName = "LaShiliquitaBDDataSet";
            this.laShiliquitaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(696, 174);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 17);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "S/.";
            // 
            // dETALLE_BOLETATableAdapter
            // 
            this.dETALLE_BOLETATableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "TOTAL:";
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(69)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTerminarVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelVenta);
            this.Font = new System.Drawing.Font("Segoe UI", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmVenta";
            this.PanelVenta.ResumeLayout(false);
            this.PanelVenta.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETALLEBOLETABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laShiliquitaBDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbIDBoleta;
        private System.Windows.Forms.Label txtIDBoleta;
        private System.Windows.Forms.Label txtNumDocCliente;
        private System.Windows.Forms.TextBox txtbNumDocCliente;
        private System.Windows.Forms.Label txtDniEmpleado;
        private System.Windows.Forms.TextBox txtbDniEmpleado;
        private System.Windows.Forms.Label txtCantidad;
        private System.Windows.Forms.TextBox txtbCantidad;
        private System.Windows.Forms.Label txtIDProducto;
        private System.Windows.Forms.TextBox txtbIDProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label txtTitulo1;
        private System.Windows.Forms.Label txtTitulo2;
        private System.Windows.Forms.Panel PanelVenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTerminarVenta;
        private LaShiliquitaBDDataSet laShiliquitaBDDataSet;
        private System.Windows.Forms.BindingSource dETALLEBOLETABindingSource;
        private LaShiliquitaBDDataSetTableAdapters.DETALLE_BOLETATableAdapter dETALLE_BOLETATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBoletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantVendidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}