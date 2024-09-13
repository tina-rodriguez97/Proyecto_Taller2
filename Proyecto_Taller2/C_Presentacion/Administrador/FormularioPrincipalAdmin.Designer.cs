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
            button2 = new Button();
            lblUsuario = new Label();
            debug = new Label();
            btnListarProductos = new Button();
            button1 = new Button();
            lblMenuAdmin = new Label();
            btnNuevoProducto = new Button();
            btnNuevoUsuario = new Button();
            panel2 = new Panel();
            lblCerrarSesion = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ptbLogo);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(debug);
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
            // button2
            // 
            button2.Location = new Point(172, 597);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            // debug
            // 
            debug.AutoSize = true;
            debug.Location = new Point(25, 597);
            debug.Name = "debug";
            debug.Size = new Size(38, 15);
            debug.TabIndex = 5;
            debug.Text = "label1";
            // 
            // btnListarProductos
            // 
            btnListarProductos.Location = new Point(12, 506);
            btnListarProductos.Name = "btnListarProductos";
            btnListarProductos.Size = new Size(279, 49);
            btnListarProductos.TabIndex = 4;
            btnListarProductos.Text = "Listar Productos";
            btnListarProductos.UseVisualStyleBackColor = true;
            btnListarProductos.Click += btnListarProductos_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 341);
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
            lblMenuAdmin.Location = new Point(67, 197);
            lblMenuAdmin.Name = "lblMenuAdmin";
            lblMenuAdmin.Size = new Size(180, 32);
            lblMenuAdmin.TabIndex = 2;
            lblMenuAdmin.Text = "Administrador";
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Location = new Point(12, 442);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(279, 49);
            btnNuevoProducto.TabIndex = 1;
            btnNuevoProducto.Text = "Nuevo Producto";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // btnNuevoUsuario
            // 
            btnNuevoUsuario.Location = new Point(11, 283);
            btnNuevoUsuario.Name = "btnNuevoUsuario";
            btnNuevoUsuario.Size = new Size(280, 43);
            btnNuevoUsuario.TabIndex = 0;
            btnNuevoUsuario.Text = "Nuevo Usuario";
            btnNuevoUsuario.UseVisualStyleBackColor = true;
            btnNuevoUsuario.Click += btnNuevoUsuario_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblCerrarSesion);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 63);
            panel2.TabIndex = 3;
            panel2.Visible = false;
            // 
            // lblCerrarSesion
            // 
            lblCerrarSesion.AutoSize = true;
            lblCerrarSesion.Font = new Font("Segoe UI", 11F);
            lblCerrarSesion.LinkColor = Color.Black;
            lblCerrarSesion.Location = new Point(753, 22);
            lblCerrarSesion.Name = "lblCerrarSesion";
            lblCerrarSesion.Size = new Size(94, 20);
            lblCerrarSesion.TabIndex = 1;
            lblCerrarSesion.TabStop = true;
            lblCerrarSesion.Text = "Cerrar sesion";
            lblCerrarSesion.VisitedLinkColor = Color.Black;
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
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
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
        private Label debug;
        private Button button2;
        private PictureBox ptbLogo;
    }
}