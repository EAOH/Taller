namespace CheckEngineTaller.Gestion
{
    partial class gFactura
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
            System.Windows.Forms.Label productoPrecioUnitarioLabel;
            System.Windows.Forms.Label productoPrecioUnitarioLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gFactura));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.productoPrecioUnitarioTextBox1 = new System.Windows.Forms.TextBox();
            this.soloServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new CheckEngineTaller.DS();
            this.productoPrecioUnitarioTextBox = new System.Windows.Forms.TextBox();
            this.soloProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoDescripcionTextBox1 = new System.Windows.Forms.TextBox();
            this.productoDescripcionTextBox = new System.Windows.Forms.TextBox();
            this.productoIdTextBox1 = new System.Windows.Forms.TextBox();
            this.productoIdTextBox = new System.Windows.Forms.TextBox();
            this.qtyServicio = new System.Windows.Forms.NumericUpDown();
            this.nudProductoCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbServicio = new System.Windows.Forms.ComboBox();
            this.cbbProducto = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaDetalle = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minimas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.productoDescuentoLabel1 = new System.Windows.Forms.Label();
            this.productoDescuentoLabel2 = new System.Windows.Forms.Label();
            this.productoExistenciaMinLabel1 = new System.Windows.Forms.Label();
            this.productoExistenciaLabel1 = new System.Windows.Forms.Label();
            this.soloServiciosTableAdapter = new CheckEngineTaller.DSTableAdapters.SoloServiciosTableAdapter();
            this.tableAdapterManager = new CheckEngineTaller.DSTableAdapters.TableAdapterManager();
            this.soloProductosTableAdapter = new CheckEngineTaller.DSTableAdapters.SoloProductosTableAdapter();
            productoPrecioUnitarioLabel = new System.Windows.Forms.Label();
            productoPrecioUnitarioLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soloServiciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soloProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductoCantidad)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // productoPrecioUnitarioLabel
            // 
            productoPrecioUnitarioLabel.AutoSize = true;
            productoPrecioUnitarioLabel.Location = new System.Drawing.Point(35, 71);
            productoPrecioUnitarioLabel.Name = "productoPrecioUnitarioLabel";
            productoPrecioUnitarioLabel.Size = new System.Drawing.Size(125, 13);
            productoPrecioUnitarioLabel.TabIndex = 30;
            productoPrecioUnitarioLabel.Text = "Producto Precio Unitario:";
            // 
            // productoPrecioUnitarioLabel1
            // 
            productoPrecioUnitarioLabel1.AutoSize = true;
            productoPrecioUnitarioLabel1.Location = new System.Drawing.Point(35, 124);
            productoPrecioUnitarioLabel1.Name = "productoPrecioUnitarioLabel1";
            productoPrecioUnitarioLabel1.Size = new System.Drawing.Size(125, 13);
            productoPrecioUnitarioLabel1.TabIndex = 31;
            productoPrecioUnitarioLabel1.Text = "Producto Precio Unitario:";
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
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(productoPrecioUnitarioLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.productoPrecioUnitarioTextBox1);
            this.splitContainer1.Panel1.Controls.Add(productoPrecioUnitarioLabel);
            this.splitContainer1.Panel1.Controls.Add(this.productoPrecioUnitarioTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.productoDescripcionTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.productoDescripcionTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.productoIdTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.productoIdTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.qtyServicio);
            this.splitContainer1.Panel1.Controls.Add(this.nudProductoCantidad);
            this.splitContainer1.Panel1.Controls.Add(this.btnAgregarServicio);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cbbServicio);
            this.splitContainer1.Panel1.Controls.Add(this.cbbProducto);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.ListaDetalle);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.productoDescuentoLabel1);
            this.splitContainer1.Panel2.Controls.Add(this.productoDescuentoLabel2);
            this.splitContainer1.Panel2.Controls.Add(this.productoExistenciaMinLabel1);
            this.splitContainer1.Panel2.Controls.Add(this.productoExistenciaLabel1);
            this.splitContainer1.Size = new System.Drawing.Size(600, 406);
            this.splitContainer1.SplitterDistance = 143;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // productoPrecioUnitarioTextBox1
            // 
            this.productoPrecioUnitarioTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soloServiciosBindingSource, "ProductoPrecioUnitario", true));
            this.productoPrecioUnitarioTextBox1.Enabled = false;
            this.productoPrecioUnitarioTextBox1.Location = new System.Drawing.Point(166, 121);
            this.productoPrecioUnitarioTextBox1.Name = "productoPrecioUnitarioTextBox1";
            this.productoPrecioUnitarioTextBox1.Size = new System.Drawing.Size(100, 20);
            this.productoPrecioUnitarioTextBox1.TabIndex = 32;
            // 
            // soloServiciosBindingSource
            // 
            this.soloServiciosBindingSource.DataMember = "SoloServicios";
            this.soloServiciosBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoPrecioUnitarioTextBox
            // 
            this.productoPrecioUnitarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soloProductosBindingSource, "ProductoPrecioUnitario", true));
            this.productoPrecioUnitarioTextBox.Enabled = false;
            this.productoPrecioUnitarioTextBox.Location = new System.Drawing.Point(166, 68);
            this.productoPrecioUnitarioTextBox.Name = "productoPrecioUnitarioTextBox";
            this.productoPrecioUnitarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.productoPrecioUnitarioTextBox.TabIndex = 31;
            // 
            // soloProductosBindingSource
            // 
            this.soloProductosBindingSource.DataMember = "SoloProductos";
            this.soloProductosBindingSource.DataSource = this.dS;
            // 
            // productoDescripcionTextBox1
            // 
            this.productoDescripcionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soloServiciosBindingSource, "ProductoDescripcion", true));
            this.productoDescripcionTextBox1.Enabled = false;
            this.productoDescripcionTextBox1.Location = new System.Drawing.Point(309, 81);
            this.productoDescripcionTextBox1.Multiline = true;
            this.productoDescripcionTextBox1.Name = "productoDescripcionTextBox1";
            this.productoDescripcionTextBox1.Size = new System.Drawing.Size(152, 52);
            this.productoDescripcionTextBox1.TabIndex = 30;
            // 
            // productoDescripcionTextBox
            // 
            this.productoDescripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soloProductosBindingSource, "ProductoDescripcion", true));
            this.productoDescripcionTextBox.Enabled = false;
            this.productoDescripcionTextBox.Location = new System.Drawing.Point(309, 27);
            this.productoDescripcionTextBox.Multiline = true;
            this.productoDescripcionTextBox.Name = "productoDescripcionTextBox";
            this.productoDescripcionTextBox.Size = new System.Drawing.Size(152, 48);
            this.productoDescripcionTextBox.TabIndex = 29;
            // 
            // productoIdTextBox1
            // 
            this.productoIdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soloServiciosBindingSource, "ProductoId", true));
            this.productoIdTextBox1.Enabled = false;
            this.productoIdTextBox1.Location = new System.Drawing.Point(95, 99);
            this.productoIdTextBox1.Name = "productoIdTextBox1";
            this.productoIdTextBox1.Size = new System.Drawing.Size(36, 20);
            this.productoIdTextBox1.TabIndex = 28;
            // 
            // productoIdTextBox
            // 
            this.productoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soloProductosBindingSource, "ProductoId", true));
            this.productoIdTextBox.Enabled = false;
            this.productoIdTextBox.Location = new System.Drawing.Point(106, 41);
            this.productoIdTextBox.Name = "productoIdTextBox";
            this.productoIdTextBox.Size = new System.Drawing.Size(36, 20);
            this.productoIdTextBox.TabIndex = 27;
            // 
            // qtyServicio
            // 
            this.qtyServicio.Location = new System.Drawing.Point(467, 93);
            this.qtyServicio.Margin = new System.Windows.Forms.Padding(2);
            this.qtyServicio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.qtyServicio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtyServicio.Name = "qtyServicio";
            this.qtyServicio.Size = new System.Drawing.Size(54, 20);
            this.qtyServicio.TabIndex = 26;
            this.qtyServicio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudProductoCantidad
            // 
            this.nudProductoCantidad.Location = new System.Drawing.Point(466, 43);
            this.nudProductoCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.nudProductoCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudProductoCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProductoCantidad.Name = "nudProductoCantidad";
            this.nudProductoCantidad.Size = new System.Drawing.Size(55, 20);
            this.nudProductoCantidad.TabIndex = 24;
            this.nudProductoCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.Enabled = false;
            this.btnAgregarServicio.Location = new System.Drawing.Point(525, 87);
            this.btnAgregarServicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(64, 28);
            this.btnAgregarServicio.TabIndex = 23;
            this.btnAgregarServicio.Text = "Agregar";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Producto: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "    .   ";
            // 
            // cbbServicio
            // 
            this.cbbServicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soloServiciosBindingSource, "ProductoNombre", true));
            this.cbbServicio.DataSource = this.soloServiciosBindingSource;
            this.cbbServicio.DisplayMember = "ProductoNombre";
            this.cbbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbServicio.FormattingEnabled = true;
            this.cbbServicio.Location = new System.Drawing.Point(147, 98);
            this.cbbServicio.Margin = new System.Windows.Forms.Padding(2);
            this.cbbServicio.Name = "cbbServicio";
            this.cbbServicio.Size = new System.Drawing.Size(157, 21);
            this.cbbServicio.TabIndex = 17;
            this.cbbServicio.DropDown += new System.EventHandler(this.cbbServicio_DropDown);
            // 
            // cbbProducto
            // 
            this.cbbProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soloProductosBindingSource, "ProductoNombre", true));
            this.cbbProducto.DataSource = this.soloProductosBindingSource;
            this.cbbProducto.DisplayMember = "ProductoNombre";
            this.cbbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProducto.FormattingEnabled = true;
            this.cbbProducto.Location = new System.Drawing.Point(147, 42);
            this.cbbProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cbbProducto.Name = "cbbProducto";
            this.cbbProducto.Size = new System.Drawing.Size(157, 21);
            this.cbbProducto.TabIndex = 16;
            this.cbbProducto.DropDown += new System.EventHandler(this.cbbProducto_DropDown);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(525, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
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
            this.regresarToolStripMenuItem.Text = "Cerrar Ventana";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // ListaDetalle
            // 
            this.ListaDetalle.AllowUserToAddRows = false;
            this.ListaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.Precio,
            this.SubTotal,
            this.Existencia,
            this.Minimas});
            this.ListaDetalle.Location = new System.Drawing.Point(3, 3);
            this.ListaDetalle.Name = "ListaDetalle";
            this.ListaDetalle.ReadOnly = true;
            this.ListaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaDetalle.Size = new System.Drawing.Size(594, 216);
            this.ListaDetalle.TabIndex = 34;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // Existencia
            // 
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            this.Existencia.Visible = false;
            // 
            // Minimas
            // 
            this.Minimas.HeaderText = "Minimas";
            this.Minimas.Name = "Minimas";
            this.Minimas.ReadOnly = true;
            this.Minimas.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(527, 222);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "Generar ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // productoDescuentoLabel1
            // 
            this.productoDescuentoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soloProductosBindingSource, "ProductoDescuento", true));
            this.productoDescuentoLabel1.Location = new System.Drawing.Point(25, 181);
            this.productoDescuentoLabel1.Name = "productoDescuentoLabel1";
            this.productoDescuentoLabel1.Size = new System.Drawing.Size(100, 23);
            this.productoDescuentoLabel1.TabIndex = 33;
            this.productoDescuentoLabel1.Text = "label5";
            // 
            // productoDescuentoLabel2
            // 
            this.productoDescuentoLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soloServiciosBindingSource, "ProductoDescuento", true));
            this.productoDescuentoLabel2.Location = new System.Drawing.Point(166, 183);
            this.productoDescuentoLabel2.Name = "productoDescuentoLabel2";
            this.productoDescuentoLabel2.Size = new System.Drawing.Size(100, 23);
            this.productoDescuentoLabel2.TabIndex = 17;
            this.productoDescuentoLabel2.Text = "label5";
            // 
            // productoExistenciaMinLabel1
            // 
            this.productoExistenciaMinLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soloProductosBindingSource, "ProductoExistenciaMin", true));
            this.productoExistenciaMinLabel1.Location = new System.Drawing.Point(60, 181);
            this.productoExistenciaMinLabel1.Name = "productoExistenciaMinLabel1";
            this.productoExistenciaMinLabel1.Size = new System.Drawing.Size(100, 23);
            this.productoExistenciaMinLabel1.TabIndex = 36;
            this.productoExistenciaMinLabel1.Text = "label5";
            // 
            // productoExistenciaLabel1
            // 
            this.productoExistenciaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soloProductosBindingSource, "ProductoExistencia", true));
            this.productoExistenciaLabel1.Location = new System.Drawing.Point(12, 181);
            this.productoExistenciaLabel1.Name = "productoExistenciaLabel1";
            this.productoExistenciaLabel1.Size = new System.Drawing.Size(100, 23);
            this.productoExistenciaLabel1.TabIndex = 35;
            this.productoExistenciaLabel1.Text = "label5";
            // 
            // soloServiciosTableAdapter
            // 
            this.soloServiciosTableAdapter.ClearBeforeFill = true;
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
            // soloProductosTableAdapter
            // 
            this.soloProductosTableAdapter.ClearBeforeFill = true;
            // 
            // gFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(600, 406);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "gFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.soloServiciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soloProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductoCantidad)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbServicio;
        private System.Windows.Forms.ComboBox cbbProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown nudProductoCantidad;
        private System.Windows.Forms.NumericUpDown qtyServicio;
        private DS dS;
        private System.Windows.Forms.BindingSource soloServiciosBindingSource;
        private DSTableAdapters.SoloServiciosTableAdapter soloServiciosTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource soloProductosBindingSource;
        private DSTableAdapters.SoloProductosTableAdapter soloProductosTableAdapter;
        private System.Windows.Forms.TextBox productoPrecioUnitarioTextBox1;
        private System.Windows.Forms.TextBox productoPrecioUnitarioTextBox;
        private System.Windows.Forms.TextBox productoDescripcionTextBox1;
        private System.Windows.Forms.TextBox productoDescripcionTextBox;
        private System.Windows.Forms.TextBox productoIdTextBox1;
        private System.Windows.Forms.TextBox productoIdTextBox;
        private System.Windows.Forms.Label productoDescuentoLabel1;
        private System.Windows.Forms.Label productoDescuentoLabel2;
        private System.Windows.Forms.DataGridView ListaDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minimas;
        private System.Windows.Forms.Label productoExistenciaMinLabel1;
        private System.Windows.Forms.Label productoExistenciaLabel1;
    }
}