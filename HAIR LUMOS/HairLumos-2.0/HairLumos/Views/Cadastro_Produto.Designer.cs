namespace HairLumos.Views
{
    partial class Cadastro_Produto
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
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.codCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_obsCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.Label();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.ttbDescricao = new System.Windows.Forms.TextBox();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskPrecoVenda = new System.Windows.Forms.MaskedTextBox();
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ttbObservacao = new System.Windows.Forms.TextBox();
            this.mskPrecoCompra = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskQtdeProd = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbMarca = new System.Windows.Forms.ComboBox();
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
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.cbbMarca);
            this.splitContainer1.Panel1.Controls.Add(this.mskQtdeProd);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.mskPrecoCompra);
            this.splitContainer1.Panel1.Controls.Add(this.ttbObservacao);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.cbbCategoria);
            this.splitContainer1.Panel1.Controls.Add(this.mskPrecoVenda);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelecionar);
            this.splitContainer1.Panel1.Controls.Add(this.dgvProduto);
            this.splitContainer1.Panel1.Controls.Add(this.Código);
            this.splitContainer1.Panel1.Controls.Add(this.ttbCodigo);
            this.splitContainer1.Panel1.Controls.Add(this.ttbDescricao);
            this.splitContainer1.Panel1.Controls.Add(this.ttbNome);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSair);
            this.splitContainer1.Panel2.Controls.Add(this.btnExcluir);
            this.splitContainer1.Panel2.Controls.Add(this.btnAlterar);
            this.splitContainer1.Panel2.Controls.Add(this.btnGravar);
            this.splitContainer1.Panel2.Controls.Add(this.btnNovo);
            this.splitContainer1.Size = new System.Drawing.Size(781, 495);
            this.splitContainer1.SplitterDistance = 423;
            this.splitContainer1.TabIndex = 1;
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
            this.codCategoria,
            this.cat_categoria,
            this.cat_obsCategoria});
            this.dgvProduto.Location = new System.Drawing.Point(21, 263);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.Size = new System.Drawing.Size(679, 146);
            this.dgvProduto.TabIndex = 12;
            // 
            // codCategoria
            // 
            this.codCategoria.DataPropertyName = "codCategoria";
            this.codCategoria.HeaderText = "Cód";
            this.codCategoria.Name = "codCategoria";
            this.codCategoria.ReadOnly = true;
            // 
            // cat_categoria
            // 
            this.cat_categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cat_categoria.DataPropertyName = "cat_categoria";
            this.cat_categoria.HeaderText = "Categoria";
            this.cat_categoria.Name = "cat_categoria";
            this.cat_categoria.ReadOnly = true;
            // 
            // cat_obsCategoria
            // 
            this.cat_obsCategoria.DataPropertyName = "cat_obsCategoria";
            this.cat_obsCategoria.HeaderText = "Observação";
            this.cat_obsCategoria.Name = "cat_obsCategoria";
            this.cat_obsCategoria.ReadOnly = true;
            this.cat_obsCategoria.Width = 150;
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
            // ttbDescricao
            // 
            this.ttbDescricao.Location = new System.Drawing.Point(21, 130);
            this.ttbDescricao.Multiline = true;
            this.ttbDescricao.Name = "ttbDescricao";
            this.ttbDescricao.Size = new System.Drawing.Size(354, 34);
            this.ttbDescricao.TabIndex = 11;
            // 
            // ttbNome
            // 
            this.ttbNome.Location = new System.Drawing.Point(21, 72);
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(354, 20);
            this.ttbNome.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Location = new System.Drawing.Point(693, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 38);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluir.Location = new System.Drawing.Point(468, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 38);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlterar.Location = new System.Drawing.Point(362, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 38);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGravar.Location = new System.Drawing.Point(256, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 38);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovo.Location = new System.Drawing.Point(150, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 38);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Preço de Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Preço de Venda";
            // 
            // mskPrecoVenda
            // 
            this.mskPrecoVenda.Location = new System.Drawing.Point(548, 72);
            this.mskPrecoVenda.Name = "mskPrecoVenda";
            this.mskPrecoVenda.Size = new System.Drawing.Size(91, 20);
            this.mskPrecoVenda.TabIndex = 17;
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.Location = new System.Drawing.Point(459, 130);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(311, 21);
            this.cbbCategoria.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Observação";
            // 
            // ttbObservacao
            // 
            this.ttbObservacao.Location = new System.Drawing.Point(21, 199);
            this.ttbObservacao.Multiline = true;
            this.ttbObservacao.Name = "ttbObservacao";
            this.ttbObservacao.Size = new System.Drawing.Size(354, 34);
            this.ttbObservacao.TabIndex = 22;
            // 
            // mskPrecoCompra
            // 
            this.mskPrecoCompra.Location = new System.Drawing.Point(410, 72);
            this.mskPrecoCompra.Name = "mskPrecoCompra";
            this.mskPrecoCompra.Size = new System.Drawing.Size(91, 20);
            this.mskPrecoCompra.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Categoria";
            // 
            // mskQtdeProd
            // 
            this.mskQtdeProd.Location = new System.Drawing.Point(679, 72);
            this.mskQtdeProd.Name = "mskQtdeProd";
            this.mskQtdeProd.Size = new System.Drawing.Size(91, 20);
            this.mskQtdeProd.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(676, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Qtde Produto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Marca";
            // 
            // cbbMarca
            // 
            this.cbbMarca.FormattingEnabled = true;
            this.cbbMarca.Location = new System.Drawing.Point(459, 199);
            this.cbbMarca.Name = "cbbMarca";
            this.cbbMarca.Size = new System.Drawing.Size(311, 21);
            this.cbbMarca.TabIndex = 27;
            // 
            // Cadastro_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(805, 519);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Cadastro_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE PRODUTO";
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
        public System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat_obsCategoria;
        public System.Windows.Forms.Label Código;
        public System.Windows.Forms.TextBox ttbCodigo;
        public System.Windows.Forms.TextBox ttbDescricao;
        public System.Windows.Forms.TextBox ttbNome;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnNovo;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskPrecoCompra;
        public System.Windows.Forms.TextBox ttbObservacao;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbCategoria;
        private System.Windows.Forms.MaskedTextBox mskPrecoVenda;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbMarca;
        private System.Windows.Forms.MaskedTextBox mskQtdeProd;
        public System.Windows.Forms.Label label5;
    }
}