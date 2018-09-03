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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPacote = new System.Windows.Forms.DataGridView();
            this.btnExcuirServico = new System.Windows.Forms.Button();
            this.Código = new System.Windows.Forms.Label();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbPeriodo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.btnIncluirServico = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ttbObs = new System.Windows.Forms.TextBox();
            this.cbbServico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacote)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnSair);
            this.splitContainer1.Panel2.Controls.Add(this.btnExcluir);
            this.splitContainer1.Panel2.Controls.Add(this.btnAlterar);
            this.splitContainer1.Panel2.Controls.Add(this.btnGravar);
            this.splitContainer1.Panel2.Controls.Add(this.btnNovo);
            this.splitContainer1.Size = new System.Drawing.Size(621, 418);
            this.splitContainer1.SplitterDistance = 365;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPacote);
            this.groupBox1.Controls.Add(this.btnExcuirServico);
            this.groupBox1.Location = new System.Drawing.Point(21, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 137);
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
            this.Codigo,
            this.ServicoNome,
            this.Valor});
            this.dgvPacote.Location = new System.Drawing.Point(6, 23);
            this.dgvPacote.Name = "dgvPacote";
            this.dgvPacote.ReadOnly = true;
            this.dgvPacote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacote.Size = new System.Drawing.Size(493, 108);
            this.dgvPacote.TabIndex = 13;
            this.dgvPacote.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacote_CellDoubleClick_1);
            // 
            // btnExcuirServico
            // 
            this.btnExcuirServico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcuirServico.Location = new System.Drawing.Point(512, 70);
            this.btnExcuirServico.Name = "btnExcuirServico";
            this.btnExcuirServico.Size = new System.Drawing.Size(69, 27);
            this.btnExcuirServico.TabIndex = 14;
            this.btnExcuirServico.Text = "Excluir";
            this.btnExcuirServico.UseVisualStyleBackColor = false;
            this.btnExcuirServico.Click += new System.EventHandler(this.btnExcuirServico_Click);
            // 
            // Código
            // 
            this.Código.AutoSize = true;
            this.Código.Location = new System.Drawing.Point(18, 18);
            this.Código.Name = "Código";
            this.Código.Size = new System.Drawing.Size(40, 13);
            this.Código.TabIndex = 6;
            this.Código.Text = "Código";
            // 
            // ttbCodigo
            // 
            this.ttbCodigo.Location = new System.Drawing.Point(64, 15);
            this.ttbCodigo.Name = "ttbCodigo";
            this.ttbCodigo.Size = new System.Drawing.Size(100, 20);
            this.ttbCodigo.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(345, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 38);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Location = new System.Drawing.Point(533, 7);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 38);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluir.Location = new System.Drawing.Point(264, 7);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 38);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlterar.Location = new System.Drawing.Point(183, 7);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 38);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGravar.Location = new System.Drawing.Point(102, 7);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 38);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click_1);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovo.Location = new System.Drawing.Point(21, 7);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 38);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Valor (R$)*";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ttbPeriodo
            // 
            this.ttbPeriodo.Location = new System.Drawing.Point(117, 49);
            this.ttbPeriodo.Name = "ttbPeriodo";
            this.ttbPeriodo.Size = new System.Drawing.Size(142, 20);
            this.ttbPeriodo.TabIndex = 30;
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
            // mskValor
            // 
            this.mskValor.Location = new System.Drawing.Point(491, 19);
            this.mskValor.Name = "mskValor";
            this.mskValor.Size = new System.Drawing.Size(84, 20);
            this.mskValor.TabIndex = 31;
            this.mskValor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskValor_MaskInputRejected);
            // 
            // btnIncluirServico
            // 
            this.btnIncluirServico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIncluirServico.Location = new System.Drawing.Point(506, 39);
            this.btnIncluirServico.Name = "btnIncluirServico";
            this.btnIncluirServico.Size = new System.Drawing.Size(69, 27);
            this.btnIncluirServico.TabIndex = 28;
            this.btnIncluirServico.Text = "Incluir";
            this.btnIncluirServico.UseVisualStyleBackColor = false;
            this.btnIncluirServico.Click += new System.EventHandler(this.btnIncluirServico_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbServico);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnIncluirServico);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ttbPeriodo);
            this.groupBox2.Location = new System.Drawing.Point(21, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 84);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviços do Pacote";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(81, 19);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(127, 20);
            this.dtpDataInicio.TabIndex = 33;
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.Location = new System.Drawing.Point(284, 19);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(126, 20);
            this.dtpDataFim.TabIndex = 34;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Data Fim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Observação Pacote:";
            // 
            // ttbObs
            // 
            this.ttbObs.BackColor = System.Drawing.SystemColors.Window;
            this.ttbObs.Location = new System.Drawing.Point(117, 48);
            this.ttbObs.Multiline = true;
            this.ttbObs.Name = "ttbObs";
            this.ttbObs.Size = new System.Drawing.Size(458, 26);
            this.ttbObs.TabIndex = 19;
            // 
            // cbbServico
            // 
            this.cbbServico.FormattingEnabled = true;
            this.cbbServico.Location = new System.Drawing.Point(117, 16);
            this.cbbServico.Name = "cbbServico";
            this.cbbServico.Size = new System.Drawing.Size(343, 21);
            this.cbbServico.TabIndex = 38;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpDataInicio);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtpDataFim);
            this.groupBox3.Controls.Add(this.ttbObs);
            this.groupBox3.Controls.Add(this.mskValor);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(21, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(581, 82);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações Pacote";
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Cód Serv.";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // ServicoNome
            // 
            this.ServicoNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServicoNome.DataPropertyName = "ServicoNome";
            this.ServicoNome.HeaderText = "Serviço";
            this.ServicoNome.Name = "ServicoNome";
            this.ServicoNome.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor (R$)";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Cadastro_Pacotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(645, 442);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Cadastro_Pacotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H.L - GERENCIAR PACOTES";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacote)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Label Código;
        public System.Windows.Forms.TextBox ttbCodigo;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnAlterar;
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
        public System.Windows.Forms.TextBox ttbPeriodo;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox ttbObs;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicoNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}