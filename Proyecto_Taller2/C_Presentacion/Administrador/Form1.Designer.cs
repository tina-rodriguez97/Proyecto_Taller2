namespace Proyecto_Taller2.C_Presentacion.Administrador
{
    partial class formAdmin
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
            panel1 = new Panel();
            btnRegistrar = new Button();
            textBox5 = new TextBox();
            lblContrasena = new Label();
            textBox4 = new TextBox();
            lblDni = new Label();
            textBox3 = new TextBox();
            lblUsuario = new Label();
            textBox2 = new TextBox();
            lblApellido = new Label();
            textBox1 = new TextBox();
            lblNombre = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            lblAltaDeUsuario = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(206, 206, 206);
            panel1.Controls.Add(lblAltaDeUsuario);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(lblContrasena);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(lblDni);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(lblApellido);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lblNombre);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 566);
            panel1.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(308, 493);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(138, 45);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar usuario";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(181, 201);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(211, 23);
            textBox5.TabIndex = 9;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContrasena.Location = new Point(68, 305);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(107, 24);
            lblContrasena.TabIndex = 8;
            lblContrasena.Text = "Contraseña:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(181, 305);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(211, 23);
            textBox4.TabIndex = 7;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(68, 201);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(42, 24);
            lblDni.TabIndex = 6;
            lblDni.Text = "Dni:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(181, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 23);
            textBox3.TabIndex = 5;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(68, 262);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(76, 24);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 23);
            textBox2.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(68, 159);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(81, 24);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 23);
            textBox1.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(68, 112);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(80, 24);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            lblNombre.Click += lblNombre_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblAltaDeUsuario
            // 
            lblAltaDeUsuario.AutoSize = true;
            lblAltaDeUsuario.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAltaDeUsuario.Location = new Point(31, 30);
            lblAltaDeUsuario.Name = "lblAltaDeUsuario";
            lblAltaDeUsuario.Size = new Size(186, 28);
            lblAltaDeUsuario.TabIndex = 11;
            lblAltaDeUsuario.Text = "Alta de usuario";
            // 
            // formAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 252, 247);
            ClientSize = new Size(484, 561);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "formAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox textBox1;
        private Label lblNombre;
        private TextBox textBox5;
        private Label lblContrasena;
        private TextBox textBox4;
        private Label lblDni;
        private TextBox textBox3;
        private Label lblUsuario;
        private TextBox textBox2;
        private Label lblApellido;
        private Button btnRegistrar;
        private Label lblAltaDeUsuario;
    }
}