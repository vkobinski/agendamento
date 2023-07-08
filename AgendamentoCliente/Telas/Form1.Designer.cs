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
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEntrar.Image = global::AgendamentoCliente.Properties.Resources.btnEntrar;
            this.btnEntrar.Location = new System.Drawing.Point(562, 637);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(318, 50);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click_1);
            // 
            // txbUser
            // 
            this.txbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUser.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbUser.Location = new System.Drawing.Point(562, 400);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(318, 30);
            this.txbUser.TabIndex = 3;
            // 
            // txbPassword
            // 
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPassword.Location = new System.Drawing.Point(562, 502);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(318, 30);
            this.txbPassword.TabIndex = 4;
            // 
            // txbErro
            // 
            this.txbErro.AutoSize = true;
            this.txbErro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.txbErro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(4)))), ((int)(((byte)(44)))));
            this.txbErro.Location = new System.Drawing.Point(631, 583);
            this.txbErro.Name = "txbErro";
            this.txbErro.Size = new System.Drawing.Size(182, 19);
            this.txbErro.TabIndex = 5;
            this.txbErro.Text = "E-mail ou Senha Incorretos";
            this.txbErro.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::AgendamentoCliente.Properties.Resources.telaLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1424, 791);
            this.Controls.Add(this.txbErro);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.btnEntrar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEntrar;
        private TextBox txbUser;
        private TextBox txbPassword;
        private Label txbErro;
    }
}