namespace Proyecto_Taller2.C_Presentaciones.Vendedor
{
    partial class ListaProductos
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
            nombrepro = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewImageColumn();
            Stock = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            gbxProductos = new GroupBox();
            txtBuscarPro = new TextBox();
            btnBuscarPro = new Button();
            lblProductos = new Label();
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
            gridListaProductos.Columns.AddRange(new DataGridViewColumn[] { nombrepro, Precio, Imagen, Stock, Eliminar });
            gridListaProductos.Location = new Point(12, 124);
            gridListaProductos.Name = "gridListaProductos";
            gridListaProductos.Size = new Size(840, 416);
            gridListaProductos.TabIndex = 1;
            // 
            // nombrepro
            // 
            nombrepro.HeaderText = "Nombre Producto";
            nombrepro.Name = "nombrepro";
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
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            // 
            // gbxProductos
            // 
            gbxProductos.BackColor = Color.FromArgb(247, 251, 255);
            gbxProductos.Controls.Add(lblProductos);
            gbxProductos.Controls.Add(txtBuscarPro);
            gbxProductos.Controls.Add(btnBuscarPro);
            gbxProductos.Dock = DockStyle.Top;
            gbxProductos.Location = new Point(0, 0);
            gbxProductos.Name = "gbxProductos";
            gbxProductos.Size = new Size(864, 102);
            gbxProductos.TabIndex = 2;
            gbxProductos.TabStop = false;
            // 
            // txtBuscarPro
            // 
            txtBuscarPro.Location = new Point(642, 73);
            txtBuscarPro.Name = "txtBuscarPro";
            txtBuscarPro.Size = new Size(210, 23);
            txtBuscarPro.TabIndex = 1;
            // 
            // btnBuscarPro
            // 
            btnBuscarPro.Location = new Point(561, 72);
            btnBuscarPro.Name = "btnBuscarPro";
            btnBuscarPro.Size = new Size(75, 23);
            btnBuscarPro.TabIndex = 0;
            btnBuscarPro.Text = "Buscar";
            btnBuscarPro.UseVisualStyleBackColor = true;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblProductos.Location = new Point(12, 19);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(131, 32);
            lblProductos.TabIndex = 9;
            lblProductos.Text = "Productos";
            // 
            // ListaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(864, 561);
            ControlBox = false;
            Controls.Add(gbxProductos);
            Controls.Add(gridListaProductos);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "ListaProductos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lista Productos";
            Load += ListaProductos_Load;
            ((System.ComponentModel.ISupportInitialize)gridListaProductos).EndInit();
            gbxProductos.ResumeLayout(false);
            gbxProductos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView gridListaProductos;
        private DataGridViewTextBoxColumn nombrepro;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewImageColumn Imagen;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewButtonColumn Eliminar;
        private GroupBox gbxProductos;
        private TextBox txtBuscarPro;
        private Button btnBuscarPro;
        private Label lblProductos;
    }
}