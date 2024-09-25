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
            btnFiltro = new Button();
            lblListarProductos = new Label();
            test = new Button();
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
            col_editarProducto = new DataGridViewButtonColumn();
            col_eliminar = new DataGridViewButtonColumn();
            btnSalir = new Button();
            lblFiltrarMarca = new Label();
            comboBox2 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 251, 255);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(lblFiltrarMarca);
            panel1.Controls.Add(btnFiltro);
            panel1.Controls.Add(lblListarProductos);
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
            // btnFiltro
            // 
            btnFiltro.Location = new Point(793, 58);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(75, 23);
            btnFiltro.TabIndex = 10;
            btnFiltro.Text = "Aplicar";
            btnFiltro.UseVisualStyleBackColor = true;
            // 
            // lblListarProductos
            // 
            lblListarProductos.AutoSize = true;
            lblListarProductos.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblListarProductos.Location = new Point(12, 25);
            lblListarProductos.Name = "lblListarProductos";
            lblListarProductos.Size = new Size(131, 32);
            lblListarProductos.TabIndex = 9;
            lblListarProductos.Text = "Productos";
            // 
            // test
            // 
            test.Location = new Point(28, 60);
            test.Name = "test";
            test.Size = new Size(75, 23);
            test.TabIndex = 7;
            test.Text = "test editar";
            test.UseVisualStyleBackColor = true;
            test.Click += test_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(793, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tbxBuscarNombre
            // 
            tbxBuscarNombre.Location = new Point(640, 22);
            tbxBuscarNombre.Name = "tbxBuscarNombre";
            tbxBuscarNombre.Size = new Size(147, 23);
            tbxBuscarNombre.TabIndex = 3;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Franklin Gothic Medium", 12F);
            lblBuscar.Location = new Point(490, 24);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(144, 21);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "Buscar por nombre:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(640, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 23);
            comboBox1.TabIndex = 1;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Franklin Gothic Medium", 12F);
            lblFiltro.Location = new Point(490, 60);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(147, 21);
            lblFiltro.TabIndex = 0;
            lblFiltro.Text = "Filtrar por categoria:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 252, 247);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col_idproducto, col_nombreProducto, col_descripcionProducto, col_stock, col_precio, col_categoriaProducto, col_editarProducto, col_eliminar });
            dataGridView1.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView1.Location = new Point(12, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(856, 420);
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
            col_editarProducto.Resizable = DataGridViewTriState.True;
            col_editarProducto.SortMode = DataGridViewColumnSortMode.Automatic;
            col_editarProducto.Width = 62;
            // 
            // col_eliminar
            // 
            col_eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            col_eliminar.HeaderText = "Eliminar";
            col_eliminar.Name = "col_eliminar";
            col_eliminar.Resizable = DataGridViewTriState.True;
            col_eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            col_eliminar.Width = 75;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(756, 545);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 43);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblFiltrarMarca
            // 
            lblFiltrarMarca.AutoSize = true;
            lblFiltrarMarca.Font = new Font("Franklin Gothic Medium", 12F);
            lblFiltrarMarca.Location = new Point(204, 59);
            lblFiltrarMarca.Name = "lblFiltrarMarca";
            lblFiltrarMarca.Size = new Size(127, 21);
            lblFiltrarMarca.TabIndex = 11;
            lblFiltrarMarca.Text = "Filtrar por Marca:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(337, 58);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(147, 23);
            comboBox2.TabIndex = 12;
            // 
            // ListarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(880, 600);
            Controls.Add(btnSalir);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListarProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListarProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btnBuscar;
        private TextBox tbxBuscarNombre;
        private Label lblBuscar;
        private ComboBox comboBox1;
        private Label lblFiltro;
        private Button btnSalir;
        private Button test;
        private Label lblListarProductos;
        private Button btnFiltro;
        private DataGridViewTextBoxColumn col_idproducto;
        private DataGridViewTextBoxColumn col_nombreProducto;
        private DataGridViewTextBoxColumn col_descripcionProducto;
        private DataGridViewTextBoxColumn col_stock;
        private DataGridViewTextBoxColumn col_precio;
        private DataGridViewTextBoxColumn col_categoriaProducto;
        private DataGridViewButtonColumn col_editarProducto;
        private DataGridViewButtonColumn col_eliminar;
        private ComboBox comboBox2;
        private Label lblFiltrarMarca;
    }
}