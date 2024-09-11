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
            btnListarProductos = new Button();
            button1 = new Button();
            lblMenuAdmin = new Label();
            btnNuevoProducto = new Button();
            btnNuevoUsuario = new Button();
            panel2 = new Panel();
            lblCerrarSesion = new LinkLabel();
            lblUsuario = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 251, 255);
            panel1.Controls.Add(btnListarProductos);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblMenuAdmin);
            panel1.Controls.Add(btnNuevoProducto);
            panel1.Controls.Add(btnNuevoUsuario);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 661);
            panel1.TabIndex = 1;
            // 
            // btnListarProductos
            // 
            btnListarProductos.Location = new Point(9, 328);
            btnListarProductos.Name = "btnListarProductos";
            btnListarProductos.Size = new Size(279, 49);
            btnListarProductos.TabIndex = 4;
            btnListarProductos.Text = "Listar Productos";
            btnListarProductos.UseVisualStyleBackColor = true;
            btnListarProductos.Click += btnListarProductos_Click;
            // 
            // button1
            // 
            button1.Location = new Point(9, 163);
            button1.Name = "button1";
            button1.Size = new Size(279, 43);
            button1.TabIndex = 3;
            button1.Text = "Listar Usuarios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblMenuAdmin
            // 
            lblMenuAdmin.AutoSize = true;
            lblMenuAdmin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuAdmin.Location = new Point(9, 31);
            lblMenuAdmin.Name = "lblMenuAdmin";
            lblMenuAdmin.Size = new Size(288, 32);
            lblMenuAdmin.TabIndex = 2;
            lblMenuAdmin.Text = "Menu de Administrador";
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Location = new Point(9, 264);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(279, 49);
            btnNuevoProducto.TabIndex = 1;
            btnNuevoProducto.Text = "Nuevo Producto";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // btnNuevoUsuario
            // 
            btnNuevoUsuario.Location = new Point(9, 105);
            btnNuevoUsuario.Name = "btnNuevoUsuario";
            btnNuevoUsuario.Size = new Size(279, 43);
            btnNuevoUsuario.TabIndex = 0;
            btnNuevoUsuario.Text = "Nuevo Usuario";
            btnNuevoUsuario.UseVisualStyleBackColor = true;
            btnNuevoUsuario.Click += btnNuevoUsuario_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 251, 255);
            panel2.Controls.Add(lblCerrarSesion);
            panel2.Controls.Add(lblUsuario);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 63);
            panel2.TabIndex = 3;
            // 
            // lblCerrarSesion
            // 
            lblCerrarSesion.AutoSize = true;
            lblCerrarSesion.Font = new Font("Segoe UI", 11F);
            lblCerrarSesion.LinkColor = Color.Black;
            lblCerrarSesion.Location = new Point(699, 31);
            lblCerrarSesion.Name = "lblCerrarSesion";
            lblCerrarSesion.Size = new Size(94, 20);
            lblCerrarSesion.TabIndex = 1;
            lblCerrarSesion.TabStop = true;
            lblCerrarSesion.Text = "Cerrar sesion";
            lblCerrarSesion.VisitedLinkColor = Color.Black;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F);
            lblUsuario.Location = new Point(656, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(186, 21);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Conectado como: (Name)";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // Principal_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 236, 255);
            ClientSize = new Size(1184, 661);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            IsMdiContainer = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Principal_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioPrincipalAdmin";
            Load += Principal_Admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnNuevoUsuario;
        private Button btnNuevoProducto;
        private Label lblMenuAdmin;
        private Button btnListarProductos;
        private Button button1;
        private Panel panel2;
        private LinkLabel lblCerrarSesion;
        private Label lblUsuario;
    }
}