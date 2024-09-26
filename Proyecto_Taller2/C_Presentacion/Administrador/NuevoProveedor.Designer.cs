namespace Proyecto_Taller2.C_Presentacion.Administrador
{
    partial class NuevoProveedor
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
            lblDireccion = new Label();
            tbxTelefono = new TextBox();
            lblTelefono = new Label();
            pictureBox1 = new PictureBox();
            btnCancelar = new Button();
            lblNuevoProveedor = new Label();
            btnConfirmar = new Button();
            tbxDni = new TextBox();
            tbxApellido = new TextBox();
            lblEmail = new Label();
            tbxNombre = new TextBox();
            lblNombre = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 251, 255);
            panel1.Controls.Add(lblDireccion);
            panel1.Controls.Add(tbxTelefono);
            panel1.Controls.Add(lblTelefono);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(lblNuevoProveedor);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(tbxDni);
            panel1.Controls.Add(tbxApellido);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(tbxNombre);
            panel1.Controls.Add(lblNombre);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 561);
            panel1.TabIndex = 3;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(68, 229);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(91, 24);
            lblDireccion.TabIndex = 21;
            lblDireccion.Text = "Direccion:";
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
            lblTelefono.Location = new Point(68, 192);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(85, 24);
            lblTelefono.TabIndex = 17;
            lblTelefono.Text = "Telefono:";
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
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(158, 504);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(138, 45);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblNuevoProveedor
            // 
            lblNuevoProveedor.AutoSize = true;
            lblNuevoProveedor.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNuevoProveedor.Location = new Point(101, 40);
            lblNuevoProveedor.Name = "lblNuevoProveedor";
            lblNuevoProveedor.Size = new Size(213, 28);
            lblNuevoProveedor.TabIndex = 11;
            lblNuevoProveedor.Text = "Nuevo Proveedor";
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
            // 
            // tbxDni
            // 
            tbxDni.Location = new Point(181, 192);
            tbxDni.Name = "tbxDni";
            tbxDni.Size = new Size(211, 23);
            tbxDni.TabIndex = 9;
            // 
            // tbxApellido
            // 
            tbxApellido.Location = new Point(181, 150);
            tbxApellido.Margin = new Padding(3, 3, 10, 3);
            tbxApellido.Name = "tbxApellido";
            tbxApellido.Size = new Size(211, 23);
            tbxApellido.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(68, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 24);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
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
            // NuevoProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "NuevoProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Proveedor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDireccion;
        private TextBox tbxTelefono;
        private Label lblTelefono;
        private PictureBox pictureBox1;
        private Button btnCancelar;
        private Label lblNuevoProveedor;
        private Button btnConfirmar;
        private TextBox tbxDni;
        private TextBox tbxApellido;
        private Label lblEmail;
        private TextBox tbxNombre;
        private Label lblNombre;
    }
}