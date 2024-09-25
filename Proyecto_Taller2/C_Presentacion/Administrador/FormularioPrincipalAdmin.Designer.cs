namespace Proyecto_Taller2.C_Presentacion.Administrador
{
    partial class Principal_Admin
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
            ptbLogo = new PictureBox();
            btnCerrarSesion = new Button();
            lblUsuario = new Label();
            btnListarProductos = new Button();
            lblMenuAdmin = new Label();
            btnNuevoProducto = new Button();
            btnEstadisticas = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ptbLogo);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(btnListarProductos);
            panel1.Controls.Add(lblMenuAdmin);
            panel1.Controls.Add(btnNuevoProducto);
            panel1.Controls.Add(btnEstadisticas);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 611);
            panel1.TabIndex = 1;
            // 
            // ptbLogo
            // 
            ptbLogo.Image = Properties.Resources.logo;
            ptbLogo.Location = new Point(67, 14);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(180, 180);
            ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLogo.TabIndex = 7;
            ptbLogo.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.LightCoral;
            btnCerrarSesion.Location = new Point(11, 567);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(279, 32);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += button2_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.Location = new Point(77, 229);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(164, 19);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Conectado como: (Name)";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // btnListarProductos
            // 
            btnListarProductos.Location = new Point(12, 422);
            btnListarProductos.Name = "btnListarProductos";
            btnListarProductos.Size = new Size(279, 49);
            btnListarProductos.TabIndex = 3;
            btnListarProductos.Text = "Listar Productos";
            btnListarProductos.UseVisualStyleBackColor = true;
            btnListarProductos.Click += btnListarProductos_Click;
            // 
            // lblMenuAdmin
            // 
            lblMenuAdmin.AutoSize = true;
            lblMenuAdmin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuAdmin.Location = new Point(67, 197);
            lblMenuAdmin.Name = "lblMenuAdmin";
            lblMenuAdmin.Size = new Size(180, 32);
            lblMenuAdmin.TabIndex = 2;
            lblMenuAdmin.Text = "Administrador";
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Location = new Point(11, 351);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(279, 49);
            btnNuevoProducto.TabIndex = 2;
            btnNuevoProducto.Text = "Nuevo Producto";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Location = new Point(11, 283);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(280, 47);
            btnEstadisticas.TabIndex = 1;
            btnEstadisticas.Text = "Estadisticas de ventas";
            btnEstadisticas.UseVisualStyleBackColor = true;
            btnEstadisticas.Click += btnNuevoUsuario_Click;
            // 
            // Principal_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 236, 255);
            ClientSize = new Size(1184, 611);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            IsMdiContainer = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Principal_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioPrincipalAdmin";
            Load += Principal_Admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEstadisticas;
        private Button btnNuevoProducto;
        private Label lblMenuAdmin;
        private Button btnListarProductos;
        private Label lblUsuario;
        private Label debug;
        private Button btnCerrarSesion;
        private PictureBox ptbLogo;
    }
}