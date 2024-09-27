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
            btnInformeVentas = new Button();
            btnGestionProveedores = new Button();
            btnGestionarClientes = new Button();
            ptbLogo = new PictureBox();
            btnCerrarSesion = new Button();
            lblUsuario = new Label();
            btnGestionarProductos = new Button();
            lblMenuAdmin = new Label();
            btnEstadisticas = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnInformeVentas);
            panel1.Controls.Add(btnGestionProveedores);
            panel1.Controls.Add(btnGestionarClientes);
            panel1.Controls.Add(ptbLogo);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(btnGestionarProductos);
            panel1.Controls.Add(lblMenuAdmin);
            panel1.Controls.Add(btnEstadisticas);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 611);
            panel1.TabIndex = 1;
            // 
            // btnInformeVentas
            // 
            btnInformeVentas.Image = Properties.Resources.histograma_de_grafico;
            btnInformeVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnInformeVentas.Location = new Point(24, 481);
            btnInformeVentas.Name = "btnInformeVentas";
            btnInformeVentas.Padding = new Padding(5, 0, 0, 0);
            btnInformeVentas.Size = new Size(232, 52);
            btnInformeVentas.TabIndex = 10;
            btnInformeVentas.Text = "Informes Venta";
            btnInformeVentas.UseVisualStyleBackColor = true;
            btnInformeVentas.Click += btnInformeVentas_Click;
            // 
            // btnGestionProveedores
            // 
            btnGestionProveedores.Image = Properties.Resources.proveedor__1_;
            btnGestionProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionProveedores.Location = new Point(24, 424);
            btnGestionProveedores.Name = "btnGestionProveedores";
            btnGestionProveedores.Padding = new Padding(5, 0, 0, 0);
            btnGestionProveedores.Size = new Size(232, 51);
            btnGestionProveedores.TabIndex = 9;
            btnGestionProveedores.Text = "Gestionar Proveedores";
            btnGestionProveedores.UseVisualStyleBackColor = true;
            btnGestionProveedores.Click += btnGestionProveedores_Click;
            // 
            // btnGestionarClientes
            // 
            btnGestionarClientes.Image = Properties.Resources.usuarios;
            btnGestionarClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionarClientes.Location = new Point(24, 369);
            btnGestionarClientes.Name = "btnGestionarClientes";
            btnGestionarClientes.Padding = new Padding(5, 0, 0, 0);
            btnGestionarClientes.Size = new Size(232, 49);
            btnGestionarClientes.TabIndex = 8;
            btnGestionarClientes.Text = "Gestionar Clientes";
            btnGestionarClientes.UseVisualStyleBackColor = true;
            btnGestionarClientes.Click += btnGestionarClientes_Click;
            // 
            // ptbLogo
            // 
            ptbLogo.Image = Properties.Resources.logo;
            ptbLogo.InitialImage = Properties.Resources.logo;
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
            btnCerrarSesion.Image = Properties.Resources.salida;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(11, 561);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(279, 38);
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
            // btnGestionarProductos
            // 
            btnGestionarProductos.Image = Properties.Resources.caja_abierta;
            btnGestionarProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionarProductos.Location = new Point(24, 314);
            btnGestionarProductos.Name = "btnGestionarProductos";
            btnGestionarProductos.Padding = new Padding(5, 0, 0, 0);
            btnGestionarProductos.Size = new Size(232, 49);
            btnGestionarProductos.TabIndex = 3;
            btnGestionarProductos.Text = "Gestionar Productos";
            btnGestionarProductos.UseVisualStyleBackColor = true;
            btnGestionarProductos.Click += btnListarProductos_Click;
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
            // btnEstadisticas
            // 
            btnEstadisticas.Image = Properties.Resources.comprobacion_de_lista;
            btnEstadisticas.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstadisticas.Location = new Point(24, 261);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Padding = new Padding(5, 0, 0, 0);
            btnEstadisticas.Size = new Size(232, 47);
            btnEstadisticas.TabIndex = 1;
            btnEstadisticas.Text = "Listar todas las ventas";
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
            Text = "Clothing Store: Administrador";
            Load += Principal_Admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEstadisticas;
        private Label lblMenuAdmin;
        private Button btnGestionarProductos;
        private Label lblUsuario;
        private Button btnCerrarSesion;
        private PictureBox ptbLogo;
        private Button btnGestionarClientes;
        private Button btnGestionProveedores;
        private Button btnInformeVentas;
    }
}