namespace AgendamentoCliente.Telas
{
    partial class AgendamentoPaciente
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
            btnCancelar = new Button();
            btnAgendar = new Button();
            lbl3 = new Label();
            lbl4 = new Label();
            txbNomeMedico = new TextBox();
            btnCadastrar = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(55, 61);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(108, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Nome do Paciente:";
            // 
            // txbNomePaciente
            // 
            txbNomePaciente.Location = new Point(191, 58);
            txbNomePaciente.Name = "txbNomePaciente";
            txbNomePaciente.Size = new Size(247, 23);
            txbNomePaciente.TabIndex = 1;
            txbNomePaciente.TextChanged += txbNomePaciente_TextChanged_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(337, 222);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(191, 222);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(101, 23);
            btnAgendar.TabIndex = 5;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click_1;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(55, 105);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(103, 15);
            lbl3.TabIndex = 6;
            lbl3.Text = "Nome do Médico:";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(55, 151);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(130, 15);
            lbl4.TabIndex = 8;
            lbl4.Text = "Data do Agendamento:";
            // 
            // txbNomeMedico
            // 
            txbNomeMedico.Location = new Point(191, 102);
            txbNomeMedico.Name = "txbNomeMedico";
            txbNomeMedico.Size = new Size(247, 23);
            txbNomeMedico.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(191, 261);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(247, 23);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(205, 151);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(282, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // AgendamentoPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 306);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnCadastrar);
            Controls.Add(txbNomeMedico);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(btnAgendar);
            Controls.Add(btnCancelar);
            Controls.Add(txbNomePaciente);
            Controls.Add(lbl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AgendamentoPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendamento";
            Load += AgendamentoPaciente_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label lbl1;
        private TextBox txbNomePaciente;
        private Button btnCancelar;
        private Button btnAgendar;
        private Label lbl3;
        private Label lbl4;
        private TextBox txbNomeMedico;
        private Button btnCadastrar;
        private DateTimePicker dateTimePicker1;
    }
}