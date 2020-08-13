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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ventas = new System.Windows.Forms.TabPage();
            this.Cliente = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(983, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.ventas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ventas.Location = new System.Drawing.Point(4, 4);
            this.ventas.Name = "ventas";
            this.ventas.Padding = new System.Windows.Forms.Padding(3);
            this.ventas.Size = new System.Drawing.Size(1892, 874);
            this.ventas.TabIndex = 0;
            this.ventas.Text = "Ventas";
            this.ventas.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cliente.Location = new System.Drawing.Point(4, 4);
            this.Cliente.Name = "Cliente";
            this.Cliente.Padding = new System.Windows.Forms.Padding(3);
            this.Cliente.Size = new System.Drawing.Size(1892, 874);
            this.Cliente.TabIndex = 1;
            this.Cliente.Text = "Clientes";
            this.Cliente.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonCliente
            // 
            this.buttonCliente.Location = new System.Drawing.Point(12, 56);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(107, 35);
            this.buttonCliente.TabIndex = 3;
            this.buttonCliente.Text = "Cliente";
            this.buttonCliente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ventas;
        private System.Windows.Forms.TabPage Cliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCliente;
    }
}

