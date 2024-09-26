namespace Proyecto_Taller2.C_Presentacion.Administrador
{
    partial class GestionProveedores
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
            btnSalir = new Button();
            dataGridView1 = new DataGridView();
            col_fecha = new DataGridViewTextBoxColumn();
            col_nombre = new DataGridViewTextBoxColumn();
            col_direccion = new DataGridViewTextBoxColumn();
            col_telefono = new DataGridViewTextBoxColumn();
            col_email = new DataGridViewTextBoxColumn();
            col_modificar = new DataGridViewButtonColumn();
            panel1 = new Panel();
            btnNuevoProveedor = new Button();
            lblProveedores = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            lbl = new Label();
            btnBuscar = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            lblFiltro = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(756, 564);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 35);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.None;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 252, 247);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col_fecha, col_nombre, col_direccion, col_telefono, col_email, col_modificar });
            dataGridView1.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView1.Location = new Point(12, 110);
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
            dataGridView1.Size = new Size(856, 448);
            dataGridView1.TabIndex = 14;
            // 
            // col_fecha
            // 
            col_fecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_fecha.HeaderText = "Fecha de Alta";
            col_fecha.Name = "col_fecha";
            // 
            // col_nombre
            // 
            col_nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_nombre.HeaderText = "Nombre";
            col_nombre.Name = "col_nombre";
            // 
            // col_direccion
            // 
            col_direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_direccion.HeaderText = "Direccion";
            col_direccion.Name = "col_direccion";
            // 
            // col_telefono
            // 
            col_telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            col_telefono.HeaderText = "Telefono";
            col_telefono.Name = "col_telefono";
            col_telefono.Width = 77;
            // 
            // col_email
            // 
            col_email.HeaderText = "Email";
            col_email.Name = "col_email";
            // 
            // col_modificar
            // 
            col_modificar.HeaderText = "Modificar";
            col_modificar.Name = "col_modificar";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 251, 255);
            panel1.Controls.Add(btnNuevoProveedor);
            panel1.Controls.Add(lblProveedores);
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
            panel1.TabIndex = 13;
            // 
            // btnNuevoProveedor
            // 
            btnNuevoProveedor.Location = new Point(12, 60);
            btnNuevoProveedor.Name = "btnNuevoProveedor";
            btnNuevoProveedor.Size = new Size(128, 27);
            btnNuevoProveedor.TabIndex = 8;
            btnNuevoProveedor.Text = "Nuevo Proveedor";
            btnNuevoProveedor.UseVisualStyleBackColor = true;
            btnNuevoProveedor.Click += btnNuevoProveedor_Click;
            // 
            // lblProveedores
            // 
            lblProveedores.AutoSize = true;
            lblProveedores.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblProveedores.Location = new Point(12, 17);
            lblProveedores.Name = "lblProveedores";
            lblProveedores.Size = new Size(157, 32);
            lblProveedores.TabIndex = 7;
            lblProveedores.Text = "Proveedores";
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
            lbl.Size = new Size(115, 21);
            lbl.TabIndex = 4;
            lbl.Text = "Buscar por DNI:";
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
            // GestionProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(880, 600);
            Controls.Add(btnSalir);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionProveedores";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label lblProveedores;
        private Button button1;
        private TextBox textBox1;
        private Label lbl;
        private Button btnBuscar;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label lblFiltro;
        private Button btnNuevoProveedor;
        private DataGridViewTextBoxColumn col_fecha;
        private DataGridViewTextBoxColumn col_nombre;
        private DataGridViewTextBoxColumn col_direccion;
        private DataGridViewTextBoxColumn col_telefono;
        private DataGridViewTextBoxColumn col_email;
        private DataGridViewButtonColumn col_modificar;
    }
}