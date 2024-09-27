namespace Proyecto_Taller2.C_Presentacion.Administrador
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelHeader = new Panel();
            label1 = new Label();
            lblGanancias = new Label();
            label2 = new Label();
            lblEstadisticas = new Label();
            lblVentasTotales = new Label();
            lblVendedorGanancias = new Label();
            label3 = new Label();
            btnBuscar = new Button();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            chartCategoriaMasVendida = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            chartVendedoresMasVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblVendedores = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            chartGanancias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage3 = new TabPage();
            chartProductoMasVendido = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartVendedor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblCategorias = new Label();
            lblProductosMasVendido = new Label();
            label5 = new Label();
            panelHeader.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartCategoriaMasVendida).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVendedoresMasVentas).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGanancias).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartProductoMasVendido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartVendedor).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(247, 251, 255);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(lblGanancias);
            panelHeader.Controls.Add(label2);
            panelHeader.Controls.Add(lblEstadisticas);
            panelHeader.Controls.Add(lblVentasTotales);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(880, 117);
            panelHeader.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 12F);
            label1.Location = new Point(567, 85);
            label1.Name = "label1";
            label1.Size = new Size(175, 21);
            label1.TabIndex = 3;
            label1.Text = "Productos en existencia:";
            // 
            // lblGanancias
            // 
            lblGanancias.AutoSize = true;
            lblGanancias.Font = new Font("Franklin Gothic Medium", 12F);
            lblGanancias.Location = new Point(181, 85);
            lblGanancias.Name = "lblGanancias";
            lblGanancias.Size = new Size(137, 21);
            lblGanancias.TabIndex = 2;
            lblGanancias.Text = "Ganancias totales:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F);
            label2.Location = new Point(361, 85);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
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
            lblVentasTotales.Font = new Font("Franklin Gothic Medium", 12F);
            lblVentasTotales.Location = new Point(26, 85);
            lblVentasTotales.Name = "lblVentasTotales";
            lblVentasTotales.Size = new Size(115, 21);
            lblVentasTotales.TabIndex = 0;
            lblVentasTotales.Text = "Ventas totales: ";
            // 
            // lblVendedorGanancias
            // 
            lblVendedorGanancias.AutoSize = true;
            lblVendedorGanancias.Location = new Point(174, 103);
            lblVendedorGanancias.Name = "lblVendedorGanancias";
            lblVendedorGanancias.Size = new Size(149, 21);
            lblVendedorGanancias.TabIndex = 8;
            lblVendedorGanancias.Text = "Ingresos generados:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 103);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 7;
            label3.Text = "Ventas totales: ";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(305, 25);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(78, 29);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(273, 29);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Buscar vendedor...";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 251, 255);
            panel2.Controls.Add(chartVendedor);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(lblVendedorGanancias);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnBuscar);
            panel2.Location = new Point(436, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(423, 431);
            panel2.TabIndex = 5;
            // 
            // chartCategoriaMasVendida
            // 
            chartArea6.Name = "ChartArea1";
            chartCategoriaMasVendida.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            chartCategoriaMasVendida.Legends.Add(legend6);
            chartCategoriaMasVendida.Location = new Point(446, 68);
            chartCategoriaMasVendida.Name = "chartCategoriaMasVendida";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            chartCategoriaMasVendida.Series.Add(series6);
            chartCategoriaMasVendida.Size = new Size(380, 300);
            chartCategoriaMasVendida.TabIndex = 2;
            chartCategoriaMasVendida.Text = "chart2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 251, 255);
            panel1.Controls.Add(chartVendedoresMasVentas);
            panel1.Controls.Add(lblVendedores);
            panel1.Location = new Point(9, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 425);
            panel1.TabIndex = 4;
            // 
            // chartVendedoresMasVentas
            // 
            chartArea7.Name = "ChartArea1";
            chartVendedoresMasVentas.ChartAreas.Add(chartArea7);
            legend7.Name = "sadasd";
            chartVendedoresMasVentas.Legends.Add(legend7);
            chartVendedoresMasVentas.Location = new Point(17, 97);
            chartVendedoresMasVentas.Name = "chartVendedoresMasVentas";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series7.Legend = "sadasd";
            series7.Name = "Series1";
            chartVendedoresMasVentas.Series.Add(series7);
            chartVendedoresMasVentas.Size = new Size(383, 304);
            chartVendedoresMasVentas.TabIndex = 1;
            chartVendedoresMasVentas.Text = "chart1";
            title2.Name = "asd";
            chartVendedoresMasVentas.Titles.Add(title2);
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 123);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(880, 465);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(chartGanancias);
            tabPage1.Font = new Font("Segoe UI", 12F);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(872, 437);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(panel2);
            tabPage2.Font = new Font("Segoe UI", 12F);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(872, 437);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Vendedores";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartGanancias
            // 
            chartGanancias.BorderlineWidth = 2;
            chartArea8.Name = "ChartArea1";
            chartGanancias.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            chartGanancias.Legends.Add(legend8);
            chartGanancias.Location = new Point(45, 51);
            chartGanancias.Name = "chartGanancias";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Ventas";
            series8.YValuesPerPoint = 4;
            chartGanancias.Series.Add(series8);
            chartGanancias.Size = new Size(793, 340);
            chartGanancias.TabIndex = 0;
            chartGanancias.Text = "chart3";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lblProductosMasVendido);
            tabPage3.Controls.Add(lblCategorias);
            tabPage3.Controls.Add(chartCategoriaMasVendida);
            tabPage3.Controls.Add(chartProductoMasVendido);
            tabPage3.Font = new Font("Segoe UI", 12F);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(872, 437);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Productos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartProductoMasVendido
            // 
            chartArea9.Name = "ChartArea1";
            chartProductoMasVendido.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            chartProductoMasVendido.Legends.Add(legend9);
            chartProductoMasVendido.Location = new Point(10, 68);
            chartProductoMasVendido.Name = "chartProductoMasVendido";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            chartProductoMasVendido.Series.Add(series9);
            chartProductoMasVendido.Size = new Size(430, 300);
            chartProductoMasVendido.TabIndex = 0;
            chartProductoMasVendido.Text = "chart4";
            // 
            // chartVendedor
            // 
            chartArea10.Name = "ChartArea1";
            chartVendedor.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            chartVendedor.Legends.Add(legend10);
            chartVendedor.Location = new Point(15, 151);
            chartVendedor.Name = "chartVendedor";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            chartVendedor.Series.Add(series10);
            chartVendedor.Size = new Size(396, 256);
            chartVendedor.TabIndex = 9;
            chartVendedor.Text = "chart5";
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCategorias.Location = new Point(502, 26);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(251, 30);
            lblCategorias.TabIndex = 3;
            lblCategorias.Text = "Categoria mas vendida";
            // 
            // lblProductosMasVendido
            // 
            lblProductosMasVendido.AutoSize = true;
            lblProductosMasVendido.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblProductosMasVendido.Location = new Point(66, 26);
            lblProductosMasVendido.Name = "lblProductosMasVendido";
            lblProductosMasVendido.Size = new Size(247, 30);
            lblProductosMasVendido.TabIndex = 4;
            lblProductosMasVendido.Text = "Producto mas vendido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label5.Location = new Point(244, 18);
            label5.Name = "label5";
            label5.Size = new Size(345, 30);
            label5.TabIndex = 1;
            label5.Text = "Promedio de ganancias por mes";
            // 
            // EstadisticasVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(880, 600);
            Controls.Add(tabControl1);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EstadisticasVentas";
            Text = "EstadisticasVentas";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartCategoriaMasVendida).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartVendedoresMasVentas).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartGanancias).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartProductoMasVendido).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartVendedor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private Label lblGanancias;
        private Label label2;
        private Label lblEstadisticas;
        private Label lblVentasTotales;
        private Label lblVendedorGanancias;
        private Label label3;
        private Button btnBuscar;
        private ComboBox comboBox1;
        private Panel panel2;
        private Panel panel1;
        private Label lblVendedores;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategoriaMasVendida;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVendedoresMasVentas;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGanancias;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductoMasVendido;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVendedor;
        private Label label5;
        private Label lblProductosMasVendido;
        private Label lblCategorias;
    }
}