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
            lbl1.Location = new Point(388, 294);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(108, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Nome do Paciente:";
            // 
            // txbNomePaciente
            // 
            txbNomePaciente.Location = new Point(537, 291);
            txbNomePaciente.Name = "txbNomePaciente";
            txbNomePaciente.Size = new Size(247, 23);
            txbNomePaciente.TabIndex = 1;
            txbNomePaciente.TextChanged += txbNomePaciente_TextChanged_1;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Image = Properties.Resources.btnEntrar;
            btnCancelar.Location = new Point(687, 442);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(152, 50);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnAgendar
            // 
            btnAgendar.FlatStyle = FlatStyle.Flat;
            btnAgendar.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgendar.ForeColor = SystemColors.ControlLightLight;
            btnAgendar.Image = Properties.Resources.btnEntrar;
            btnAgendar.Location = new Point(527, 442);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(154, 50);
            btnAgendar.TabIndex = 5;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click_1;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(388, 328);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(103, 15);
            lbl3.TabIndex = 6;
            lbl3.Text = "Nome do Médico:";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(388, 371);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(130, 15);
            lbl4.TabIndex = 8;
            lbl4.Text = "Data do Agendamento:";
            // 
            // txbNomeMedico
            // 
            txbNomeMedico.Location = new Point(537, 320);
            txbNomeMedico.Name = "txbNomeMedico";
            txbNomeMedico.Size = new Size(247, 23);
            txbNomeMedico.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.ForeColor = SystemColors.ControlLightLight;
            btnCadastrar.Image = Properties.Resources.btnEntrar;
            btnCadastrar.Location = new Point(527, 498);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(314, 50);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CalendarForeColor = SystemColors.WindowText;
            dateTimePicker1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(537, 366);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(247, 22);
            dateTimePicker1.TabIndex = 11;
            // 
            // AgendamentoPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.telaMenu;
            ClientSize = new Size(1424, 985);
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