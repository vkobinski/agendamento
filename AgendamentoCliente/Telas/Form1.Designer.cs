namespace AgendamentoCliente
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnEntrar = new Button();
            txbUser = new TextBox();
            txbPassword = new TextBox();
            txbErro = new Label();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.ForeColor = SystemColors.ControlLightLight;
            btnEntrar.Image = Properties.Resources.btnEntrar;
            btnEntrar.Location = new Point(560, 638);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(318, 50);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txbUser
            // 
            txbUser.BorderStyle = BorderStyle.None;
            txbUser.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txbUser.Location = new Point(560, 400);
            txbUser.Name = "txbUser";
            txbUser.Size = new Size(318, 30);
            txbUser.TabIndex = 3;
            // 
            // txbPassword
            // 
            txbPassword.BorderStyle = BorderStyle.None;
            txbPassword.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txbPassword.Location = new Point(560, 502);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(318, 30);
            txbPassword.TabIndex = 4;
            // 
            // txbErro
            // 
            txbErro.AutoSize = true;
            txbErro.Font = new Font("Calibri", 12F, FontStyle.Underline, GraphicsUnit.Point);
            txbErro.ForeColor = Color.FromArgb(76, 4, 44);
            txbErro.Location = new Point(631, 583);
            txbErro.Name = "txbErro";
            txbErro.Size = new Size(182, 19);
            txbErro.TabIndex = 5;
            txbErro.Text = "E-mail ou Senha Incorretos";
            txbErro.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = Properties.Resources.telaLogin;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1424, 985);
            Controls.Add(txbErro);
            Controls.Add(txbPassword);
            Controls.Add(txbUser);
            Controls.Add(btnEntrar);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private TextBox txbUser;
        private TextBox txbPassword;
        private Label txbErro;
    }
}