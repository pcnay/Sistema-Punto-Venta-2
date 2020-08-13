namespace Sistema_Punto_Venta
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ventas = new System.Windows.Forms.TabPage();
            this.Cliente = new System.Windows.Forms.TabPage();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Cliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.ventas);
            this.tabControl1.Controls.Add(this.Cliente);
            this.tabControl1.Location = new System.Drawing.Point(0, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1900, 900);
            this.tabControl1.TabIndex = 1;
            // 
            // ventas
            // 
            this.ventas.BackColor = System.Drawing.Color.Transparent;
            this.ventas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ventas.Location = new System.Drawing.Point(4, 4);
            this.ventas.Name = "ventas";
            this.ventas.Padding = new System.Windows.Forms.Padding(3);
            this.ventas.Size = new System.Drawing.Size(1892, 874);
            this.ventas.TabIndex = 0;
            this.ventas.Text = "Ventas";
            // 
            // Cliente
            // 
            this.Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cliente.Controls.Add(this.groupBox2);
            this.Cliente.Location = new System.Drawing.Point(4, 4);
            this.Cliente.Name = "Cliente";
            this.Cliente.Padding = new System.Windows.Forms.Padding(3);
            this.Cliente.Size = new System.Drawing.Size(1892, 874);
            this.Cliente.TabIndex = 1;
            this.Cliente.Text = "Clientes";
            this.Cliente.UseVisualStyleBackColor = true;
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonCliente.FlatAppearance.BorderSize = 0;
            this.buttonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCliente.Location = new System.Drawing.Point(4, 76);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(107, 35);
            this.buttonCliente.TabIndex = 3;
            this.buttonCliente.Text = "CLIENTES";
            this.buttonCliente.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1229, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(359, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Punto De Venta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(2, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1198, 82);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1217, 961);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.Cliente.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ventas;
        private System.Windows.Forms.TabPage Cliente;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
    }
}

