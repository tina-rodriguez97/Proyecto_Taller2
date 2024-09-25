namespace Proyecto_Taller2.C_Presentacion.Supervisor
{
    partial class ListarUsuarios
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
            panel1 = new Panel();
            lblListarUsuarios = new Label();
            btnFiltro = new Button();
            test = new Button();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            lblBuscar = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            lblFiltro = new Label();
            dataGridView1 = new DataGridView();
            col_apellido = new DataGridViewTextBoxColumn();
            col_nombre = new DataGridViewTextBoxColumn();
            col_dni = new DataGridViewTextBoxColumn();
            col_usuario = new DataGridViewTextBoxColumn();
            col_rol = new DataGridViewTextBoxColumn();
            col_activo = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            col_eliminar = new DataGridViewButtonColumn();
            btnSalir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 251, 255);
            panel1.Controls.Add(lblListarUsuarios);
            panel1.Controls.Add(btnFiltro);
            panel1.Controls.Add(test);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lblBuscar);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(lblFiltro);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 100);
            panel1.TabIndex = 2;
            // 
            // lblListarUsuarios
            // 
            lblListarUsuarios.AutoSize = true;
            lblListarUsuarios.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblListarUsuarios.Location = new Point(12, 18);
            lblListarUsuarios.Name = "lblListarUsuarios";
            lblListarUsuarios.Size = new Size(113, 32);
            lblListarUsuarios.TabIndex = 8;
            lblListarUsuarios.Text = "Usuarios";
            // 
            // btnFiltro
            // 
            btnFiltro.Location = new Point(777, 18);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(75, 23);
            btnFiltro.TabIndex = 7;
            btnFiltro.Text = "Aplicar";
            btnFiltro.UseVisualStyleBackColor = true;
            // 
            // test
            // 
            test.Location = new Point(294, 53);
            test.Name = "test";
            test.Size = new Size(75, 23);
            test.TabIndex = 6;
            test.Text = "test editar";
            test.UseVisualStyleBackColor = true;
            test.Click += test_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(777, 55);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(642, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 23);
            textBox1.TabIndex = 4;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Franklin Gothic Medium", 12F);
            lblBuscar.Location = new Point(442, 53);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(87, 21);
            lblBuscar.TabIndex = 3;
            lblBuscar.Text = "Buscar por:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(535, 55);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(101, 23);
            comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(535, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 23);
            comboBox1.TabIndex = 1;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFiltro.Location = new Point(442, 20);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col_apellido, col_nombre, col_dni, col_usuario, col_rol, col_activo, Editar, col_eliminar });
            dataGridView1.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView1.Location = new Point(12, 114);
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
            dataGridView1.Size = new Size(856, 441);
            dataGridView1.TabIndex = 3;
            // 
            // col_apellido
            // 
            col_apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_apellido.HeaderText = "Apellido";
            col_apellido.Name = "col_apellido";
            // 
            // col_nombre
            // 
            col_nombre.HeaderText = "Nombre";
            col_nombre.Name = "col_nombre";
            // 
            // col_dni
            // 
            col_dni.HeaderText = "DNI";
            col_dni.Name = "col_dni";
            // 
            // col_usuario
            // 
            col_usuario.HeaderText = "Nombre de usuario";
            col_usuario.Name = "col_usuario";
            // 
            // col_rol
            // 
            col_rol.HeaderText = "Rol";
            col_rol.Name = "col_rol";
            // 
            // col_activo
            // 
            col_activo.HeaderText = "Activo";
            col_activo.Name = "col_activo";
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            // 
            // col_eliminar
            // 
            col_eliminar.HeaderText = "Eliminar";
            col_eliminar.Name = "col_eliminar";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(752, 561);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 37);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // ListarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(880, 600);
            Controls.Add(btnSalir);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListarUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListarUsuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblListarUsuarios;
        private Button btnFiltro;
        private Button test;
        private Button btnBuscar;
        private TextBox textBox1;
        private Label lblBuscar;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label lblFiltro;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn col_apellido;
        private DataGridViewTextBoxColumn col_nombre;
        private DataGridViewTextBoxColumn col_dni;
        private DataGridViewTextBoxColumn col_usuario;
        private DataGridViewTextBoxColumn col_rol;
        private DataGridViewTextBoxColumn col_activo;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn col_eliminar;
        private Button btnSalir;
    }
}