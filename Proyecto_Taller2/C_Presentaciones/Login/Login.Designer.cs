namespace Proyecto_Taller2.C_Presentaciones.Login
{
    partial class Login
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
            gbxLogin = new GroupBox();
            btnLoginIniciar = new Button();
            textBox2 = new TextBox();
            txtLoginUser = new TextBox();
            lblLoginPass = new Label();
            lblLoginUser = new Label();
            lblLogin = new Label();
            pbxLogin = new PictureBox();
            pbxImage = new PictureBox();
            gbxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxImage).BeginInit();
            SuspendLayout();
            // 
            // gbxLogin
            // 
            gbxLogin.BackColor = Color.LightSteelBlue;
            gbxLogin.Controls.Add(btnLoginIniciar);
            gbxLogin.Controls.Add(textBox2);
            gbxLogin.Controls.Add(txtLoginUser);
            gbxLogin.Controls.Add(lblLoginPass);
            gbxLogin.Controls.Add(lblLoginUser);
            gbxLogin.Controls.Add(lblLogin);
            gbxLogin.Controls.Add(pbxLogin);
            gbxLogin.Location = new Point(279, 2);
            gbxLogin.Name = "gbxLogin";
            gbxLogin.Size = new Size(407, 447);
            gbxLogin.TabIndex = 0;
            gbxLogin.TabStop = false;
            // 
            // btnLoginIniciar
            // 
            btnLoginIniciar.BackColor = Color.AliceBlue;
            btnLoginIniciar.FlatStyle = FlatStyle.Popup;
            btnLoginIniciar.Location = new Point(266, 385);
            btnLoginIniciar.Name = "btnLoginIniciar";
            btnLoginIniciar.Size = new Size(75, 23);
            btnLoginIniciar.TabIndex = 10;
            btnLoginIniciar.Text = "Iniciar";
            btnLoginIniciar.UseVisualStyleBackColor = false;
            btnLoginIniciar.Click += btnLoginIniciar_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 328);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(262, 23);
            textBox2.TabIndex = 5;
            // 
            // txtLoginUser
            // 
            txtLoginUser.Location = new Point(79, 256);
            txtLoginUser.Name = "txtLoginUser";
            txtLoginUser.Size = new Size(262, 23);
            txtLoginUser.TabIndex = 4;
            // 
            // lblLoginPass
            // 
            lblLoginPass.AutoSize = true;
            lblLoginPass.Location = new Point(79, 301);
            lblLoginPass.Name = "lblLoginPass";
            lblLoginPass.Size = new Size(67, 15);
            lblLoginPass.TabIndex = 3;
            lblLoginPass.Text = "Contraseña";
            // 
            // lblLoginUser
            // 
            lblLoginUser.AutoSize = true;
            lblLoginUser.Location = new Point(79, 226);
            lblLoginUser.Name = "lblLoginUser";
            lblLoginUser.Size = new Size(110, 15);
            lblLoginUser.TabIndex = 2;
            lblLoginUser.Text = "Nombre de Usuario";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(142, 162);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(135, 30);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Iniciar Sesión";
            // 
            // pbxLogin
            // 
            pbxLogin.Image = Properties.Resources.logo;
            pbxLogin.Location = new Point(117, 22);
            pbxLogin.Name = "pbxLogin";
            pbxLogin.Size = new Size(190, 125);
            pbxLogin.SizeMode = PictureBoxSizeMode.CenterImage;
            pbxLogin.TabIndex = 0;
            pbxLogin.TabStop = false;
            // 
            // pbxImage
            // 
            pbxImage.Image = Properties.Resources.image2;
            pbxImage.Location = new Point(2, 2);
            pbxImage.Name = "pbxImage";
            pbxImage.Size = new Size(276, 447);
            pbxImage.SizeMode = PictureBoxSizeMode.CenterImage;
            pbxImage.TabIndex = 1;
            pbxImage.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 450);
            Controls.Add(pbxImage);
            Controls.Add(gbxLogin);
            Name = "Login";
            Text = "Login";
            gbxLogin.ResumeLayout(false);
            gbxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxLogin;
        private Label lblLogin;
        private PictureBox pbxLogin;
        private TextBox textBox2;
        private TextBox txtLoginUser;
        private Label lblLoginPass;
        private Label lblLoginUser;
        private Button btnLoginIniciar;
        private PictureBox pbxImage;
    }
}