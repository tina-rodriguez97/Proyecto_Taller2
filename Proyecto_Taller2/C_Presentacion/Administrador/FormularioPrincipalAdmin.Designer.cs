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
            debug = new Label();
            btnListarProductos = new Button();
            button1 = new Button();
            lblMenuAdmin = new Label();
            btnNuevoProducto = new Button();
            btnNuevoUsuario = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 237, 237);
            panel1.Controls.Add(debug);
            panel1.Controls.Add(btnListarProductos);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblMenuAdmin);
            panel1.Controls.Add(btnNuevoProducto);
            panel1.Controls.Add(btnNuevoUsuario);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 607);
            panel1.TabIndex = 1;
            // 
            // debug
            // 
            debug.AutoSize = true;
            debug.Location = new Point(137, 449);
            debug.Name = "debug";
            debug.Size = new Size(38, 15);
            debug.TabIndex = 5;
            debug.Text = "label1";
            // 
            // btnListarProductos
            // 
            btnListarProductos.Location = new Point(9, 328);
            btnListarProductos.Name = "btnListarProductos";
            btnListarProductos.Size = new Size(241, 49);
            btnListarProductos.TabIndex = 4;
            btnListarProductos.Text = "Listar Productos";
            btnListarProductos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(9, 163);
            button1.Name = "button1";
            button1.Size = new Size(241, 43);
            button1.TabIndex = 3;
            button1.Text = "Listar Usuarios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblMenuAdmin
            // 
            lblMenuAdmin.AutoSize = true;
            lblMenuAdmin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuAdmin.Location = new Point(0, 31);
            lblMenuAdmin.Name = "lblMenuAdmin";
            lblMenuAdmin.Size = new Size(288, 32);
            lblMenuAdmin.TabIndex = 2;
            lblMenuAdmin.Text = "Menu de Administrador";
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Location = new Point(9, 264);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(241, 49);
            btnNuevoProducto.TabIndex = 1;
            btnNuevoProducto.Text = "Nuevo Producto";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // btnNuevoUsuario
            // 
            btnNuevoUsuario.Location = new Point(9, 105);
            btnNuevoUsuario.Name = "btnNuevoUsuario";
            btnNuevoUsuario.Size = new Size(241, 43);
            btnNuevoUsuario.TabIndex = 0;
            btnNuevoUsuario.Text = "Nuevo Usuario";
            btnNuevoUsuario.UseVisualStyleBackColor = true;
            btnNuevoUsuario.Click += btnNuevoUsuario_Click;
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
            MinimizeBox = false;
            Name = "Principal_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioPrincipalAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnNuevoUsuario;
        private Button btnNuevoProducto;
        private Label lblMenuAdmin;
        private Button btnListarProductos;
        private Button button1;
        private Label debug;
    }
}