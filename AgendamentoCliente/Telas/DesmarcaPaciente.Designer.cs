namespace AgendamentoCliente.Telas
{
    partial class DesmarcaPaciente
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
            lbl2 = new Label();
            txbNomePaciente = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnDesmarcar = new Button();
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
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(57, 104);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(117, 15);
            lbl2.TabIndex = 3;
            lbl2.Text = "Data de Nascimento:";
            // 
            // txbNomePaciente
            // 
            txbNomePaciente.Location = new Point(181, 58);
            txbNomePaciente.Name = "txbNomePaciente";
            txbNomePaciente.Size = new Size(247, 23);
            txbNomePaciente.TabIndex = 4;
            txbNomePaciente.TextChanged += txbNomePaciente_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(181, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(247, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // btnDesmarcar
            // 
            btnDesmarcar.Location = new Point(181, 230);
            btnDesmarcar.Name = "btnDesmarcar";
            btnDesmarcar.Size = new Size(101, 23);
            btnDesmarcar.TabIndex = 6;
            btnDesmarcar.Text = "Desmarcar";
            btnDesmarcar.UseVisualStyleBackColor = true;
            btnDesmarcar.Click += btnDesmarcar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(327, 230);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // DesmarcaPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 306);
            Controls.Add(btnCancelar);
            Controls.Add(btnDesmarcar);
            Controls.Add(dateTimePicker1);
            Controls.Add(txbNomePaciente);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DesmarcaPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Desmarcar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private TextBox txbNomePaciente;
        private DateTimePicker dateTimePicker1;
        private Button btnDesmarcar;
        private Button btnCancelar;
    }
}