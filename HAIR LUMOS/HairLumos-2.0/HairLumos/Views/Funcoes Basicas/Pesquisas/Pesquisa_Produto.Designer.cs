namespace HairLumos.Views.Funcoes_Basicas.Pesquisas
{
    partial class Pesquisa_Produto
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.ttbDescricao = new System.Windows.Forms.TextBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.codproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marc_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(772, 30);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 30);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.White;
            this.btnSelecionar.Location = new System.Drawing.Point(575, 30);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(100, 30);
            this.btnSelecionar.TabIndex = 11;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(455, 30);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisa";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // ttbDescricao
            // 
            this.ttbDescricao.Location = new System.Drawing.Point(12, 35);
            this.ttbDescricao.Name = "ttbDescricao";
            this.ttbDescricao.Size = new System.Drawing.Size(400, 20);
            this.ttbDescricao.TabIndex = 9;
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
            this.marc_nome,
            this.cat_categoria,
            this.prod_qtde});
            this.dgvProduto.Location = new System.Drawing.Point(12, 98);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.Size = new System.Drawing.Size(860, 368);
            this.dgvProduto.TabIndex = 13;
            this.dgvProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellDoubleClick);
            // 
            // codproduto
            // 
            this.codproduto.DataPropertyName = "codproduto";
            this.codproduto.HeaderText = "Cod";
            this.codproduto.Name = "codproduto";
            this.codproduto.ReadOnly = true;
            // 
            // prod_produto
            // 
            this.prod_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prod_produto.DataPropertyName = "prod_produto";
            this.prod_produto.HeaderText = "Descrição";
            this.prod_produto.Name = "prod_produto";
            this.prod_produto.ReadOnly = true;
            // 
            // marc_nome
            // 
            this.marc_nome.DataPropertyName = "marc_nome";
            this.marc_nome.HeaderText = "Marca";
            this.marc_nome.Name = "marc_nome";
            this.marc_nome.ReadOnly = true;
            this.marc_nome.Width = 200;
            // 
            // cat_categoria
            // 
            this.cat_categoria.DataPropertyName = "cat_categoria";
            this.cat_categoria.HeaderText = "Categoria";
            this.cat_categoria.Name = "cat_categoria";
            this.cat_categoria.ReadOnly = true;
            this.cat_categoria.Width = 200;
            // 
            // prod_qtde
            // 
            this.prod_qtde.DataPropertyName = "prod_qtde";
            this.prod_qtde.HeaderText = "Qtde estoque";
            this.prod_qtde.Name = "prod_qtde";
            this.prod_qtde.ReadOnly = true;
            // 
            // Pesquisa_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(884, 478);
            this.ControlBox = false;
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.ttbDescricao);
            this.Name = "Pesquisa_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H.L - PESQUISA PRODUTOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox ttbDescricao;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn marc_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_qtde;
    }
}