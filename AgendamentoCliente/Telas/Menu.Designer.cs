namespace AgendamentoCliente.Telas
{
    partial class Menu
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
            btnAgendar = new Button();
            btnDesmarcar = new Button();
            btnCadastrar = new Button();
            btnRemover = new Button();
            visualizaPaciente = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            DataNascimento = new DataGridViewTextBoxColumn();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)visualizaPaciente).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.Location = new Point(296, 43);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(128, 23);
            lbl1.TabIndex = 0;
            lbl1.Text = "LAYOUT TESTE";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(24, 89);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(87, 15);
            lbl2.TabIndex = 1;
            lbl2.Text = "Lista Pacientes:";
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(584, 89);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(113, 23);
            btnAgendar.TabIndex = 2;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnDesmarcar
            // 
            btnDesmarcar.Location = new Point(584, 133);
            btnDesmarcar.Name = "btnDesmarcar";
            btnDesmarcar.Size = new Size(113, 23);
            btnDesmarcar.TabIndex = 3;
            btnDesmarcar.Text = "Desmarcar";
            btnDesmarcar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(584, 173);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(113, 23);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar Médico";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(584, 215);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(113, 23);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover Médico";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click_1;
            // 
            // visualizaPaciente
            // 
            visualizaPaciente.BackgroundColor = SystemColors.Control;
            visualizaPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visualizaPaciente.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, DataNascimento });
            visualizaPaciente.Location = new Point(22, 126);
            visualizaPaciente.Margin = new Padding(3, 2, 3, 2);
            visualizaPaciente.Name = "visualizaPaciente";
            visualizaPaciente.RowHeadersWidth = 51;
            visualizaPaciente.RowTemplate.Height = 29;
            visualizaPaciente.Size = new Size(542, 290);
            visualizaPaciente.TabIndex = 6;
            visualizaPaciente.CellContentClick += visualizaPaciente_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            // 
            // DataNascimento
            // 
            DataNascimento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataNascimento.HeaderText = "Data de Atendimento";
            DataNascimento.MinimumWidth = 6;
            DataNascimento.Name = "DataNascimento";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(22, 421);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 560);
            Controls.Add(btnAtualizar);
            Controls.Add(visualizaPaciente);
            Controls.Add(btnRemover);
            Controls.Add(btnCadastrar);
            Controls.Add(btnDesmarcar);
            Controls.Add(btnAgendar);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            MaximizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BemVindo";
            Load += Menu_Load_1;
            ((System.ComponentModel.ISupportInitialize)visualizaPaciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Button btnAgendar;
        private Button btnDesmarcar;
        private Button btnCadastrar;
        private Button btnRemover;
        private DataGridView visualizaPaciente;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn DataNascimento;
        private Button btnAtualizar;
    }
}