namespace HairLumos.Views.Funcoes_Fundamentais
{
    partial class GerenciarCompra
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
            this.totalCompra = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Pedido = new System.Windows.Forms.TabPage();
            this.dgvGerenciarCompra = new System.Windows.Forms.DataGridView();
            this.Observação = new System.Windows.Forms.TabPage();
            this.ttbObservacao = new System.Windows.Forms.TextBox();
            this.btnExcluirCompra = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIncluirProduto = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ttbQuantidade = new System.Windows.Forms.TextBox();
            this.mskVenda = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskCusto = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisaProduto = new System.Windows.Forms.Button();
            this.ttbProduto = new System.Windows.Forms.TextBox();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.btnPesquisaFornecedor = new System.Windows.Forms.Button();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.ttbFornecedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Código = new System.Windows.Forms.Label();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerarCompra = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Pedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGerenciarCompra)).BeginInit();
            this.Observação.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnPesquisaProduto);
            this.splitContainer1.Panel1.Controls.Add(this.ttbProduto);
            this.splitContainer1.Panel1.Controls.Add(this.rbNao);
            this.splitContainer1.Panel1.Controls.Add(this.btnPesquisaFornecedor);
            this.splitContainer1.Panel1.Controls.Add(this.rbSim);
            this.splitContainer1.Panel1.Controls.Add(this.ttbFornecedor);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.Código);
            this.splitContainer1.Panel1.Controls.Add(this.ttbCodigo);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnGerarCompra);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnSair);
            this.splitContainer1.Panel2.Controls.Add(this.btnExcluir);
            this.splitContainer1.Panel2.Controls.Add(this.btnLocalizar);
            this.splitContainer1.Panel2.Controls.Add(this.btnNovo);
            this.splitContainer1.Size = new System.Drawing.Size(916, 477);
            this.splitContainer1.SplitterDistance = 408;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.totalCompra);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Controls.Add(this.btnExcluirCompra);
            this.groupBox3.Location = new System.Drawing.Point(21, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(878, 225);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // totalCompra
            // 
            this.totalCompra.AutoSize = true;
            this.totalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.totalCompra.Location = new System.Drawing.Point(816, 176);
            this.totalCompra.Name = "totalCompra";
            this.totalCompra.Size = new System.Drawing.Size(31, 15);
            this.totalCompra.TabIndex = 18;
            this.totalCompra.Text = "0,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(800, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total R$:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Pedido);
            this.tabControl1.Controls.Add(this.Observação);
            this.tabControl1.Location = new System.Drawing.Point(9, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 200);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // Pedido
            // 
            this.Pedido.Controls.Add(this.dgvGerenciarCompra);
            this.Pedido.Location = new System.Drawing.Point(4, 22);
            this.Pedido.Name = "Pedido";
            this.Pedido.Padding = new System.Windows.Forms.Padding(3);
            this.Pedido.Size = new System.Drawing.Size(777, 174);
            this.Pedido.TabIndex = 0;
            this.Pedido.Text = "Pedido";
            this.Pedido.UseVisualStyleBackColor = true;
            // 
            // dgvGerenciarCompra
            // 
            this.dgvGerenciarCompra.AllowUserToAddRows = false;
            this.dgvGerenciarCompra.AllowUserToDeleteRows = false;
            this.dgvGerenciarCompra.BackgroundColor = System.Drawing.Color.White;
            this.dgvGerenciarCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGerenciarCompra.Location = new System.Drawing.Point(6, 6);
            this.dgvGerenciarCompra.Name = "dgvGerenciarCompra";
            this.dgvGerenciarCompra.ReadOnly = true;
            this.dgvGerenciarCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGerenciarCompra.Size = new System.Drawing.Size(765, 162);
            this.dgvGerenciarCompra.TabIndex = 15;
            // 
            // Observação
            // 
            this.Observação.Controls.Add(this.ttbObservacao);
            this.Observação.Location = new System.Drawing.Point(4, 22);
            this.Observação.Name = "Observação";
            this.Observação.Padding = new System.Windows.Forms.Padding(3);
            this.Observação.Size = new System.Drawing.Size(777, 174);
            this.Observação.TabIndex = 1;
            this.Observação.Text = "Observação";
            this.Observação.UseVisualStyleBackColor = true;
            // 
            // ttbObservacao
            // 
            this.ttbObservacao.Location = new System.Drawing.Point(9, 18);
            this.ttbObservacao.MaxLength = 100;
            this.ttbObservacao.Multiline = true;
            this.ttbObservacao.Name = "ttbObservacao";
            this.ttbObservacao.Size = new System.Drawing.Size(750, 135);
            this.ttbObservacao.TabIndex = 30;
            // 
            // btnExcluirCompra
            // 
            this.btnExcluirCompra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluirCompra.Location = new System.Drawing.Point(800, 93);
            this.btnExcluirCompra.Name = "btnExcluirCompra";
            this.btnExcluirCompra.Size = new System.Drawing.Size(72, 37);
            this.btnExcluirCompra.TabIndex = 16;
            this.btnExcluirCompra.Text = "Excluir Item";
            this.btnExcluirCompra.UseVisualStyleBackColor = false;
            this.btnExcluirCompra.Click += new System.EventHandler(this.btnExcluirCompra_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(785, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Compra Consignado?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIncluirProduto);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ttbQuantidade);
            this.groupBox1.Controls.Add(this.mskVenda);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mskCusto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 66);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // btnIncluirProduto
            // 
            this.btnIncluirProduto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIncluirProduto.Location = new System.Drawing.Point(767, 19);
            this.btnIncluirProduto.Name = "btnIncluirProduto";
            this.btnIncluirProduto.Size = new System.Drawing.Size(105, 37);
            this.btnIncluirProduto.TabIndex = 17;
            this.btnIncluirProduto.Text = "Incluir Produto";
            this.btnIncluirProduto.UseVisualStyleBackColor = false;
            this.btnIncluirProduto.Click += new System.EventHandler(this.btnIncluirProduto_Click);
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd/MM/YYYY";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(215, 24);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(103, 20);
            this.dtpData.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Qtde";
            // 
            // ttbQuantidade
            // 
            this.ttbQuantidade.Location = new System.Drawing.Point(58, 27);
            this.ttbQuantidade.Name = "ttbQuantidade";
            this.ttbQuantidade.Size = new System.Drawing.Size(100, 20);
            this.ttbQuantidade.TabIndex = 24;
            // 
            // mskVenda
            // 
            this.mskVenda.Location = new System.Drawing.Point(652, 23);
            this.mskVenda.Name = "mskVenda";
            this.mskVenda.Size = new System.Drawing.Size(100, 20);
            this.mskVenda.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Preço de Venda*";
            // 
            // mskCusto
            // 
            this.mskCusto.Location = new System.Drawing.Point(428, 24);
            this.mskCusto.Name = "mskCusto";
            this.mskCusto.Size = new System.Drawing.Size(100, 20);
            this.mskCusto.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Preço de Custo*";
            // 
            // btnPesquisaProduto
            // 
            this.btnPesquisaProduto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisaProduto.Location = new System.Drawing.Point(552, 57);
            this.btnPesquisaProduto.Name = "btnPesquisaProduto";
            this.btnPesquisaProduto.Size = new System.Drawing.Size(87, 31);
            this.btnPesquisaProduto.TabIndex = 17;
            this.btnPesquisaProduto.Text = "Pesquisa";
            this.btnPesquisaProduto.UseVisualStyleBackColor = false;
            this.btnPesquisaProduto.Click += new System.EventHandler(this.btnPesquisaProduto_Click);
            // 
            // ttbProduto
            // 
            this.ttbProduto.Location = new System.Drawing.Point(79, 62);
            this.ttbProduto.MaxLength = 100;
            this.ttbProduto.Name = "ttbProduto";
            this.ttbProduto.Size = new System.Drawing.Size(448, 20);
            this.ttbProduto.TabIndex = 16;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(848, 85);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(45, 17);
            this.rbNao.TabIndex = 27;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // btnPesquisaFornecedor
            // 
            this.btnPesquisaFornecedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisaFornecedor.Location = new System.Drawing.Point(812, 9);
            this.btnPesquisaFornecedor.Name = "btnPesquisaFornecedor";
            this.btnPesquisaFornecedor.Size = new System.Drawing.Size(87, 31);
            this.btnPesquisaFornecedor.TabIndex = 15;
            this.btnPesquisaFornecedor.Text = "Pesquisa";
            this.btnPesquisaFornecedor.UseVisualStyleBackColor = false;
            this.btnPesquisaFornecedor.Click += new System.EventHandler(this.btnPesquisaFornecedor_Click);
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(788, 85);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(42, 17);
            this.rbSim.TabIndex = 26;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // ttbFornecedor
            // 
            this.ttbFornecedor.Location = new System.Drawing.Point(345, 15);
            this.ttbFornecedor.MaxLength = 100;
            this.ttbFornecedor.Name = "ttbFornecedor";
            this.ttbFornecedor.Size = new System.Drawing.Size(448, 20);
            this.ttbFornecedor.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fornecedor:";
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
            this.ttbCodigo.Enabled = false;
            this.ttbCodigo.Location = new System.Drawing.Point(64, 15);
            this.ttbCodigo.Name = "ttbCodigo";
            this.ttbCodigo.Size = new System.Drawing.Size(100, 20);
            this.ttbCodigo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Produto";
            // 
            // btnGerarCompra
            // 
            this.btnGerarCompra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGerarCompra.Location = new System.Drawing.Point(519, 12);
            this.btnGerarCompra.Name = "btnGerarCompra";
            this.btnGerarCompra.Size = new System.Drawing.Size(221, 48);
            this.btnGerarCompra.TabIndex = 14;
            this.btnGerarCompra.Text = "Gerar Compra e Contas a Pagar";
            this.btnGerarCompra.UseVisualStyleBackColor = false;
            this.btnGerarCompra.Click += new System.EventHandler(this.btnGerarCompra_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(286, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 48);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Location = new System.Drawing.Point(824, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 48);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluir.Location = new System.Drawing.Point(205, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 48);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLocalizar.Location = new System.Drawing.Point(124, 12);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 48);
            this.btnLocalizar.TabIndex = 8;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovo.Location = new System.Drawing.Point(43, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 48);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // GerenciarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(940, 501);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GerenciarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GERENCIAR COMPRA";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Pedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGerenciarCompra)).EndInit();
            this.Observação.ResumeLayout(false);
            this.Observação.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Label Código;
        public System.Windows.Forms.TextBox ttbCodigo;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnLocalizar;
        public System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Pedido;
        private System.Windows.Forms.DataGridView dgvGerenciarCompra;
        private System.Windows.Forms.TabPage Observação;
        public System.Windows.Forms.TextBox ttbObservacao;
        public System.Windows.Forms.Button btnExcluirCompra;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpData;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox ttbQuantidade;
        private System.Windows.Forms.MaskedTextBox mskVenda;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskCusto;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnPesquisaProduto;
        public System.Windows.Forms.TextBox ttbProduto;
        private System.Windows.Forms.RadioButton rbNao;
        public System.Windows.Forms.Button btnPesquisaFornecedor;
        private System.Windows.Forms.RadioButton rbSim;
        public System.Windows.Forms.TextBox ttbFornecedor;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnGerarCompra;
        public System.Windows.Forms.Button btnIncluirProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalCompra;
    }
}