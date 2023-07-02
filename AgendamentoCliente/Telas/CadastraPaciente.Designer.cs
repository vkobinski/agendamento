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
            txbNomePaciente = new TextBox();
            dataNascimento = new DateTimePicker();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txbNomePaciente
            // 
            txbNomePaciente.BorderStyle = BorderStyle.None;
            txbNomePaciente.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbNomePaciente.Location = new Point(461, 427);
            txbNomePaciente.Name = "txbNomePaciente";
            txbNomePaciente.Size = new Size(517, 26);
            txbNomePaciente.TabIndex = 2;
            txbNomePaciente.TextChanged += txbNomePaciente_TextChanged;
            // 
            // dataNascimento
            // 
            dataNascimento.CalendarFont = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataNascimento.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataNascimento.Format = DateTimePickerFormat.Short;
            dataNascimento.Location = new Point(461, 520);
            dataNascimento.Name = "dataNascimento";
            dataNascimento.Size = new Size(247, 33);
            dataNascimento.TabIndex = 8;
            // 
            // btnConfirmar
            // 
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = SystemColors.ControlLightLight;
            btnConfirmar.Image = Properties.Resources.btnEntrar;
            btnConfirmar.Location = new Point(461, 646);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(200, 50);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Image = Properties.Resources.btnEntrar;
            btnCancelar.Location = new Point(778, 646);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 50);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // CadastraPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.telaCadastroPaciente;
            ClientSize = new Size(1442, 999);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(dataNascimento);
            Controls.Add(txbNomePaciente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastraPaciente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txbNomePaciente;
        private DateTimePicker dataNascimento;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}