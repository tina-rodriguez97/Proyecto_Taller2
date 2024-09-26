namespace Proyecto_Taller2.C_Presentaciones.Vendedor
{
    partial class AltaCliente
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
            panelAltaCliente = new Panel();
            lblAltaCliente = new Label();
            lblNomAltaC = new Label();
            lblApeAltaC = new Label();
            lblDniAltaC = new Label();
            lblTelAltaC = new Label();
            lblDirAltaC = new Label();
            lblMailAltaC = new Label();
            lblFechaAltaC = new Label();
            txtNomAltaC = new TextBox();
            txtApeAltaC = new TextBox();
            txtDniAltaC = new TextBox();
            txtTelAltaC = new TextBox();
            txtDirAltaC = new TextBox();
            txtMailAltaC = new TextBox();
            dtpAltaCliente = new DateTimePicker();
            btnAltaC = new Button();
            btnCancelarAltaC = new Button();
            panelAltaCliente.SuspendLayout();
            SuspendLayout();
            // 
            // panelAltaCliente
            // 
            panelAltaCliente.BackColor = SystemColors.Control;
            panelAltaCliente.Controls.Add(btnCancelarAltaC);
            panelAltaCliente.Controls.Add(btnAltaC);
            panelAltaCliente.Controls.Add(dtpAltaCliente);
            panelAltaCliente.Controls.Add(txtMailAltaC);
            panelAltaCliente.Controls.Add(txtDirAltaC);
            panelAltaCliente.Controls.Add(txtTelAltaC);
            panelAltaCliente.Controls.Add(txtDniAltaC);
            panelAltaCliente.Controls.Add(txtApeAltaC);
            panelAltaCliente.Controls.Add(txtNomAltaC);
            panelAltaCliente.Controls.Add(lblFechaAltaC);
            panelAltaCliente.Controls.Add(lblMailAltaC);
            panelAltaCliente.Controls.Add(lblDirAltaC);
            panelAltaCliente.Controls.Add(lblTelAltaC);
            panelAltaCliente.Controls.Add(lblDniAltaC);
            panelAltaCliente.Controls.Add(lblApeAltaC);
            panelAltaCliente.Controls.Add(lblNomAltaC);
            panelAltaCliente.Controls.Add(lblAltaCliente);
            panelAltaCliente.Location = new Point(192, 2);
            panelAltaCliente.Name = "panelAltaCliente";
            panelAltaCliente.Size = new Size(377, 469);
            panelAltaCliente.TabIndex = 0;
            // 
            // lblAltaCliente
            // 
            lblAltaCliente.AutoSize = true;
            lblAltaCliente.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAltaCliente.Location = new Point(136, 17);
            lblAltaCliente.Name = "lblAltaCliente";
            lblAltaCliente.Size = new Size(120, 30);
            lblAltaCliente.TabIndex = 0;
            lblAltaCliente.Text = "Alta Cliente";
            // 
            // lblNomAltaC
            // 
            lblNomAltaC.AutoSize = true;
            lblNomAltaC.Location = new Point(51, 78);
            lblNomAltaC.Name = "lblNomAltaC";
            lblNomAltaC.Size = new Size(54, 15);
            lblNomAltaC.TabIndex = 1;
            lblNomAltaC.Text = "Nombre:";
            // 
            // lblApeAltaC
            // 
            lblApeAltaC.AutoSize = true;
            lblApeAltaC.Location = new Point(51, 129);
            lblApeAltaC.Name = "lblApeAltaC";
            lblApeAltaC.Size = new Size(54, 15);
            lblApeAltaC.TabIndex = 2;
            lblApeAltaC.Text = "Apellido:";
            // 
            // lblDniAltaC
            // 
            lblDniAltaC.AutoSize = true;
            lblDniAltaC.Location = new Point(51, 183);
            lblDniAltaC.Name = "lblDniAltaC";
            lblDniAltaC.Size = new Size(30, 15);
            lblDniAltaC.TabIndex = 3;
            lblDniAltaC.Text = "DNI:";
            // 
            // lblTelAltaC
            // 
            lblTelAltaC.AutoSize = true;
            lblTelAltaC.Location = new Point(50, 234);
            lblTelAltaC.Name = "lblTelAltaC";
            lblTelAltaC.Size = new Size(55, 15);
            lblTelAltaC.TabIndex = 4;
            lblTelAltaC.Text = "Teléfono:";
            // 
            // lblDirAltaC
            // 
            lblDirAltaC.AutoSize = true;
            lblDirAltaC.Location = new Point(50, 282);
            lblDirAltaC.Name = "lblDirAltaC";
            lblDirAltaC.Size = new Size(60, 15);
            lblDirAltaC.TabIndex = 5;
            lblDirAltaC.Text = "Dirección:";
            // 
            // lblMailAltaC
            // 
            lblMailAltaC.AutoSize = true;
            lblMailAltaC.Location = new Point(52, 332);
            lblMailAltaC.Name = "lblMailAltaC";
            lblMailAltaC.Size = new Size(46, 15);
            lblMailAltaC.TabIndex = 6;
            lblMailAltaC.Text = "Correo:";
            // 
            // lblFechaAltaC
            // 
            lblFechaAltaC.AutoSize = true;
            lblFechaAltaC.Location = new Point(82, 378);
            lblFechaAltaC.Name = "lblFechaAltaC";
            lblFechaAltaC.Size = new Size(81, 15);
            lblFechaAltaC.TabIndex = 7;
            lblFechaAltaC.Text = "Fecha de Alta:";
            lblFechaAltaC.Click += label7_Click;
            // 
            // txtNomAltaC
            // 
            txtNomAltaC.Location = new Point(118, 70);
            txtNomAltaC.Name = "txtNomAltaC";
            txtNomAltaC.Size = new Size(218, 23);
            txtNomAltaC.TabIndex = 11;
            // 
            // txtApeAltaC
            // 
            txtApeAltaC.Location = new Point(118, 121);
            txtApeAltaC.Name = "txtApeAltaC";
            txtApeAltaC.Size = new Size(218, 23);
            txtApeAltaC.TabIndex = 12;
            // 
            // txtDniAltaC
            // 
            txtDniAltaC.Location = new Point(118, 175);
            txtDniAltaC.Name = "txtDniAltaC";
            txtDniAltaC.Size = new Size(218, 23);
            txtDniAltaC.TabIndex = 13;
            txtDniAltaC.TextChanged += textBox3_TextChanged;
            // 
            // txtTelAltaC
            // 
            txtTelAltaC.Location = new Point(118, 226);
            txtTelAltaC.Name = "txtTelAltaC";
            txtTelAltaC.Size = new Size(218, 23);
            txtTelAltaC.TabIndex = 14;
            // 
            // txtDirAltaC
            // 
            txtDirAltaC.Location = new Point(118, 274);
            txtDirAltaC.Name = "txtDirAltaC";
            txtDirAltaC.Size = new Size(218, 23);
            txtDirAltaC.TabIndex = 15;
            // 
            // txtMailAltaC
            // 
            txtMailAltaC.Location = new Point(118, 324);
            txtMailAltaC.Name = "txtMailAltaC";
            txtMailAltaC.Size = new Size(218, 23);
            txtMailAltaC.TabIndex = 16;
            // 
            // dtpAltaCliente
            // 
            dtpAltaCliente.Format = DateTimePickerFormat.Short;
            dtpAltaCliente.Location = new Point(218, 370);
            dtpAltaCliente.Name = "dtpAltaCliente";
            dtpAltaCliente.Size = new Size(98, 23);
            dtpAltaCliente.TabIndex = 17;
            // 
            // btnAltaC
            // 
            btnAltaC.BackColor = Color.SpringGreen;
            btnAltaC.FlatStyle = FlatStyle.Popup;
            btnAltaC.Location = new Point(88, 423);
            btnAltaC.Name = "btnAltaC";
            btnAltaC.Size = new Size(75, 23);
            btnAltaC.TabIndex = 18;
            btnAltaC.Text = "Aceptar";
            btnAltaC.UseVisualStyleBackColor = false;
            // 
            // btnCancelarAltaC
            // 
            btnCancelarAltaC.BackColor = Color.Salmon;
            btnCancelarAltaC.FlatStyle = FlatStyle.Popup;
            btnCancelarAltaC.Location = new Point(218, 423);
            btnCancelarAltaC.Name = "btnCancelarAltaC";
            btnCancelarAltaC.Size = new Size(75, 23);
            btnCancelarAltaC.TabIndex = 19;
            btnCancelarAltaC.Text = "Cancelar";
            btnCancelarAltaC.UseVisualStyleBackColor = false;
            // 
            // AltaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 470);
            Controls.Add(panelAltaCliente);
            Name = "AltaCliente";
            Text = "AltaCliente";
            panelAltaCliente.ResumeLayout(false);
            panelAltaCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAltaCliente;
        private Label lblFechaAltaC;
        private Label lblMailAltaC;
        private Label lblDirAltaC;
        private Label lblTelAltaC;
        private Label lblDniAltaC;
        private Label lblApeAltaC;
        private Label lblNomAltaC;
        private Label lblAltaCliente;
        private TextBox txtMailAltaC;
        private TextBox txtDirAltaC;
        private TextBox txtTelAltaC;
        private TextBox txtDniAltaC;
        private TextBox txtApeAltaC;
        private TextBox txtNomAltaC;
        private DateTimePicker dtpAltaCliente;
        private Button btnAltaC;
        private Button btnCancelarAltaC;
    }
}