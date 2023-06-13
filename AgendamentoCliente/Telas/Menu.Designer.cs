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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.visualizaPaciente = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.visualizaPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(338, 57);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(161, 29);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "LAYOUT TESTE";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(27, 119);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(107, 20);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Lista Pacientes:";
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(667, 119);
            this.btnAgendar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(129, 31);
            this.btnAgendar.TabIndex = 2;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.Location = new System.Drawing.Point(667, 177);
            this.btnDesmarcar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(129, 31);
            this.btnDesmarcar.TabIndex = 3;
            this.btnDesmarcar.Text = "Desmarcar";
            this.btnDesmarcar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(667, 231);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(129, 31);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar Médico";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(667, 287);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(129, 31);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover Médico";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click_1);
            // 
            // visualizaPaciente
            // 
            this.visualizaPaciente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.visualizaPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visualizaPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.DataNascimento});
            this.visualizaPaciente.Location = new System.Drawing.Point(25, 168);
            this.visualizaPaciente.Name = "visualizaPaciente";
            this.visualizaPaciente.RowHeadersWidth = 51;
            this.visualizaPaciente.RowTemplate.Height = 29;
            this.visualizaPaciente.Size = new System.Drawing.Size(620, 387);
            this.visualizaPaciente.TabIndex = 6;
            this.visualizaPaciente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.visualizaPaciente_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            // 
            // DataNascimento
            // 
            this.DataNascimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataNascimento.HeaderText = "Data de Atendimento";
            this.DataNascimento.MinimumWidth = 6;
            this.DataNascimento.Name = "DataNascimento";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 747);
            this.Controls.Add(this.visualizaPaciente);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnDesmarcar);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BemVindo";
            this.Load += new System.EventHandler(this.Menu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.visualizaPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}