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
            lbl1 = new Label();
            lbl2 = new Label();
            txbUser = new TextBox();
            txbPassword = new TextBox();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(91, 104);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(21, 32);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(40, 15);
            lbl1.TabIndex = 1;
            lbl1.Text = "Login:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(21, 65);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(42, 15);
            lbl2.TabIndex = 2;
            lbl2.Text = "Senha:";
            // 
            // txbUser
            // 
            txbUser.Location = new Point(79, 29);
            txbUser.Name = "txbUser";
            txbUser.Size = new Size(100, 23);
            txbUser.TabIndex = 3;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(79, 62);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(100, 23);
            txbPassword.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 139);
            Controls.Add(txbPassword);
            Controls.Add(txbUser);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(btnEntrar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private Label lbl1;
        private Label lbl2;
        private TextBox txbUser;
        private TextBox txbPassword;
    }
}