namespace Proyecto_Taller2.C_Presentacion.Administrador
{
    partial class AgregarProducto
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
            lblAgregarProducto = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblDescripcion = new Label();
            btnAgregar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnCancelar = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAgregarProducto
            // 
            lblAgregarProducto.AutoSize = true;
            lblAgregarProducto.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgregarProducto.Location = new Point(32, 42);
            lblAgregarProducto.Name = "lblAgregarProducto";
            lblAgregarProducto.Size = new Size(220, 32);
            lblAgregarProducto.TabIndex = 0;
            lblAgregarProducto.Text = "Agregar Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 99);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 216);
            label2.Name = "label2";
            label2.Size = new Size(107, 30);
            label2.TabIndex = 2;
            label2.Text = "Categoria:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 268);
            label3.Name = "label3";
            label3.Size = new Size(127, 30);
            label3.TabIndex = 3;
            label3.Text = "Stock Inicial:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(32, 158);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(126, 30);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripcion:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(363, 516);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(110, 43);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(165, 223);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(165, 275);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(242, 23);
            textBox4.TabIndex = 9;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(247, 516);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 43);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 251, 255);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(lblAgregarProducto);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblDescripcion);
            panel1.Controls.Add(btnAgregar);
            panel1.Location = new Point(420, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 600);
            panel1.TabIndex = 11;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1180, 600);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarProducto";
            StartPosition = FormStartPosition.Manual;
            Text = "AgregarProducto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAgregarProducto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblDescripcion;
        private Button btnAgregar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnCancelar;
        private Panel panel1;
    }
}