namespace HairLumos.Views
{
    partial class Cadastro_Pacotes
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.ttbPacote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ttbObs = new System.Windows.Forms.TextBox();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbPeriodicidade = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ttbQtdeServico = new System.Windows.Forms.TextBox();
            this.cbbServico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIncluirServico = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPacote = new System.Windows.Forms.DataGridView();
            this.Servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodicidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcuirServico = new System.Windows.Forms.Button();
            this.Código = new System.Windows.Forms.Label();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacote)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.Código);
            this.splitContainer1.Panel1.Controls.Add(this.ttbCodigo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.splitContainer1.Panel2.Controls.Add(this.btnPesquisa);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnSair);
            this.splitContainer1.Panel2.Controls.Add(this.btnExcluir);
            this.splitContainer1.Panel2.Controls.Add(this.btnGravar);
            this.splitContainer1.Panel2.Controls.Add(this.btnNovo);
            this.splitContainer1.Size = new System.Drawing.Size(696, 418);
            this.splitContainer1.SplitterDistance = 365;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dtpDataInicio);
            this.groupBox3.Controls.Add(this.ttbPacote);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.ttbObs);
            this.groupBox3.Controls.Add(this.mskValor);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(21, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(659, 95);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações Pacote";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbSim);
            this.groupBox4.Controls.Add(this.rbNao);
            this.groupBox4.Controls.Add(this.dtpDataFim);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(6, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(332, 39);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "O Pacote terá data final?";
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(6, 19);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(44, 17);
            this.rbSim.TabIndex = 38;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "SIM";
            this.rbSim.UseVisualStyleBackColor = true;
            this.rbSim.CheckedChanged += new System.EventHandler(this.rbSim_CheckedChanged);
            this.rbSim.Click += new System.EventHandler(this.rbSim_Click);
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(75, 19);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(48, 17);
            this.rbNao.TabIndex = 37;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "NÃO";
            this.rbNao.UseVisualStyleBackColor = true;
            this.rbNao.Click += new System.EventHandler(this.rbNao_Click);
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.Location = new System.Drawing.Point(198, 13);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(96, 20);
            this.dtpDataFim.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data Fim:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Pacote:";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(81, 19);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(97, 20);
            this.dtpDataInicio.TabIndex = 0;
            // 
            // ttbPacote
            // 
            this.ttbPacote.Location = new System.Drawing.Point(399, 19);
            this.ttbPacote.Name = "ttbPacote";
            this.ttbPacote.Size = new System.Drawing.Size(254, 20);
            this.ttbPacote.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Data Início:";
            // 
            // ttbObs
            // 
            this.ttbObs.BackColor = System.Drawing.SystemColors.Window;
            this.ttbObs.Location = new System.Drawing.Point(399, 63);
            this.ttbObs.Multiline = true;
            this.ttbObs.Name = "ttbObs";
            this.ttbObs.Size = new System.Drawing.Size(254, 23);
            this.ttbObs.TabIndex = 3;
            // 
            // mskValor
            // 
            this.mskValor.Location = new System.Drawing.Point(254, 19);
            this.mskValor.Name = "mskValor";
            this.mskValor.Size = new System.Drawing.Size(84, 20);
            this.mskValor.TabIndex = 1;
            this.mskValor.Enter += new System.EventHandler(this.mskValor_Enter);
            this.mskValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskValor_KeyPress);
            this.mskValor.Leave += new System.EventHandler(this.mskValor_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Observação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Valor (R$)*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbPeriodicidade);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ttbQtdeServico);
            this.groupBox2.Controls.Add(this.cbbServico);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnIncluirServico);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(21, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 84);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviços do Pacote";
            // 
            // cbbPeriodicidade
            // 
            this.cbbPeriodicidade.FormattingEnabled = true;
            this.cbbPeriodicidade.Items.AddRange(new object[] {
            "UMA VEZ",
            "SEMANAL",
            "QUINZENAL",
            "MENSAL"});
            this.cbbPeriodicidade.Location = new System.Drawing.Point(116, 46);
            this.cbbPeriodicidade.Name = "cbbPeriodicidade";
            this.cbbPeriodicidade.Size = new System.Drawing.Size(143, 21);
            this.cbbPeriodicidade.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Qtde do Servico*";
            // 
            // ttbQtdeServico
            // 
            this.ttbQtdeServico.Location = new System.Drawing.Point(359, 49);
            this.ttbQtdeServico.Name = "ttbQtdeServico";
            this.ttbQtdeServico.Size = new System.Drawing.Size(72, 20);
            this.ttbQtdeServico.TabIndex = 3;
            // 
            // cbbServico
            // 
            this.cbbServico.FormattingEnabled = true;
            this.cbbServico.Location = new System.Drawing.Point(117, 16);
            this.cbbServico.Name = "cbbServico";
            this.cbbServico.Size = new System.Drawing.Size(428, 21);
            this.cbbServico.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Serviço*";
            // 
            // btnIncluirServico
            // 
            this.btnIncluirServico.BackColor = System.Drawing.Color.White;
            this.btnIncluirServico.Location = new System.Drawing.Point(476, 45);
            this.btnIncluirServico.Name = "btnIncluirServico";
            this.btnIncluirServico.Size = new System.Drawing.Size(69, 27);
            this.btnIncluirServico.TabIndex = 4;
            this.btnIncluirServico.Text = "Incluir";
            this.btnIncluirServico.UseVisualStyleBackColor = false;
            this.btnIncluirServico.Click += new System.EventHandler(this.btnIncluirServico_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Periodicidade*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPacote);
            this.groupBox1.Controls.Add(this.btnExcuirServico);
            this.groupBox1.Location = new System.Drawing.Point(21, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 137);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Serviço do Pacote";
            // 
            // dgvPacote
            // 
            this.dgvPacote.AllowUserToAddRows = false;
            this.dgvPacote.AllowUserToDeleteRows = false;
            this.dgvPacote.BackgroundColor = System.Drawing.Color.White;
            this.dgvPacote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Servico,
            this.Quantidade,
            this.Periodicidade});
            this.dgvPacote.Location = new System.Drawing.Point(6, 23);
            this.dgvPacote.Name = "dgvPacote";
            this.dgvPacote.ReadOnly = true;
            this.dgvPacote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacote.Size = new System.Drawing.Size(572, 108);
            this.dgvPacote.TabIndex = 13;
            this.dgvPacote.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacote_CellDoubleClick_1);
            // 
            // Servico
            // 
            this.Servico.DataPropertyName = "Servico";
            this.Servico.HeaderText = "Serviço";
            this.Servico.Name = "Servico";
            this.Servico.ReadOnly = true;
            this.Servico.Width = 250;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Qtde Serv.";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Periodicidade
            // 
            this.Periodicidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Periodicidade.DataPropertyName = "Periodicidade";
            this.Periodicidade.HeaderText = "Periodicidade";
            this.Periodicidade.Name = "Periodicidade";
            this.Periodicidade.ReadOnly = true;
            // 
            // btnExcuirServico
            // 
            this.btnExcuirServico.BackColor = System.Drawing.Color.White;
            this.btnExcuirServico.Location = new System.Drawing.Point(584, 70);
            this.btnExcuirServico.Name = "btnExcuirServico";
            this.btnExcuirServico.Size = new System.Drawing.Size(69, 27);
            this.btnExcuirServico.TabIndex = 0;
            this.btnExcuirServico.Text = "Excluir";
            this.btnExcuirServico.UseVisualStyleBackColor = false;
            this.btnExcuirServico.Click += new System.EventHandler(this.btnExcuirServico_Click);
            // 
            // Código
            // 
            this.Código.AutoSize = true;
            this.Código.Location = new System.Drawing.Point(18, 12);
            this.Código.Name = "Código";
            this.Código.Size = new System.Drawing.Size(40, 13);
            this.Código.TabIndex = 6;
            this.Código.Text = "Código";
            // 
            // ttbCodigo
            // 
            this.ttbCodigo.Enabled = false;
            this.ttbCodigo.Location = new System.Drawing.Point(64, 9);
            this.ttbCodigo.Name = "ttbCodigo";
            this.ttbCodigo.Size = new System.Drawing.Size(100, 20);
            this.ttbCodigo.TabIndex = 7;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.White;
            this.btnPesquisa.Location = new System.Drawing.Point(182, 7);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 38);
            this.btnPesquisa.TabIndex = 3;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(344, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 38);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(605, 7);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 38);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(263, 7);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 38);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.White;
            this.btnGravar.Location = new System.Drawing.Point(102, 7);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 38);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click_1);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(21, 7);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 38);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // Cadastro_Pacotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(720, 442);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Cadastro_Pacotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H.L - GERENCIAR PACOTES";
            this.Load += new System.EventHandler(this.Cadastro_Pacotes_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Label Código;
        public System.Windows.Forms.TextBox ttbCodigo;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPacote;
        public System.Windows.Forms.Button btnExcuirServico;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbServico;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnIncluirServico;
        private System.Windows.Forms.MaskedTextBox mskValor;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox ttbObs;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox ttbPacote;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox ttbQtdeServico;
        public System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodicidade;
        private System.Windows.Forms.ComboBox cbbPeriodicidade;
    }
}