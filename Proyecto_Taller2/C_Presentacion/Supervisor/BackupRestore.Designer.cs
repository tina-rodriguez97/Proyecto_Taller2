namespace Proyecto_Taller2.C_Presentacion.Supervisor
{
    partial class BackupRestore
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
            btnBuscarRestaurar = new Button();
            btnBuscarGuardar = new Button();
            btnRestaurar = new Button();
            btnGuardar = new Button();
            tbxBuscarCopia = new TextBox();
            tbxGuardarEn = new TextBox();
            lblGuardar = new Label();
            lblRestaurar = new Label();
            lblBackupRestore = new Label();
            saveFileDialog = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            btnSalir = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 251, 255);
            panel1.Controls.Add(btnBuscarRestaurar);
            panel1.Controls.Add(btnBuscarGuardar);
            panel1.Controls.Add(btnRestaurar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(tbxBuscarCopia);
            panel1.Controls.Add(tbxGuardarEn);
            panel1.Controls.Add(lblGuardar);
            panel1.Controls.Add(lblRestaurar);
            panel1.Controls.Add(lblBackupRestore);
            panel1.Location = new Point(190, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 408);
            panel1.TabIndex = 0;
            // 
            // btnBuscarRestaurar
            // 
            btnBuscarRestaurar.Location = new Point(277, 308);
            btnBuscarRestaurar.Name = "btnBuscarRestaurar";
            btnBuscarRestaurar.Size = new Size(62, 23);
            btnBuscarRestaurar.TabIndex = 20;
            btnBuscarRestaurar.Text = "Buscar..";
            btnBuscarRestaurar.UseVisualStyleBackColor = true;
            btnBuscarRestaurar.Click += btnBuscarRestaurar_Click;
            // 
            // btnBuscarGuardar
            // 
            btnBuscarGuardar.Location = new Point(277, 175);
            btnBuscarGuardar.Name = "btnBuscarGuardar";
            btnBuscarGuardar.Size = new Size(62, 23);
            btnBuscarGuardar.TabIndex = 19;
            btnBuscarGuardar.Text = "Buscar..";
            btnBuscarGuardar.UseVisualStyleBackColor = true;
            btnBuscarGuardar.Click += btnBuscarGuardar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(364, 307);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(107, 23);
            btnRestaurar.TabIndex = 18;
            btnRestaurar.Text = "Restaurar copia";
            btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(364, 175);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(107, 23);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar copia";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // tbxBuscarCopia
            // 
            tbxBuscarCopia.Location = new Point(35, 308);
            tbxBuscarCopia.Name = "tbxBuscarCopia";
            tbxBuscarCopia.Size = new Size(240, 23);
            tbxBuscarCopia.TabIndex = 16;
            // 
            // tbxGuardarEn
            // 
            tbxGuardarEn.Location = new Point(35, 175);
            tbxGuardarEn.Name = "tbxGuardarEn";
            tbxGuardarEn.Size = new Size(240, 23);
            tbxGuardarEn.TabIndex = 15;
            // 
            // lblGuardar
            // 
            lblGuardar.AutoSize = true;
            lblGuardar.Font = new Font("Franklin Gothic Medium", 14.25F);
            lblGuardar.Location = new Point(35, 128);
            lblGuardar.Name = "lblGuardar";
            lblGuardar.Size = new Size(240, 24);
            lblGuardar.TabIndex = 14;
            lblGuardar.Text = "Realizar copia de seguridad:";
            // 
            // lblRestaurar
            // 
            lblRestaurar.AutoSize = true;
            lblRestaurar.Font = new Font("Franklin Gothic Medium", 14.25F);
            lblRestaurar.Location = new Point(35, 258);
            lblRestaurar.Name = "lblRestaurar";
            lblRestaurar.Size = new Size(148, 24);
            lblRestaurar.TabIndex = 13;
            lblRestaurar.Text = "Restaurar desde:";
            // 
            // lblBackupRestore
            // 
            lblBackupRestore.AutoSize = true;
            lblBackupRestore.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBackupRestore.Location = new Point(35, 65);
            lblBackupRestore.Name = "lblBackupRestore";
            lblBackupRestore.Size = new Size(169, 28);
            lblBackupRestore.TabIndex = 12;
            lblBackupRestore.Text = "Base de datos";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(752, 551);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 37);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // BackupRestore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(880, 600);
            Controls.Add(btnSalir);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BackupRestore";
            Text = "BackupRestore";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblBackupRestore;
        private Button btnGuardar;
        private TextBox tbxBuscarCopia;
        private TextBox tbxGuardarEn;
        private Label lblGuardar;
        private Label lblRestaurar;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog1;
        private Button btnRestaurar;
        private Button btnBuscarRestaurar;
        private Button btnBuscarGuardar;
        private Button btnSalir;
    }
}