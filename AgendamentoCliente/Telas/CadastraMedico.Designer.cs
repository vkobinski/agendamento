namespace AgendamentoCliente.Telas
{
    partial class CadastraMedico
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
            txbNomeMedico = new TextBox();
            btnFoto = new Button();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            fotoMedico = new PictureBox();
            txbEmail = new TextBox();
            txbSenha = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            label3 = new Label();
            panel18 = new Panel();
            panel19 = new Panel();
            panel20 = new Panel();
            panel21 = new Panel();
            panel22 = new Panel();
            panel23 = new Panel();
            panel24 = new Panel();
            panel25 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fotoMedico).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel15.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel23.SuspendLayout();
            SuspendLayout();
            // 
            // txbNomeMedico
            // 
            txbNomeMedico.Anchor = AnchorStyles.Bottom;
            txbNomeMedico.BorderStyle = BorderStyle.None;
            txbNomeMedico.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbNomeMedico.Location = new Point(472, 215);
            txbNomeMedico.Margin = new Padding(3, 4, 3, 4);
            txbNomeMedico.Name = "txbNomeMedico";
            txbNomeMedico.Size = new Size(587, 33);
            txbNomeMedico.TabIndex = 0;
            txbNomeMedico.TextChanged += txbNomeMedico_TextChanged;
            // 
            // btnFoto
            // 
            btnFoto.Anchor = AnchorStyles.Bottom;
            btnFoto.BackColor = SystemColors.ControlLightLight;
            btnFoto.FlatStyle = FlatStyle.Flat;
            btnFoto.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFoto.ForeColor = SystemColors.ControlLightLight;
            btnFoto.Image = Properties.Resources.btnPrincipal;
            btnFoto.Location = new Point(694, 732);
            btnFoto.Margin = new Padding(3, 5, 3, 5);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(151, 43);
            btnFoto.TabIndex = 4;
            btnFoto.Text = "Adicionar Foto";
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Bottom;
            btnCadastrar.BackColor = Color.FromArgb(1, 140, 241);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = SystemColors.ControlLightLight;
            btnCadastrar.Location = new Point(473, 815);
            btnCadastrar.Margin = new Padding(3, 5, 3, 5);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(229, 52);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.BackColor = Color.FromArgb(1, 140, 241);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(832, 815);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(235, 52);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fotoMedico
            // 
            fotoMedico.Anchor = AnchorStyles.Bottom;
            fotoMedico.BackColor = SystemColors.ControlLightLight;
            fotoMedico.Location = new Point(675, 481);
            fotoMedico.Name = "fotoMedico";
            fotoMedico.Size = new Size(189, 220);
            fotoMedico.SizeMode = PictureBoxSizeMode.Zoom;
            fotoMedico.TabIndex = 10;
            fotoMedico.TabStop = false;
            fotoMedico.Paint += CadastraMedico_Paint;
            fotoMedico.MouseDown += fotoMedico_MouseDown;
            fotoMedico.MouseMove += fotoMedico_MouseMove;
            fotoMedico.MouseUp += fotoMedico_MouseUp;
            // 
            // txbEmail
            // 
            txbEmail.Anchor = AnchorStyles.Bottom;
            txbEmail.BorderStyle = BorderStyle.None;
            txbEmail.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbEmail.Location = new Point(472, 321);
            txbEmail.Margin = new Padding(3, 4, 3, 4);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(587, 33);
            txbEmail.TabIndex = 1;
            // 
            // txbSenha
            // 
            txbSenha.Anchor = AnchorStyles.Bottom;
            txbSenha.BorderStyle = BorderStyle.None;
            txbSenha.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbSenha.Location = new Point(472, 428);
            txbSenha.Margin = new Padding(3, 4, 3, 4);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(587, 33);
            txbSenha.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 140, 241);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1543, 119);
            panel1.TabIndex = 16;
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
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(1, 140, 241);
            label1.Location = new Point(602, 131);
            label1.Name = "label1";
            label1.Size = new Size(347, 54);
            label1.TabIndex = 17;
            label1.Text = "Cadastrar Médico";
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Bottom;
            panel10.BackColor = Color.FromArgb(1, 140, 241);
            panel10.Controls.Add(panel11);
            panel10.Controls.Add(panel15);
            panel10.Controls.Add(panel17);
            panel10.Location = new Point(473, 253);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(589, 1);
            panel10.TabIndex = 21;
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(1, 140, 241);
            label2.Location = new Point(470, 267);
            label2.Name = "label2";
            label2.Size = new Size(90, 33);
            label2.TabIndex = 20;
            label2.Text = "Nome ";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom;
            panel2.BackColor = Color.FromArgb(1, 140, 241);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel9);
            panel2.Location = new Point(471, 360);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(589, 1);
            panel2.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(1, 140, 241);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(0, 137);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 1);
            panel3.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(1, 140, 241);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 63);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(360, 1);
            panel4.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(1, 140, 241);
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(360, 1);
            panel5.TabIndex = 15;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(1, 140, 241);
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(360, 1);
            panel6.TabIndex = 15;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(1, 140, 241);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(0, 63);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(360, 1);
            panel7.TabIndex = 16;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(1, 140, 241);
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(360, 1);
            panel8.TabIndex = 15;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(1, 140, 241);
            panel9.Location = new Point(0, 29);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(360, 1);
            panel9.TabIndex = 15;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(1, 140, 241);
            label3.Location = new Point(467, 373);
            label3.Name = "label3";
            label3.Size = new Size(84, 33);
            label3.TabIndex = 22;
            label3.Text = "E-mail";
            // 
            // panel18
            // 
            panel18.Anchor = AnchorStyles.Bottom;
            panel18.BackColor = Color.FromArgb(1, 140, 241);
            panel18.Controls.Add(panel19);
            panel18.Controls.Add(panel23);
            panel18.Controls.Add(panel25);
            panel18.Location = new Point(471, 467);
            panel18.Margin = new Padding(3, 4, 3, 4);
            panel18.Name = "panel18";
            panel18.Size = new Size(589, 1);
            panel18.TabIndex = 25;
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(1, 140, 241);
            panel19.Controls.Add(panel20);
            panel19.Controls.Add(panel22);
            panel19.Location = new Point(0, 137);
            panel19.Margin = new Padding(3, 4, 3, 4);
            panel19.Name = "panel19";
            panel19.Size = new Size(360, 1);
            panel19.TabIndex = 17;
            // 
            // panel20
            // 
            panel20.BackColor = Color.FromArgb(1, 140, 241);
            panel20.Controls.Add(panel21);
            panel20.Location = new Point(0, 63);
            panel20.Margin = new Padding(3, 4, 3, 4);
            panel20.Name = "panel20";
            panel20.Size = new Size(360, 1);
            panel20.TabIndex = 16;
            // 
            // panel21
            // 
            panel21.BackColor = Color.FromArgb(1, 140, 241);
            panel21.Location = new Point(0, 0);
            panel21.Margin = new Padding(3, 4, 3, 4);
            panel21.Name = "panel21";
            panel21.Size = new Size(360, 1);
            panel21.TabIndex = 15;
            // 
            // panel22
            // 
            panel22.BackColor = Color.FromArgb(1, 140, 241);
            panel22.Location = new Point(0, 0);
            panel22.Margin = new Padding(3, 4, 3, 4);
            panel22.Name = "panel22";
            panel22.Size = new Size(360, 1);
            panel22.TabIndex = 15;
            // 
            // panel23
            // 
            panel23.BackColor = Color.FromArgb(1, 140, 241);
            panel23.Controls.Add(panel24);
            panel23.Location = new Point(0, 63);
            panel23.Margin = new Padding(3, 4, 3, 4);
            panel23.Name = "panel23";
            panel23.Size = new Size(360, 1);
            panel23.TabIndex = 16;
            // 
            // panel24
            // 
            panel24.BackColor = Color.FromArgb(1, 140, 241);
            panel24.Location = new Point(0, 0);
            panel24.Margin = new Padding(3, 4, 3, 4);
            panel24.Name = "panel24";
            panel24.Size = new Size(360, 1);
            panel24.TabIndex = 15;
            // 
            // panel25
            // 
            panel25.BackColor = Color.FromArgb(1, 140, 241);
            panel25.Location = new Point(0, 29);
            panel25.Margin = new Padding(3, 4, 3, 4);
            panel25.Name = "panel25";
            panel25.Size = new Size(360, 1);
            panel25.TabIndex = 15;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(1, 140, 241);
            label4.Location = new Point(467, 480);
            label4.Name = "label4";
            label4.Size = new Size(83, 33);
            label4.TabIndex = 24;
            label4.Text = "Senha";
            // 
            // CadastraMedico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1543, 972);
            Controls.Add(panel18);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel10);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(txbSenha);
            Controls.Add(txbEmail);
            Controls.Add(fotoMedico);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(btnFoto);
            Controls.Add(txbNomeMedico);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "CadastraMedico";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastramento";
            WindowState = FormWindowState.Maximized;
            FormClosing += CadastraMedico_FormClosing;
            Load += CadastraMedico_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fotoMedico).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel23.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txbNomeMedico;
        private Button btnFoto;
        private Button btnCadastrar;
        private Button btnCancelar;
        private FileSystemWatcher fileSystemWatcher1;
        private PictureBox fotoMedico;
        private TextBox txbSenha;
        private TextBox txbEmail;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel18;
        private Panel panel19;
        private Panel panel20;
        private Panel panel21;
        private Panel panel22;
        private Panel panel23;
        private Panel panel24;
        private Panel panel25;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Label label3;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Label label2;
    }
}