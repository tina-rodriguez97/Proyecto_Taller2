namespace Proyecto_Taller2.C_Presentacion.Supervisor
{
    partial class EstadisticasVentas
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
            lblVendedores = new Label();
            panel2 = new Panel();
            lblCategorias = new Label();
            panel3 = new Panel();
            label1 = new Label();
            lblGanancias = new Label();
            label2 = new Label();
            lblEstadisticas = new Label();
            lblVentasTotales = new Label();
            splitter1 = new Splitter();
            lblVendedorGanancias = new Label();
            label3 = new Label();
            btnBuscar = new Button();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 251, 255);
            panel1.Controls.Add(lblVendedores);
            panel1.Location = new Point(12, 173);
            panel1.Name = "panel1";
            panel1.Size = new Size(419, 415);
            panel1.TabIndex = 0;
            // 
            // lblVendedores
            // 
            lblVendedores.AutoSize = true;
            lblVendedores.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblVendedores.Location = new Point(52, 15);
            lblVendedores.Name = "lblVendedores";
            lblVendedores.Size = new Size(279, 30);
            lblVendedores.TabIndex = 0;
            lblVendedores.Text = "Vendedor con mas ventas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 251, 255);
            panel2.Controls.Add(lblCategorias);
            panel2.Location = new Point(445, 173);
            panel2.Name = "panel2";
            panel2.Size = new Size(423, 415);
            panel2.TabIndex = 1;
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCategorias.Location = new Point(86, 15);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(251, 30);
            lblCategorias.TabIndex = 1;
            lblCategorias.Text = "Categoria mas vendida";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(247, 251, 255);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblGanancias);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lblEstadisticas);
            panel3.Controls.Add(lblVentasTotales);
            panel3.Controls.Add(splitter1);
            panel3.Controls.Add(lblVendedorGanancias);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(comboBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(880, 167);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 125);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 3;
            label1.Text = "Productos en existencia:";
            // 
            // lblGanancias
            // 
            lblGanancias.AutoSize = true;
            lblGanancias.Location = new Point(178, 85);
            lblGanancias.Name = "lblGanancias";
            lblGanancias.Size = new Size(102, 15);
            lblGanancias.TabIndex = 2;
            lblGanancias.Text = "Ganancias totales:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 125);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 4;
            label2.Text = "Vendedores activos:";
            // 
            // lblEstadisticas
            // 
            lblEstadisticas.AutoSize = true;
            lblEstadisticas.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblEstadisticas.Location = new Point(17, 20);
            lblEstadisticas.Name = "lblEstadisticas";
            lblEstadisticas.Size = new Size(240, 30);
            lblEstadisticas.TabIndex = 1;
            lblEstadisticas.Text = "Estadisticas generales";
            // 
            // lblVentasTotales
            // 
            lblVentasTotales.AutoSize = true;
            lblVentasTotales.Location = new Point(30, 85);
            lblVentasTotales.Name = "lblVentasTotales";
            lblVentasTotales.Size = new Size(85, 15);
            lblVentasTotales.TabIndex = 0;
            lblVentasTotales.Text = "Ventas totales: ";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(440, 167);
            splitter1.TabIndex = 9;
            splitter1.TabStop = false;
            // 
            // lblVendedorGanancias
            // 
            lblVendedorGanancias.AutoSize = true;
            lblVendedorGanancias.Location = new Point(455, 125);
            lblVendedorGanancias.Name = "lblVendedorGanancias";
            lblVendedorGanancias.Size = new Size(112, 15);
            lblVendedorGanancias.TabIndex = 8;
            lblVendedorGanancias.Text = "Ingresos generados:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(455, 85);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 7;
            label3.Text = "Ventas totales: ";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(691, 51);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(74, 24);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(455, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Buscar vendedor...";
            // 
            // EstadisticasVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(880, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EstadisticasVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EstadisticasVentas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblVendedores;
        private Panel panel2;
        private Label lblCategorias;
        private Panel panel3;
        private Label lblEstadisticas;
        private Label lblVentasTotales;
        private Label lblGanancias;
        private Label lblVendedorGanancias;
        private Label label3;
        private Button btnBuscar;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private Splitter splitter1;
    }
}