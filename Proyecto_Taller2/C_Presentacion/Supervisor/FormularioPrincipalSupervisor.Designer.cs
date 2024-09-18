namespace Proyecto_Taller2.C_Presentacion.Supervisor
{
    partial class FormularioPrincipalSupervisor
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
            panelAside = new Panel();
            btnAgregarusuario = new Button();
            btnListarUsuarios = new Button();
            btnCerrarSesion = new Button();
            btnListarVentas = new Button();
            btnEstadistias = new Button();
            ptbLogo = new PictureBox();
            lblUsuario = new Label();
            lblMenuSupervisor = new Label();
            panelAside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // panelAside
            // 
            panelAside.BackColor = Color.White;
            panelAside.Controls.Add(btnAgregarusuario);
            panelAside.Controls.Add(btnListarUsuarios);
            panelAside.Controls.Add(btnCerrarSesion);
            panelAside.Controls.Add(btnListarVentas);
            panelAside.Controls.Add(btnEstadistias);
            panelAside.Controls.Add(ptbLogo);
            panelAside.Controls.Add(lblUsuario);
            panelAside.Controls.Add(lblMenuSupervisor);
            panelAside.Dock = DockStyle.Left;
            panelAside.Location = new Point(0, 0);
            panelAside.Name = "panelAside";
            panelAside.Size = new Size(300, 611);
            panelAside.TabIndex = 1;
            // 
            // btnAgregarusuario
            // 
            btnAgregarusuario.Location = new Point(12, 295);
            btnAgregarusuario.Name = "btnAgregarusuario";
            btnAgregarusuario.Size = new Size(280, 43);
            btnAgregarusuario.TabIndex = 16;
            btnAgregarusuario.Text = "Agregar Usuario";
            btnAgregarusuario.UseVisualStyleBackColor = true;
            btnAgregarusuario.Click += btnAgregarusuario_Click;
            // 
            // btnListarUsuarios
            // 
            btnListarUsuarios.Location = new Point(12, 355);
            btnListarUsuarios.Name = "btnListarUsuarios";
            btnListarUsuarios.Size = new Size(280, 43);
            btnListarUsuarios.TabIndex = 15;
            btnListarUsuarios.Text = "Listar usuarios";
            btnListarUsuarios.UseVisualStyleBackColor = true;
            btnListarUsuarios.Click += btnListarUsuarios_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.LightCoral;
            btnCerrarSesion.Location = new Point(12, 534);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(279, 32);
            btnCerrarSesion.TabIndex = 14;
            btnCerrarSesion.Text = "Cerrar sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnListarVentas
            // 
            btnListarVentas.Location = new Point(12, 472);
            btnListarVentas.Name = "btnListarVentas";
            btnListarVentas.Size = new Size(280, 43);
            btnListarVentas.TabIndex = 12;
            btnListarVentas.Text = "Listar ventas";
            btnListarVentas.UseVisualStyleBackColor = true;
            btnListarVentas.Click += btnListarVentas_Click;
            // 
            // btnEstadistias
            // 
            btnEstadistias.Location = new Point(12, 414);
            btnEstadistias.Name = "btnEstadistias";
            btnEstadistias.Size = new Size(280, 43);
            btnEstadistias.TabIndex = 11;
            btnEstadistias.Text = "Estadisticas";
            btnEstadistias.UseVisualStyleBackColor = true;
            btnEstadistias.Click += btnEstadistias_Click;
            // 
            // ptbLogo
            // 
            ptbLogo.Image = Properties.Resources.logo;
            ptbLogo.Location = new Point(60, 26);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(180, 180);
            ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLogo.TabIndex = 10;
            ptbLogo.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.Location = new Point(70, 241);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(164, 19);
            lblUsuario.TabIndex = 8;
            lblUsuario.Text = "Conectado como: (Name)";
            // 
            // lblMenuSupervisor
            // 
            lblMenuSupervisor.AutoSize = true;
            lblMenuSupervisor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuSupervisor.Location = new Point(84, 209);
            lblMenuSupervisor.Name = "lblMenuSupervisor";
            lblMenuSupervisor.Size = new Size(137, 32);
            lblMenuSupervisor.TabIndex = 9;
            lblMenuSupervisor.Text = "Supervisor";
            // 
            // FormularioPrincipalSupervisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 611);
            Controls.Add(panelAside);
            IsMdiContainer = true;
            MaximizeBox = false;
            Name = "FormularioPrincipalSupervisor";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioPrincipalSupervisor";
            panelAside.ResumeLayout(false);
            panelAside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAside;
        private PictureBox ptbLogo;
        private Label lblUsuario;
        private Label lblMenuSupervisor;
        private Button btnEstadistias;
        private Button btnListarVentas;
        private Button btnCerrarSesion;
        private Button btnAgregarusuario;
        private Button btnListarUsuarios;
    }
}