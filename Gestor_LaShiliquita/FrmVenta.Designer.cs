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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNumDocCliente = new System.Windows.Forms.Label();
            this.txtDniEmpleado = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.Label();
            this.txtbCantidad = new System.Windows.Forms.TextBox();
            this.txtIDProducto = new System.Windows.Forms.Label();
            this.txtbIDProducto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTitulo1 = new System.Windows.Forms.Label();
            this.txtTitulo2 = new System.Windows.Forms.Label();
            this.PanelVenta = new System.Windows.Forms.Panel();
            this.cbxNumE = new System.Windows.Forms.ComboBox();
            this.cbxNumC = new System.Windows.Forms.ComboBox();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOLETABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOLETATableAdapter = new Gestor_LaShiliquita.LaShiliquitaBDDataSetTableAdapters.BOLETATableAdapter();
            this.bOLETABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PanelVenta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETALLEBOLETABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laShiliquitaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOLETABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOLETABindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumDocCliente
            // 
            this.txtNumDocCliente.AutoSize = true;
            this.txtNumDocCliente.Location = new System.Drawing.Point(19, 31);
            this.txtNumDocCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNumDocCliente.Name = "txtNumDocCliente";
            this.txtNumDocCliente.Size = new System.Drawing.Size(119, 17);
            this.txtNumDocCliente.TabIndex = 3;
            this.txtNumDocCliente.Text = "Numero de cliente:";
            // 
            // txtDniEmpleado
            // 
            this.txtDniEmpleado.AutoSize = true;
            this.txtDniEmpleado.Location = new System.Drawing.Point(19, 84);
            this.txtDniEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDniEmpleado.Name = "txtDniEmpleado";
            this.txtDniEmpleado.Size = new System.Drawing.Size(230, 17);
            this.txtDniEmpleado.TabIndex = 5;
            this.txtDniEmpleado.Text = "Numero de documento de empleado:";
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
            this.btnAgregar.Location = new System.Drawing.Point(645, 27);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 37);
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
            this.PanelVenta.Controls.Add(this.cbxNumE);
            this.PanelVenta.Controls.Add(this.cbxNumC);
            this.PanelVenta.Controls.Add(this.txtTitulo1);
            this.PanelVenta.Controls.Add(this.txtDniEmpleado);
            this.PanelVenta.Controls.Add(this.txtNumDocCliente);
            this.PanelVenta.Location = new System.Drawing.Point(14, 14);
            this.PanelVenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelVenta.Name = "PanelVenta";
            this.PanelVenta.Size = new System.Drawing.Size(272, 205);
            this.PanelVenta.TabIndex = 13;
            // 
            // cbxNumE
            // 
            this.cbxNumE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxNumE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNumE.FormattingEnabled = true;
            this.cbxNumE.Location = new System.Drawing.Point(22, 118);
            this.cbxNumE.Name = "cbxNumE";
            this.cbxNumE.Size = new System.Drawing.Size(227, 23);
            this.cbxNumE.TabIndex = 13;
            this.cbxNumE.SelectedIndexChanged += new System.EventHandler(this.cbxNumE_SelectedIndexChanged);
            // 
            // cbxNumC
            // 
            this.cbxNumC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxNumC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNumC.FormattingEnabled = true;
            this.cbxNumC.Location = new System.Drawing.Point(22, 55);
            this.cbxNumC.Name = "cbxNumC";
            this.cbxNumC.Size = new System.Drawing.Size(227, 23);
            this.cbxNumC.TabIndex = 12;
            this.cbxNumC.SelectedIndexChanged += new System.EventHandler(this.cbxNumC_SelectedIndexChanged);
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
            this.btnTerminarVenta.Location = new System.Drawing.Point(645, 98);
            this.btnTerminarVenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTerminarVenta.Name = "btnTerminarVenta";
            this.btnTerminarVenta.Size = new System.Drawing.Size(94, 37);
            this.btnTerminarVenta.TabIndex = 13;
            this.btnTerminarVenta.Text = "Comprar";
            this.btnTerminarVenta.UseVisualStyleBackColor = true;
            this.btnTerminarVenta.Click += new System.EventHandler(this.btnTerminarVenta_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AutoGenerateColumns = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(225)))), ((int)(((byte)(210)))));
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(34)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(584, 357);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(225)))), ((int)(((byte)(210)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(34)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.bOLETABindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(645, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(154, 357);
            this.dataGridView1.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDBoleta";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDBoleta";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // bOLETABindingSource
            // 
            this.bOLETABindingSource.DataMember = "BOLETA";
            this.bOLETABindingSource.DataSource = this.laShiliquitaBDDataSet;
            // 
            // bOLETATableAdapter
            // 
            this.bOLETATableAdapter.ClearBeforeFill = true;
            // 
            // bOLETABindingSource1
            // 
            this.bOLETABindingSource1.DataMember = "BOLETA";
            this.bOLETABindingSource1.DataSource = this.laShiliquitaBDDataSet;
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(69)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dataGridView1);
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
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.PanelVenta.ResumeLayout(false);
            this.PanelVenta.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETALLEBOLETABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laShiliquitaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOLETABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOLETABindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtNumDocCliente;
        private System.Windows.Forms.Label txtDniEmpleado;
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
        private System.Windows.Forms.ComboBox cbxNumE;
        private System.Windows.Forms.ComboBox cbxNumC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bOLETABindingSource;
        private LaShiliquitaBDDataSetTableAdapters.BOLETATableAdapter bOLETATableAdapter;
        private System.Windows.Forms.BindingSource bOLETABindingSource1;
    }
}