namespace Proyecto_Taller2.C_Presentacion.Supervisor
{
    partial class EditarUsuario
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            lblDireccion = new Label();
            cbxUserActivo = new ComboBox();
            lblActivo = new Label();
            tbxTelefono = new TextBox();
            lblTelefono = new Label();
            pictureBox1 = new PictureBox();
            cbxRol = new ComboBox();
            lblRol = new Label();
            btnCancelar = new Button();
            lblEditarUsuario = new Label();
            btnConfirmar = new Button();
            tbxDni = new TextBox();
            lblContrasena = new Label();
            tbxClave = new TextBox();
            lblDni = new Label();
            tbxUser = new TextBox();
            lblUsuario = new Label();
            tbxApellido = new TextBox();
            lblApellido = new Label();
            tbxNombre = new TextBox();
            lblNombre = new Label();
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 251, 255);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lblDireccion);
            panel1.Controls.Add(cbxUserActivo);
            panel1.Controls.Add(lblActivo);
            panel1.Controls.Add(tbxTelefono);
            panel1.Controls.Add(lblTelefono);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cbxRol);
            panel1.Controls.Add(lblRol);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(lblEditarUsuario);
            panel1.Controls.Add(btnConfirmar);
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
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 561);
            panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 267);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 23);
            textBox1.TabIndex = 22;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(68, 267);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(91, 24);
            lblDireccion.TabIndex = 21;
            lblDireccion.Text = "Direccion:";
            // 
            // cbxUserActivo
            // 
            cbxUserActivo.FormattingEnabled = true;
            cbxUserActivo.Items.AddRange(new object[] { "Activo", "No Activo" });
            cbxUserActivo.Location = new Point(181, 441);
            cbxUserActivo.Name = "cbxUserActivo";
            cbxUserActivo.Size = new Size(211, 23);
            cbxUserActivo.TabIndex = 20;
            // 
            // lblActivo
            // 
            lblActivo.AutoSize = true;
            lblActivo.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActivo.Location = new Point(68, 441);
            lblActivo.Name = "lblActivo";
            lblActivo.Size = new Size(64, 24);
            lblActivo.TabIndex = 19;
            lblActivo.Text = "Activo:";
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(181, 229);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(211, 23);
            tbxTelefono.TabIndex = 18;
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
            // pictureBox1
            // 
            //pictureBox1.Image = Properties.Resources.userplus;
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
            cbxRol.Location = new Point(181, 401);
            cbxRol.Name = "cbxRol";
            cbxRol.Size = new Size(211, 23);
            cbxRol.TabIndex = 15;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRol.Location = new Point(68, 401);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(42, 24);
            lblRol.TabIndex = 13;
            lblRol.Text = "Rol:";
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
            // lblEditarUsuario
            // 
            lblEditarUsuario.AutoSize = true;
            lblEditarUsuario.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditarUsuario.Location = new Point(101, 40);
            lblEditarUsuario.Name = "lblEditarUsuario";
            lblEditarUsuario.Size = new Size(174, 28);
            lblEditarUsuario.TabIndex = 11;
            lblEditarUsuario.Text = "Editar Usuario";
            // 
            // btnConfirmar
            // 
            btnConfirmar.FlatStyle = FlatStyle.System;
            btnConfirmar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(311, 504);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(138, 45);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // tbxDni
            // 
            tbxDni.Location = new Point(181, 192);
            tbxDni.Name = "tbxDni";
            tbxDni.Size = new Size(211, 23);
            tbxDni.TabIndex = 9;
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
            // tbxClave
            // 
            tbxClave.Location = new Point(181, 361);
            tbxClave.Name = "tbxClave";
            tbxClave.Size = new Size(211, 23);
            tbxClave.TabIndex = 7;
            tbxClave.UseSystemPasswordChar = true;
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
            // tbxUser
            // 
            tbxUser.Location = new Point(181, 321);
            tbxUser.Name = "tbxUser";
            tbxUser.Size = new Size(211, 23);
            tbxUser.TabIndex = 5;
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
            // tbxApellido
            // 
            tbxApellido.Location = new Point(181, 150);
            tbxApellido.Margin = new Padding(3, 3, 10, 3);
            tbxApellido.Name = "tbxApellido";
            tbxApellido.Size = new Size(211, 23);
            tbxApellido.TabIndex = 3;
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
            // tbxNombre
            // 
            tbxNombre.BackColor = SystemColors.Window;
            tbxNombre.Location = new Point(181, 112);
            tbxNombre.Margin = new Padding(3, 3, 10, 3);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(211, 23);
            tbxNombre.TabIndex = 1;
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
            // 
            // errorProvider
            // 
            errorProvider.BlinkRate = 300;
            errorProvider.ContainerControl = this;
            // 
            // EditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(panel1);
            Name = "EditarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbxUserActivo;
        private Label lblActivo;
        private TextBox tbxTelefono;
        private Label lblTelefono;
        private PictureBox pictureBox1;
        private ComboBox cbxRol;
        private Label lblRol;
        private Button btnCancelar;
        private Label lblEditarUsuario;
        private Button btnConfirmar;
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
        private TextBox textBox1;
        private Label lblDireccion;
        private ErrorProvider errorProvider;
    }
}