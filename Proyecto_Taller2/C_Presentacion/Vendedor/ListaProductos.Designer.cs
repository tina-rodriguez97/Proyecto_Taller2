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
            gridListaProductos.Location = new Point(0, 77);
            gridListaProductos.Name = "gridListaProductos";
            gridListaProductos.Size = new Size(764, 375);
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
            gbxProductos.Controls.Add(txtBuscarPro);
            gbxProductos.Controls.Add(btnBuscarPro);
            gbxProductos.Location = new Point(0, 0);
            gbxProductos.Name = "gbxProductos";
            gbxProductos.Size = new Size(764, 78);
            gbxProductos.TabIndex = 2;
            gbxProductos.TabStop = false;
            // 
            // txtBuscarPro
            // 
            txtBuscarPro.Location = new Point(543, 22);
            txtBuscarPro.Name = "txtBuscarPro";
            txtBuscarPro.Size = new Size(210, 23);
            txtBuscarPro.TabIndex = 1;
            // 
            // btnBuscarPro
            // 
            btnBuscarPro.Location = new Point(462, 21);
            btnBuscarPro.Name = "btnBuscarPro";
            btnBuscarPro.Size = new Size(75, 23);
            btnBuscarPro.TabIndex = 0;
            btnBuscarPro.Text = "Buscar";
            btnBuscarPro.UseVisualStyleBackColor = true;
            // 
            // ListaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(765, 452);
            ControlBox = false;
            Controls.Add(gbxProductos);
            Controls.Add(gridListaProductos);
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
    }
}