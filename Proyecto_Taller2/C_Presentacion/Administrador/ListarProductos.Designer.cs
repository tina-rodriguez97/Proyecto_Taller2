namespace Proyecto_Taller2.C_Presentacion.Administrador
{
    partial class ListarProductos
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
            btnBuscar = new Button();
            tbxBuscarNombre = new TextBox();
            lblBuscar = new Label();
            comboBox1 = new ComboBox();
            lblFiltro = new Label();
            dataGridView1 = new DataGridView();
            col_idproducto = new DataGridViewTextBoxColumn();
            col_nombreProducto = new DataGridViewTextBoxColumn();
            col_descripcionProducto = new DataGridViewTextBoxColumn();
            col_stock = new DataGridViewTextBoxColumn();
            col_precio = new DataGridViewTextBoxColumn();
            col_categoriaProducto = new DataGridViewTextBoxColumn();
            col_editarProducto = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
            test = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(test);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(tbxBuscarNombre);
            panel1.Controls.Add(lblBuscar);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(lblFiltro);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 94);
            panel1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(714, 26);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tbxBuscarNombre
            // 
            tbxBuscarNombre.Location = new Point(561, 25);
            tbxBuscarNombre.Name = "tbxBuscarNombre";
            tbxBuscarNombre.Size = new Size(147, 23);
            tbxBuscarNombre.TabIndex = 3;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 14F);
            lblBuscar.Location = new Point(378, 22);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(177, 25);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "Buscar por nombre:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(225, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 23);
            comboBox1.TabIndex = 1;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Segoe UI", 14F);
            lblFiltro.Location = new Point(36, 22);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(183, 25);
            lblFiltro.TabIndex = 0;
            lblFiltro.Text = "Filtrar por categoria:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 252, 247);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col_idproducto, col_nombreProducto, col_descripcionProducto, col_stock, col_precio, col_categoriaProducto, col_editarProducto });
            dataGridView1.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView1.Location = new Point(12, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(840, 420);
            dataGridView1.TabIndex = 1;
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
            // col_stock
            // 
            col_stock.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            col_stock.HeaderText = "Stock";
            col_stock.Name = "col_stock";
            col_stock.Width = 61;
            // 
            // col_precio
            // 
            col_precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            col_precio.HeaderText = "Precio";
            col_precio.Name = "col_precio";
            col_precio.Width = 65;
            // 
            // col_categoriaProducto
            // 
            col_categoriaProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            col_categoriaProducto.HeaderText = "Categoria";
            col_categoriaProducto.Name = "col_categoriaProducto";
            col_categoriaProducto.Width = 83;
            // 
            // col_editarProducto
            // 
            col_editarProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            col_editarProducto.HeaderText = "Editar";
            col_editarProducto.Name = "col_editarProducto";
            col_editarProducto.Width = 62;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(740, 545);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 43);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // test
            // 
            test.Location = new Point(714, 55);
            test.Name = "test";
            test.Size = new Size(75, 23);
            test.TabIndex = 7;
            test.Text = "test editar";
            test.UseVisualStyleBackColor = true;
            test.Click += test_Click;
            // 
            // ListarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 600);
            Controls.Add(btnSalir);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListarProductos";
            StartPosition = FormStartPosition.Manual;
            Text = "ListarProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn col_idproducto;
        private DataGridViewTextBoxColumn col_nombreProducto;
        private DataGridViewTextBoxColumn col_descripcionProducto;
        private DataGridViewTextBoxColumn col_stock;
        private DataGridViewTextBoxColumn col_precio;
        private DataGridViewTextBoxColumn col_categoriaProducto;
        private DataGridViewTextBoxColumn col_editarProducto;
        private Button btnBuscar;
        private TextBox tbxBuscarNombre;
        private Label lblBuscar;
        private ComboBox comboBox1;
        private Label lblFiltro;
        private Button btnSalir;
        private Button test;
    }
}