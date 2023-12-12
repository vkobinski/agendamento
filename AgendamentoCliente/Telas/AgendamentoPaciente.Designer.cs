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
            dateTimePicker1 = new DateTimePicker();
            txbNomePaciente = new TextBox();
            btnCancelar = new Button();
            btnAgendar = new Button();
            txbNomeMedico = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            label3 = new Label();
            panel18 = new Panel();
            label4 = new Label();
            txbNascimento = new TextBox();
            panel19 = new Panel();
            panel20 = new Panel();
            panel21 = new Panel();
            panel22 = new Panel();
            panel23 = new Panel();
            panel24 = new Panel();
            panel25 = new Panel();
            panel26 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel15.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel21.SuspendLayout();
            panel24.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.CalendarFont = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CalendarForeColor = SystemColors.WindowText;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.ControlText;
            dateTimePicker1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(529, 661);
            dateTimePicker1.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(326, 40);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.KeyPress += dateTimePicker1_KeyPress;
            // 
            // txbNomePaciente
            // 
            txbNomePaciente.Anchor = AnchorStyles.None;
            txbNomePaciente.BorderStyle = BorderStyle.None;
            txbNomePaciente.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txbNomePaciente.Location = new Point(529, 400);
            txbNomePaciente.Margin = new Padding(3, 4, 3, 4);
            txbNomePaciente.Name = "txbNomePaciente";
            txbNomePaciente.Size = new Size(592, 33);
            txbNomePaciente.TabIndex = 0;
            txbNomePaciente.KeyDown += txbNomePaciente_KeyDown;
            txbNomePaciente.KeyPress += txbNomePaciente_KeyPress;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.FromArgb(1, 140, 241);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(893, 911);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(229, 51);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgendar
            // 
            btnAgendar.Anchor = AnchorStyles.None;
            btnAgendar.BackColor = Color.FromArgb(1, 140, 241);
            btnAgendar.FlatStyle = FlatStyle.Flat;
            btnAgendar.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgendar.ForeColor = SystemColors.ControlLightLight;
            btnAgendar.Location = new Point(529, 911);
            btnAgendar.Margin = new Padding(3, 4, 3, 4);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(229, 51);
            btnAgendar.TabIndex = 5;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // txbNomeMedico
            // 
            txbNomeMedico.Anchor = AnchorStyles.None;
            txbNomeMedico.BorderStyle = BorderStyle.None;
            txbNomeMedico.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txbNomeMedico.Location = new Point(529, 536);
            txbNomeMedico.Margin = new Padding(3, 4, 3, 4);
            txbNomeMedico.Name = "txbNomeMedico";
            txbNomeMedico.Size = new Size(592, 33);
            txbNomeMedico.TabIndex = 1;
            txbNomeMedico.KeyDown += txbNomeMedico_KeyDown;
            txbNomeMedico.KeyPress += txbNomeMedico_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 140, 241);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1648, 119);
            panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(157, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 103);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(1, 140, 241);
            label1.Location = new Point(746, 280);
            label1.Name = "label1";
            label1.Size = new Size(179, 54);
            label1.TabIndex = 18;
            label1.Text = "Agendar";
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.None;
            panel10.BackColor = Color.FromArgb(1, 140, 241);
            panel10.Controls.Add(panel11);
            panel10.Controls.Add(panel15);
            panel10.Controls.Add(panel17);
            panel10.Location = new Point(529, 439);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(589, 1);
            panel10.TabIndex = 23;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(1, 140, 241);
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(panel14);
            panel11.Location = new Point(0, 137);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(360, 1);
            panel11.TabIndex = 17;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(1, 140, 241);
            panel12.Controls.Add(panel13);
            panel12.Location = new Point(0, 63);
            panel12.Margin = new Padding(3, 4, 3, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(360, 1);
            panel12.TabIndex = 16;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(1, 140, 241);
            panel13.Location = new Point(0, 0);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(360, 1);
            panel13.TabIndex = 15;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(1, 140, 241);
            panel14.Location = new Point(0, 0);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Size = new Size(360, 1);
            panel14.TabIndex = 15;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(1, 140, 241);
            panel15.Controls.Add(panel16);
            panel15.Location = new Point(0, 63);
            panel15.Margin = new Padding(3, 4, 3, 4);
            panel15.Name = "panel15";
            panel15.Size = new Size(360, 1);
            panel15.TabIndex = 16;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(1, 140, 241);
            panel16.Location = new Point(0, 0);
            panel16.Margin = new Padding(3, 4, 3, 4);
            panel16.Name = "panel16";
            panel16.Size = new Size(360, 1);
            panel16.TabIndex = 15;
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(1, 140, 241);
            panel17.Location = new Point(0, 29);
            panel17.Margin = new Padding(3, 4, 3, 4);
            panel17.Name = "panel17";
            panel17.Size = new Size(360, 1);
            panel17.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(1, 140, 241);
            label2.Location = new Point(529, 447);
            label2.Name = "label2";
            label2.Size = new Size(220, 33);
            label2.TabIndex = 22;
            label2.Text = "Nome do Paciente";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(1, 140, 241);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel9);
            panel2.Location = new Point(529, 575);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(589, 1);
            panel2.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(1, 140, 241);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(0, 137);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 1);
            panel3.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(1, 140, 241);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 63);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(360, 1);
            panel4.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(1, 140, 241);
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(360, 1);
            panel5.TabIndex = 15;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(1, 140, 241);
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(360, 1);
            panel6.TabIndex = 15;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(1, 140, 241);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(0, 63);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(360, 1);
            panel7.TabIndex = 16;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(1, 140, 241);
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(360, 1);
            panel8.TabIndex = 15;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(1, 140, 241);
            panel9.Location = new Point(0, 29);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(360, 1);
            panel9.TabIndex = 15;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(1, 140, 241);
            label3.Location = new Point(529, 581);
            label3.Name = "label3";
            label3.Size = new Size(210, 33);
            label3.TabIndex = 24;
            label3.Text = "Nome do Médico";
            // 
            // panel18
            // 
            panel18.Anchor = AnchorStyles.None;
            panel18.BackColor = Color.FromArgb(1, 140, 241);
            panel18.Location = new Point(529, 707);
            panel18.Margin = new Padding(3, 4, 3, 4);
            panel18.Name = "panel18";
            panel18.Size = new Size(589, 1);
            panel18.TabIndex = 27;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(1, 140, 241);
            label4.Location = new Point(529, 713);
            label4.Name = "label4";
            label4.Size = new Size(346, 33);
            label4.TabIndex = 26;
            label4.Text = "Data e Hora do Agendamento";
            // 
            // txbNascimento
            // 
            txbNascimento.Anchor = AnchorStyles.None;
            txbNascimento.BorderStyle = BorderStyle.None;
            txbNascimento.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txbNascimento.ForeColor = Color.Black;
            txbNascimento.Location = new Point(1128, 400);
            txbNascimento.Margin = new Padding(3, 4, 3, 4);
            txbNascimento.Name = "txbNascimento";
            txbNascimento.Size = new Size(166, 33);
            txbNascimento.TabIndex = 28;
            // 
            // panel19
            // 
            panel19.Anchor = AnchorStyles.None;
            panel19.BackColor = Color.FromArgb(1, 140, 241);
            panel19.Controls.Add(panel20);
            panel19.Controls.Add(panel24);
            panel19.Controls.Add(panel26);
            panel19.Location = new Point(1129, 439);
            panel19.Margin = new Padding(3, 4, 3, 4);
            panel19.Name = "panel19";
            panel19.Size = new Size(165, 1);
            panel19.TabIndex = 24;
            // 
            // panel20
            // 
            panel20.BackColor = Color.FromArgb(1, 140, 241);
            panel20.Controls.Add(panel21);
            panel20.Controls.Add(panel23);
            panel20.Location = new Point(0, 137);
            panel20.Margin = new Padding(3, 4, 3, 4);
            panel20.Name = "panel20";
            panel20.Size = new Size(360, 1);
            panel20.TabIndex = 17;
            // 
            // panel21
            // 
            panel21.BackColor = Color.FromArgb(1, 140, 241);
            panel21.Controls.Add(panel22);
            panel21.Location = new Point(0, 63);
            panel21.Margin = new Padding(3, 4, 3, 4);
            panel21.Name = "panel21";
            panel21.Size = new Size(360, 1);
            panel21.TabIndex = 16;
            // 
            // panel22
            // 
            panel22.BackColor = Color.FromArgb(1, 140, 241);
            panel22.Location = new Point(0, 0);
            panel22.Margin = new Padding(3, 4, 3, 4);
            panel22.Name = "panel22";
            panel22.Size = new Size(360, 1);
            panel22.TabIndex = 15;
            // 
            // panel23
            // 
            panel23.BackColor = Color.FromArgb(1, 140, 241);
            panel23.Location = new Point(0, 0);
            panel23.Margin = new Padding(3, 4, 3, 4);
            panel23.Name = "panel23";
            panel23.Size = new Size(360, 1);
            panel23.TabIndex = 15;
            // 
            // panel24
            // 
            panel24.BackColor = Color.FromArgb(1, 140, 241);
            panel24.Controls.Add(panel25);
            panel24.Location = new Point(0, 63);
            panel24.Margin = new Padding(3, 4, 3, 4);
            panel24.Name = "panel24";
            panel24.Size = new Size(360, 1);
            panel24.TabIndex = 16;
            // 
            // panel25
            // 
            panel25.BackColor = Color.FromArgb(1, 140, 241);
            panel25.Location = new Point(0, 0);
            panel25.Margin = new Padding(3, 4, 3, 4);
            panel25.Name = "panel25";
            panel25.Size = new Size(360, 1);
            panel25.TabIndex = 15;
            // 
            // panel26
            // 
            panel26.BackColor = Color.FromArgb(1, 140, 241);
            panel26.Location = new Point(0, 29);
            panel26.Margin = new Padding(3, 4, 3, 4);
            panel26.Name = "panel26";
            panel26.Size = new Size(360, 1);
            panel26.TabIndex = 15;
            // 
            // AgendamentoPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1648, 1055);
            Controls.Add(panel19);
            Controls.Add(txbNascimento);
            Controls.Add(panel18);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel10);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txbNomeMedico);
            Controls.Add(btnAgendar);
            Controls.Add(btnCancelar);
            Controls.Add(txbNomePaciente);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AgendamentoPaciente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendamento";
            WindowState = FormWindowState.Maximized;
            FormClosing += AgendamentoPaciente_FormClosing;
            Load += AgendamentoPaciente_Load_1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel24.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txbNomePaciente;
        private Button btnCancelar;
        private Button btnAgendar;
        private TextBox txbNomeMedico;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Label label3;
        private Panel panel18;
        private Label label4;
        private TextBox txbNascimento;
        private Panel panel19;
        private Panel panel20;
        private Panel panel21;
        private Panel panel22;
        private Panel panel23;
        private Panel panel24;
        private Panel panel25;
        private Panel panel26;
    }
}