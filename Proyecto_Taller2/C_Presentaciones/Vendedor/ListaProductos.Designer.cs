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
            gridProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridProductos).BeginInit();
            SuspendLayout();
            // 
            // gridProductos
            // 
            gridProductos.BackgroundColor = Color.Lavender;
            gridProductos.BorderStyle = BorderStyle.Fixed3D;
            gridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProductos.GridColor = SystemColors.InactiveCaption;
            gridProductos.Location = new Point(-1, -1);
            gridProductos.Name = "gridProductos";
            gridProductos.Size = new Size(479, 453);
            gridProductos.TabIndex = 0;
            // 
            // ListaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(478, 452);
            ControlBox = false;
            Controls.Add(gridProductos);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "ListaProductos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lista Productos";
            Load += ListaProductos_Load;
            ((System.ComponentModel.ISupportInitialize)gridProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridProductos;
    }
}