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
            this.txbNomeMedico = new System.Windows.Forms.TextBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fotoMedico = new System.Windows.Forms.PictureBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNomeMedico
            // 
            this.txbNomeMedico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNomeMedico.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNomeMedico.Location = new System.Drawing.Point(462, 302);
            this.txbNomeMedico.Name = "txbNomeMedico";
            this.txbNomeMedico.Size = new System.Drawing.Size(514, 26);
            this.txbNomeMedico.TabIndex = 5;
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFoto.Image = global::AgendamentoCliente.Properties.Resources.btnEntrar;
            this.btnFoto.Location = new System.Drawing.Point(625, 692);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(132, 32);
            this.btnFoto.TabIndex = 7;
            this.btnFoto.Text = "Adicionar Foto";
            this.btnFoto.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Image = global::AgendamentoCliente.Properties.Resources.btnEntrar;
            this.btnCadastrar.Location = new System.Drawing.Point(462, 768);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(200, 50);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Image = global::AgendamentoCliente.Properties.Resources.btnEntrar;
            this.btnCancelar.Location = new System.Drawing.Point(776, 768);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(206, 50);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fotoMedico
            // 
            this.fotoMedico.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fotoMedico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoMedico.Location = new System.Drawing.Point(462, 591);
            this.fotoMedico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fotoMedico.Name = "fotoMedico";
            this.fotoMedico.Size = new System.Drawing.Size(139, 133);
            this.fotoMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoMedico.TabIndex = 10;
            this.fotoMedico.TabStop = false;
            // 
            // txbEmail
            // 
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEmail.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbEmail.Location = new System.Drawing.Point(462, 401);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(514, 26);
            this.txbEmail.TabIndex = 13;
            // 
            // txbSenha
            // 
            this.txbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSenha.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSenha.Location = new System.Drawing.Point(462, 504);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(514, 26);
            this.txbSenha.TabIndex = 14;
            // 
            // CadastraMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgendamentoCliente.Properties.Resources.telaCadastroMedico;
            this.ClientSize = new System.Drawing.Size(1442, 999);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.fotoMedico);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.txbNomeMedico);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastraMedico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.CadastraMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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