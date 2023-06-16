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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txbNomeMedico = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fotoMedico = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(63, 56);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(129, 20);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Nome do Médico:";
            // 
            // txbNomeMedico
            // 
            this.txbNomeMedico.Location = new System.Drawing.Point(187, 52);
            this.txbNomeMedico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbNomeMedico.Name = "txbNomeMedico";
            this.txbNomeMedico.Size = new System.Drawing.Size(282, 27);
            this.txbNomeMedico.TabIndex = 5;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(142, 205);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(42, 20);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "Foto:";
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(384, 205);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(86, 31);
            this.btnFoto.TabIndex = 7;
            this.btnFoto.Text = "Adicionar";
            this.btnFoto.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(187, 361);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(115, 31);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(354, 361);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 31);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fotoMedico
            // 
            this.fotoMedico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoMedico.Location = new System.Drawing.Point(187, 205);
            this.fotoMedico.Name = "fotoMedico";
            this.fotoMedico.Size = new System.Drawing.Size(115, 134);
            this.fotoMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoMedico.TabIndex = 10;
            this.fotoMedico.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(130, 111);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 20);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(133, 160);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(52, 20);
            this.lblSenha.TabIndex = 12;
            this.lblSenha.Text = "Senha:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(187, 107);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(282, 27);
            this.txbEmail.TabIndex = 13;
            this.txbEmail.TextChanged += new System.EventHandler(this.txbEmail_TextChanged);
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(187, 156);
            this.txbSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(282, 27);
            this.txbSenha.TabIndex = 14;
            // 
            // CadastraMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 408);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.fotoMedico);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txbNomeMedico);
            this.Controls.Add(this.lbl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastraMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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