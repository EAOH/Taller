namespace CheckEngineTaller.Gestion
{
    partial class gcliente
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblGestionCliente = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnGuardarCl = new System.Windows.Forms.Button();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblIdentidad = new System.Windows.Forms.Label();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel1.Controls.Add(this.lblGestionCliente);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.txtTelefono);
            this.splitContainer1.Panel2.Controls.Add(this.txtDireccion);
            this.splitContainer1.Panel2.Controls.Add(this.btnGuardarCl);
            this.splitContainer1.Panel2.Controls.Add(this.txtIdentidad);
            this.splitContainer1.Panel2.Controls.Add(this.txtApellido1);
            this.splitContainer1.Panel2.Controls.Add(this.txtNombre1);
            this.splitContainer1.Panel2.Controls.Add(this.lblTelefono);
            this.splitContainer1.Panel2.Controls.Add(this.lblDireccion);
            this.splitContainer1.Panel2.Controls.Add(this.lblIdentidad);
            this.splitContainer1.Panel2.Controls.Add(this.lblApellido1);
            this.splitContainer1.Panel2.Controls.Add(this.lblNombre1);
            this.splitContainer1.Size = new System.Drawing.Size(600, 366);
            this.splitContainer1.SplitterDistance = 61;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblGestionCliente
            // 
            this.lblGestionCliente.AutoSize = true;
            this.lblGestionCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.lblGestionCliente.Location = new System.Drawing.Point(259, 35);
            this.lblGestionCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestionCliente.Name = "lblGestionCliente";
            this.lblGestionCliente.Size = new System.Drawing.Size(83, 13);
            this.lblGestionCliente.TabIndex = 6;
            this.lblGestionCliente.Text = "Gestion Clientes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(395, 110);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(184, 20);
            this.txtTelefono.TabIndex = 28;
            this.txtTelefono.Tag = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(110, 158);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(449, 20);
            this.txtDireccion.TabIndex = 27;
            this.txtDireccion.Tag = "Dirección";
            // 
            // btnGuardarCl
            // 
            this.btnGuardarCl.BackColor = System.Drawing.Color.LightGray;
            this.btnGuardarCl.Location = new System.Drawing.Point(250, 236);
            this.btnGuardarCl.Name = "btnGuardarCl";
            this.btnGuardarCl.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCl.TabIndex = 15;
            this.btnGuardarCl.Text = "Guardar";
            this.btnGuardarCl.UseVisualStyleBackColor = false;
            this.btnGuardarCl.Click += new System.EventHandler(this.btnGuardarCl_Click);
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Location = new System.Drawing.Point(110, 110);
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(184, 20);
            this.txtIdentidad.TabIndex = 26;
            this.txtIdentidad.Tag = "Identificacion";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(110, 63);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(184, 20);
            this.txtApellido1.TabIndex = 24;
            this.txtApellido1.Tag = "Primer apellido";
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(110, 19);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(184, 20);
            this.txtNombre1.TabIndex = 22;
            this.txtNombre1.Tag = "Primer nombre";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(307, 114);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 21;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(22, 158);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 20;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblIdentidad
            // 
            this.lblIdentidad.AutoSize = true;
            this.lblIdentidad.Location = new System.Drawing.Point(22, 110);
            this.lblIdentidad.Name = "lblIdentidad";
            this.lblIdentidad.Size = new System.Drawing.Size(70, 13);
            this.lblIdentidad.TabIndex = 19;
            this.lblIdentidad.Text = "Identificacion";
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Location = new System.Drawing.Point(22, 63);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(76, 13);
            this.lblApellido1.TabIndex = 17;
            this.lblApellido1.Text = "Primer Apellido";
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(22, 27);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(76, 13);
            this.lblNombre1.TabIndex = 14;
            this.lblNombre1.Text = "Primer Nombre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtApellido2);
            this.panel1.Controls.Add(this.txtNombre2);
            this.panel1.Controls.Add(this.lblApellido2);
            this.panel1.Controls.Add(this.lblNombre2);
            this.panel1.Location = new System.Drawing.Point(291, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 72);
            this.panel1.TabIndex = 29;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(106, 48);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(184, 20);
            this.txtApellido2.TabIndex = 29;
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(106, 4);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(184, 20);
            this.txtNombre2.TabIndex = 28;
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Location = new System.Drawing.Point(18, 48);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(90, 13);
            this.lblApellido2.TabIndex = 27;
            this.lblApellido2.Text = "Segundo Apellido";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(18, 6);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(90, 13);
            this.lblNombre2.TabIndex = 26;
            this.lblNombre2.Text = "Segundo Nombre";
            // 
            // gcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "gcliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gcliente";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnGuardarCl;
        private System.Windows.Forms.TextBox txtIdentidad;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblIdentidad;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblGestionCliente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.Label lblNombre2;
    }
}