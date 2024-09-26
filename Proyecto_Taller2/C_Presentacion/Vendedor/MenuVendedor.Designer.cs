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
            lblNombreVendedorM = new Label();
            pictureBox1 = new PictureBox();
            btnCerrarSseion = new Button();
            btnAltaCliente = new Button();
            btnVentasRealizadas = new Button();
            btnRealizarVenta = new Button();
            btnListaProductos = new Button();
            panelMuestra = new Panel();
            panelMenuVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenuVendedor
            // 
            panelMenuVendedor.Controls.Add(lblNombreVendedorM);
            panelMenuVendedor.Controls.Add(pictureBox1);
            panelMenuVendedor.Controls.Add(btnCerrarSseion);
            panelMenuVendedor.Controls.Add(btnAltaCliente);
            panelMenuVendedor.Controls.Add(btnVentasRealizadas);
            panelMenuVendedor.Controls.Add(btnRealizarVenta);
            panelMenuVendedor.Controls.Add(btnListaProductos);
            panelMenuVendedor.Location = new Point(1, 1);
            panelMenuVendedor.Name = "panelMenuVendedor";
            panelMenuVendedor.Size = new Size(214, 609);
            panelMenuVendedor.TabIndex = 4;
            // 
            // lblNombreVendedorM
            // 
            lblNombreVendedorM.AutoSize = true;
            lblNombreVendedorM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreVendedorM.Location = new Point(40, 170);
            lblNombreVendedorM.Name = "lblNombreVendedorM";
            lblNombreVendedorM.Size = new Size(139, 21);
            lblNombreVendedorM.TabIndex = 0;
            lblNombreVendedorM.Text = "Nombre Vendedor";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(50, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 112);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnCerrarSseion
            // 
            btnCerrarSseion.BackColor = Color.Salmon;
            btnCerrarSseion.FlatStyle = FlatStyle.Popup;
            btnCerrarSseion.Location = new Point(72, 566);
            btnCerrarSseion.Name = "btnCerrarSseion";
            btnCerrarSseion.Size = new Size(75, 23);
            btnCerrarSseion.TabIndex = 11;
            btnCerrarSseion.Text = "Cerrar Sesión";
            btnCerrarSseion.UseVisualStyleBackColor = false;
            btnCerrarSseion.Click += btnCerrarSseion_Click;
            // 
            // btnAltaCliente
            // 
            btnAltaCliente.Location = new Point(32, 466);
            btnAltaCliente.Name = "btnAltaCliente";
            btnAltaCliente.Size = new Size(155, 23);
            btnAltaCliente.TabIndex = 3;
            btnAltaCliente.Text = "Alta Cliente";
            btnAltaCliente.UseVisualStyleBackColor = true;
            btnAltaCliente.Click += btnAltaCliente_Click;
            // 
            // btnVentasRealizadas
            // 
            btnVentasRealizadas.Location = new Point(32, 402);
            btnVentasRealizadas.Name = "btnVentasRealizadas";
            btnVentasRealizadas.Size = new Size(155, 23);
            btnVentasRealizadas.TabIndex = 2;
            btnVentasRealizadas.Text = "Ver ventas realizadas";
            btnVentasRealizadas.UseVisualStyleBackColor = true;
            btnVentasRealizadas.Click += btnVentasRealizadas_Click;
            // 
            // btnRealizarVenta
            // 
            btnRealizarVenta.Location = new Point(32, 336);
            btnRealizarVenta.Name = "btnRealizarVenta";
            btnRealizarVenta.Size = new Size(155, 23);
            btnRealizarVenta.TabIndex = 1;
            btnRealizarVenta.Text = "Realizar una venta";
            btnRealizarVenta.UseVisualStyleBackColor = true;
            btnRealizarVenta.Click += btnRealizarVenta_Click;
            // 
            // btnListaProductos
            // 
            btnListaProductos.Location = new Point(32, 264);
            btnListaProductos.Name = "btnListaProductos";
            btnListaProductos.Size = new Size(155, 23);
            btnListaProductos.TabIndex = 0;
            btnListaProductos.Text = "Listar Productos";
            btnListaProductos.UseVisualStyleBackColor = true;
            btnListaProductos.Click += btnListaProductos_Click;
            // 
            // panelMuestra
            // 
            panelMuestra.Location = new Point(213, 1);
            panelMuestra.Name = "panelMuestra";
            panelMuestra.Size = new Size(971, 609);
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
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MenuVendedor";
            Text = "MenuVendedor";
            panelMenuVendedor.ResumeLayout(false);
            panelMenuVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label lblNombreVendedorM;
        private PictureBox pictureBox1;
    }
}



