namespace HairLumos.Views
{
    partial class Cadastro_Pessoa
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPagaNao = new System.Windows.Forms.RadioButton();
            this.rbPagaSim = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tabcInformaçõesPessoa = new System.Windows.Forms.TabControl();
            this.Endereço = new System.Windows.Forms.TabPage();
            this.pnlEndereco = new System.Windows.Forms.Panel();
            this.btnSalvarEndereco = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbCidade = new System.Windows.Forms.ComboBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ttbCep = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ttbComplemento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ttbBairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ttbNumero = new System.Windows.Forms.TextBox();
            this.ttbLogradouro = new System.Windows.Forms.TextBox();
            this.dgvEndereço = new System.Windows.Forms.DataGridView();
            this.btnIncluirEndereco = new System.Windows.Forms.Button();
            this.Contato = new System.Windows.Forms.TabPage();
            this.pnlContato = new System.Windows.Forms.Panel();
            this.btnSalvarContato = new System.Windows.Forms.Button();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dgvContato = new System.Windows.Forms.DataGridView();
            this.btnIncluirContato = new System.Windows.Forms.Button();
            this.Financeiro = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Observações = new System.Windows.Forms.TabPage();
            this.pnlObservacao = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ttbRg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ttbRazao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Código = new System.Windows.Forms.Label();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnFormaPagamento = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabcInformaçõesPessoa.SuspendLayout();
            this.Endereço.SuspendLayout();
            this.pnlEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereço)).BeginInit();
            this.Contato.SuspendLayout();
            this.pnlContato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).BeginInit();
            this.Financeiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Observações.SuspendLayout();
            this.pnlObservacao.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.mskCNPJ);
            this.splitContainer1.Panel1.Controls.Add(this.mskCPF);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.dtpDataNascimento);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.rbInativo);
            this.splitContainer1.Panel1.Controls.Add(this.rbAtivo);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.tabcInformaçõesPessoa);
            this.splitContainer1.Panel1.Controls.Add(this.ttbRg);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.ttbRazao);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.ttbNome);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.Código);
            this.splitContainer1.Panel1.Controls.Add(this.ttbCodigo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.btnPesquisar);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnSair);
            this.splitContainer1.Panel2.Controls.Add(this.btnExcluir);
            this.splitContainer1.Panel2.Controls.Add(this.btnAlterar);
            this.splitContainer1.Panel2.Controls.Add(this.btnGravar);
            this.splitContainer1.Panel2.Controls.Add(this.btnNovo);
            this.splitContainer1.Size = new System.Drawing.Size(890, 495);
            this.splitContainer1.SplitterDistance = 423;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPagaNao);
            this.groupBox2.Controls.Add(this.rbPagaSim);
            this.groupBox2.Location = new System.Drawing.Point(758, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(91, 81);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pagamento Diferenciado?";
            // 
            // rbPagaNao
            // 
            this.rbPagaNao.AutoSize = true;
            this.rbPagaNao.Location = new System.Drawing.Point(7, 32);
            this.rbPagaNao.Name = "rbPagaNao";
            this.rbPagaNao.Size = new System.Drawing.Size(45, 17);
            this.rbPagaNao.TabIndex = 0;
            this.rbPagaNao.TabStop = true;
            this.rbPagaNao.Text = "Não";
            this.rbPagaNao.UseVisualStyleBackColor = true;
            // 
            // rbPagaSim
            // 
            this.rbPagaSim.AutoSize = true;
            this.rbPagaSim.Location = new System.Drawing.Point(7, 53);
            this.rbPagaSim.Name = "rbPagaSim";
            this.rbPagaSim.Size = new System.Drawing.Size(42, 17);
            this.rbPagaSim.TabIndex = 1;
            this.rbPagaSim.TabStop = true;
            this.rbPagaSim.Text = "Sim";
            this.rbPagaSim.UseVisualStyleBackColor = true;
            this.rbPagaSim.Click += new System.EventHandler(this.rbPagaSim_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFisica);
            this.groupBox1.Controls.Add(this.rbJuridica);
            this.groupBox1.Location = new System.Drawing.Point(64, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 81);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo*";
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Location = new System.Drawing.Point(7, 21);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(54, 17);
            this.rbFisica.TabIndex = 0;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(7, 53);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(63, 17);
            this.rbJuridica.TabIndex = 1;
            this.rbJuridica.TabStop = true;
            this.rbJuridica.Text = "Jurídica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Location = new System.Drawing.Point(305, 151);
            this.mskCNPJ.Mask = "00.000.000/0000-00";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(123, 20);
            this.mskCNPJ.TabIndex = 3;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(470, 151);
            this.mskCPF.Mask = "000.000.00-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(83, 20);
            this.mskCPF.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(561, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Nascimento";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(628, 151);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(114, 20);
            this.dtpDataNascimento.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "CNPJ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "CPF:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(790, 22);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(57, 17);
            this.rbInativo.TabIndex = 49;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Location = new System.Drawing.Point(735, 22);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbAtivo.TabIndex = 48;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(688, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Status*";
            // 
            // tabcInformaçõesPessoa
            // 
            this.tabcInformaçõesPessoa.Controls.Add(this.Endereço);
            this.tabcInformaçõesPessoa.Controls.Add(this.Contato);
            this.tabcInformaçõesPessoa.Controls.Add(this.Financeiro);
            this.tabcInformaçõesPessoa.Controls.Add(this.Observações);
            this.tabcInformaçõesPessoa.Location = new System.Drawing.Point(12, 188);
            this.tabcInformaçõesPessoa.Name = "tabcInformaçõesPessoa";
            this.tabcInformaçõesPessoa.SelectedIndex = 0;
            this.tabcInformaçõesPessoa.Size = new System.Drawing.Size(875, 232);
            this.tabcInformaçõesPessoa.TabIndex = 46;
            // 
            // Endereço
            // 
            this.Endereço.Controls.Add(this.pnlEndereco);
            this.Endereço.Controls.Add(this.dgvEndereço);
            this.Endereço.Controls.Add(this.btnIncluirEndereco);
            this.Endereço.Location = new System.Drawing.Point(4, 22);
            this.Endereço.Name = "Endereço";
            this.Endereço.Size = new System.Drawing.Size(867, 206);
            this.Endereço.TabIndex = 4;
            this.Endereço.Text = "Endereço";
            this.Endereço.UseVisualStyleBackColor = true;
            // 
            // pnlEndereco
            // 
            this.pnlEndereco.Controls.Add(this.btnSalvarEndereco);
            this.pnlEndereco.Controls.Add(this.label15);
            this.pnlEndereco.Controls.Add(this.label14);
            this.pnlEndereco.Controls.Add(this.cbbCidade);
            this.pnlEndereco.Controls.Add(this.cbbEstado);
            this.pnlEndereco.Controls.Add(this.label13);
            this.pnlEndereco.Controls.Add(this.ttbCep);
            this.pnlEndereco.Controls.Add(this.label12);
            this.pnlEndereco.Controls.Add(this.ttbComplemento);
            this.pnlEndereco.Controls.Add(this.label11);
            this.pnlEndereco.Controls.Add(this.ttbBairro);
            this.pnlEndereco.Controls.Add(this.label10);
            this.pnlEndereco.Controls.Add(this.label3);
            this.pnlEndereco.Controls.Add(this.ttbNumero);
            this.pnlEndereco.Controls.Add(this.ttbLogradouro);
            this.pnlEndereco.Location = new System.Drawing.Point(41, 4);
            this.pnlEndereco.Name = "pnlEndereco";
            this.pnlEndereco.Size = new System.Drawing.Size(818, 107);
            this.pnlEndereco.TabIndex = 9;
            this.pnlEndereco.Visible = false;
            // 
            // btnSalvarEndereco
            // 
            this.btnSalvarEndereco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvarEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarEndereco.Location = new System.Drawing.Point(762, 43);
            this.btnSalvarEndereco.Name = "btnSalvarEndereco";
            this.btnSalvarEndereco.Size = new System.Drawing.Size(53, 28);
            this.btnSalvarEndereco.TabIndex = 7;
            this.btnSalvarEndereco.Text = "Salvar";
            this.btnSalvarEndereco.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(428, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 70;
            this.label15.Text = "Cidade";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(148, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 69;
            this.label14.Text = "Estado";
            // 
            // cbbCidade
            // 
            this.cbbCidade.FormattingEnabled = true;
            this.cbbCidade.Location = new System.Drawing.Point(470, 70);
            this.cbbCidade.Name = "cbbCidade";
            this.cbbCidade.Size = new System.Drawing.Size(286, 21);
            this.cbbCidade.TabIndex = 6;
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(203, 70);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(215, 21);
            this.cbbEstado.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "CEP";
            // 
            // ttbCep
            // 
            this.ttbCep.Location = new System.Drawing.Point(70, 71);
            this.ttbCep.Name = "ttbCep";
            this.ttbCep.Size = new System.Drawing.Size(69, 20);
            this.ttbCep.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(354, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 63;
            this.label12.Text = "Complemento";
            // 
            // ttbComplemento
            // 
            this.ttbComplemento.Location = new System.Drawing.Point(431, 41);
            this.ttbComplemento.Name = "ttbComplemento";
            this.ttbComplemento.Size = new System.Drawing.Size(325, 20);
            this.ttbComplemento.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "Bairro";
            // 
            // ttbBairro
            // 
            this.ttbBairro.Location = new System.Drawing.Point(70, 44);
            this.ttbBairro.Name = "ttbBairro";
            this.ttbBairro.Size = new System.Drawing.Size(278, 20);
            this.ttbBairro.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(631, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Nº";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Logradouro";
            // 
            // ttbNumero
            // 
            this.ttbNumero.Location = new System.Drawing.Point(656, 6);
            this.ttbNumero.Name = "ttbNumero";
            this.ttbNumero.Size = new System.Drawing.Size(100, 20);
            this.ttbNumero.TabIndex = 1;
            // 
            // ttbLogradouro
            // 
            this.ttbLogradouro.Location = new System.Drawing.Point(70, 6);
            this.ttbLogradouro.Name = "ttbLogradouro";
            this.ttbLogradouro.Size = new System.Drawing.Size(553, 20);
            this.ttbLogradouro.TabIndex = 0;
            // 
            // dgvEndereço
            // 
            this.dgvEndereço.AllowUserToAddRows = false;
            this.dgvEndereço.AllowUserToDeleteRows = false;
            this.dgvEndereço.BackgroundColor = System.Drawing.Color.White;
            this.dgvEndereço.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndereço.Location = new System.Drawing.Point(41, 117);
            this.dgvEndereço.Name = "dgvEndereço";
            this.dgvEndereço.ReadOnly = true;
            this.dgvEndereço.Size = new System.Drawing.Size(818, 76);
            this.dgvEndereço.TabIndex = 8;
            this.dgvEndereço.Visible = false;
            // 
            // btnIncluirEndereco
            // 
            this.btnIncluirEndereco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIncluirEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirEndereco.Location = new System.Drawing.Point(5, 4);
            this.btnIncluirEndereco.Name = "btnIncluirEndereco";
            this.btnIncluirEndereco.Size = new System.Drawing.Size(29, 32);
            this.btnIncluirEndereco.TabIndex = 0;
            this.btnIncluirEndereco.Text = "+";
            this.btnIncluirEndereco.UseVisualStyleBackColor = false;
            this.btnIncluirEndereco.Click += new System.EventHandler(this.btnIncluirEndereco_Click);
            // 
            // Contato
            // 
            this.Contato.Controls.Add(this.pnlContato);
            this.Contato.Controls.Add(this.dgvContato);
            this.Contato.Controls.Add(this.btnIncluirContato);
            this.Contato.Location = new System.Drawing.Point(4, 22);
            this.Contato.Name = "Contato";
            this.Contato.Padding = new System.Windows.Forms.Padding(3);
            this.Contato.Size = new System.Drawing.Size(867, 196);
            this.Contato.TabIndex = 1;
            this.Contato.Text = "Contato";
            this.Contato.UseVisualStyleBackColor = true;
            // 
            // pnlContato
            // 
            this.pnlContato.Controls.Add(this.btnSalvarContato);
            this.pnlContato.Controls.Add(this.mskCelular);
            this.pnlContato.Controls.Add(this.mskTelefone);
            this.pnlContato.Controls.Add(this.label18);
            this.pnlContato.Controls.Add(this.label19);
            this.pnlContato.Controls.Add(this.label21);
            this.pnlContato.Controls.Add(this.textBox5);
            this.pnlContato.Location = new System.Drawing.Point(42, 4);
            this.pnlContato.Name = "pnlContato";
            this.pnlContato.Size = new System.Drawing.Size(642, 80);
            this.pnlContato.TabIndex = 12;
            this.pnlContato.Visible = false;
            // 
            // btnSalvarContato
            // 
            this.btnSalvarContato.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvarContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarContato.Location = new System.Drawing.Point(570, 36);
            this.btnSalvarContato.Name = "btnSalvarContato";
            this.btnSalvarContato.Size = new System.Drawing.Size(53, 28);
            this.btnSalvarContato.TabIndex = 66;
            this.btnSalvarContato.Text = "Salvar";
            this.btnSalvarContato.UseVisualStyleBackColor = false;
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(256, 41);
            this.mskCelular.Mask = "(99) 0 0000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(104, 20);
            this.mskCelular.TabIndex = 65;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(69, 41);
            this.mskTelefone.Mask = "(99) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(100, 20);
            this.mskTelefone.TabIndex = 64;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(211, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 63;
            this.label18.Text = "Celular";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 61;
            this.label19.Text = "Telefone";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 59;
            this.label21.Text = "E-mail";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(70, 6);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(553, 20);
            this.textBox5.TabIndex = 0;
            // 
            // dgvContato
            // 
            this.dgvContato.AllowUserToAddRows = false;
            this.dgvContato.AllowUserToDeleteRows = false;
            this.dgvContato.BackgroundColor = System.Drawing.Color.White;
            this.dgvContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContato.Location = new System.Drawing.Point(42, 90);
            this.dgvContato.Name = "dgvContato";
            this.dgvContato.ReadOnly = true;
            this.dgvContato.Size = new System.Drawing.Size(642, 103);
            this.dgvContato.TabIndex = 11;
            this.dgvContato.Visible = false;
            // 
            // btnIncluirContato
            // 
            this.btnIncluirContato.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIncluirContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirContato.Location = new System.Drawing.Point(6, 4);
            this.btnIncluirContato.Name = "btnIncluirContato";
            this.btnIncluirContato.Size = new System.Drawing.Size(29, 32);
            this.btnIncluirContato.TabIndex = 10;
            this.btnIncluirContato.Text = "+";
            this.btnIncluirContato.UseVisualStyleBackColor = false;
            this.btnIncluirContato.Click += new System.EventHandler(this.btnIncluirContato_Click);
            // 
            // Financeiro
            // 
            this.Financeiro.Controls.Add(this.dataGridView1);
            this.Financeiro.Location = new System.Drawing.Point(4, 22);
            this.Financeiro.Name = "Financeiro";
            this.Financeiro.Size = new System.Drawing.Size(867, 196);
            this.Financeiro.TabIndex = 3;
            this.Financeiro.Text = "Financeiro";
            this.Financeiro.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 170);
            this.dataGridView1.TabIndex = 0;
            // 
            // Observações
            // 
            this.Observações.Controls.Add(this.label17);
            this.Observações.Controls.Add(this.textBox1);
            this.Observações.Controls.Add(this.pnlObservacao);
            this.Observações.Controls.Add(this.button1);
            this.Observações.Location = new System.Drawing.Point(4, 22);
            this.Observações.Name = "Observações";
            this.Observações.Size = new System.Drawing.Size(867, 196);
            this.Observações.TabIndex = 5;
            this.Observações.Text = "Observações";
            this.Observações.UseVisualStyleBackColor = true;
            // 
            // pnlObservacao
            // 
            this.pnlObservacao.Controls.Add(this.btnFormaPagamento);
            this.pnlObservacao.Controls.Add(this.radioButton1);
            this.pnlObservacao.Controls.Add(this.radioButton2);
            this.pnlObservacao.Controls.Add(this.label1);
            this.pnlObservacao.Location = new System.Drawing.Point(48, 24);
            this.pnlObservacao.Name = "pnlObservacao";
            this.pnlObservacao.Size = new System.Drawing.Size(587, 42);
            this.pnlObservacao.TabIndex = 13;
            this.pnlObservacao.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(98, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 62;
            this.radioButton1.Text = "Não";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(548, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 34);
            this.button1.TabIndex = 66;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(50, 7);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 17);
            this.radioButton2.TabIndex = 61;
            this.radioButton2.Text = "Sim";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Fiado?";
            // 
            // ttbRg
            // 
            this.ttbRg.Location = new System.Drawing.Point(101, 151);
            this.ttbRg.Name = "ttbRg";
            this.ttbRg.Size = new System.Drawing.Size(128, 20);
            this.ttbRg.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "R.G:";
            // 
            // ttbRazao
            // 
            this.ttbRazao.Location = new System.Drawing.Point(305, 103);
            this.ttbRazao.Name = "ttbRazao";
            this.ttbRazao.Size = new System.Drawing.Size(544, 20);
            this.ttbRazao.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Razão Social";
            // 
            // ttbNome
            // 
            this.ttbNome.Location = new System.Drawing.Point(305, 56);
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(544, 20);
            this.ttbNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nome/Fantasia*";
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
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisar.Location = new System.Drawing.Point(339, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 38);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(551, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 38);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Location = new System.Drawing.Point(795, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 38);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluir.Location = new System.Drawing.Point(445, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 38);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlterar.Location = new System.Drawing.Point(233, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 38);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGravar.Location = new System.Drawing.Point(127, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 38);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovo.Location = new System.Drawing.Point(21, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 38);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnFormaPagamento
            // 
            this.btnFormaPagamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormaPagamento.Location = new System.Drawing.Point(275, 7);
            this.btnFormaPagamento.Name = "btnFormaPagamento";
            this.btnFormaPagamento.Size = new System.Drawing.Size(206, 27);
            this.btnFormaPagamento.TabIndex = 67;
            this.btnFormaPagamento.Text = "Forma Pagamento";
            this.btnFormaPagamento.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(53, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 13);
            this.label17.TabIndex = 68;
            this.label17.Text = "Observação Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(473, 62);
            this.textBox1.TabIndex = 67;
            // 
            // Cadastro_Pessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(914, 529);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Cadastro_Pessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE PESSOAS";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabcInformaçõesPessoa.ResumeLayout(false);
            this.Endereço.ResumeLayout(false);
            this.pnlEndereco.ResumeLayout(false);
            this.pnlEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereço)).EndInit();
            this.Contato.ResumeLayout(false);
            this.pnlContato.ResumeLayout(false);
            this.pnlContato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).EndInit();
            this.Financeiro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Observações.ResumeLayout(false);
            this.Observações.PerformLayout();
            this.pnlObservacao.ResumeLayout(false);
            this.pnlObservacao.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabcInformaçõesPessoa;
        private System.Windows.Forms.TabPage Endereço;
        private System.Windows.Forms.TabPage Contato;
        private System.Windows.Forms.TabPage Financeiro;
        private System.Windows.Forms.TabPage Observações;
        private System.Windows.Forms.TextBox ttbRg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ttbRazao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlEndereco;
        private System.Windows.Forms.DataGridView dgvEndereço;
        public System.Windows.Forms.Button btnIncluirEndereco;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbCidade;
        private System.Windows.Forms.ComboBox cbbEstado;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox ttbCep;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox ttbComplemento;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox ttbBairro;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox ttbNumero;
        public System.Windows.Forms.TextBox ttbLogradouro;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnSalvarEndereco;
        public System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel pnlContato;
        public System.Windows.Forms.Button btnSalvarContato;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dgvContato;
        public System.Windows.Forms.Button btnIncluirContato;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlObservacao;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPagaNao;
        private System.Windows.Forms.RadioButton rbPagaSim;
        public System.Windows.Forms.Button btnFormaPagamento;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox textBox1;
    }
}