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
            components = new System.ComponentModel.Container();
            lblAgregarProducto = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblDescripcion = new Label();
            btnAgregar = new Button();
            tbxNombre = new TextBox();
            tbxDescripcion = new TextBox();
            btnCancelar = new Button();
            panel1 = new Panel();
            btnNuevaCategoria = new Button();
            button1 = new Button();
            cbxMarca = new ComboBox();
            lblMarca = new Label();
            cbxCategoria = new ComboBox();
            tbxTalleXL = new TextBox();
            tbxTalleL = new TextBox();
            tbxTalleM = new TextBox();
            tbxTalleS = new TextBox();
            cbxTalleXL = new CheckBox();
            cbxTalleL = new CheckBox();
            cbxTalleM = new CheckBox();
            cbxTalleS = new CheckBox();
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
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
            label1.Font = new Font("Franklin Gothic Medium", 14.25F);
            label1.Location = new Point(34, 134);
            label1.Name = "label1";
            label1.Size = new Size(80, 24);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 14.25F);
            label2.Location = new Point(34, 311);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 2;
            label2.Text = "Categoria:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 14.25F);
            label3.Location = new Point(33, 359);
            label3.Name = "label3";
            label3.Size = new Size(115, 24);
            label3.TabIndex = 3;
            label3.Text = "Stock Inicial:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Franklin Gothic Medium", 14.25F);
            lblDescripcion.Location = new Point(34, 176);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(110, 24);
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
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(165, 137);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(242, 23);
            tbxNombre.TabIndex = 6;
            // 
            // tbxDescripcion
            // 
            tbxDescripcion.Location = new Point(165, 176);
            tbxDescripcion.Multiline = true;
            tbxDescripcion.Name = "tbxDescripcion";
            tbxDescripcion.Size = new Size(242, 76);
            tbxDescripcion.TabIndex = 7;
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
            panel1.Controls.Add(btnNuevaCategoria);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(cbxMarca);
            panel1.Controls.Add(lblMarca);
            panel1.Controls.Add(cbxCategoria);
            panel1.Controls.Add(tbxTalleXL);
            panel1.Controls.Add(tbxTalleL);
            panel1.Controls.Add(tbxTalleM);
            panel1.Controls.Add(tbxTalleS);
            panel1.Controls.Add(cbxTalleXL);
            panel1.Controls.Add(cbxTalleL);
            panel1.Controls.Add(cbxTalleM);
            panel1.Controls.Add(cbxTalleS);
            panel1.Controls.Add(tbxNombre);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(lblAgregarProducto);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbxDescripcion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblDescripcion);
            panel1.Controls.Add(btnAgregar);
            panel1.Location = new Point(190, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 600);
            panel1.TabIndex = 11;
            // 
            // btnNuevaCategoria
            // 
            btnNuevaCategoria.Location = new Point(296, 308);
            btnNuevaCategoria.Name = "btnNuevaCategoria";
            btnNuevaCategoria.Size = new Size(108, 26);
            btnNuevaCategoria.TabIndex = 23;
            btnNuevaCategoria.Text = "Nueva Categoria";
            btnNuevaCategoria.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(296, 272);
            button1.Name = "button1";
            button1.Size = new Size(108, 25);
            button1.TabIndex = 22;
            button1.Text = "Nueva marca";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbxMarca
            // 
            cbxMarca.FormattingEnabled = true;
            cbxMarca.Location = new Point(165, 273);
            cbxMarca.Name = "cbxMarca";
            cbxMarca.Size = new Size(125, 23);
            cbxMarca.TabIndex = 21;
            // 
            // lblMarca
            // 
            lblMarca.Font = new Font("Franklin Gothic Medium", 14.25F);
            lblMarca.Location = new Point(34, 273);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(93, 24);
            lblMarca.TabIndex = 20;
            lblMarca.Text = "Marca:";
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(165, 311);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(125, 23);
            cbxCategoria.TabIndex = 19;
            // 
            // tbxTalleXL
            // 
            tbxTalleXL.Enabled = false;
            tbxTalleXL.Location = new Point(207, 446);
            tbxTalleXL.Name = "tbxTalleXL";
            tbxTalleXL.Size = new Size(45, 23);
            tbxTalleXL.TabIndex = 18;
            // 
            // tbxTalleL
            // 
            tbxTalleL.Enabled = false;
            tbxTalleL.Location = new Point(207, 417);
            tbxTalleL.Name = "tbxTalleL";
            tbxTalleL.Size = new Size(45, 23);
            tbxTalleL.TabIndex = 17;
            // 
            // tbxTalleM
            // 
            tbxTalleM.Enabled = false;
            tbxTalleM.Location = new Point(207, 388);
            tbxTalleM.Name = "tbxTalleM";
            tbxTalleM.Size = new Size(45, 23);
            tbxTalleM.TabIndex = 16;
            // 
            // tbxTalleS
            // 
            tbxTalleS.Location = new Point(207, 359);
            tbxTalleS.Name = "tbxTalleS";
            tbxTalleS.Size = new Size(45, 23);
            tbxTalleS.TabIndex = 15;
            // 
            // cbxTalleXL
            // 
            cbxTalleXL.AutoSize = true;
            cbxTalleXL.Font = new Font("Segoe UI", 11F);
            cbxTalleXL.Location = new Point(165, 446);
            cbxTalleXL.Name = "cbxTalleXL";
            cbxTalleXL.Size = new Size(44, 24);
            cbxTalleXL.TabIndex = 14;
            cbxTalleXL.Text = "XL";
            cbxTalleXL.UseVisualStyleBackColor = true;
            cbxTalleXL.CheckedChanged += cbxTalleXL_CheckedChanged;
            // 
            // cbxTalleL
            // 
            cbxTalleL.AutoSize = true;
            cbxTalleL.Font = new Font("Segoe UI", 11F);
            cbxTalleL.Location = new Point(165, 417);
            cbxTalleL.Name = "cbxTalleL";
            cbxTalleL.Size = new Size(35, 24);
            cbxTalleL.TabIndex = 13;
            cbxTalleL.Text = "L";
            cbxTalleL.UseVisualStyleBackColor = true;
            cbxTalleL.CheckedChanged += cbxTalleL_CheckedChanged;
            // 
            // cbxTalleM
            // 
            cbxTalleM.AutoSize = true;
            cbxTalleM.Font = new Font("Segoe UI", 11F);
            cbxTalleM.Location = new Point(165, 388);
            cbxTalleM.Name = "cbxTalleM";
            cbxTalleM.Size = new Size(41, 24);
            cbxTalleM.TabIndex = 12;
            cbxTalleM.Text = "M";
            cbxTalleM.UseVisualStyleBackColor = true;
            cbxTalleM.CheckedChanged += cbxTalleM_CheckedChanged;
            // 
            // cbxTalleS
            // 
            cbxTalleS.AutoSize = true;
            cbxTalleS.Checked = true;
            cbxTalleS.CheckState = CheckState.Checked;
            cbxTalleS.Font = new Font("Segoe UI", 11F);
            cbxTalleS.Location = new Point(165, 359);
            cbxTalleS.Name = "cbxTalleS";
            cbxTalleS.Size = new Size(36, 24);
            cbxTalleS.TabIndex = 11;
            cbxTalleS.Text = "S";
            cbxTalleS.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.BlinkRate = 300;
            errorProvider.ContainerControl = this;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(880, 600);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarProducto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAgregarProducto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblDescripcion;
        private Button btnAgregar;
        private TextBox tbxNombre;
        private TextBox tbxDescripcion;
        private Button btnCancelar;
        private Panel panel1;
        private CheckBox cbxTalleL;
        private CheckBox cbxTalleM;
        private CheckBox cbxTalleS;
        private CheckBox cbxTalleXL;
        private ComboBox cbxCategoria;
        private TextBox tbxTalleXL;
        private TextBox tbxTalleL;
        private TextBox tbxTalleM;
        private TextBox tbxTalleS;
        private ErrorProvider errorProvider;
        private Button button1;
        private ComboBox cbxMarca;
        private Label lblMarca;
        private Button btnNuevaCategoria;
    }
}