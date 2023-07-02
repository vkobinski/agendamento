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
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fotoMedico).BeginInit();
            SuspendLayout();
            // 
            // txbNomeMedico
            // 
            txbNomeMedico.BorderStyle = BorderStyle.None;
            txbNomeMedico.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbNomeMedico.Location = new Point(462, 302);
            txbNomeMedico.Name = "txbNomeMedico";
            txbNomeMedico.Size = new Size(514, 26);
            txbNomeMedico.TabIndex = 5;
            // 
            // btnFoto
            // 
            btnFoto.BackColor = SystemColors.ControlLightLight;
            btnFoto.FlatStyle = FlatStyle.Flat;
            btnFoto.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFoto.ForeColor = SystemColors.ControlLightLight;
            btnFoto.Image = Properties.Resources.btnEntrar;
            btnFoto.Location = new Point(625, 692);
            btnFoto.Margin = new Padding(3, 4, 3, 4);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(132, 32);
            btnFoto.TabIndex = 7;
            btnFoto.Text = "Adicionar Foto";
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.ControlLightLight;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = SystemColors.ControlLightLight;
            btnCadastrar.Image = Properties.Resources.btnEntrar;
            btnCadastrar.Location = new Point(462, 768);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(200, 50);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLightLight;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Image = Properties.Resources.btnEntrar;
            btnCancelar.Location = new Point(776, 768);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(206, 50);
            btnCancelar.TabIndex = 9;
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
            fotoMedico.BackColor = SystemColors.ControlLightLight;
            fotoMedico.BorderStyle = BorderStyle.FixedSingle;
            fotoMedico.Location = new Point(462, 591);
            fotoMedico.Margin = new Padding(3, 2, 3, 2);
            fotoMedico.Name = "fotoMedico";
            fotoMedico.Size = new Size(139, 133);
            fotoMedico.SizeMode = PictureBoxSizeMode.StretchImage;
            fotoMedico.TabIndex = 10;
            fotoMedico.TabStop = false;
            // 
            // txbEmail
            // 
            txbEmail.BorderStyle = BorderStyle.None;
            txbEmail.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbEmail.Location = new Point(462, 401);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(514, 26);
            txbEmail.TabIndex = 13;
            txbEmail.TextChanged += txbEmail_TextChanged;
            // 
            // txbSenha
            // 
            txbSenha.BorderStyle = BorderStyle.None;
            txbSenha.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbSenha.Location = new Point(462, 504);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(514, 26);
            txbSenha.TabIndex = 14;
            // 
            // CadastraMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.telaCadastroMedico;
            ClientSize = new Size(1442, 999);
            Controls.Add(txbSenha);
            Controls.Add(txbEmail);
            Controls.Add(fotoMedico);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(btnFoto);
            Controls.Add(txbNomeMedico);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastraMedico";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fotoMedico).EndInit();
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
    }
}