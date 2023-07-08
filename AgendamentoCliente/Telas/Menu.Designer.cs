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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.visualizaPaciente = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrarPaciente = new System.Windows.Forms.Button();
            this.idAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.visualizaPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgendar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgendar.Image = global::AgendamentoCliente.Properties.Resources.btnEntrar;
            this.btnAgendar.Location = new System.Drawing.Point(1112, 343);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(200, 48);
            this.btnAgendar.TabIndex = 2;
            this.btnAgendar.Text = "Agendar Paciente";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click_1);
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDesmarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesmarcar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDesmarcar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDesmarcar.Image = global::AgendamentoCliente.Properties.Resources.btnEntrar;
            this.btnDesmarcar.Location = new System.Drawing.Point(408, 740);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(200, 50);
            this.btnDesmarcar.TabIndex = 3;
            this.btnDesmarcar.Text = "Desmarcar Paciente";
            this.btnDesmarcar.UseVisualStyleBackColor = false;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click_1);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Image = global::AgendamentoCliente.Properties.Resources.btnEntrar;
            this.btnCadastrar.Location = new System.Drawing.Point(1112, 434);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(200, 48);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar Médico";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemover.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemover.Image = global::AgendamentoCliente.Properties.Resources.btnEntrar;
            this.btnRemover.Location = new System.Drawing.Point(1112, 529);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(200, 50);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover Médico";
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // visualizaPaciente
            // 
            this.visualizaPaciente.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.visualizaPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.visualizaPaciente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.visualizaPaciente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(4)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.visualizaPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.visualizaPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visualizaPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAtendimento,
            this.ID,
            this.Nome,
            this.DataNascimento});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.visualizaPaciente.DefaultCellStyle = dataGridViewCellStyle2;
            this.visualizaPaciente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(4)))), ((int)(((byte)(44)))));
            this.visualizaPaciente.Location = new System.Drawing.Point(94, 321);
            this.visualizaPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visualizaPaciente.Name = "visualizaPaciente";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(4)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.visualizaPaciente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.visualizaPaciente.RowHeadersVisible = false;
            this.visualizaPaciente.RowHeadersWidth = 51;
            this.visualizaPaciente.RowTemplate.Height = 29;
            this.visualizaPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visualizaPaciente.Size = new System.Drawing.Size(865, 335);
            this.visualizaPaciente.TabIndex = 6;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtualizar.Image = global::AgendamentoCliente.Properties.Resources.btnEntrar;
            this.btnAtualizar.Location = new System.Drawing.Point(138, 740);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(200, 50);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // btnCadastrarPaciente
            // 
            this.btnCadastrarPaciente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarPaciente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarPaciente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarPaciente.Image = global::AgendamentoCliente.Properties.Resources.btnEntrar;
            this.btnCadastrarPaciente.Location = new System.Drawing.Point(1097, 615);
            this.btnCadastrarPaciente.Name = "btnCadastrarPaciente";
            this.btnCadastrarPaciente.Size = new System.Drawing.Size(215, 68);
            this.btnCadastrarPaciente.TabIndex = 8;
            this.btnCadastrarPaciente.Text = "Cadastrar Paciente";
            this.btnCadastrarPaciente.UseVisualStyleBackColor = false;
            // 
            // idAtendimento
            // 
            this.idAtendimento.HeaderText = "ID";
            this.idAtendimento.Name = "idAtendimento";
            this.idAtendimento.ReadOnly = true;
            this.idAtendimento.Visible = false;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "Médico";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Paciente";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgendamentoCliente.Properties.Resources.TelaMenu1;
            this.ClientSize = new System.Drawing.Size(1442, 791);
            this.Controls.Add(this.btnCadastrarPaciente);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.visualizaPaciente);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnDesmarcar);
            this.Controls.Add(this.btnAgendar);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.visualizaPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnAgendar;
        private Button btnDesmarcar;
        private Button btnCadastrar;
        private Button btnRemover;
        private DataGridView visualizaPaciente;
        private Button btnAtualizar;
        private Button btnCadastrarPaciente;
        private DataGridViewTextBoxColumn idAtendimento;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn DataNascimento;
    }
}