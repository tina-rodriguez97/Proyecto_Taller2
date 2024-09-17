namespace Proyecto_Taller2
{
    partial class RealizarVenta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblNuevaVenta = new Label();
            cbxConsumidor = new ComboBox();
            lblConsumidor = new Label();
            lblVendedor = new Label();
            dtpFecha = new DateTimePicker();
            lblFechaVenta = new Label();
            gridVentaProducto = new DataGridView();
            NombreProducto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewImageColumn();
            Cantidad = new DataGridViewCheckBoxColumn();
            Subtotal = new DataGridViewCheckBoxColumn();
            btnCobrar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridVentaProducto).BeginInit();
            SuspendLayout();
            // 
            // lblNuevaVenta
            // 
            lblNuevaVenta.AutoSize = true;
            lblNuevaVenta.Font = new Font("Bookman Old Style", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNuevaVenta.Location = new Point(33, 18);
            lblNuevaVenta.Name = "lblNuevaVenta";
            lblNuevaVenta.Size = new Size(141, 24);
            lblNuevaVenta.TabIndex = 0;
            lblNuevaVenta.Text = "Nueva Venta";
            // 
            // cbxConsumidor
            // 
            cbxConsumidor.FlatStyle = FlatStyle.Flat;
            cbxConsumidor.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxConsumidor.FormattingEnabled = true;
            cbxConsumidor.Location = new Point(531, 73);
            cbxConsumidor.Name = "cbxConsumidor";
            cbxConsumidor.Size = new Size(219, 28);
            cbxConsumidor.TabIndex = 1;
            // 
            // cbxProducto
            // 
            cbxProducto.FlatStyle = FlatStyle.Flat;
            cbxProducto.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxProducto.FormattingEnabled = true;
            cbxProducto.Location = new Point(28, 158);
            cbxProducto.Name = "cbxProducto";
            cbxProducto.Size = new Size(722, 28);
            cbxProducto.TabIndex = 2;
            cbxProducto.SelectedIndexChanged += cbxProducto_SelectedIndexChanged;
            // 
            // lblConsumidor
            // 
            lblConsumidor.AutoSize = true;
            lblConsumidor.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConsumidor.Location = new Point(366, 77);
            lblConsumidor.Name = "lblConsumidor";
            lblConsumidor.Size = new Size(159, 19);
            lblConsumidor.TabIndex = 3;
            lblConsumidor.Text = "Tipo de consumidor:";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVendedor.Location = new Point(607, 18);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(143, 19);
            lblVendedor.TabIndex = 4;
            lblVendedor.Text = "Nombre Vendedor";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(28, 122);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(178, 19);
            lblProducto.TabIndex = 5;
            lblProducto.Text = "Seleccione el producto";
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarFont = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(186, 77);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(96, 23);
            dtpFecha.TabIndex = 6;
            // 
            // lblFechaVenta
            // 
            lblFechaVenta.AutoSize = true;
            lblFechaVenta.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaVenta.Location = new Point(33, 81);
            lblFechaVenta.Name = "lblFechaVenta";
            lblFechaVenta.Size = new Size(129, 19);
            lblFechaVenta.TabIndex = 7;
            lblFechaVenta.Text = "Fecha de venta:";
            // 
            // gridVentaProducto
            // 
            gridVentaProducto.AllowUserToAddRows = false;
            gridVentaProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridVentaProducto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridVentaProducto.BackgroundColor = Color.Lavender;
            gridVentaProducto.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridVentaProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridVentaProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVentaProducto.Columns.AddRange(new DataGridViewColumn[] { NombreProducto, Precio, Imagen, Cantidad, Subtotal });
            gridVentaProducto.Location = new Point(28, 213);
            gridVentaProducto.Name = "gridVentaProducto";
            gridVentaProducto.Size = new Size(722, 150);
            gridVentaProducto.TabIndex = 8;
            gridVentaProducto.CellContentClick += gridVentaProducto_CellContentClick;
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
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            // 
            // btnCobrar
            // 
            btnCobrar.BackColor = Color.SpringGreen;
            btnCobrar.FlatStyle = FlatStyle.Popup;
            btnCobrar.Location = new Point(272, 413);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(75, 23);
            btnCobrar.TabIndex = 9;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Salmon;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(405, 413);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // RealizarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(772, 448);
            Controls.Add(btnCancelar);
            Controls.Add(btnCobrar);
            Controls.Add(gridVentaProducto);
            Controls.Add(lblFechaVenta);
            Controls.Add(dtpFecha);
            Controls.Add(lblProducto);
            Controls.Add(lblVendedor);
            Controls.Add(lblConsumidor);
            Controls.Add(cbxProducto);
            Controls.Add(cbxConsumidor);
            Controls.Add(lblNuevaVenta);
            Name = "RealizarVenta";
            Text = "Realizar una Vneta";
            ((System.ComponentModel.ISupportInitialize)gridVentaProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNuevaVenta;
        private ComboBox cbxConsumidor;
        private Label lblConsumidor;
        private Label lblVendedor;
        private DateTimePicker dtpFecha;
        private Label lblFechaVenta;
        private DataGridView gridVentaProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewImageColumn Imagen;
        private DataGridViewCheckBoxColumn Cantidad;
        private DataGridViewCheckBoxColumn Subtotal;
        private Button btnCobrar;
        private Button btnCancelar;
    }
}
