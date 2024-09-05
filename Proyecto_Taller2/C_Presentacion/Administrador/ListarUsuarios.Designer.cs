namespace Proyecto_Taller2.C_Presentacion.Administrador
{
    partial class formListarUsuarios
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
            dataGridView1 = new DataGridView();
            col_apellido = new DataGridViewTextBoxColumn();
            col_nombre = new DataGridViewTextBoxColumn();
            col_dni = new DataGridViewTextBoxColumn();
            col_usuario = new DataGridViewTextBoxColumn();
            col_rol = new DataGridViewTextBoxColumn();
            col_activo = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            col_eliminar = new DataGridViewButtonColumn();
            panel1 = new Panel();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.None;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 252, 247);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col_apellido, col_nombre, col_dni, col_usuario, col_rol, col_activo, Editar, col_eliminar });
            dataGridView1.Location = new Point(324, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(837, 403);
            dataGridView1.TabIndex = 0;
            // 
            // col_apellido
            // 
            col_apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            col_apellido.HeaderText = "Apellido";
            col_apellido.Name = "col_apellido";
            col_apellido.Width = 76;
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
            // panel1
            // 
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1161, 89);
            panel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1036, 503);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 47);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // formListarUsuarios
            // 
            AccessibleRole = AccessibleRole.Border;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 561);
            Controls.Add(btnSalir);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "formListarUsuarios";
            StartPosition = FormStartPosition.Manual;
            Text = "ListarUsuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn col_apellido;
        private DataGridViewTextBoxColumn col_nombre;
        private DataGridViewTextBoxColumn col_dni;
        private DataGridViewTextBoxColumn col_usuario;
        private DataGridViewTextBoxColumn col_rol;
        private DataGridViewTextBoxColumn col_activo;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn col_eliminar;
        private Panel panel1;
        private Button btnSalir;
    }
}