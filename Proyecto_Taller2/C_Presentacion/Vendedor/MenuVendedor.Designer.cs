namespace Proyecto_Taller2.C_Presentaciones
{
    partial class MenuVendedor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenuVendedor = new Panel();
            lblUsuario = new Label();
            lblMenuVendedor = new Label();
            ptbLogo = new PictureBox();
            btnCerrarSseion = new Button();
            btnAltaCliente = new Button();
            btnVentasRealizadas = new Button();
            btnRealizarVenta = new Button();
            btnListaProductos = new Button();
            panelMuestra = new Panel();
            panelMenuVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMenuVendedor
            // 
            panelMenuVendedor.BackColor = Color.White;
            panelMenuVendedor.Controls.Add(lblUsuario);
            panelMenuVendedor.Controls.Add(lblMenuVendedor);
            panelMenuVendedor.Controls.Add(ptbLogo);
            panelMenuVendedor.Controls.Add(btnCerrarSseion);
            panelMenuVendedor.Controls.Add(btnAltaCliente);
            panelMenuVendedor.Controls.Add(btnVentasRealizadas);
            panelMenuVendedor.Controls.Add(btnRealizarVenta);
            panelMenuVendedor.Controls.Add(btnListaProductos);
            panelMenuVendedor.Dock = DockStyle.Left;
            panelMenuVendedor.Location = new Point(0, 0);
            panelMenuVendedor.Name = "panelMenuVendedor";
            panelMenuVendedor.Size = new Size(300, 611);
            panelMenuVendedor.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.Location = new Point(66, 245);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(164, 19);
            lblUsuario.TabIndex = 13;
            lblUsuario.Text = "Conectado como: (Name)";
            // 
            // lblMenuVendedor
            // 
            lblMenuVendedor.AutoSize = true;
            lblMenuVendedor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuVendedor.Location = new Point(81, 213);
            lblMenuVendedor.Name = "lblMenuVendedor";
            lblMenuVendedor.Size = new Size(124, 32);
            lblMenuVendedor.TabIndex = 14;
            lblMenuVendedor.Text = "Vendedor";
            // 
            // ptbLogo
            // 
            ptbLogo.Image = Properties.Resources.logo;
            ptbLogo.InitialImage = Properties.Resources.logo;
            ptbLogo.Location = new Point(60, 12);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(180, 180);
            ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLogo.TabIndex = 12;
            ptbLogo.TabStop = false;
            // 
            // btnCerrarSseion
            // 
            btnCerrarSseion.BackColor = Color.Salmon;
            btnCerrarSseion.FlatStyle = FlatStyle.Popup;
            btnCerrarSseion.Location = new Point(12, 554);
            btnCerrarSseion.Name = "btnCerrarSseion";
            btnCerrarSseion.Size = new Size(271, 23);
            btnCerrarSseion.TabIndex = 11;
            btnCerrarSseion.Text = "Cerrar Sesión";
            btnCerrarSseion.UseVisualStyleBackColor = false;
            btnCerrarSseion.Click += btnCerrarSseion_Click;
            // 
            // btnAltaCliente
            // 
            btnAltaCliente.Location = new Point(12, 472);
            btnAltaCliente.Name = "btnAltaCliente";
            btnAltaCliente.Size = new Size(271, 42);
            btnAltaCliente.TabIndex = 3;
            btnAltaCliente.Text = "Alta Cliente";
            btnAltaCliente.UseVisualStyleBackColor = true;
            btnAltaCliente.Click += btnAltaCliente_Click;
            // 
            // btnVentasRealizadas
            // 
            btnVentasRealizadas.Location = new Point(12, 412);
            btnVentasRealizadas.Name = "btnVentasRealizadas";
            btnVentasRealizadas.Size = new Size(271, 42);
            btnVentasRealizadas.TabIndex = 2;
            btnVentasRealizadas.Text = "Ver ventas realizadas";
            btnVentasRealizadas.UseVisualStyleBackColor = true;
            btnVentasRealizadas.Click += btnVentasRealizadas_Click;
            // 
            // btnRealizarVenta
            // 
            btnRealizarVenta.Location = new Point(12, 352);
            btnRealizarVenta.Name = "btnRealizarVenta";
            btnRealizarVenta.Size = new Size(271, 42);
            btnRealizarVenta.TabIndex = 1;
            btnRealizarVenta.Text = "Realizar una venta";
            btnRealizarVenta.UseVisualStyleBackColor = true;
            btnRealizarVenta.Click += btnRealizarVenta_Click;
            // 
            // btnListaProductos
            // 
            btnListaProductos.Location = new Point(12, 290);
            btnListaProductos.Name = "btnListaProductos";
            btnListaProductos.Size = new Size(271, 42);
            btnListaProductos.TabIndex = 0;
            btnListaProductos.Text = "Listar Productos";
            btnListaProductos.UseVisualStyleBackColor = true;
            btnListaProductos.Click += btnListaProductos_Click;
            // 
            // panelMuestra
            // 
            panelMuestra.Dock = DockStyle.Fill;
            panelMuestra.Location = new Point(300, 0);
            panelMuestra.Name = "panelMuestra";
            panelMuestra.Size = new Size(884, 611);
            panelMuestra.TabIndex = 6;
            panelMuestra.Paint += panelMuestra_Paint;
            // 
            // MenuVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 611);
            Controls.Add(panelMuestra);
            Controls.Add(panelMenuVendedor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MenuVendedor";
            Text = "Clothing Store: Vendedor";
            panelMenuVendedor.ResumeLayout(false);
            panelMenuVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuVendedor;
        private Button btnRealizarVenta;
        private Button btnListaProductos;
        private Button btnVentasRealizadas;
        private Panel panelMuestra;
        private Button btnAltaCliente;
        private Button btnCerrarSseion;
        private PictureBox ptbLogo;
        private Label lblUsuario;
        private Label lblMenuVendedor;
    }
}



