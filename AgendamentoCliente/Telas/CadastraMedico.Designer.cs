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
            lbl1 = new Label();
            txbNomeMedico = new TextBox();
            lbl2 = new Label();
            btnFoto = new Button();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            fotoMedico = new PictureBox();
            lblEmail = new Label();
            lblSenha = new Label();
            txbEmail = new TextBox();
            txbSenha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fotoMedico).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(55, 42);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(103, 15);
            lbl1.TabIndex = 2;
            lbl1.Text = "Nome do Médico:";
            // 
            // txbNomeMedico
            // 
            txbNomeMedico.Location = new Point(164, 39);
            txbNomeMedico.Name = "txbNomeMedico";
            txbNomeMedico.Size = new Size(247, 23);
            txbNomeMedico.TabIndex = 5;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(124, 154);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(34, 15);
            lbl2.TabIndex = 6;
            lbl2.Text = "Foto:";
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(336, 154);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(75, 23);
            btnFoto.TabIndex = 7;
            btnFoto.Text = "Adicionar";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(164, 271);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(101, 23);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(310, 271);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fotoMedico
            // 
            fotoMedico.BorderStyle = BorderStyle.FixedSingle;
            fotoMedico.Location = new Point(164, 154);
            fotoMedico.Margin = new Padding(3, 2, 3, 2);
            fotoMedico.Name = "fotoMedico";
            fotoMedico.Size = new Size(101, 101);
            fotoMedico.SizeMode = PictureBoxSizeMode.StretchImage;
            fotoMedico.TabIndex = 10;
            fotoMedico.TabStop = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(114, 83);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "E-mail:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(116, 120);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 12;
            lblSenha.Text = "Senha:";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(164, 80);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(247, 23);
            txbEmail.TabIndex = 13;
            txbEmail.TextChanged += txbEmail_TextChanged;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(164, 117);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(247, 23);
            txbSenha.TabIndex = 14;
            // 
            // CadastraMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 306);
            Controls.Add(txbSenha);
            Controls.Add(txbEmail);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(fotoMedico);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(btnFoto);
            Controls.Add(lbl2);
            Controls.Add(txbNomeMedico);
            Controls.Add(lbl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastraMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fotoMedico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txbNomeMedico;
        private Label lbl2;
        private Button btnFoto;
        private Button btnCadastrar;
        private Button btnCancelar;
        private FileSystemWatcher fileSystemWatcher1;
        private PictureBox fotoMedico;
        private Label lblSenha;
        private Label lblEmail;
        private TextBox txbSenha;
        private TextBox txbEmail;
    }
}