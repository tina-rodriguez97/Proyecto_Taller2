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
            gridListaProductos = new DataGridView();
            gbxProductos = new GroupBox();
            btnFiltrarVen = new Button();
            nombreproducto = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewImageColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Total = new DataGridViewButtonColumn();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            lblFiltrar = new Label();
            ((System.ComponentModel.ISupportInitialize)gridListaProductos).BeginInit();
            gbxProductos.SuspendLayout();
            SuspendLayout();
            // 
            // gridListaProductos
            // 
            gridListaProductos.AllowUserToAddRows = false;
            gridListaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridListaProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridListaProductos.Columns.AddRange(new DataGridViewColumn[] { nombreproducto, PrecioUnitario, Imagen, Cantidad, Total });
            gridListaProductos.Location = new Point(1, 74);
            gridListaProductos.Name = "gridListaProductos";
            gridListaProductos.Size = new Size(798, 375);
            gridListaProductos.TabIndex = 2;
            // 
            // gbxProductos
            // 
            gbxProductos.Controls.Add(lblFiltrar);
            gbxProductos.Controls.Add(dtpHasta);
            gbxProductos.Controls.Add(dtpDesde);
            gbxProductos.Controls.Add(btnFiltrarVen);
            gbxProductos.Location = new Point(1, 0);
            gbxProductos.Name = "gbxProductos";
            gbxProductos.Size = new Size(798, 74);
            gbxProductos.TabIndex = 3;
            gbxProductos.TabStop = false;
            // 
            // btnFiltrarVen
            // 
            btnFiltrarVen.Location = new Point(693, 22);
            btnFiltrarVen.Name = "btnFiltrarVen";
            btnFiltrarVen.Size = new Size(75, 23);
            btnFiltrarVen.TabIndex = 0;
            btnFiltrarVen.Text = "Filtrar";
            btnFiltrarVen.UseVisualStyleBackColor = true;
            // 
            // nombreproducto
            // 
            nombreproducto.HeaderText = "Nombre Producto";
            nombreproducto.Name = "nombreproducto";
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "Precio Unitario";
            PrecioUnitario.Name = "PrecioUnitario";
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
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(491, 22);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(95, 23);
            dtpDesde.TabIndex = 1;
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(592, 22);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(95, 23);
            dtpHasta.TabIndex = 2;
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.Location = new Point(392, 26);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(93, 15);
            lblFiltrar.TabIndex = 3;
            lblFiltrar.Text = "Filtrar por fecha:";
            // 
            // ListaVentasRealizadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbxProductos);
            Controls.Add(gridListaProductos);
            Name = "ListaVentasRealizadas";
            Text = "ListaVentasRealizadas";
            ((System.ComponentModel.ISupportInitialize)gridListaProductos).EndInit();
            gbxProductos.ResumeLayout(false);
            gbxProductos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridListaProductos;
        private DataGridViewTextBoxColumn nombreproducto;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewImageColumn Imagen;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewButtonColumn Total;
        private GroupBox gbxProductos;
        private Button btnFiltrarVen;
        private Label lblFiltrar;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
    }
}