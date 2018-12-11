namespace HairLumos.Views.Funcoes_Fundamentais.RF_F8_Fechar_Atendimento
{
    partial class Fechamento
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
            this.btnCliente = new System.Windows.Forms.Button();
            this.ttbCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTotalGeral = new System.Windows.Forms.MaskedTextBox();
            this.mskTotalProduto = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTotalServico = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvListaProdutos = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirServico = new System.Windows.Forms.Button();
            this.dgvListaServicos = new System.Windows.Forms.DataGridView();
            this.tiposerv_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agen_dataagendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agen_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServicos)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnCliente);
            this.splitContainer1.Panel1.Controls.Add(this.ttbCliente);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.splitContainer1.Panel2.Controls.Add(this.btnSair);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnFinalizar);
            this.splitContainer1.Size = new System.Drawing.Size(776, 467);
            this.splitContainer1.SplitterDistance = 398;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.White;
            this.btnCliente.Location = new System.Drawing.Point(656, 15);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(104, 25);
            this.btnCliente.TabIndex = 54;
            this.btnCliente.Text = "Pesquisar Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // ttbCliente
            // 
            this.ttbCliente.Enabled = false;
            this.ttbCliente.Location = new System.Drawing.Point(59, 18);
            this.ttbCliente.Name = "ttbCliente";
            this.ttbCliente.Size = new System.Drawing.Size(588, 20);
            this.ttbCliente.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.mskTotalGeral);
            this.groupBox7.Controls.Add(this.mskTotalProduto);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.mskTotalServico);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.dgvListaProdutos);
            this.groupBox7.Controls.Add(this.btnExcluirServico);
            this.groupBox7.Controls.Add(this.dgvListaServicos);
            this.groupBox7.Location = new System.Drawing.Point(3, 44);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(759, 350);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Serviço/Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Total Geral R$";
            // 
            // mskTotalGeral
            // 
            this.mskTotalGeral.Enabled = false;
            this.mskTotalGeral.Location = new System.Drawing.Point(653, 322);
            this.mskTotalGeral.Name = "mskTotalGeral";
            this.mskTotalGeral.Size = new System.Drawing.Size(84, 20);
            this.mskTotalGeral.TabIndex = 52;
            // 
            // mskTotalProduto
            // 
            this.mskTotalProduto.Enabled = false;
            this.mskTotalProduto.Location = new System.Drawing.Point(653, 270);
            this.mskTotalProduto.Name = "mskTotalProduto";
            this.mskTotalProduto.Size = new System.Drawing.Size(84, 20);
            this.mskTotalProduto.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Total Produto R$";
            // 
            // mskTotalServico
            // 
            this.mskTotalServico.Enabled = false;
            this.mskTotalServico.Location = new System.Drawing.Point(653, 89);
            this.mskTotalServico.Name = "mskTotalServico";
            this.mskTotalServico.Size = new System.Drawing.Size(84, 20);
            this.mskTotalServico.TabIndex = 49;
            this.mskTotalServico.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTotalServico_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Total Serviço R$";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Produto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Serviço";
            // 
            // dgvListaProdutos
            // 
            this.dgvListaProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Quantidade,
            this.Valor});
            this.dgvListaProdutos.Enabled = false;
            this.dgvListaProdutos.Location = new System.Drawing.Point(6, 190);
            this.dgvListaProdutos.Name = "dgvListaProdutos";
            this.dgvListaProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProdutos.Size = new System.Drawing.Size(638, 120);
            this.dgvListaProdutos.TabIndex = 43;
            // 
            // Produto
            // 
            this.Produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Produto.DataPropertyName = "Produto";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Qtde";
            this.Quantidade.Name = "Quantidade";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor (R$)";
            this.Valor.Name = "Valor";
            // 
            // btnExcluirServico
            // 
            this.btnExcluirServico.BackColor = System.Drawing.Color.White;
            this.btnExcluirServico.Location = new System.Drawing.Point(649, 35);
            this.btnExcluirServico.Name = "btnExcluirServico";
            this.btnExcluirServico.Size = new System.Drawing.Size(104, 25);
            this.btnExcluirServico.TabIndex = 39;
            this.btnExcluirServico.Text = "Excluir Serviço";
            this.btnExcluirServico.UseVisualStyleBackColor = false;
            this.btnExcluirServico.Click += new System.EventHandler(this.btnExcluirServico_Click);
            // 
            // dgvListaServicos
            // 
            this.dgvListaServicos.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tiposerv_descricao,
            this.agen_dataagendamento,
            this.agen_valor});
            this.dgvListaServicos.Enabled = false;
            this.dgvListaServicos.Location = new System.Drawing.Point(15, 35);
            this.dgvListaServicos.Name = "dgvListaServicos";
            this.dgvListaServicos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaServicos.Size = new System.Drawing.Size(629, 127);
            this.dgvListaServicos.TabIndex = 42;
            // 
            // tiposerv_descricao
            // 
            this.tiposerv_descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tiposerv_descricao.DataPropertyName = "tiposerv_descricao";
            this.tiposerv_descricao.HeaderText = "Serviço";
            this.tiposerv_descricao.Name = "tiposerv_descricao";
            // 
            // agen_dataagendamento
            // 
            this.agen_dataagendamento.DataPropertyName = "agen_dataagendamento";
            this.agen_dataagendamento.HeaderText = "Data Serviço";
            this.agen_dataagendamento.Name = "agen_dataagendamento";
            this.agen_dataagendamento.Width = 120;
            // 
            // agen_valor
            // 
            this.agen_valor.DataPropertyName = "agen_valor";
            this.agen_valor.HeaderText = "Valor (R$)";
            this.agen_valor.Name = "agen_valor";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(695, 7);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(67, 38);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(123, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 38);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(12, 7);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(105, 38);
            this.btnFinalizar.TabIndex = 0;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // Fechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Fechamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H.L - FECHAMENTO";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvListaProdutos;
        public System.Windows.Forms.Button btnExcluirServico;
        private System.Windows.Forms.DataGridView dgvListaServicos;
        private System.Windows.Forms.TextBox ttbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskTotalProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTotalServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTotalGeral;
        public System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposerv_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn agen_dataagendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn agen_valor;
    }
}