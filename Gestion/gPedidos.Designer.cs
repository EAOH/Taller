namespace CheckEngineTaller.Gestion
{
    partial class gPedidos
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
            this.nudPrecioUnitarioPedido = new System.Windows.Forms.NumericUpDown();
            this.nudCantidadPedido = new System.Windows.Forms.NumericUpDown();
            this.btnGuardadPedido = new System.Windows.Forms.Button();
            this.txtDescripcionPedido = new System.Windows.Forms.TextBox();
            this.txtCodigoProductoPedido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioUnitarioPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel2.Controls.Add(this.nudPrecioUnitarioPedido);
            this.splitContainer1.Panel2.Controls.Add(this.nudCantidadPedido);
            this.splitContainer1.Panel2.Controls.Add(this.btnGuardadPedido);
            this.splitContainer1.Panel2.Controls.Add(this.txtDescripcionPedido);
            this.splitContainer1.Panel2.Controls.Add(this.txtCodigoProductoPedido);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(600, 366);
            this.splitContainer1.SplitterDistance = 61;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion De Pedidos";
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
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // nudPrecioUnitarioPedido
            // 
            this.nudPrecioUnitarioPedido.DecimalPlaces = 2;
            this.nudPrecioUnitarioPedido.Location = new System.Drawing.Point(428, 119);
            this.nudPrecioUnitarioPedido.Margin = new System.Windows.Forms.Padding(2);
            this.nudPrecioUnitarioPedido.Name = "nudPrecioUnitarioPedido";
            this.nudPrecioUnitarioPedido.Size = new System.Drawing.Size(129, 20);
            this.nudPrecioUnitarioPedido.TabIndex = 12;
            // 
            // nudCantidadPedido
            // 
            this.nudCantidadPedido.Location = new System.Drawing.Point(162, 119);
            this.nudCantidadPedido.Margin = new System.Windows.Forms.Padding(2);
            this.nudCantidadPedido.Name = "nudCantidadPedido";
            this.nudCantidadPedido.Size = new System.Drawing.Size(129, 20);
            this.nudCantidadPedido.TabIndex = 11;
            // 
            // btnGuardadPedido
            // 
            this.btnGuardadPedido.Location = new System.Drawing.Point(243, 208);
            this.btnGuardadPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardadPedido.Name = "btnGuardadPedido";
            this.btnGuardadPedido.Size = new System.Drawing.Size(113, 44);
            this.btnGuardadPedido.TabIndex = 10;
            this.btnGuardadPedido.Text = "Guardar";
            this.btnGuardadPedido.UseVisualStyleBackColor = true;
            this.btnGuardadPedido.Click += new System.EventHandler(this.btnGuardadPedido_Click);
            // 
            // txtDescripcionPedido
            // 
            this.txtDescripcionPedido.Location = new System.Drawing.Point(428, 43);
            this.txtDescripcionPedido.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionPedido.MaxLength = 100;
            this.txtDescripcionPedido.Name = "txtDescripcionPedido";
            this.txtDescripcionPedido.Size = new System.Drawing.Size(130, 20);
            this.txtDescripcionPedido.TabIndex = 8;
            this.txtDescripcionPedido.Tag = "Descripcion del producto";
            // 
            // txtCodigoProductoPedido
            // 
            this.txtCodigoProductoPedido.Location = new System.Drawing.Point(162, 43);
            this.txtCodigoProductoPedido.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoProductoPedido.Name = "txtCodigoProductoPedido";
            this.txtCodigoProductoPedido.Size = new System.Drawing.Size(130, 20);
            this.txtCodigoProductoPedido.TabIndex = 6;
            this.txtCodigoProductoPedido.Tag = "Codigo del producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio Unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo De Producto:";
            // 
            // gPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "gPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gPedidos";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioUnitarioPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDescripcionPedido;
        private System.Windows.Forms.TextBox txtCodigoProductoPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardadPedido;
        private System.Windows.Forms.NumericUpDown nudPrecioUnitarioPedido;
        private System.Windows.Forms.NumericUpDown nudCantidadPedido;
    }
}