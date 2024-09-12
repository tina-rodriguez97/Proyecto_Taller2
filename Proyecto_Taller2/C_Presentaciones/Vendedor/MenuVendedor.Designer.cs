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
            btnVentasRealizadas = new Button();
            btnRealizarVenta = new Button();
            btnListaProductos = new Button();
            panelMuestra = new Panel();
            panel1 = new Panel();
            gridVentasRealizadas = new DataGridView();
            NombreProducto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewImageColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            FechaVenta = new DataGridViewTextBoxColumn();
            panelMenuVendedor.SuspendLayout();
            panelMuestra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridVentasRealizadas).BeginInit();
            SuspendLayout();
            // 
            // panelMenuVendedor
            // 
            panelMenuVendedor.Controls.Add(btnVentasRealizadas);
            panelMenuVendedor.Controls.Add(btnRealizarVenta);
            panelMenuVendedor.Controls.Add(btnListaProductos);
            panelMenuVendedor.Location = new Point(1, 1);
            panelMenuVendedor.Name = "panelMenuVendedor";
            panelMenuVendedor.Size = new Size(214, 558);
            panelMenuVendedor.TabIndex = 4;
            // 
            // btnVentasRealizadas
            // 
            btnVentasRealizadas.Location = new Point(23, 221);
            btnVentasRealizadas.Name = "btnVentasRealizadas";
            btnVentasRealizadas.Size = new Size(155, 23);
            btnVentasRealizadas.TabIndex = 2;
            btnVentasRealizadas.Text = "Ver ventas realizadas";
            btnVentasRealizadas.UseVisualStyleBackColor = true;
            // 
            // btnRealizarVenta
            // 
            btnRealizarVenta.Location = new Point(23, 173);
            btnRealizarVenta.Name = "btnRealizarVenta";
            btnRealizarVenta.Size = new Size(155, 23);
            btnRealizarVenta.TabIndex = 1;
            btnRealizarVenta.Text = "Realizar una venta";
            btnRealizarVenta.UseVisualStyleBackColor = true;
            // 
            // btnListaProductos
            // 
            btnListaProductos.Location = new Point(23, 121);
            btnListaProductos.Name = "btnListaProductos";
            btnListaProductos.Size = new Size(155, 23);
            btnListaProductos.TabIndex = 0;
            btnListaProductos.Text = "Listar Productos";
            btnListaProductos.UseVisualStyleBackColor = true;
            btnListaProductos.Click += btnListaProductos_Click;
            // 
            // panelMuestra
            // 
            panelMuestra.Controls.Add(gridVentasRealizadas);
            panelMuestra.Location = new Point(213, 85);
            panelMuestra.Name = "panelMuestra";
            panelMuestra.Size = new Size(768, 474);
            panelMuestra.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Location = new Point(213, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 88);
            panel1.TabIndex = 8;
            // 
            // gridVentasRealizadas
            // 
            gridVentasRealizadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVentasRealizadas.Columns.AddRange(new DataGridViewColumn[] { NombreProducto, Precio, Imagen, Cantidad, Total, FechaVenta });
            gridVentasRealizadas.Location = new Point(0, 3);
            gridVentasRealizadas.Name = "gridVentasRealizadas";
            gridVentasRealizadas.Size = new Size(765, 468);
            gridVentasRealizadas.TabIndex = 0;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre Producto";
            NombreProducto.Name = "NombreProducto";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Imagen
            // 
            Imagen.HeaderText = "Imagen";
            Imagen.Name = "Imagen";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Resizable = DataGridViewTriState.True;
            Cantidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.Resizable = DataGridViewTriState.True;
            Total.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // FechaVenta
            // 
            FechaVenta.HeaderText = "Fecha de Venta";
            FechaVenta.Name = "FechaVenta";
            FechaVenta.Resizable = DataGridViewTriState.True;
            FechaVenta.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // MenuVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Controls.Add(panelMuestra);
            Controls.Add(panelMenuVendedor);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MenuVendedor";
            Text = "MenuVendedor";
            panelMenuVendedor.ResumeLayout(false);
            panelMuestra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridVentasRealizadas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuVendedor;
        private Button btnRealizarVenta;
        private Button btnListaProductos;
        private Button btnVentasRealizadas;
        private Panel panelMuestra;
        private Panel panel1;
        private DataGridView gridVentasRealizadas;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewImageColumn Imagen;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn FechaVenta;
    }
}



