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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            Eliminar = new DataGridViewButtonColumn();
            btnCobrar = new Button();
            btnCancelarVenta = new Button();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            stock = new DataGridViewCheckBoxColumn();
            lblSelecPro = new Label();
            lblDetalleVenta = new Label();
            cbxBuscarProVenta = new ComboBox();
            btnBuscarProVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)gridVentaProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            cbxConsumidor.Location = new Point(630, 81);
            cbxConsumidor.Name = "cbxConsumidor";
            cbxConsumidor.Size = new Size(219, 28);
            cbxConsumidor.TabIndex = 1;
            // 
            // lblConsumidor
            // 
            lblConsumidor.AutoSize = true;
            lblConsumidor.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConsumidor.Location = new Point(465, 85);
            lblConsumidor.Name = "lblConsumidor";
            lblConsumidor.Size = new Size(159, 19);
            lblConsumidor.TabIndex = 3;
            lblConsumidor.Text = "Tipo de consumidor:";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVendedor.Location = new Point(652, 18);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(143, 19);
            lblVendedor.TabIndex = 4;
            lblVendedor.Text = "Nombre Vendedor";
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
            gridVentaProducto.Columns.AddRange(new DataGridViewColumn[] { NombreProducto, Precio, Imagen, Cantidad, Subtotal, Eliminar });
            gridVentaProducto.Location = new Point(25, 382);
            gridVentaProducto.Name = "gridVentaProducto";
            gridVentaProducto.Size = new Size(824, 150);
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
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            // 
            // btnCobrar
            // 
            btnCobrar.BackColor = Color.SpringGreen;
            btnCobrar.FlatStyle = FlatStyle.Popup;
            btnCobrar.Location = new Point(373, 550);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(75, 23);
            btnCobrar.TabIndex = 9;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.BackColor = Color.Salmon;
            btnCancelarVenta.FlatStyle = FlatStyle.Popup;
            btnCancelarVenta.Location = new Point(465, 550);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(75, 23);
            btnCancelarVenta.TabIndex = 10;
            btnCancelarVenta.Text = "Cancelar";
            btnCancelarVenta.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Lavender;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewImageColumn1, stock });
            dataGridView1.Location = new Point(25, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(824, 150);
            dataGridView1.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre Producto";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Precio";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.HeaderText = "Imagen";
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            // 
            // lblSelecPro
            // 
            lblSelecPro.AutoSize = true;
            lblSelecPro.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelecPro.Location = new Point(25, 136);
            lblSelecPro.Name = "lblSelecPro";
            lblSelecPro.Size = new Size(171, 19);
            lblSelecPro.TabIndex = 12;
            lblSelecPro.Text = "Seleccionar producto:";
            // 
            // lblDetalleVenta
            // 
            lblDetalleVenta.AutoSize = true;
            lblDetalleVenta.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetalleVenta.Location = new Point(25, 350);
            lblDetalleVenta.Name = "lblDetalleVenta";
            lblDetalleVenta.Size = new Size(138, 19);
            lblDetalleVenta.TabIndex = 13;
            lblDetalleVenta.Text = "Detalle de venta:";
            // 
            // cbxBuscarProVenta
            // 
            cbxBuscarProVenta.FlatStyle = FlatStyle.Flat;
            cbxBuscarProVenta.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxBuscarProVenta.FormattingEnabled = true;
            cbxBuscarProVenta.Location = new Point(546, 136);
            cbxBuscarProVenta.Name = "cbxBuscarProVenta";
            cbxBuscarProVenta.Size = new Size(303, 28);
            cbxBuscarProVenta.TabIndex = 14;
            // 
            // btnBuscarProVenta
            // 
            btnBuscarProVenta.BackColor = Color.AliceBlue;
            btnBuscarProVenta.FlatStyle = FlatStyle.Popup;
            btnBuscarProVenta.Location = new Point(465, 139);
            btnBuscarProVenta.Name = "btnBuscarProVenta";
            btnBuscarProVenta.Size = new Size(75, 23);
            btnBuscarProVenta.TabIndex = 15;
            btnBuscarProVenta.Text = "Buscar";
            btnBuscarProVenta.UseVisualStyleBackColor = false;
            // 
            // RealizarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(880, 600);
            Controls.Add(btnBuscarProVenta);
            Controls.Add(cbxBuscarProVenta);
            Controls.Add(lblDetalleVenta);
            Controls.Add(lblSelecPro);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancelarVenta);
            Controls.Add(btnCobrar);
            Controls.Add(gridVentaProducto);
            Controls.Add(lblFechaVenta);
            Controls.Add(dtpFecha);
            Controls.Add(lblVendedor);
            Controls.Add(lblConsumidor);
            Controls.Add(cbxConsumidor);
            Controls.Add(lblNuevaVenta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RealizarVenta";
            Text = "Realizar una Vneta";
            ((System.ComponentModel.ISupportInitialize)gridVentaProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button btnCancelarVenta;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewCheckBoxColumn stock;
        private Label lblSelecPro;
        private Label lblDetalleVenta;
        private ComboBox cbxBuscarProVenta;
        private Button btnBuscarProVenta;
    }
}
