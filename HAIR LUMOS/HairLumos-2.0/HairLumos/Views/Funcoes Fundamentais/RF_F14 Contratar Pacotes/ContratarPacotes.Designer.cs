namespace HairLumos.Views.Funcoes_Fundamentais.RF_F14_Contratar_Pacotes
{
    partial class ContratarPacotes
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
            this.button1 = new System.Windows.Forms.Button();
            this.mskPrecoCompra = new System.Windows.Forms.MaskedTextBox();
            this.ttbObservacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.codproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_precocusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_precovenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.Label();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.mskPrecoCompra);
            this.splitContainer1.Panel1.Controls.Add(this.ttbObservacao);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelecionar);
            this.splitContainer1.Panel1.Controls.Add(this.dgvProduto);
            this.splitContainer1.Panel1.Controls.Add(this.Código);
            this.splitContainer1.Panel1.Controls.Add(this.ttbCodigo);
            this.splitContainer1.Panel1.Controls.Add(this.ttbNome);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnSair);
            this.splitContainer1.Panel2.Controls.Add(this.btnExcluir);
            this.splitContainer1.Panel2.Controls.Add(this.btnAlterar);
            this.splitContainer1.Panel2.Controls.Add(this.btnGravar);
            this.splitContainer1.Panel2.Controls.Add(this.btnNovo);
            this.splitContainer1.Size = new System.Drawing.Size(781, 495);
            this.splitContainer1.SplitterDistance = 423;
            this.splitContainer1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(527, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 27);
            this.button1.TabIndex = 22;
            this.button1.Text = "Pesquisa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // mskPrecoCompra
            // 
            this.mskPrecoCompra.Location = new System.Drawing.Point(408, 94);
            this.mskPrecoCompra.Name = "mskPrecoCompra";
            this.mskPrecoCompra.Size = new System.Drawing.Size(91, 20);
            this.mskPrecoCompra.TabIndex = 1;
            // 
            // ttbObservacao
            // 
            this.ttbObservacao.Location = new System.Drawing.Point(21, 194);
            this.ttbObservacao.MaxLength = 200;
            this.ttbObservacao.Multiline = true;
            this.ttbObservacao.Name = "ttbObservacao";
            this.ttbObservacao.Size = new System.Drawing.Size(749, 31);
            this.ttbObservacao.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Observação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Preço de Compra*";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelecionar.Location = new System.Drawing.Point(706, 320);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(64, 27);
            this.btnSelecionar.TabIndex = 12;
            this.btnSelecionar.Text = "Seleciona";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codproduto,
            this.prod_produto,
            this.prod_precocusto,
            this.prod_precovenda,
            this.prod_qtde});
            this.dgvProduto.Location = new System.Drawing.Point(21, 263);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(679, 146);
            this.dgvProduto.TabIndex = 12;
            // 
            // codproduto
            // 
            this.codproduto.DataPropertyName = "codproduto";
            this.codproduto.HeaderText = "Cód";
            this.codproduto.Name = "codproduto";
            this.codproduto.ReadOnly = true;
            this.codproduto.Width = 50;
            // 
            // prod_produto
            // 
            this.prod_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prod_produto.DataPropertyName = "prod_produto";
            this.prod_produto.HeaderText = "Produto";
            this.prod_produto.Name = "prod_produto";
            this.prod_produto.ReadOnly = true;
            // 
            // prod_precocusto
            // 
            this.prod_precocusto.DataPropertyName = "prod_precocusto";
            this.prod_precocusto.HeaderText = "Preço Custo (R$)";
            this.prod_precocusto.Name = "prod_precocusto";
            this.prod_precocusto.ReadOnly = true;
            // 
            // prod_precovenda
            // 
            this.prod_precovenda.DataPropertyName = "prod_precovenda";
            this.prod_precovenda.HeaderText = "Preço Venda (R$)";
            this.prod_precovenda.Name = "prod_precovenda";
            this.prod_precovenda.ReadOnly = true;
            // 
            // prod_qtde
            // 
            this.prod_qtde.DataPropertyName = "prod_qtde";
            this.prod_qtde.HeaderText = "Qtde Produto";
            this.prod_qtde.Name = "prod_qtde";
            this.prod_qtde.ReadOnly = true;
            // 
            // Código
            // 
            this.Código.AutoSize = true;
            this.Código.Location = new System.Drawing.Point(18, 18);
            this.Código.Name = "Código";
            this.Código.Size = new System.Drawing.Size(43, 13);
            this.Código.TabIndex = 6;
            this.Código.Text = "Cliente*";
            // 
            // ttbCodigo
            // 
            this.ttbCodigo.Location = new System.Drawing.Point(64, 15);
            this.ttbCodigo.Name = "ttbCodigo";
            this.ttbCodigo.Size = new System.Drawing.Size(435, 20);
            this.ttbCodigo.TabIndex = 7;
            // 
            // ttbNome
            // 
            this.ttbNome.Location = new System.Drawing.Point(19, 94);
            this.ttbNome.MaxLength = 100;
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(354, 20);
            this.ttbNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome do Produto*";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(445, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 38);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Location = new System.Drawing.Point(693, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 38);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluir.Location = new System.Drawing.Point(339, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 38);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
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
            // ContratarPacotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(805, 519);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ContratarPacotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H.L - CONTRAR PACOTES";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MaskedTextBox mskPrecoCompra;
        public System.Windows.Forms.TextBox ttbObservacao;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_precocusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_precovenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_qtde;
        public System.Windows.Forms.Label Código;
        public System.Windows.Forms.TextBox ttbCodigo;
        public System.Windows.Forms.TextBox ttbNome;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnNovo;
        public System.Windows.Forms.Button button1;
    }
}