namespace Proyecto_Taller2.C_Presentacion.Supervisor
{
    partial class DetalleVenta
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
            lblFechaVenta = new Label();
            lblCliente = new Label();
            lblVendedor = new Label();
            lblDetalleVenta = new Label();
            dataGridView1 = new DataGridView();
            col_idproducto = new DataGridViewTextBoxColumn();
            col_nombreProducto = new DataGridViewTextBoxColumn();
            col_descripcionProducto = new DataGridViewTextBoxColumn();
            col_cantidad = new DataGridViewTextBoxColumn();
            col_precio = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            lblTotal = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 251, 255);
            panel1.Controls.Add(lblFechaVenta);
            panel1.Controls.Add(lblCliente);
            panel1.Controls.Add(lblVendedor);
            panel1.Controls.Add(lblDetalleVenta);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 150);
            panel1.TabIndex = 0;
            // 
            // lblFechaVenta
            // 
            lblFechaVenta.AutoSize = true;
            lblFechaVenta.Font = new Font("Franklin Gothic Medium", 12F);
            lblFechaVenta.Location = new Point(24, 57);
            lblFechaVenta.Name = "lblFechaVenta";
            lblFechaVenta.Size = new Size(55, 21);
            lblFechaVenta.TabIndex = 13;
            lblFechaVenta.Text = "Fecha:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Franklin Gothic Medium", 12F);
            lblCliente.Location = new Point(290, 97);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(61, 21);
            lblCliente.TabIndex = 12;
            lblCliente.Text = "Cliente:";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Franklin Gothic Medium", 12F);
            lblVendedor.Location = new Point(24, 97);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(79, 21);
            lblVendedor.TabIndex = 11;
            lblVendedor.Text = "Vendedor:";
            // 
            // lblDetalleVenta
            // 
            lblDetalleVenta.AutoSize = true;
            lblDetalleVenta.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblDetalleVenta.Location = new Point(12, 12);
            lblDetalleVenta.Name = "lblDetalleVenta";
            lblDetalleVenta.Size = new Size(339, 32);
            lblDetalleVenta.TabIndex = 10;
            lblDetalleVenta.Text = "Detalle de la venta Nro: (nn)";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 252, 247);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col_idproducto, col_nombreProducto, col_descripcionProducto, col_cantidad, col_precio });
            dataGridView1.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView1.Location = new Point(12, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(684, 314);
            dataGridView1.TabIndex = 2;
            // 
            // col_idproducto
            // 
            col_idproducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            col_idproducto.HeaderText = "ID";
            col_idproducto.Name = "col_idproducto";
            col_idproducto.Resizable = DataGridViewTriState.False;
            col_idproducto.Width = 43;
            // 
            // col_nombreProducto
            // 
            col_nombreProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_nombreProducto.HeaderText = "Nombre";
            col_nombreProducto.Name = "col_nombreProducto";
            // 
            // col_descripcionProducto
            // 
            col_descripcionProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_descripcionProducto.HeaderText = "Descripcion";
            col_descripcionProducto.Name = "col_descripcionProducto";
            // 
            // col_cantidad
            // 
            col_cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            col_cantidad.HeaderText = "Cantidad";
            col_cantidad.Name = "col_cantidad";
            col_cantidad.Width = 80;
            // 
            // col_precio
            // 
            col_precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            col_precio.HeaderText = "Precio";
            col_precio.Name = "col_precio";
            col_precio.Width = 65;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 251, 255);
            panel2.Controls.Add(lblTotal);
            panel2.Location = new Point(12, 488);
            panel2.Name = "panel2";
            panel2.Size = new Size(684, 70);
            panel2.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotal.Location = new Point(494, 16);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(174, 32);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "Total: (precio)";
            // 
            // DetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(708, 560);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DetalleVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalleVenta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDetalleVenta;
        private Label lblCliente;
        private Label lblVendedor;
        private Label lblFechaVenta;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn col_idproducto;
        private DataGridViewTextBoxColumn col_nombreProducto;
        private DataGridViewTextBoxColumn col_descripcionProducto;
        private DataGridViewTextBoxColumn col_cantidad;
        private DataGridViewTextBoxColumn col_precio;
        private Panel panel2;
        private Label lblTotal;
    }
}