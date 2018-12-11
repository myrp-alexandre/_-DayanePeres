namespace HairLumos.Views.Funcoes_Fundamentais.RF_F7_Vender_Produto
{
    partial class VenderProduto
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.mskValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.mskQtde = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.ttbProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.ttbCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFecharVenda = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.splitContainer1.Panel2.Controls.Add(this.btnFecharVenda);
            this.splitContainer1.Panel2.Controls.Add(this.btnPesquisar);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnSair);
            this.splitContainer1.Panel2.Controls.Add(this.btnNovo);
            this.splitContainer1.Size = new System.Drawing.Size(776, 479);
            this.splitContainer1.SplitterDistance = 420;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(21, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 310);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produto";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnExcluirItem);
            this.groupBox4.Controls.Add(this.dgvProdutos);
            this.groupBox4.Location = new System.Drawing.Point(9, 121);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(717, 182);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista de Produto Selecionado";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.mskValorTotal);
            this.groupBox5.Location = new System.Drawing.Point(595, 84);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(116, 83);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Valor a Pagar(R$)";
            // 
            // mskValorTotal
            // 
            this.mskValorTotal.Enabled = false;
            this.mskValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskValorTotal.Location = new System.Drawing.Point(6, 40);
            this.mskValorTotal.Name = "mskValorTotal";
            this.mskValorTotal.Size = new System.Drawing.Size(104, 21);
            this.mskValorTotal.TabIndex = 24;
            this.mskValorTotal.Enter += new System.EventHandler(this.mskValorTotal_Enter);
            this.mskValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskValorTotal_KeyPress);
            this.mskValorTotal.Leave += new System.EventHandler(this.mskValorTotal_Leave);
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.BackColor = System.Drawing.Color.White;
            this.btnExcluirItem.Location = new System.Drawing.Point(616, 33);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(78, 29);
            this.btnExcluirItem.TabIndex = 0;
            this.btnExcluirItem.Text = "Excluir";
            this.btnExcluirItem.UseVisualStyleBackColor = false;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Quantidade,
            this.Valor});
            this.dgvProdutos.Enabled = false;
            this.dgvProdutos.Location = new System.Drawing.Point(13, 19);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(575, 148);
            this.dgvProdutos.TabIndex = 18;
            // 
            // Produto
            // 
            this.Produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Produto.DataPropertyName = "Produto";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor (R$)";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIncluir);
            this.groupBox3.Controls.Add(this.mskQtde);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.mskValor);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnPesquisarProduto);
            this.groupBox3.Controls.Add(this.ttbProduto);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(9, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(717, 96);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selecionar Produto";
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.White;
            this.btnIncluir.Location = new System.Drawing.Point(469, 53);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(78, 29);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.Text = "+ Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // mskQtde
            // 
            this.mskQtde.Location = new System.Drawing.Point(301, 58);
            this.mskQtde.Name = "mskQtde";
            this.mskQtde.Size = new System.Drawing.Size(134, 20);
            this.mskQtde.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Qtde*";
            // 
            // mskValor
            // 
            this.mskValor.Location = new System.Drawing.Point(92, 58);
            this.mskValor.Name = "mskValor";
            this.mskValor.Size = new System.Drawing.Size(134, 20);
            this.mskValor.TabIndex = 1;
            this.mskValor.Enter += new System.EventHandler(this.mskValor_Enter);
            this.mskValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskValor_KeyPress);
            this.mskValor.Leave += new System.EventHandler(this.mskValor_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Valor (R$)*";
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.BackColor = System.Drawing.Color.White;
            this.btnPesquisarProduto.Location = new System.Drawing.Point(589, 10);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(105, 36);
            this.btnPesquisarProduto.TabIndex = 0;
            this.btnPesquisarProduto.Text = "Pesquisar Produto";
            this.btnPesquisarProduto.UseVisualStyleBackColor = false;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // ttbProduto
            // 
            this.ttbProduto.BackColor = System.Drawing.SystemColors.Window;
            this.ttbProduto.Enabled = false;
            this.ttbProduto.Location = new System.Drawing.Point(92, 19);
            this.ttbProduto.Name = "ttbProduto";
            this.ttbProduto.Size = new System.Drawing.Size(455, 20);
            this.ttbProduto.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Produto*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskTelefone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnPesquisarCliente);
            this.groupBox1.Controls.Add(this.ttbCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 89);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "informações de Cliente";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Enabled = false;
            this.mskTelefone.Location = new System.Drawing.Point(101, 53);
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(134, 20);
            this.mskTelefone.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Telefone*";
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.BackColor = System.Drawing.Color.White;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(598, 44);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(105, 36);
            this.btnPesquisarCliente.TabIndex = 0;
            this.btnPesquisarCliente.Text = "Pesquisar Cliente";
            this.btnPesquisarCliente.UseVisualStyleBackColor = false;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // ttbCliente
            // 
            this.ttbCliente.BackColor = System.Drawing.SystemColors.Window;
            this.ttbCliente.Enabled = false;
            this.ttbCliente.Location = new System.Drawing.Point(101, 18);
            this.ttbCliente.Name = "ttbCliente";
            this.ttbCliente.Size = new System.Drawing.Size(602, 20);
            this.ttbCliente.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cliente";
            // 
            // btnFecharVenda
            // 
            this.btnFecharVenda.BackColor = System.Drawing.Color.White;
            this.btnFecharVenda.Location = new System.Drawing.Point(396, 9);
            this.btnFecharVenda.Name = "btnFecharVenda";
            this.btnFecharVenda.Size = new System.Drawing.Size(222, 38);
            this.btnFecharVenda.TabIndex = 3;
            this.btnFecharVenda.Text = "FECHAR VENDA";
            this.btnFecharVenda.UseVisualStyleBackColor = false;
            this.btnFecharVenda.Click += new System.EventHandler(this.btnFecharVenda_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(122, 9);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(90, 38);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(218, 9);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 38);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(692, 9);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(71, 38);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(26, 9);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 38);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // VenderProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "VenderProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H.L - VENDER PRODUTO";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnPesquisarCliente;
        public System.Windows.Forms.TextBox ttbCliente;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button btnPesquisarProduto;
        public System.Windows.Forms.TextBox ttbProduto;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnFecharVenda;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MaskedTextBox mskValorTotal;
        public System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.MaskedTextBox mskValor;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskQtde;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}