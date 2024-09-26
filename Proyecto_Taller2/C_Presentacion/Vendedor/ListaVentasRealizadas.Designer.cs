namespace Proyecto_Taller2.C_Presentaciones.Vendedor
{
    partial class ListaVentasRealizadas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gbxProductos = new GroupBox();
            lblFiltrar = new Label();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            btnFiltrarVen = new Button();
            lblVentas = new Label();
            dataGridView1 = new DataGridView();
            col_fecha = new DataGridViewTextBoxColumn();
            col_nroVenta = new DataGridViewTextBoxColumn();
            col_cliente = new DataGridViewTextBoxColumn();
            col_cantProuctos = new DataGridViewTextBoxColumn();
            col_precioTotal = new DataGridViewTextBoxColumn();
            col_verDetalle = new DataGridViewButtonColumn();
            gbxProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbxProductos
            // 
            gbxProductos.BackColor = Color.FromArgb(247, 251, 255);
            gbxProductos.Controls.Add(lblVentas);
            gbxProductos.Controls.Add(lblFiltrar);
            gbxProductos.Controls.Add(dtpHasta);
            gbxProductos.Controls.Add(dtpDesde);
            gbxProductos.Controls.Add(btnFiltrarVen);
            gbxProductos.Dock = DockStyle.Top;
            gbxProductos.Location = new Point(0, 0);
            gbxProductos.Name = "gbxProductos";
            gbxProductos.Size = new Size(880, 100);
            gbxProductos.TabIndex = 3;
            gbxProductos.TabStop = false;
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.Location = new Point(480, 26);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(93, 15);
            lblFiltrar.TabIndex = 3;
            lblFiltrar.Text = "Filtrar por fecha:";
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(680, 22);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(95, 23);
            dtpHasta.TabIndex = 2;
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(579, 22);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(95, 23);
            dtpDesde.TabIndex = 1;
            // 
            // btnFiltrarVen
            // 
            btnFiltrarVen.Location = new Point(781, 22);
            btnFiltrarVen.Name = "btnFiltrarVen";
            btnFiltrarVen.Size = new Size(75, 23);
            btnFiltrarVen.TabIndex = 0;
            btnFiltrarVen.Text = "Filtrar";
            btnFiltrarVen.UseVisualStyleBackColor = true;
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblVentas.Location = new Point(12, 19);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(136, 32);
            lblVentas.TabIndex = 10;
            lblVentas.Text = "Mis ventas";
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.None;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 252, 247);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col_fecha, col_nroVenta, col_cliente, col_cantProuctos, col_precioTotal, col_verDetalle });
            dataGridView1.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView1.Location = new Point(12, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(856, 469);
            dataGridView1.TabIndex = 4;
            // 
            // col_fecha
            // 
            col_fecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_fecha.HeaderText = "Fecha";
            col_fecha.Name = "col_fecha";
            // 
            // col_nroVenta
            // 
            col_nroVenta.HeaderText = "Nro Venta";
            col_nroVenta.Name = "col_nroVenta";
            // 
            // col_cliente
            // 
            col_cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_cliente.HeaderText = "Cliente";
            col_cliente.Name = "col_cliente";
            // 
            // col_cantProuctos
            // 
            col_cantProuctos.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            col_cantProuctos.HeaderText = "Cantidad de productos";
            col_cantProuctos.Name = "col_cantProuctos";
            col_cantProuctos.Width = 140;
            // 
            // col_precioTotal
            // 
            col_precioTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            col_precioTotal.HeaderText = "Precio Total";
            col_precioTotal.Name = "col_precioTotal";
            col_precioTotal.Width = 86;
            // 
            // col_verDetalle
            // 
            col_verDetalle.HeaderText = "Ver detalle";
            col_verDetalle.Name = "col_verDetalle";
            // 
            // ListaVentasRealizadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(880, 600);
            Controls.Add(dataGridView1);
            Controls.Add(gbxProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListaVentasRealizadas";
            Text = "ListaVentasRealizadas";
            gbxProductos.ResumeLayout(false);
            gbxProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbxProductos;
        private Button btnFiltrarVen;
        private Label lblFiltrar;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Label lblVentas;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn col_fecha;
        private DataGridViewTextBoxColumn col_nroVenta;
        private DataGridViewTextBoxColumn col_cliente;
        private DataGridViewTextBoxColumn col_cantProuctos;
        private DataGridViewTextBoxColumn col_precioTotal;
        private DataGridViewButtonColumn col_verDetalle;
    }
}