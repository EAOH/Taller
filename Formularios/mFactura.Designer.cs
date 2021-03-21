namespace CheckEngineTaller.Formularios
{
    partial class mFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mFactura));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Btn_Cliente = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Identidad = new System.Windows.Forms.TextBox();
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Subtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Descuento = new System.Windows.Forms.TextBox();
            this.txt_Factura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Impuesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Cliente = new System.Windows.Forms.TextBox();
            this.Date_Fecha = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tap_Factura = new System.Windows.Forms.TabControl();
            this.Tap_Crear = new System.Windows.Forms.TabPage();
            this.ListaDetalle = new System.Windows.Forms.DataGridView();
            this.TAP_Ver = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.facturaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaFechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteIdentificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaSubtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaImpuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaDescuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new CheckEngineTaller.DS();
            this.TAP_Detalle = new System.Windows.Forms.TabPage();
            this.Data_Detalle = new System.Windows.Forms.DataGridView();
            this.facturaDetalleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaTableAdapter = new CheckEngineTaller.DSTableAdapters.FacturaTableAdapter();
            this.tableAdapterManager = new CheckEngineTaller.DSTableAdapters.TableAdapterManager();
            this.facturaDetalleTableAdapter = new CheckEngineTaller.DSTableAdapters.FacturaDetalleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Tap_Factura.SuspendLayout();
            this.Tap_Crear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDetalle)).BeginInit();
            this.TAP_Ver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.TAP_Detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel1.Controls.Add(this.Btn_Cliente);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.Txt_Nombre);
            this.splitContainer1.Panel1.Controls.Add(this.Txt_Identidad);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_Crear);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.Txt_Subtotal);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.Txt_Descuento);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Factura);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.Txt_Total);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.Txt_Impuesto);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.Txt_Cliente);
            this.splitContainer1.Panel1.Controls.Add(this.Date_Fecha);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel2.Controls.Add(this.Tap_Factura);
            this.splitContainer1.Size = new System.Drawing.Size(600, 389);
            this.splitContainer1.SplitterDistance = 152;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // Btn_Cliente
            // 
            this.Btn_Cliente.Location = new System.Drawing.Point(332, 110);
            this.Btn_Cliente.Name = "Btn_Cliente";
            this.Btn_Cliente.Size = new System.Drawing.Size(28, 23);
            this.Btn_Cliente.TabIndex = 25;
            this.Btn_Cliente.Text = "...";
            this.Btn_Cliente.UseVisualStyleBackColor = true;
            this.Btn_Cliente.Visible = false;
            this.Btn_Cliente.Click += new System.EventHandler(this.Btn_Cliente_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Identidad: ";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Enabled = false;
            this.Txt_Nombre.Location = new System.Drawing.Point(176, 108);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(151, 20);
            this.Txt_Nombre.TabIndex = 23;
            // 
            // Txt_Identidad
            // 
            this.Txt_Identidad.Enabled = false;
            this.Txt_Identidad.Location = new System.Drawing.Point(116, 129);
            this.Txt_Identidad.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Identidad.Name = "Txt_Identidad";
            this.Txt_Identidad.Size = new System.Drawing.Size(211, 20);
            this.Txt_Identidad.TabIndex = 22;
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.Location = new System.Drawing.Point(521, 33);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(75, 23);
            this.Btn_Crear.TabIndex = 21;
            this.Btn_Crear.Text = "Crear";
            this.Btn_Crear.UseVisualStyleBackColor = true;
            this.Btn_Crear.Visible = false;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Subtotal: Lps";
            // 
            // Txt_Subtotal
            // 
            this.Txt_Subtotal.Enabled = false;
            this.Txt_Subtotal.Location = new System.Drawing.Point(437, 31);
            this.Txt_Subtotal.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Subtotal.Name = "Txt_Subtotal";
            this.Txt_Subtotal.Size = new System.Drawing.Size(80, 20);
            this.Txt_Subtotal.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Descuento: Lps";
            // 
            // Txt_Descuento
            // 
            this.Txt_Descuento.Enabled = false;
            this.Txt_Descuento.Location = new System.Drawing.Point(437, 55);
            this.Txt_Descuento.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Descuento.Name = "Txt_Descuento";
            this.Txt_Descuento.Size = new System.Drawing.Size(80, 20);
            this.Txt_Descuento.TabIndex = 17;
            this.Txt_Descuento.Text = "0.00";
            this.Txt_Descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Descuento_KeyPress);
            this.Txt_Descuento.Leave += new System.EventHandler(this.Txt_Descuento_Leave);
            // 
            // txt_Factura
            // 
            this.txt_Factura.Enabled = false;
            this.txt_Factura.Location = new System.Drawing.Point(116, 71);
            this.txt_Factura.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Factura.Name = "txt_Factura";
            this.txt_Factura.Size = new System.Drawing.Size(56, 20);
            this.txt_Factura.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total: Lps";
            // 
            // Txt_Total
            // 
            this.Txt_Total.Enabled = false;
            this.Txt_Total.Location = new System.Drawing.Point(437, 103);
            this.Txt_Total.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.Size = new System.Drawing.Size(80, 20);
            this.Txt_Total.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Impuesto: Lps";
            // 
            // Txt_Impuesto
            // 
            this.Txt_Impuesto.Enabled = false;
            this.Txt_Impuesto.Location = new System.Drawing.Point(437, 79);
            this.Txt_Impuesto.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Impuesto.Name = "Txt_Impuesto";
            this.Txt_Impuesto.Size = new System.Drawing.Size(80, 20);
            this.Txt_Impuesto.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cliente: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Factura Numero: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha: ";
            // 
            // Txt_Cliente
            // 
            this.Txt_Cliente.Enabled = false;
            this.Txt_Cliente.Location = new System.Drawing.Point(116, 108);
            this.Txt_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Cliente.Name = "Txt_Cliente";
            this.Txt_Cliente.Size = new System.Drawing.Size(56, 20);
            this.Txt_Cliente.TabIndex = 8;
            // 
            // Date_Fecha
            // 
            this.Date_Fecha.Enabled = false;
            this.Date_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_Fecha.Location = new System.Drawing.Point(116, 32);
            this.Date_Fecha.Margin = new System.Windows.Forms.Padding(2);
            this.Date_Fecha.Name = "Date_Fecha";
            this.Date_Fecha.Size = new System.Drawing.Size(151, 20);
            this.Date_Fecha.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.regresarToolStripMenuItem.Text = "Cerrar ventana";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // Tap_Factura
            // 
            this.Tap_Factura.Controls.Add(this.Tap_Crear);
            this.Tap_Factura.Controls.Add(this.TAP_Ver);
            this.Tap_Factura.Controls.Add(this.TAP_Detalle);
            this.Tap_Factura.Location = new System.Drawing.Point(3, -25);
            this.Tap_Factura.Name = "Tap_Factura";
            this.Tap_Factura.SelectedIndex = 0;
            this.Tap_Factura.Size = new System.Drawing.Size(597, 265);
            this.Tap_Factura.TabIndex = 0;
            // 
            // Tap_Crear
            // 
            this.Tap_Crear.BackColor = System.Drawing.Color.Gainsboro;
            this.Tap_Crear.Controls.Add(this.ListaDetalle);
            this.Tap_Crear.Location = new System.Drawing.Point(4, 22);
            this.Tap_Crear.Name = "Tap_Crear";
            this.Tap_Crear.Padding = new System.Windows.Forms.Padding(3);
            this.Tap_Crear.Size = new System.Drawing.Size(589, 239);
            this.Tap_Crear.TabIndex = 0;
            this.Tap_Crear.Text = "Crear Factura";
            // 
            // ListaDetalle
            // 
            this.ListaDetalle.AllowUserToAddRows = false;
            this.ListaDetalle.AllowUserToDeleteRows = false;
            this.ListaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaDetalle.Location = new System.Drawing.Point(4, 6);
            this.ListaDetalle.MultiSelect = false;
            this.ListaDetalle.Name = "ListaDetalle";
            this.ListaDetalle.ReadOnly = true;
            this.ListaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaDetalle.Size = new System.Drawing.Size(580, 226);
            this.ListaDetalle.TabIndex = 2;
            // 
            // TAP_Ver
            // 
            this.TAP_Ver.BackColor = System.Drawing.Color.Gainsboro;
            this.TAP_Ver.Controls.Add(this.dataGridView1);
            this.TAP_Ver.Location = new System.Drawing.Point(4, 22);
            this.TAP_Ver.Name = "TAP_Ver";
            this.TAP_Ver.Padding = new System.Windows.Forms.Padding(3);
            this.TAP_Ver.Size = new System.Drawing.Size(589, 239);
            this.TAP_Ver.TabIndex = 1;
            this.TAP_Ver.Text = "Ver Facturas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facturaIdDataGridViewTextBoxColumn,
            this.facturaFechaDataGridViewTextBoxColumn,
            this.clienteIdDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.clienteIdentificacionDataGridViewTextBoxColumn,
            this.facturaSubtotalDataGridViewTextBoxColumn,
            this.facturaImpuestoDataGridViewTextBoxColumn,
            this.facturaDescuentoDataGridViewTextBoxColumn,
            this.facturaTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facturaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(580, 226);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // facturaIdDataGridViewTextBoxColumn
            // 
            this.facturaIdDataGridViewTextBoxColumn.DataPropertyName = "FacturaId";
            this.facturaIdDataGridViewTextBoxColumn.HeaderText = "FacturaId";
            this.facturaIdDataGridViewTextBoxColumn.Name = "facturaIdDataGridViewTextBoxColumn";
            this.facturaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturaFechaDataGridViewTextBoxColumn
            // 
            this.facturaFechaDataGridViewTextBoxColumn.DataPropertyName = "FacturaFecha";
            this.facturaFechaDataGridViewTextBoxColumn.HeaderText = "FacturaFecha";
            this.facturaFechaDataGridViewTextBoxColumn.Name = "facturaFechaDataGridViewTextBoxColumn";
            this.facturaFechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteIdDataGridViewTextBoxColumn
            // 
            this.clienteIdDataGridViewTextBoxColumn.DataPropertyName = "ClienteId";
            this.clienteIdDataGridViewTextBoxColumn.HeaderText = "ClienteId";
            this.clienteIdDataGridViewTextBoxColumn.Name = "clienteIdDataGridViewTextBoxColumn";
            this.clienteIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "NombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteIdentificacionDataGridViewTextBoxColumn
            // 
            this.clienteIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "ClienteIdentificacion";
            this.clienteIdentificacionDataGridViewTextBoxColumn.HeaderText = "ClienteIdentificacion";
            this.clienteIdentificacionDataGridViewTextBoxColumn.Name = "clienteIdentificacionDataGridViewTextBoxColumn";
            this.clienteIdentificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturaSubtotalDataGridViewTextBoxColumn
            // 
            this.facturaSubtotalDataGridViewTextBoxColumn.DataPropertyName = "FacturaSubtotal";
            this.facturaSubtotalDataGridViewTextBoxColumn.HeaderText = "FacturaSubtotal";
            this.facturaSubtotalDataGridViewTextBoxColumn.Name = "facturaSubtotalDataGridViewTextBoxColumn";
            this.facturaSubtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturaImpuestoDataGridViewTextBoxColumn
            // 
            this.facturaImpuestoDataGridViewTextBoxColumn.DataPropertyName = "FacturaImpuesto";
            this.facturaImpuestoDataGridViewTextBoxColumn.HeaderText = "FacturaImpuesto";
            this.facturaImpuestoDataGridViewTextBoxColumn.Name = "facturaImpuestoDataGridViewTextBoxColumn";
            this.facturaImpuestoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturaDescuentoDataGridViewTextBoxColumn
            // 
            this.facturaDescuentoDataGridViewTextBoxColumn.DataPropertyName = "FacturaDescuento";
            this.facturaDescuentoDataGridViewTextBoxColumn.HeaderText = "FacturaDescuento";
            this.facturaDescuentoDataGridViewTextBoxColumn.Name = "facturaDescuentoDataGridViewTextBoxColumn";
            this.facturaDescuentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturaTotalDataGridViewTextBoxColumn
            // 
            this.facturaTotalDataGridViewTextBoxColumn.DataPropertyName = "FacturaTotal";
            this.facturaTotalDataGridViewTextBoxColumn.HeaderText = "FacturaTotal";
            this.facturaTotalDataGridViewTextBoxColumn.Name = "facturaTotalDataGridViewTextBoxColumn";
            this.facturaTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataMember = "Factura";
            this.facturaBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TAP_Detalle
            // 
            this.TAP_Detalle.BackColor = System.Drawing.Color.Gainsboro;
            this.TAP_Detalle.Controls.Add(this.Data_Detalle);
            this.TAP_Detalle.Location = new System.Drawing.Point(4, 22);
            this.TAP_Detalle.Name = "TAP_Detalle";
            this.TAP_Detalle.Padding = new System.Windows.Forms.Padding(3);
            this.TAP_Detalle.Size = new System.Drawing.Size(589, 239);
            this.TAP_Detalle.TabIndex = 2;
            this.TAP_Detalle.Text = "Ver Detalle";
            // 
            // Data_Detalle
            // 
            this.Data_Detalle.AllowUserToAddRows = false;
            this.Data_Detalle.AllowUserToDeleteRows = false;
            this.Data_Detalle.AutoGenerateColumns = false;
            this.Data_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Detalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facturaDetalleIDDataGridViewTextBoxColumn,
            this.facturaidDataGridViewTextBoxColumn1,
            this.productoIdDataGridViewTextBoxColumn,
            this.productoNombreDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn});
            this.Data_Detalle.DataSource = this.facturaDetalleBindingSource;
            this.Data_Detalle.Location = new System.Drawing.Point(4, 6);
            this.Data_Detalle.MultiSelect = false;
            this.Data_Detalle.Name = "Data_Detalle";
            this.Data_Detalle.ReadOnly = true;
            this.Data_Detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data_Detalle.Size = new System.Drawing.Size(580, 226);
            this.Data_Detalle.TabIndex = 1;
            // 
            // facturaDetalleIDDataGridViewTextBoxColumn
            // 
            this.facturaDetalleIDDataGridViewTextBoxColumn.DataPropertyName = "FacturaDetalleID";
            this.facturaDetalleIDDataGridViewTextBoxColumn.HeaderText = "FacturaDetalleID";
            this.facturaDetalleIDDataGridViewTextBoxColumn.Name = "facturaDetalleIDDataGridViewTextBoxColumn";
            this.facturaDetalleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturaidDataGridViewTextBoxColumn1
            // 
            this.facturaidDataGridViewTextBoxColumn1.DataPropertyName = "Facturaid";
            this.facturaidDataGridViewTextBoxColumn1.HeaderText = "Facturaid";
            this.facturaidDataGridViewTextBoxColumn1.Name = "facturaidDataGridViewTextBoxColumn1";
            this.facturaidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productoIdDataGridViewTextBoxColumn
            // 
            this.productoIdDataGridViewTextBoxColumn.DataPropertyName = "ProductoId";
            this.productoIdDataGridViewTextBoxColumn.HeaderText = "ProductoId";
            this.productoIdDataGridViewTextBoxColumn.Name = "productoIdDataGridViewTextBoxColumn";
            this.productoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoNombreDataGridViewTextBoxColumn
            // 
            this.productoNombreDataGridViewTextBoxColumn.DataPropertyName = "ProductoNombre";
            this.productoNombreDataGridViewTextBoxColumn.HeaderText = "ProductoNombre";
            this.productoNombreDataGridViewTextBoxColumn.Name = "productoNombreDataGridViewTextBoxColumn";
            this.productoNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            this.subtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturaDetalleBindingSource
            // 
            this.facturaDetalleBindingSource.DataMember = "FacturaDetalle";
            this.facturaDetalleBindingSource.DataSource = this.dS;
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActividadTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BitacoraTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EstacionTableAdapter = null;
            this.tableAdapterManager.PedidoTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CheckEngineTaller.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VehiculoTableAdapter = null;
            // 
            // facturaDetalleTableAdapter
            // 
            this.facturaDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // mFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(600, 389);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "mFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mFactura_FormClosed);
            this.Load += new System.EventHandler(this.mFactura_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Tap_Factura.ResumeLayout(false);
            this.Tap_Crear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListaDetalle)).EndInit();
            this.TAP_Ver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.TAP_Detalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDetalleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Cliente;
        private System.Windows.Forms.DateTimePicker Date_Fecha;
        private System.Windows.Forms.Button Btn_Crear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Subtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Descuento;
        private System.Windows.Forms.TextBox txt_Factura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Impuesto;
        private System.Windows.Forms.TabControl Tap_Factura;
        private System.Windows.Forms.TabPage Tap_Crear;
        private System.Windows.Forms.TabPage TAP_Ver;
        private System.Windows.Forms.TabPage TAP_Detalle;
        private System.Windows.Forms.DataGridView Data_Detalle;
        private System.Windows.Forms.DataGridView ListaDetalle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Identidad;
        private System.Windows.Forms.Button Btn_Cliente;
        private DS dS;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private DSTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaFechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIdentificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaSubtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaImpuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaDescuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource facturaDetalleBindingSource;
        private DSTableAdapters.FacturaDetalleTableAdapter facturaDetalleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaDetalleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
    }
}