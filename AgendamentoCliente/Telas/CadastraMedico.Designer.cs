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
            fotoMedico = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)fotoMedico).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(55, 61);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(103, 15);
            lbl1.TabIndex = 2;
            lbl1.Text = "Nome do Médico:";
            // 
            // txbNomeMedico
            // 
            txbNomeMedico.Location = new Point(164, 58);
            txbNomeMedico.Name = "txbNomeMedico";
            txbNomeMedico.Size = new Size(247, 23);
            txbNomeMedico.TabIndex = 5;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(124, 122);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(34, 15);
            lbl2.TabIndex = 6;
            lbl2.Text = "Foto:";
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(336, 122);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(75, 23);
            btnFoto.TabIndex = 7;
            btnFoto.Text = "Adicionar";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(164, 235);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(101, 23);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(310, 235);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // fotoMedico
            // 
            fotoMedico.Location = new Point(175, 102);
            fotoMedico.Name = "fotoMedico";
            fotoMedico.Size = new Size(90, 86);
            fotoMedico.SizeMode = PictureBoxSizeMode.StretchImage;
            fotoMedico.TabIndex = 10;
            fotoMedico.TabStop = false;
            // 
            // CadastraMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 306);
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
        private PictureBox fotoMedico;
    }
}