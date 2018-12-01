namespace HairLumos.Views.Funcoes_Fundamentais.RF_F10___Quitar_Despesa
{
    partial class PagarDespesa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ttbDespesa = new System.Windows.Forms.TextBox();
            this.dgvDespesas = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnpAGAMENTOdESPESA = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.mskTroco = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskRestante = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskRecebido = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskTotal = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskSubtotal = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnExcluirForma = new System.Windows.Forms.Button();
            this.dgvFormasPagamento = new System.Windows.Forms.DataGridView();
            this.btnAdicionarPagamento = new System.Windows.Forms.Button();
            this.cbbForma = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskValorPagar = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskDesconto = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskAcrescimo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormasPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 636);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagamento de Despesa";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ttbCodigo);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.ttbDespesa);
            this.groupBox7.Controls.Add(this.dgvDespesas);
            this.groupBox7.Location = new System.Drawing.Point(13, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(780, 240);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Itens Despesa";
            // 
            // ttbCodigo
            // 
            this.ttbCodigo.Enabled = false;
            this.ttbCodigo.Location = new System.Drawing.Point(88, 35);
            this.ttbCodigo.Name = "ttbCodigo";
            this.ttbCodigo.Size = new System.Drawing.Size(78, 20);
            this.ttbCodigo.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "CÓDIGO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "TIPO DESPESA:";
            // 
            // ttbDespesa
            // 
            this.ttbDespesa.Enabled = false;
            this.ttbDespesa.Location = new System.Drawing.Point(335, 35);
            this.ttbDespesa.Name = "ttbDespesa";
            this.ttbDespesa.Size = new System.Drawing.Size(371, 20);
            this.ttbDespesa.TabIndex = 34;
            // 
            // dgvDespesas
            // 
            this.dgvDespesas.BackgroundColor = System.Drawing.Color.White;
            this.dgvDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Qtde,
            this.Valor});
            this.dgvDespesas.Location = new System.Drawing.Point(17, 79);
            this.dgvDespesas.Name = "dgvDespesas";
            this.dgvDespesas.Size = new System.Drawing.Size(747, 155);
            this.dgvDespesas.TabIndex = 33;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnAdicionarPagamento);
            this.groupBox4.Controls.Add(this.cbbForma);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.mskValorPagar);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.mskDesconto);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.mskAcrescimo);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(13, 265);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(780, 367);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Finalizar Pagamento Despesa";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBox3.Controls.Add(this.btnSair);
            this.groupBox3.Controls.Add(this.btnpAGAMENTOdESPESA);
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Location = new System.Drawing.Point(468, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 114);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(166, 69);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(116, 35);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnpAGAMENTOdESPESA
            // 
            this.btnpAGAMENTOdESPESA.BackColor = System.Drawing.Color.White;
            this.btnpAGAMENTOdESPESA.Location = new System.Drawing.Point(13, 19);
            this.btnpAGAMENTOdESPESA.Name = "btnpAGAMENTOdESPESA";
            this.btnpAGAMENTOdESPESA.Size = new System.Drawing.Size(269, 38);
            this.btnpAGAMENTOdESPESA.TabIndex = 0;
            this.btnpAGAMENTOdESPESA.Text = "CONCLUIR PAGAMENTO DESPESA";
            this.btnpAGAMENTOdESPESA.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(13, 69);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 35);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.mskTroco);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.mskRestante);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.mskRecebido);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.mskTotal);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.mskSubtotal);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(468, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(297, 224);
            this.groupBox6.TabIndex = 44;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Valores";
            // 
            // mskTroco
            // 
            this.mskTroco.Enabled = false;
            this.mskTroco.Location = new System.Drawing.Point(151, 177);
            this.mskTroco.Name = "mskTroco";
            this.mskTroco.Size = new System.Drawing.Size(115, 20);
            this.mskTroco.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "TROCO";
            // 
            // mskRestante
            // 
            this.mskRestante.Enabled = false;
            this.mskRestante.Location = new System.Drawing.Point(151, 137);
            this.mskRestante.Name = "mskRestante";
            this.mskRestante.Size = new System.Drawing.Size(115, 20);
            this.mskRestante.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "RESTANTE";
            // 
            // mskRecebido
            // 
            this.mskRecebido.Enabled = false;
            this.mskRecebido.Location = new System.Drawing.Point(151, 95);
            this.mskRecebido.Name = "mskRecebido";
            this.mskRecebido.Size = new System.Drawing.Size(115, 20);
            this.mskRecebido.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "RECEBIDO";
            // 
            // mskTotal
            // 
            this.mskTotal.Enabled = false;
            this.mskTotal.Location = new System.Drawing.Point(151, 54);
            this.mskTotal.Name = "mskTotal";
            this.mskTotal.Size = new System.Drawing.Size(115, 20);
            this.mskTotal.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "TOTAL";
            // 
            // mskSubtotal
            // 
            this.mskSubtotal.Enabled = false;
            this.mskSubtotal.Location = new System.Drawing.Point(151, 18);
            this.mskSubtotal.Name = "mskSubtotal";
            this.mskSubtotal.Size = new System.Drawing.Size(115, 20);
            this.mskSubtotal.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "SUBTOTAL";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnExcluirForma);
            this.groupBox5.Controls.Add(this.dgvFormasPagamento);
            this.groupBox5.Location = new System.Drawing.Point(11, 166);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(439, 195);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Formas de Pagamentos Adicionadas";
            // 
            // btnExcluirForma
            // 
            this.btnExcluirForma.BackColor = System.Drawing.Color.White;
            this.btnExcluirForma.Location = new System.Drawing.Point(341, 76);
            this.btnExcluirForma.Name = "btnExcluirForma";
            this.btnExcluirForma.Size = new System.Drawing.Size(92, 29);
            this.btnExcluirForma.TabIndex = 0;
            this.btnExcluirForma.Text = "Excluir";
            this.btnExcluirForma.UseVisualStyleBackColor = false;
            // 
            // dgvFormasPagamento
            // 
            this.dgvFormasPagamento.BackgroundColor = System.Drawing.Color.White;
            this.dgvFormasPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormasPagamento.Location = new System.Drawing.Point(6, 19);
            this.dgvFormasPagamento.Name = "dgvFormasPagamento";
            this.dgvFormasPagamento.Size = new System.Drawing.Size(329, 170);
            this.dgvFormasPagamento.TabIndex = 31;
            // 
            // btnAdicionarPagamento
            // 
            this.btnAdicionarPagamento.BackColor = System.Drawing.Color.White;
            this.btnAdicionarPagamento.Location = new System.Drawing.Point(223, 123);
            this.btnAdicionarPagamento.Name = "btnAdicionarPagamento";
            this.btnAdicionarPagamento.Size = new System.Drawing.Size(129, 29);
            this.btnAdicionarPagamento.TabIndex = 4;
            this.btnAdicionarPagamento.Text = "Adicionar Pagamento";
            this.btnAdicionarPagamento.UseVisualStyleBackColor = false;
            // 
            // cbbForma
            // 
            this.cbbForma.FormattingEnabled = true;
            this.cbbForma.Location = new System.Drawing.Point(107, 91);
            this.cbbForma.Name = "cbbForma";
            this.cbbForma.Size = new System.Drawing.Size(245, 21);
            this.cbbForma.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "FORMA";
            // 
            // mskValorPagar
            // 
            this.mskValorPagar.Location = new System.Drawing.Point(107, 128);
            this.mskValorPagar.Name = "mskValorPagar";
            this.mskValorPagar.Size = new System.Drawing.Size(111, 20);
            this.mskValorPagar.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "VALOR À PAGAR";
            // 
            // mskDesconto
            // 
            this.mskDesconto.Location = new System.Drawing.Point(107, 59);
            this.mskDesconto.Name = "mskDesconto";
            this.mskDesconto.Size = new System.Drawing.Size(111, 20);
            this.mskDesconto.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESCONTO";
            // 
            // mskAcrescimo
            // 
            this.mskAcrescimo.Location = new System.Drawing.Point(107, 17);
            this.mskAcrescimo.Name = "mskAcrescimo";
            this.mskAcrescimo.Size = new System.Drawing.Size(111, 20);
            this.mskAcrescimo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ACRÉSCIMO";
            // 
            // Produto
            // 
            this.Produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Produto.DataPropertyName = "Produto";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // Qtde
            // 
            this.Qtde.DataPropertyName = "Qtde";
            this.Qtde.HeaderText = "Quantidade";
            this.Qtde.Name = "Qtde";
            this.Qtde.Width = 180;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Width = 180;
            // 
            // PagarDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(824, 660);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "PagarDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H.L - PAGAMENTO DE DESPESAS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormasPagamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnpAGAMENTOdESPESA;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.MaskedTextBox mskTroco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskRestante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskRecebido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskSubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Button btnExcluirForma;
        private System.Windows.Forms.DataGridView dgvFormasPagamento;
        public System.Windows.Forms.Button btnAdicionarPagamento;
        private System.Windows.Forms.ComboBox cbbForma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskValorPagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskDesconto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskAcrescimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvDespesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbDespesa;
        private System.Windows.Forms.TextBox ttbCodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}