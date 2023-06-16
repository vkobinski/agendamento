namespace AgendamentoCliente.Telas
{
    partial class CadastraPaciente
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
            txbNomePaciente = new TextBox();
            lbl2 = new Label();
            dataNascimento = new DateTimePicker();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(55, 61);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(108, 15);
            lbl1.TabIndex = 1;
            lbl1.Text = "Nome do Paciente:";
            // 
            // txbNomePaciente
            // 
            txbNomePaciente.Location = new Point(178, 58);
            txbNomePaciente.Name = "txbNomePaciente";
            txbNomePaciente.Size = new Size(247, 23);
            txbNomePaciente.TabIndex = 2;
            txbNomePaciente.TextChanged += txbNomePaciente_TextChanged;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(55, 105);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(117, 15);
            lbl2.TabIndex = 7;
            lbl2.Text = "Data de Nascimento:";
            // 
            // dataNascimento
            // 
            dataNascimento.Location = new Point(178, 99);
            dataNascimento.Name = "dataNascimento";
            dataNascimento.Size = new Size(247, 23);
            dataNascimento.TabIndex = 8;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(178, 228);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(350, 228);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastraPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 306);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(dataNascimento);
            Controls.Add(lbl2);
            Controls.Add(txbNomePaciente);
            Controls.Add(lbl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastraPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastraPaciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txbNomePaciente;
        private Label lbl2;
        private DateTimePicker dataNascimento;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}