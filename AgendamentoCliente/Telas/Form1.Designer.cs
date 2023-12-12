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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel15.SuspendLayout();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.None;
            btnEntrar.BackColor = Color.FromArgb(1, 140, 241);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.ForeColor = SystemColors.ControlLightLight;
            btnEntrar.Location = new Point(640, 742);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(366, 55);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txbUser
            // 
            txbUser.Anchor = AnchorStyles.None;
            txbUser.BorderStyle = BorderStyle.None;
            txbUser.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txbUser.Location = new Point(645, 420);
            txbUser.Margin = new Padding(3, 4, 3, 4);
            txbUser.Name = "txbUser";
            txbUser.Size = new Size(359, 37);
            txbUser.TabIndex = 3;
            // 
            // txbPassword
            // 
            txbPassword.Anchor = AnchorStyles.None;
            txbPassword.BorderStyle = BorderStyle.None;
            txbPassword.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txbPassword.Location = new Point(648, 555);
            txbPassword.Margin = new Padding(3, 4, 3, 4);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(355, 37);
            txbPassword.TabIndex = 4;
            txbPassword.KeyPress += txbPassword_KeyPress;
            // 
            // txbErro
            // 
            txbErro.Anchor = AnchorStyles.None;
            txbErro.AutoSize = true;
            txbErro.Font = new Font("Calibri", 12F, FontStyle.Underline, GraphicsUnit.Point);
            txbErro.ForeColor = Color.FromArgb(1, 140, 241);
            txbErro.Location = new Point(723, 665);
            txbErro.Name = "txbErro";
            txbErro.Size = new Size(235, 24);
            txbErro.TabIndex = 5;
            txbErro.Text = "E-mail ou Senha Incorretos";
            txbErro.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 140, 241);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1648, 119);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(157, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 103);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(1, 140, 241);
            label1.Location = new Point(769, 337);
            label1.Name = "label1";
            label1.Size = new Size(122, 54);
            label1.TabIndex = 11;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(1, 140, 241);
            label2.Location = new Point(640, 477);
            label2.Name = "label2";
            label2.Size = new Size(73, 33);
            label2.TabIndex = 12;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(1, 140, 241);
            label3.Location = new Point(640, 613);
            label3.Name = "label3";
            label3.Size = new Size(81, 33);
            label3.TabIndex = 13;
            label3.Text = "Senha";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(1, 140, 241);
            panel2.Location = new Point(643, 460);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 1);
            panel2.TabIndex = 14;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.None;
            panel10.BackColor = Color.FromArgb(1, 140, 241);
            panel10.Controls.Add(panel11);
            panel10.Controls.Add(panel15);
            panel10.Controls.Add(panel17);
            panel10.Location = new Point(646, 596);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(360, 1);
            panel10.TabIndex = 15;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(1, 140, 241);
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(panel14);
            panel11.Location = new Point(0, 137);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(360, 1);
            panel11.TabIndex = 17;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(1, 140, 241);
            panel12.Controls.Add(panel13);
            panel12.Location = new Point(0, 63);
            panel12.Margin = new Padding(3, 4, 3, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(360, 1);
            panel12.TabIndex = 16;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(1, 140, 241);
            panel13.Location = new Point(0, 0);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(360, 1);
            panel13.TabIndex = 15;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(1, 140, 241);
            panel14.Location = new Point(0, 0);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Size = new Size(360, 1);
            panel14.TabIndex = 15;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(1, 140, 241);
            panel15.Controls.Add(panel16);
            panel15.Location = new Point(0, 63);
            panel15.Margin = new Padding(3, 4, 3, 4);
            panel15.Name = "panel15";
            panel15.Size = new Size(360, 1);
            panel15.TabIndex = 16;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(1, 140, 241);
            panel16.Location = new Point(0, 0);
            panel16.Margin = new Padding(3, 4, 3, 4);
            panel16.Name = "panel16";
            panel16.Size = new Size(360, 1);
            panel16.TabIndex = 15;
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(1, 140, 241);
            panel17.Location = new Point(0, 29);
            panel17.Margin = new Padding(3, 4, 3, 4);
            panel17.Name = "panel17";
            panel17.Size = new Size(360, 1);
            panel17.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1648, 1055);
            Controls.Add(panel10);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(txbErro);
            Controls.Add(txbPassword);
            Controls.Add(txbUser);
            Controls.Add(btnEntrar);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel15.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private TextBox txbUser;
        private TextBox txbPassword;
        private Label txbErro;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
    }
}