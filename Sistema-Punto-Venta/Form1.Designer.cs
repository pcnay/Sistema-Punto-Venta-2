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
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.ventas = new System.Windows.Forms.TabPage();
            this.Cliente = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonCliente_Cancelar = new System.Windows.Forms.Button();
            this.buttonCliente_Agregar = new System.Windows.Forms.Button();
            this.textBoxCliente_Direccion = new System.Windows.Forms.TextBox();
            this.labelCliente_Direccion = new System.Windows.Forms.Label();
            this.textBoxCliente_Telefono = new System.Windows.Forms.TextBox();
            this.labelCliente_Telefono = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelCliente_Email = new System.Windows.Forms.Label();
            this.textBoxCliente_Apellido = new System.Windows.Forms.TextBox();
            this.labelCliente_Apellido = new System.Windows.Forms.Label();
            this.textBoxCliente_Nombe = new System.Windows.Forms.TextBox();
            this.labelCliente_Nombre = new System.Windows.Forms.Label();
            this.textBoxCliente_Nid = new System.Windows.Forms.TextBox();
            this.labelCliente_Nid = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCliente_Buscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlPrincipal.SuspendLayout();
            this.Cliente.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlPrincipal.Controls.Add(this.ventas);
            this.tabControlPrincipal.Controls.Add(this.Cliente);
            this.tabControlPrincipal.Location = new System.Drawing.Point(0, 113);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(1900, 900);
            this.tabControlPrincipal.TabIndex = 1;
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
            this.Cliente.Controls.Add(this.groupBox5);
            this.Cliente.Controls.Add(this.groupBox3);
            this.Cliente.Controls.Add(this.groupBox2);
            this.Cliente.Location = new System.Drawing.Point(4, 4);
            this.Cliente.Name = "Cliente";
            this.Cliente.Padding = new System.Windows.Forms.Padding(3);
            this.Cliente.Size = new System.Drawing.Size(1892, 874);
            this.Cliente.TabIndex = 1;
            this.Cliente.Text = "Clientes";
            this.Cliente.UseVisualStyleBackColor = true;
            this.Cliente.Click += new System.EventHandler(this.Cliente_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Location = new System.Drawing.Point(478, 117);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(732, 700);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.tabControl2);
            this.groupBox3.Location = new System.Drawing.Point(13, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 709);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(0, 10);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(448, 693);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonCliente_Cancelar);
            this.tabPage1.Controls.Add(this.buttonCliente_Agregar);
            this.tabPage1.Controls.Add(this.textBoxCliente_Direccion);
            this.tabPage1.Controls.Add(this.labelCliente_Direccion);
            this.tabPage1.Controls.Add(this.textBoxCliente_Telefono);
            this.tabPage1.Controls.Add(this.labelCliente_Telefono);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.labelCliente_Email);
            this.tabPage1.Controls.Add(this.textBoxCliente_Apellido);
            this.tabPage1.Controls.Add(this.labelCliente_Apellido);
            this.tabPage1.Controls.Add(this.textBoxCliente_Nombe);
            this.tabPage1.Controls.Add(this.labelCliente_Nombre);
            this.tabPage1.Controls.Add(this.textBoxCliente_Nid);
            this.tabPage1.Controls.Add(this.labelCliente_Nid);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(440, 667);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCliente_Cancelar
            // 
            this.buttonCliente_Cancelar.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonCliente_Cancelar.FlatAppearance.BorderSize = 0;
            this.buttonCliente_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCliente_Cancelar.Location = new System.Drawing.Point(206, 440);
            this.buttonCliente_Cancelar.Name = "buttonCliente_Cancelar";
            this.buttonCliente_Cancelar.Size = new System.Drawing.Size(107, 35);
            this.buttonCliente_Cancelar.TabIndex = 16;
            this.buttonCliente_Cancelar.Text = "CANCELAR";
            this.buttonCliente_Cancelar.UseVisualStyleBackColor = false;
            // 
            // buttonCliente_Agregar
            // 
            this.buttonCliente_Agregar.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonCliente_Agregar.FlatAppearance.BorderSize = 0;
            this.buttonCliente_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCliente_Agregar.Location = new System.Drawing.Point(41, 440);
            this.buttonCliente_Agregar.Name = "buttonCliente_Agregar";
            this.buttonCliente_Agregar.Size = new System.Drawing.Size(107, 35);
            this.buttonCliente_Agregar.TabIndex = 15;
            this.buttonCliente_Agregar.Text = "AGREGAR";
            this.buttonCliente_Agregar.UseVisualStyleBackColor = false;
            // 
            // textBoxCliente_Direccion
            // 
            this.textBoxCliente_Direccion.Location = new System.Drawing.Point(219, 383);
            this.textBoxCliente_Direccion.Multiline = true;
            this.textBoxCliente_Direccion.Name = "textBoxCliente_Direccion";
            this.textBoxCliente_Direccion.Size = new System.Drawing.Size(200, 36);
            this.textBoxCliente_Direccion.TabIndex = 14;
            // 
            // labelCliente_Direccion
            // 
            this.labelCliente_Direccion.AutoSize = true;
            this.labelCliente_Direccion.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelCliente_Direccion.Location = new System.Drawing.Point(219, 367);
            this.labelCliente_Direccion.Name = "labelCliente_Direccion";
            this.labelCliente_Direccion.Size = new System.Drawing.Size(52, 13);
            this.labelCliente_Direccion.TabIndex = 13;
            this.labelCliente_Direccion.Text = "Direccion";
            // 
            // textBoxCliente_Telefono
            // 
            this.textBoxCliente_Telefono.Location = new System.Drawing.Point(5, 383);
            this.textBoxCliente_Telefono.Multiline = true;
            this.textBoxCliente_Telefono.Name = "textBoxCliente_Telefono";
            this.textBoxCliente_Telefono.Size = new System.Drawing.Size(206, 36);
            this.textBoxCliente_Telefono.TabIndex = 12;
            // 
            // labelCliente_Telefono
            // 
            this.labelCliente_Telefono.AutoSize = true;
            this.labelCliente_Telefono.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelCliente_Telefono.Location = new System.Drawing.Point(2, 367);
            this.labelCliente_Telefono.Name = "labelCliente_Telefono";
            this.labelCliente_Telefono.Size = new System.Drawing.Size(49, 13);
            this.labelCliente_Telefono.TabIndex = 11;
            this.labelCliente_Telefono.Text = "Telefono";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 325);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 36);
            this.textBox1.TabIndex = 10;
            // 
            // labelCliente_Email
            // 
            this.labelCliente_Email.AutoSize = true;
            this.labelCliente_Email.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelCliente_Email.Location = new System.Drawing.Point(221, 309);
            this.labelCliente_Email.Name = "labelCliente_Email";
            this.labelCliente_Email.Size = new System.Drawing.Size(32, 13);
            this.labelCliente_Email.TabIndex = 9;
            this.labelCliente_Email.Text = "Email";
            // 
            // textBoxCliente_Apellido
            // 
            this.textBoxCliente_Apellido.Location = new System.Drawing.Point(9, 326);
            this.textBoxCliente_Apellido.Multiline = true;
            this.textBoxCliente_Apellido.Name = "textBoxCliente_Apellido";
            this.textBoxCliente_Apellido.Size = new System.Drawing.Size(206, 36);
            this.textBoxCliente_Apellido.TabIndex = 8;
            // 
            // labelCliente_Apellido
            // 
            this.labelCliente_Apellido.AutoSize = true;
            this.labelCliente_Apellido.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelCliente_Apellido.Location = new System.Drawing.Point(6, 310);
            this.labelCliente_Apellido.Name = "labelCliente_Apellido";
            this.labelCliente_Apellido.Size = new System.Drawing.Size(44, 13);
            this.labelCliente_Apellido.TabIndex = 7;
            this.labelCliente_Apellido.Text = "Apellido";
            // 
            // textBoxCliente_Nombe
            // 
            this.textBoxCliente_Nombe.Location = new System.Drawing.Point(221, 269);
            this.textBoxCliente_Nombe.Multiline = true;
            this.textBoxCliente_Nombe.Name = "textBoxCliente_Nombe";
            this.textBoxCliente_Nombe.Size = new System.Drawing.Size(200, 36);
            this.textBoxCliente_Nombe.TabIndex = 6;
            // 
            // labelCliente_Nombre
            // 
            this.labelCliente_Nombre.AutoSize = true;
            this.labelCliente_Nombre.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelCliente_Nombre.Location = new System.Drawing.Point(221, 253);
            this.labelCliente_Nombre.Name = "labelCliente_Nombre";
            this.labelCliente_Nombre.Size = new System.Drawing.Size(44, 13);
            this.labelCliente_Nombre.TabIndex = 5;
            this.labelCliente_Nombre.Text = "Nombre";
            // 
            // textBoxCliente_Nid
            // 
            this.textBoxCliente_Nid.Location = new System.Drawing.Point(9, 269);
            this.textBoxCliente_Nid.Multiline = true;
            this.textBoxCliente_Nid.Name = "textBoxCliente_Nid";
            this.textBoxCliente_Nid.Size = new System.Drawing.Size(206, 36);
            this.textBoxCliente_Nid.TabIndex = 4;
            // 
            // labelCliente_Nid
            // 
            this.labelCliente_Nid.AutoSize = true;
            this.labelCliente_Nid.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelCliente_Nid.Location = new System.Drawing.Point(6, 253);
            this.labelCliente_Nid.Name = "labelCliente_Nid";
            this.labelCliente_Nid.Size = new System.Drawing.Size(71, 13);
            this.labelCliente_Nid.TabIndex = 3;
            this.labelCliente_Nid.Text = "No. Identidad";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Location = new System.Drawing.Point(27, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 195);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(33, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 165);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label5.Location = new System.Drawing.Point(107, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Informacion_Nuevo_Cliente";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(440, 667);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pago";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCliente_Buscar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(2, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1208, 80);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // textBoxCliente_Buscar
            // 
            this.textBoxCliente_Buscar.Location = new System.Drawing.Point(230, 28);
            this.textBoxCliente_Buscar.Multiline = true;
            this.textBoxCliente_Buscar.Name = "textBoxCliente_Buscar";
            this.textBoxCliente_Buscar.Size = new System.Drawing.Size(295, 36);
            this.textBoxCliente_Buscar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label3.Location = new System.Drawing.Point(174, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label2.Location = new System.Drawing.Point(5, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Clientes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1217, 961);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.tabControlPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlPrincipal.ResumeLayout(false);
            this.Cliente.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage ventas;
        private System.Windows.Forms.TabPage Cliente;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCliente_Buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCliente_Nombe;
        private System.Windows.Forms.Label labelCliente_Nombre;
        private System.Windows.Forms.TextBox textBoxCliente_Nid;
        private System.Windows.Forms.Label labelCliente_Nid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelCliente_Email;
        private System.Windows.Forms.TextBox textBoxCliente_Apellido;
        private System.Windows.Forms.Label labelCliente_Apellido;
        private System.Windows.Forms.TextBox textBoxCliente_Direccion;
        private System.Windows.Forms.Label labelCliente_Direccion;
        private System.Windows.Forms.TextBox textBoxCliente_Telefono;
        private System.Windows.Forms.Label labelCliente_Telefono;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonCliente_Cancelar;
        private System.Windows.Forms.Button buttonCliente_Agregar;
    }
}

