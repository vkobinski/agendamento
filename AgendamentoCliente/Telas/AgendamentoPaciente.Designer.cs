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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txbNomePaciente = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txbNomeMedico = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(63, 81);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(134, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Nome do Paciente:";
            // 
            // txbNomePaciente
            // 
            this.txbNomePaciente.Location = new System.Drawing.Point(218, 77);
            this.txbNomePaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbNomePaciente.Name = "txbNomePaciente";
            this.txbNomePaciente.Size = new System.Drawing.Size(282, 27);
            this.txbNomePaciente.TabIndex = 1;
            this.txbNomePaciente.TextChanged += new System.EventHandler(this.txbNomePaciente_TextChanged_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(385, 296);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 31);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(218, 296);
            this.btnAgendar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(115, 31);
            this.btnAgendar.TabIndex = 5;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click_1);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(63, 140);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(129, 20);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Nome do Médico:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(63, 201);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(165, 20);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "Data do Agendamento:";
            // 
            // txbNomeMedico
            // 
            this.txbNomeMedico.Location = new System.Drawing.Point(218, 136);
            this.txbNomeMedico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbNomeMedico.Name = "txbNomeMedico";
            this.txbNomeMedico.Size = new System.Drawing.Size(282, 27);
            this.txbNomeMedico.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(218, 348);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(282, 31);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(234, 201);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(322, 27);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // AgendamentoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 408);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbNomeMedico);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txbNomePaciente);
            this.Controls.Add(this.lbl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgendamentoPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.AgendamentoPaciente_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

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