namespace Proyecto_Taller2.C_Presentacion.Administrador
{
    partial class nuevaMarca
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
            btnGuardar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            lblNuevaMarca = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 251, 255);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblNuevaMarca);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 237);
            panel1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(257, 197);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 28);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(159, 197);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(92, 28);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 14.25F);
            label1.Location = new Point(3, 101);
            label1.Name = "label1";
            label1.Size = new Size(80, 24);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // lblNuevaMarca
            // 
            lblNuevaMarca.AutoSize = true;
            lblNuevaMarca.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNuevaMarca.Location = new Point(103, 21);
            lblNuevaMarca.Name = "lblNuevaMarca";
            lblNuevaMarca.Size = new Size(164, 32);
            lblNuevaMarca.TabIndex = 1;
            lblNuevaMarca.Text = "Nueva marca";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 0;
            // 
            // nuevaMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(384, 261);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "nuevaMarca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar nueva marca";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label lblNuevaMarca;
        private Label label1;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}