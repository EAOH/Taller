namespace CheckEngineTaller.Gestion
{
    partial class gVehiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardarVehiculo = new System.Windows.Forms.Button();
            this.txtPlacaVehiculo = new System.Windows.Forms.TextBox();
            this.txtModeloVehiculo = new System.Windows.Forms.TextBox();
            this.cbbMarcaVehiculo = new System.Windows.Forms.ComboBox();
            this.cbbColorVehiculo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoClienteVehiculo = new System.Windows.Forms.TextBox();
            this.chkEstadoVehiculo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chkEstadoVehiculo);
            this.splitContainer1.Panel2.Controls.Add(this.btnGuardarVehiculo);
            this.splitContainer1.Panel2.Controls.Add(this.txtPlacaVehiculo);
            this.splitContainer1.Panel2.Controls.Add(this.txtModeloVehiculo);
            this.splitContainer1.Panel2.Controls.Add(this.cbbMarcaVehiculo);
            this.splitContainer1.Panel2.Controls.Add(this.cbbColorVehiculo);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtCodigoClienteVehiculo);
            this.splitContainer1.Size = new System.Drawing.Size(800, 500);
            this.splitContainer1.SplitterDistance = 86;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(239, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gestion Vehiculos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // btnGuardarVehiculo
            // 
            this.btnGuardarVehiculo.Location = new System.Drawing.Point(341, 311);
            this.btnGuardarVehiculo.Name = "btnGuardarVehiculo";
            this.btnGuardarVehiculo.Size = new System.Drawing.Size(118, 53);
            this.btnGuardarVehiculo.TabIndex = 25;
            this.btnGuardarVehiculo.Text = "Guardar";
            this.btnGuardarVehiculo.UseVisualStyleBackColor = true;
            this.btnGuardarVehiculo.Click += new System.EventHandler(this.btnGuardarVehiculo_Click);
            // 
            // txtPlacaVehiculo
            // 
            this.txtPlacaVehiculo.Location = new System.Drawing.Point(551, 170);
            this.txtPlacaVehiculo.Name = "txtPlacaVehiculo";
            this.txtPlacaVehiculo.Size = new System.Drawing.Size(173, 22);
            this.txtPlacaVehiculo.TabIndex = 23;
            // 
            // txtModeloVehiculo
            // 
            this.txtModeloVehiculo.Location = new System.Drawing.Point(219, 165);
            this.txtModeloVehiculo.Name = "txtModeloVehiculo";
            this.txtModeloVehiculo.Size = new System.Drawing.Size(173, 22);
            this.txtModeloVehiculo.TabIndex = 22;
            // 
            // cbbMarcaVehiculo
            // 
            this.cbbMarcaVehiculo.FormattingEnabled = true;
            this.cbbMarcaVehiculo.Location = new System.Drawing.Point(551, 103);
            this.cbbMarcaVehiculo.Name = "cbbMarcaVehiculo";
            this.cbbMarcaVehiculo.Size = new System.Drawing.Size(173, 24);
            this.cbbMarcaVehiculo.TabIndex = 21;
            // 
            // cbbColorVehiculo
            // 
            this.cbbColorVehiculo.FormattingEnabled = true;
            this.cbbColorVehiculo.Location = new System.Drawing.Point(219, 103);
            this.cbbColorVehiculo.Name = "cbbColorVehiculo";
            this.cbbColorVehiculo.Size = new System.Drawing.Size(173, 24);
            this.cbbColorVehiculo.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Estado: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Placa: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Modelo: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Marca: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Color: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Codigo Cliente: ";
            // 
            // txtCodigoClienteVehiculo
            // 
            this.txtCodigoClienteVehiculo.Location = new System.Drawing.Point(219, 46);
            this.txtCodigoClienteVehiculo.Name = "txtCodigoClienteVehiculo";
            this.txtCodigoClienteVehiculo.Size = new System.Drawing.Size(173, 22);
            this.txtCodigoClienteVehiculo.TabIndex = 13;
            // 
            // chkEstadoVehiculo
            // 
            this.chkEstadoVehiculo.AutoSize = true;
            this.chkEstadoVehiculo.Location = new System.Drawing.Point(294, 234);
            this.chkEstadoVehiculo.Name = "chkEstadoVehiculo";
            this.chkEstadoVehiculo.Size = new System.Drawing.Size(102, 21);
            this.chkEstadoVehiculo.TabIndex = 26;
            this.chkEstadoVehiculo.Text = "Terminado.";
            this.chkEstadoVehiculo.UseVisualStyleBackColor = true;
            // 
            // gVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "gVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gVehiculo";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarVehiculo;
        private System.Windows.Forms.TextBox txtPlacaVehiculo;
        private System.Windows.Forms.TextBox txtModeloVehiculo;
        private System.Windows.Forms.ComboBox cbbMarcaVehiculo;
        private System.Windows.Forms.ComboBox cbbColorVehiculo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoClienteVehiculo;
        private System.Windows.Forms.CheckBox chkEstadoVehiculo;
    }
}