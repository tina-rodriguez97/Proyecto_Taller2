namespace Proyecto_Taller2.C_Presentacion.Supervisor
{
    partial class ListarVentas
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button2 = new Button();
            lblListarVentas = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            lbl = new Label();
            btnBuscar = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            lblFiltro = new Label();
            dataGridView1 = new DataGridView();
            col_fecha = new DataGridViewTextBoxColumn();
            col_nroVenta = new DataGridViewTextBoxColumn();
            col_vendedor = new DataGridViewTextBoxColumn();
            col_cliente = new DataGridViewTextBoxColumn();
            col_cantProuctos = new DataGridViewTextBoxColumn();
            col_precioTotal = new DataGridViewTextBoxColumn();
            col_verDetalle = new DataGridViewButtonColumn();
            btnSalir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 251, 255);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(lblListarVentas);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lbl);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(lblFiltro);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 100);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(295, 56);
            button2.Name = "button2";
            button2.Size = new Size(75, 25);
            button2.TabIndex = 8;
            button2.Text = "testDetalle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblListarVentas
            // 
            lblListarVentas.AutoSize = true;
            lblListarVentas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblListarVentas.Location = new Point(12, 27);
            lblListarVentas.Name = "lblListarVentas";
            lblListarVentas.Size = new Size(89, 32);
            lblListarVentas.TabIndex = 7;
            lblListarVentas.Text = "Ventas";
            // 
            // button1
            // 
            button1.Location = new Point(793, 60);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 6;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(630, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 23);
            textBox1.TabIndex = 5;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Franklin Gothic Medium", 12F);
            lbl.Location = new Point(474, 27);
            lbl.Name = "lbl";
            lbl.Size = new Size(150, 21);
            lbl.TabIndex = 4;
            lbl.Text = "Buscar nro de venta:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(793, 27);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 25);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(687, 58);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 23);
            comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(560, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Franklin Gothic Medium", 12F);
            lblFiltro.Location = new Point(474, 57);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(80, 21);
            lblFiltro.TabIndex = 0;
            lblFiltro.Text = "Filtrar por:";
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.None;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 252, 247);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col_fecha, col_nroVenta, col_vendedor, col_cliente, col_cantProuctos, col_precioTotal, col_verDetalle });
            dataGridView1.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView1.Location = new Point(12, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(856, 432);
            dataGridView1.TabIndex = 1;
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
            // col_vendedor
            // 
            col_vendedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_vendedor.HeaderText = "Vendedor";
            col_vendedor.Name = "col_vendedor";
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
            // btnSalir
            // 
            btnSalir.Location = new Point(756, 553);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 35);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // ListarVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(880, 600);
            Controls.Add(btnSalir);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "ListarVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListarVentas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label lblFiltro;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox1;
        private Label lbl;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn col_fecha;
        private DataGridViewTextBoxColumn col_nroVenta;
        private DataGridViewTextBoxColumn col_vendedor;
        private DataGridViewTextBoxColumn col_cliente;
        private DataGridViewTextBoxColumn col_cantProuctos;
        private DataGridViewTextBoxColumn col_precioTotal;
        private DataGridViewButtonColumn col_verDetalle;
        private Label lblListarVentas;
        private Button btnSalir;
        private Button button2;
    }
}