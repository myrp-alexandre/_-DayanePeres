namespace HairLumos.Views.Funcoes_Fundamentais.RF_F12_Gerenciar_Comissao
{
    partial class GerenciarComissao
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.mskTotal = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskTotalReceber = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTotalPagar = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbParceiro = new System.Windows.Forms.ComboBox();
            this.btnSelecionaUm = new System.Windows.Forms.GroupBox();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.rbReceber = new System.Windows.Forms.RadioButton();
            this.rbPagar = new System.Windows.Forms.RadioButton();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDtAte = new System.Windows.Forms.DateTimePicker();
            this.dtpDtDe = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAux = new System.Windows.Forms.DataGridView();
            this.btnVoltaTodos = new System.Windows.Forms.Button();
            this.btnVoltaUm = new System.Windows.Forms.Button();
            this.btnSelecionaTodos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvComissaoListadas = new System.Windows.Forms.DataGridView();
            this.btnExcuirServico = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnQuitarComissao = new System.Windows.Forms.Button();
            this.CodComis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.btnSelecionaUm.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAux)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComissaoListadas)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.btnVoltaTodos);
            this.splitContainer1.Panel1.Controls.Add(this.btnVoltaUm);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelecionaTodos);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnExcuirServico);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.splitContainer1.Panel2.Controls.Add(this.btnSair);
            this.splitContainer1.Panel2.Controls.Add(this.btnQuitarComissao);
            this.splitContainer1.Size = new System.Drawing.Size(1145, 450);
            this.splitContainer1.SplitterDistance = 391;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.mskTotal);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.mskTotalReceber);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.mskTotalPagar);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(532, 339);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(603, 43);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Valores:";
            // 
            // mskTotal
            // 
            this.mskTotal.Enabled = false;
            this.mskTotal.ForeColor = System.Drawing.Color.Blue;
            this.mskTotal.Location = new System.Drawing.Point(496, 17);
            this.mskTotal.Name = "mskTotal";
            this.mskTotal.Size = new System.Drawing.Size(100, 20);
            this.mskTotal.TabIndex = 5;
            this.mskTotal.Enter += new System.EventHandler(this.mskTotal_Enter);
            this.mskTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTotal_KeyPress);
            this.mskTotal.Leave += new System.EventHandler(this.mskTotal_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(439, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total(R$)";
            // 
            // mskTotalReceber
            // 
            this.mskTotalReceber.Enabled = false;
            this.mskTotalReceber.ForeColor = System.Drawing.Color.Green;
            this.mskTotalReceber.Location = new System.Drawing.Point(330, 17);
            this.mskTotalReceber.Name = "mskTotalReceber";
            this.mskTotalReceber.Size = new System.Drawing.Size(100, 20);
            this.mskTotalReceber.TabIndex = 3;
            this.mskTotalReceber.Enter += new System.EventHandler(this.mskTotalReceber_Enter);
            this.mskTotalReceber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTotalReceber_KeyPress);
            this.mskTotalReceber.Leave += new System.EventHandler(this.mskTotalReceber_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(217, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total a Receber (R$)";
            // 
            // mskTotalPagar
            // 
            this.mskTotalPagar.Enabled = false;
            this.mskTotalPagar.ForeColor = System.Drawing.Color.Red;
            this.mskTotalPagar.Location = new System.Drawing.Point(107, 17);
            this.mskTotalPagar.Name = "mskTotalPagar";
            this.mskTotalPagar.Size = new System.Drawing.Size(100, 20);
            this.mskTotalPagar.TabIndex = 1;
            this.mskTotalPagar.Enter += new System.EventHandler(this.mskTotalPagar_Enter);
            this.mskTotalPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTotalPagar_KeyPress);
            this.mskTotalPagar.Leave += new System.EventHandler(this.mskTotalPagar_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total a Pagar (R$)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbParceiro);
            this.groupBox3.Controls.Add(this.btnSelecionaUm);
            this.groupBox3.Controls.Add(this.btnPesquisa);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dtpDtAte);
            this.groupBox3.Controls.Add(this.dtpDtDe);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(16, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1119, 124);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações de Comissão";
            // 
            // cbbParceiro
            // 
            this.cbbParceiro.FormattingEnabled = true;
            this.cbbParceiro.Location = new System.Drawing.Point(275, 80);
            this.cbbParceiro.Name = "cbbParceiro";
            this.cbbParceiro.Size = new System.Drawing.Size(509, 21);
            this.cbbParceiro.TabIndex = 15;
            // 
            // btnSelecionaUm
            // 
            this.btnSelecionaUm.Controls.Add(this.rbTodas);
            this.btnSelecionaUm.Controls.Add(this.rbReceber);
            this.btnSelecionaUm.Controls.Add(this.rbPagar);
            this.btnSelecionaUm.Location = new System.Drawing.Point(702, 19);
            this.btnSelecionaUm.Name = "btnSelecionaUm";
            this.btnSelecionaUm.Size = new System.Drawing.Size(408, 50);
            this.btnSelecionaUm.TabIndex = 14;
            this.btnSelecionaUm.TabStop = false;
            this.btnSelecionaUm.Text = "Comissão:";
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.BackColor = System.Drawing.Color.Blue;
            this.rbTodas.Location = new System.Drawing.Point(331, 19);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(55, 17);
            this.rbTodas.TabIndex = 2;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas";
            this.rbTodas.UseVisualStyleBackColor = false;
            this.rbTodas.CheckedChanged += new System.EventHandler(this.rbTodas_CheckedChanged);
            // 
            // rbReceber
            // 
            this.rbReceber.AutoSize = true;
            this.rbReceber.BackColor = System.Drawing.Color.Green;
            this.rbReceber.Location = new System.Drawing.Point(178, 20);
            this.rbReceber.Name = "rbReceber";
            this.rbReceber.Size = new System.Drawing.Size(75, 17);
            this.rbReceber.TabIndex = 1;
            this.rbReceber.TabStop = true;
            this.rbReceber.Text = "a Receber";
            this.rbReceber.UseVisualStyleBackColor = false;
            this.rbReceber.CheckedChanged += new System.EventHandler(this.rbReceber_CheckedChanged);
            // 
            // rbPagar
            // 
            this.rbPagar.AutoSize = true;
            this.rbPagar.BackColor = System.Drawing.Color.Red;
            this.rbPagar.Location = new System.Drawing.Point(20, 20);
            this.rbPagar.Name = "rbPagar";
            this.rbPagar.Size = new System.Drawing.Size(62, 17);
            this.rbPagar.TabIndex = 0;
            this.rbPagar.TabStop = true;
            this.rbPagar.Text = "a Pagar";
            this.rbPagar.UseVisualStyleBackColor = false;
            this.rbPagar.CheckedChanged += new System.EventHandler(this.rbPagar_CheckedChanged);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.White;
            this.btnPesquisa.Location = new System.Drawing.Point(811, 75);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 29);
            this.btnPesquisa.TabIndex = 3;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parceiro:";
            // 
            // dtpDtAte
            // 
            this.dtpDtAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtAte.Location = new System.Drawing.Point(248, 30);
            this.dtpDtAte.Name = "dtpDtAte";
            this.dtpDtAte.Size = new System.Drawing.Size(114, 20);
            this.dtpDtAte.TabIndex = 1;
            // 
            // dtpDtDe
            // 
            this.dtpDtDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtDe.Location = new System.Drawing.Point(47, 30);
            this.dtpDtDe.Name = "dtpDtDe";
            this.dtpDtDe.Size = new System.Drawing.Size(114, 20);
            this.dtpDtDe.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Até";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "De:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAux);
            this.groupBox2.Location = new System.Drawing.Point(622, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 191);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parceiro Selecionados";
            // 
            // dgvAux
            // 
            this.dgvAux.AllowUserToAddRows = false;
            this.dgvAux.AllowUserToDeleteRows = false;
            this.dgvAux.BackgroundColor = System.Drawing.Color.White;
            this.dgvAux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAux.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvAux.Location = new System.Drawing.Point(9, 24);
            this.dgvAux.Name = "dgvAux";
            this.dgvAux.ReadOnly = true;
            this.dgvAux.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAux.Size = new System.Drawing.Size(498, 161);
            this.dgvAux.TabIndex = 14;
            // 
            // btnVoltaTodos
            // 
            this.btnVoltaTodos.BackColor = System.Drawing.Color.White;
            this.btnVoltaTodos.Location = new System.Drawing.Point(539, 271);
            this.btnVoltaTodos.Name = "btnVoltaTodos";
            this.btnVoltaTodos.Size = new System.Drawing.Size(69, 27);
            this.btnVoltaTodos.TabIndex = 3;
            this.btnVoltaTodos.Text = "<<";
            this.btnVoltaTodos.UseVisualStyleBackColor = false;
            this.btnVoltaTodos.Click += new System.EventHandler(this.btnVoltaTodos_Click);
            // 
            // btnVoltaUm
            // 
            this.btnVoltaUm.BackColor = System.Drawing.Color.White;
            this.btnVoltaUm.Location = new System.Drawing.Point(539, 238);
            this.btnVoltaUm.Name = "btnVoltaUm";
            this.btnVoltaUm.Size = new System.Drawing.Size(69, 27);
            this.btnVoltaUm.TabIndex = 2;
            this.btnVoltaUm.Text = "<";
            this.btnVoltaUm.UseVisualStyleBackColor = false;
            this.btnVoltaUm.Click += new System.EventHandler(this.btnVoltaUm_Click);
            // 
            // btnSelecionaTodos
            // 
            this.btnSelecionaTodos.BackColor = System.Drawing.Color.White;
            this.btnSelecionaTodos.Location = new System.Drawing.Point(539, 205);
            this.btnSelecionaTodos.Name = "btnSelecionaTodos";
            this.btnSelecionaTodos.Size = new System.Drawing.Size(69, 27);
            this.btnSelecionaTodos.TabIndex = 1;
            this.btnSelecionaTodos.Text = ">>";
            this.btnSelecionaTodos.UseVisualStyleBackColor = false;
            this.btnSelecionaTodos.Click += new System.EventHandler(this.btnSelecionaTodos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvComissaoListadas);
            this.groupBox1.Location = new System.Drawing.Point(10, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 191);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parceiros Listados";
            // 
            // dgvComissaoListadas
            // 
            this.dgvComissaoListadas.AllowUserToAddRows = false;
            this.dgvComissaoListadas.AllowUserToDeleteRows = false;
            this.dgvComissaoListadas.BackgroundColor = System.Drawing.Color.White;
            this.dgvComissaoListadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComissaoListadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodComis,
            this.Nome,
            this.Valor,
            this.Status,
            this.Data,
            this.Pagamento});
            this.dgvComissaoListadas.Location = new System.Drawing.Point(6, 23);
            this.dgvComissaoListadas.Name = "dgvComissaoListadas";
            this.dgvComissaoListadas.ReadOnly = true;
            this.dgvComissaoListadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComissaoListadas.Size = new System.Drawing.Size(498, 161);
            this.dgvComissaoListadas.TabIndex = 13;
            // 
            // btnExcuirServico
            // 
            this.btnExcuirServico.BackColor = System.Drawing.Color.White;
            this.btnExcuirServico.Location = new System.Drawing.Point(539, 172);
            this.btnExcuirServico.Name = "btnExcuirServico";
            this.btnExcuirServico.Size = new System.Drawing.Size(69, 27);
            this.btnExcuirServico.TabIndex = 0;
            this.btnExcuirServico.Text = ">";
            this.btnExcuirServico.UseVisualStyleBackColor = false;
            this.btnExcuirServico.Click += new System.EventHandler(this.btnExcuirServico_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(1053, 7);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 38);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnQuitarComissao
            // 
            this.btnQuitarComissao.BackColor = System.Drawing.Color.White;
            this.btnQuitarComissao.Location = new System.Drawing.Point(458, 7);
            this.btnQuitarComissao.Name = "btnQuitarComissao";
            this.btnQuitarComissao.Size = new System.Drawing.Size(280, 38);
            this.btnQuitarComissao.TabIndex = 1;
            this.btnQuitarComissao.Text = "Quitar";
            this.btnQuitarComissao.UseVisualStyleBackColor = false;
            this.btnQuitarComissao.Click += new System.EventHandler(this.btnQuitarComissao_Click);
            // 
            // CodComis
            // 
            this.CodComis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodComis.DataPropertyName = "CodComis";
            this.CodComis.HeaderText = "Cód";
            this.CodComis.Name = "CodComis";
            this.CodComis.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Parceiro";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor (R$)";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 80;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Comissão";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 80;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data do Serviço";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 80;
            // 
            // Pagamento
            // 
            this.Pagamento.DataPropertyName = "Pagamento";
            this.Pagamento.HeaderText = "Status";
            this.Pagamento.Name = "Pagamento";
            this.Pagamento.ReadOnly = true;
            this.Pagamento.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodComis";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Parceiro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor (R$)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn4.HeaderText = "Comissão";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data do Serviço";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Pagamento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // GerenciarComissao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1165, 474);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "GerenciarComissao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H.L - GERENCIAR COMISSÃO";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.btnSelecionaUm.ResumeLayout(false);
            this.btnSelecionaUm.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAux)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComissaoListadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvComissaoListadas;
        public System.Windows.Forms.Button btnExcuirServico;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnQuitarComissao;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnVoltaTodos;
        public System.Windows.Forms.Button btnVoltaUm;
        public System.Windows.Forms.Button btnSelecionaTodos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MaskedTextBox mskTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskTotalReceber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTotalPagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox btnSelecionaUm;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.RadioButton rbReceber;
        private System.Windows.Forms.RadioButton rbPagar;
        public System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDtAte;
        private System.Windows.Forms.DateTimePicker dtpDtDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAux;
        private System.Windows.Forms.ComboBox cbbParceiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodComis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}