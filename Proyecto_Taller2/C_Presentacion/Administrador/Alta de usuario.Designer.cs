namespace Proyecto_Taller2.C_Presentacion.Administrador
{
    partial class formAltaUsuarioAdmin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAltaUsuarioAdmin));
            fileSystemWatcher1 = new FileSystemWatcher();
            lblNombre = new Label();
            tbxNombre = new TextBox();
            lblApellido = new Label();
            tbxApellido = new TextBox();
            lblUsuario = new Label();
            tbxUser = new TextBox();
            lblDni = new Label();
            tbxClave = new TextBox();
            lblContrasena = new Label();
            tbxDni = new TextBox();
            btnRegistrar = new Button();
            lblAltaDeUsuario = new Label();
            btnCancelar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            cbxRol = new ComboBox();
            lblRol = new Label();
            errorProvider = new ErrorProvider(components);
            lblTelefono = new Label();
            tbxTelefono = new TextBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Franklin Gothic Medium", 14.25F);
            lblNombre.Location = new Point(68, 112);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(80, 24);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            lblNombre.Click += lblNombre_Click;
            // 
            // tbxNombre
            // 
            tbxNombre.BackColor = SystemColors.Window;
            tbxNombre.Location = new Point(181, 112);
            tbxNombre.Margin = new Padding(3, 3, 10, 3);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(211, 23);
            tbxNombre.TabIndex = 1;
            tbxNombre.KeyPress += tbxNombre_KeyPress;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(68, 150);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(81, 24);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // tbxApellido
            // 
            tbxApellido.Location = new Point(181, 150);
            tbxApellido.Margin = new Padding(3, 3, 10, 3);
            tbxApellido.Name = "tbxApellido";
            tbxApellido.Size = new Size(211, 23);
            tbxApellido.TabIndex = 3;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(68, 318);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(76, 24);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario:";
            // 
            // tbxUser
            // 
            tbxUser.Location = new Point(181, 321);
            tbxUser.Name = "tbxUser";
            tbxUser.Size = new Size(211, 23);
            tbxUser.TabIndex = 5;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(68, 192);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(42, 24);
            lblDni.TabIndex = 6;
            lblDni.Text = "Dni:";
            // 
            // tbxClave
            // 
            tbxClave.Location = new Point(181, 361);
            tbxClave.Name = "tbxClave";
            tbxClave.Size = new Size(211, 23);
            tbxClave.TabIndex = 7;
            tbxClave.UseSystemPasswordChar = true;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContrasena.Location = new Point(68, 361);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(107, 24);
            lblContrasena.TabIndex = 8;
            lblContrasena.Text = "Contraseña:";
            // 
            // tbxDni
            // 
            tbxDni.Location = new Point(181, 192);
            tbxDni.Name = "tbxDni";
            tbxDni.Size = new Size(211, 23);
            tbxDni.TabIndex = 9;
            tbxDni.KeyPress += tbxDni_KeyPress;
            // 
            // btnRegistrar
            // 
            btnRegistrar.FlatStyle = FlatStyle.System;
            btnRegistrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(311, 504);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(138, 45);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar usuario";
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblAltaDeUsuario
            // 
            lblAltaDeUsuario.AutoSize = true;
            lblAltaDeUsuario.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAltaDeUsuario.Location = new Point(101, 40);
            lblAltaDeUsuario.Name = "lblAltaDeUsuario";
            lblAltaDeUsuario.Size = new Size(186, 28);
            lblAltaDeUsuario.TabIndex = 11;
            lblAltaDeUsuario.Text = "Alta de usuario";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(158, 504);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(138, 45);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 251, 255);
            panel1.Controls.Add(tbxTelefono);
            panel1.Controls.Add(lblTelefono);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cbxRol);
            panel1.Controls.Add(lblRol);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(lblAltaDeUsuario);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(tbxDni);
            panel1.Controls.Add(lblContrasena);
            panel1.Controls.Add(tbxClave);
            panel1.Controls.Add(lblDni);
            panel1.Controls.Add(tbxUser);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(tbxApellido);
            panel1.Controls.Add(lblApellido);
            panel1.Controls.Add(tbxNombre);
            panel1.Controls.Add(lblNombre);
            panel1.Location = new Point(190, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 600);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.userplus;
            pictureBox1.Location = new Point(15, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // cbxRol
            // 
            cbxRol.FormattingEnabled = true;
            cbxRol.Items.AddRange(new object[] { "Vendedor", "Administrador", "Supervisor" });
            cbxRol.Location = new Point(181, 443);
            cbxRol.Name = "cbxRol";
            cbxRol.Size = new Size(211, 23);
            cbxRol.TabIndex = 15;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRol.Location = new Point(68, 443);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(42, 24);
            lblRol.TabIndex = 13;
            lblRol.Text = "Rol:";
            // 
            // errorProvider
            // 
            errorProvider.BlinkRate = 300;
            errorProvider.ContainerControl = this;
            errorProvider.Icon = (Icon)resources.GetObject("errorProvider.Icon");
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(68, 229);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(85, 24);
            lblTelefono.TabIndex = 17;
            lblTelefono.Text = "Telefono:";
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(181, 229);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(211, 23);
            tbxTelefono.TabIndex = 18;
            // 
            // formAltaUsuarioAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(880, 600);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "formAltaUsuarioAdmin";
            StartPosition = FormStartPosition.Manual;
            Text = "Alta de Usuario";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FileSystemWatcher fileSystemWatcher1;
        private Panel panel1;
        private Button btnCancelar;
        private Label lblAltaDeUsuario;
        private Button btnRegistrar;
        private TextBox tbxDni;
        private Label lblContrasena;
        private TextBox tbxClave;
        private Label lblDni;
        private TextBox tbxUser;
        private Label lblUsuario;
        private TextBox tbxApellido;
        private Label lblApellido;
        private TextBox tbxNombre;
        private Label lblNombre;
        private ComboBox cbxRol;
        private Label lblRol;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider;
        private TextBox tbxTelefono;
        private Label lblTelefono;
    }
}