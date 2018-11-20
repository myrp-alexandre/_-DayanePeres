namespace HairLumos.Views.Funcoes_Fundamentais.RF_F15_Acerto_de_Consignado
{
    partial class AcertoConsignado
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
            this.label5 = new System.Windows.Forms.Label();
            this.mskTotalDevolvidos = new System.Windows.Forms.MaskedTextBox();
            this.dgvDevolvidos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTotalCompradosVendidos = new System.Windows.Forms.MaskedTextBox();
            this.dgvCompradosVendidos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisaFornecedor = new System.Windows.Forms.Button();
            this.Código = new System.Windows.Forms.Label();
            this.ttbFornecedor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskTotalPedidos = new System.Windows.Forms.MaskedTextBox();
            this.ttbQtde = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.Descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolvidos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompradosVendidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnPesquisaFornecedor);
            this.splitContainer1.Panel1.Controls.Add(this.Código);
            this.splitContainer1.Panel1.Controls.Add(this.ttbFornecedor);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.btnPesquisa);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnSair);
            this.splitContainer1.Panel2.Controls.Add(this.btnExcluir);
            this.splitContainer1.Panel2.Controls.Add(this.btnGravar);
            this.splitContainer1.Panel2.Controls.Add(this.btnNovo);
            this.splitContainer1.Size = new System.Drawing.Size(781, 725);
            this.splitContainer1.SplitterDistance = 660;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.mskTotalDevolvidos);
            this.groupBox3.Controls.Add(this.dgvDevolvidos);
            this.groupBox3.Location = new System.Drawing.Point(16, 458);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(754, 194);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Devolvidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Total (R$)";
            // 
            // mskTotalDevolvidos
            // 
            this.mskTotalDevolvidos.Enabled = false;
            this.mskTotalDevolvidos.Location = new System.Drawing.Point(640, 157);
            this.mskTotalDevolvidos.Mask = "00";
            this.mskTotalDevolvidos.Name = "mskTotalDevolvidos";
            this.mskTotalDevolvidos.Size = new System.Drawing.Size(100, 20);
            this.mskTotalDevolvidos.TabIndex = 42;
            this.mskTotalDevolvidos.ValidatingType = typeof(int);
            this.mskTotalDevolvidos.Enter += new System.EventHandler(this.mskTotalDevolvidos_Enter);
            this.mskTotalDevolvidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTotalDevolvidos_KeyPress);
            this.mskTotalDevolvidos.Leave += new System.EventHandler(this.mskTotalDevolvidos_Leave);
            // 
            // dgvDevolvidos
            // 
            this.dgvDevolvidos.AllowUserToAddRows = false;
            this.dgvDevolvidos.AllowUserToDeleteRows = false;
            this.dgvDevolvidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDevolvidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolvidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvDevolvidos.Location = new System.Drawing.Point(6, 21);
            this.dgvDevolvidos.Name = "dgvDevolvidos";
            this.dgvDevolvidos.ReadOnly = true;
            this.dgvDevolvidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevolvidos.Size = new System.Drawing.Size(740, 114);
            this.dgvDevolvidos.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descr";
            this.dataGridViewTextBoxColumn4.HeaderText = "Serviço";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Qtde";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Pacote";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mskTotalCompradosVendidos);
            this.groupBox2.Controls.Add(this.dgvCompradosVendidos);
            this.groupBox2.Location = new System.Drawing.Point(16, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 194);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comprados/Vendidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Total (R$)";
            // 
            // mskTotalCompradosVendidos
            // 
            this.mskTotalCompradosVendidos.Enabled = false;
            this.mskTotalCompradosVendidos.Location = new System.Drawing.Point(640, 157);
            this.mskTotalCompradosVendidos.Mask = "00";
            this.mskTotalCompradosVendidos.Name = "mskTotalCompradosVendidos";
            this.mskTotalCompradosVendidos.Size = new System.Drawing.Size(100, 20);
            this.mskTotalCompradosVendidos.TabIndex = 42;
            this.mskTotalCompradosVendidos.ValidatingType = typeof(int);
            this.mskTotalCompradosVendidos.Enter += new System.EventHandler(this.mskTotalCompradosVendidos_Enter);
            this.mskTotalCompradosVendidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTotalCompradosVendidos_KeyPress);
            this.mskTotalCompradosVendidos.Leave += new System.EventHandler(this.mskTotalCompradosVendidos_Leave);
            // 
            // dgvCompradosVendidos
            // 
            this.dgvCompradosVendidos.AllowUserToAddRows = false;
            this.dgvCompradosVendidos.AllowUserToDeleteRows = false;
            this.dgvCompradosVendidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompradosVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompradosVendidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvCompradosVendidos.Location = new System.Drawing.Point(6, 21);
            this.dgvCompradosVendidos.Name = "dgvCompradosVendidos";
            this.dgvCompradosVendidos.ReadOnly = true;
            this.dgvCompradosVendidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompradosVendidos.Size = new System.Drawing.Size(740, 114);
            this.dgvCompradosVendidos.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Descr";
            this.dataGridViewTextBoxColumn1.HeaderText = "Serviço";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Qtde";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pacote";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // btnPesquisaFornecedor
            // 
            this.btnPesquisaFornecedor.BackColor = System.Drawing.Color.White;
            this.btnPesquisaFornecedor.Location = new System.Drawing.Point(627, 13);
            this.btnPesquisaFornecedor.Name = "btnPesquisaFornecedor";
            this.btnPesquisaFornecedor.Size = new System.Drawing.Size(143, 27);
            this.btnPesquisaFornecedor.TabIndex = 1;
            this.btnPesquisaFornecedor.Text = "Pesquisa Fornecedor";
            this.btnPesquisaFornecedor.UseVisualStyleBackColor = false;
            // 
            // Código
            // 
            this.Código.AutoSize = true;
            this.Código.Location = new System.Drawing.Point(17, 20);
            this.Código.Name = "Código";
            this.Código.Size = new System.Drawing.Size(65, 13);
            this.Código.TabIndex = 33;
            this.Código.Text = "Fornecedor*";
            // 
            // ttbFornecedor
            // 
            this.ttbFornecedor.Enabled = false;
            this.ttbFornecedor.Location = new System.Drawing.Point(88, 17);
            this.ttbFornecedor.Name = "ttbFornecedor";
            this.ttbFornecedor.Size = new System.Drawing.Size(533, 20);
            this.ttbFornecedor.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mskTotalPedidos);
            this.groupBox1.Controls.Add(this.ttbQtde);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvPedidos);
            this.groupBox1.Location = new System.Drawing.Point(16, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 185);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Total (R$)";
            // 
            // mskTotalPedidos
            // 
            this.mskTotalPedidos.Enabled = false;
            this.mskTotalPedidos.Location = new System.Drawing.Point(640, 151);
            this.mskTotalPedidos.Mask = "00";
            this.mskTotalPedidos.Name = "mskTotalPedidos";
            this.mskTotalPedidos.Size = new System.Drawing.Size(100, 20);
            this.mskTotalPedidos.TabIndex = 1;
            this.mskTotalPedidos.ValidatingType = typeof(int);
            this.mskTotalPedidos.Enter += new System.EventHandler(this.mskTotalPedidos_Enter);
            this.mskTotalPedidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTotalPedidos_KeyPress);
            this.mskTotalPedidos.Leave += new System.EventHandler(this.mskTotalPedidos_Leave);
            // 
            // ttbQtde
            // 
            this.ttbQtde.Location = new System.Drawing.Point(469, 151);
            this.ttbQtde.Mask = "00";
            this.ttbQtde.Name = "ttbQtde";
            this.ttbQtde.Size = new System.Drawing.Size(100, 20);
            this.ttbQtde.TabIndex = 0;
            this.ttbQtde.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Qtde:";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descr,
            this.Qtde,
            this.Tipo});
            this.dgvPedidos.Location = new System.Drawing.Point(6, 21);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(740, 114);
            this.dgvPedidos.TabIndex = 12;
            // 
            // Descr
            // 
            this.Descr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descr.DataPropertyName = "Descr";
            this.Descr.HeaderText = "Serviço";
            this.Descr.Name = "Descr";
            this.Descr.ReadOnly = true;
            // 
            // Qtde
            // 
            this.Qtde.DataPropertyName = "Qtde";
            this.Qtde.HeaderText = "Quantidade";
            this.Qtde.Name = "Qtde";
            this.Qtde.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Pacote";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 150;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(485, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Finalizar Consignado";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.White;
            this.btnPesquisa.Location = new System.Drawing.Point(189, 11);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(78, 38);
            this.btnPesquisa.TabIndex = 2;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(357, 11);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 38);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(693, 11);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 38);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(273, 11);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(78, 38);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.White;
            this.btnGravar.Location = new System.Drawing.Point(105, 11);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(78, 38);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(21, 11);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(78, 38);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // AcertoConsignado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(805, 749);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "AcertoConsignado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H.L - ACERTO DE CONSIGNADO";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolvidos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompradosVendidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Button btnPesquisa;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnNovo;
        public System.Windows.Forms.Label Código;
        public System.Windows.Forms.TextBox ttbFornecedor;
        public System.Windows.Forms.Button btnPesquisaFornecedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskTotalPedidos;
        private System.Windows.Forms.MaskedTextBox ttbQtde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTotalDevolvidos;
        private System.Windows.Forms.DataGridView dgvDevolvidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTotalCompradosVendidos;
        private System.Windows.Forms.DataGridView dgvCompradosVendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public System.Windows.Forms.Button button1;
    }
}