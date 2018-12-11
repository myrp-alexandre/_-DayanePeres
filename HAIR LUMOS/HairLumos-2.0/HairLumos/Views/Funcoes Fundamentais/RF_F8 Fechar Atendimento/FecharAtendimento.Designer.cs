namespace HairLumos.Views.Funcoes_Fundamentais.RF_F8_Fechar_Atendimento
{
    partial class FecharAtendimento
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFecharVenda = new System.Windows.Forms.Button();
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
            this.dgvformasPagamento = new System.Windows.Forms.DataGridView();
            this.Forma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionarPagamento = new System.Windows.Forms.Button();
            this.cbbForma = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskValorPagar = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskDesconto = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskAcrescimo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ttbCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvformasPagamento)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fechamento de Atendimento/Venda";
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
            this.groupBox4.Location = new System.Drawing.Point(13, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(780, 367);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Finalizar Venda";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBox3.Controls.Add(this.btnSair);
            this.groupBox3.Controls.Add(this.btnFecharVenda);
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
            this.btnSair.Location = new System.Drawing.Point(159, 73);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(116, 35);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnFecharVenda
            // 
            this.btnFecharVenda.BackColor = System.Drawing.Color.White;
            this.btnFecharVenda.Location = new System.Drawing.Point(6, 23);
            this.btnFecharVenda.Name = "btnFecharVenda";
            this.btnFecharVenda.Size = new System.Drawing.Size(269, 38);
            this.btnFecharVenda.TabIndex = 0;
            this.btnFecharVenda.Text = "FECHAR VENDA";
            this.btnFecharVenda.UseVisualStyleBackColor = false;
            this.btnFecharVenda.Click += new System.EventHandler(this.btnFecharVenda_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(6, 73);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 35);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.mskTroco.Enter += new System.EventHandler(this.mskTroco_Enter);
            this.mskTroco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTroco_KeyPress);
            this.mskTroco.Leave += new System.EventHandler(this.mskTroco_Leave);
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
            this.mskRestante.Enter += new System.EventHandler(this.mskRestante_Enter);
            this.mskRestante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskRestante_KeyPress);
            this.mskRestante.Leave += new System.EventHandler(this.mskRestante_Leave);
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
            this.mskRecebido.Enter += new System.EventHandler(this.mskRecebido_Enter);
            this.mskRecebido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskRecebido_KeyPress);
            this.mskRecebido.Leave += new System.EventHandler(this.mskRecebido_Leave);
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
            this.mskTotal.Enter += new System.EventHandler(this.mskTotal_Enter);
            this.mskTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTotal_KeyPress);
            this.mskTotal.Leave += new System.EventHandler(this.mskTotal_Leave);
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
            this.mskSubtotal.Enter += new System.EventHandler(this.mskSubtotal_Enter);
            this.mskSubtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskSubtotal_KeyPress);
            this.mskSubtotal.Leave += new System.EventHandler(this.mskSubtotal_Leave);
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
            this.groupBox5.Controls.Add(this.dgvformasPagamento);
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
            this.btnExcluirForma.Click += new System.EventHandler(this.btnExcluirForma_Click);
            // 
            // dgvformasPagamento
            // 
            this.dgvformasPagamento.AllowUserToAddRows = false;
            this.dgvformasPagamento.AllowUserToDeleteRows = false;
            this.dgvformasPagamento.BackgroundColor = System.Drawing.Color.White;
            this.dgvformasPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvformasPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Forma,
            this.Valor});
            this.dgvformasPagamento.Enabled = false;
            this.dgvformasPagamento.Location = new System.Drawing.Point(6, 19);
            this.dgvformasPagamento.Name = "dgvformasPagamento";
            this.dgvformasPagamento.ReadOnly = true;
            this.dgvformasPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvformasPagamento.Size = new System.Drawing.Size(329, 170);
            this.dgvformasPagamento.TabIndex = 31;
            // 
            // Forma
            // 
            this.Forma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Forma.DataPropertyName = "Forma";
            this.Forma.HeaderText = "Forma de Pagamento";
            this.Forma.Name = "Forma";
            this.Forma.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
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
            this.btnAdicionarPagamento.Click += new System.EventHandler(this.btnAdicionarPagamento_Click);
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
            this.mskValorPagar.Enter += new System.EventHandler(this.mskValorPagar_Enter);
            this.mskValorPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskValorPagar_KeyPress);
            this.mskValorPagar.Leave += new System.EventHandler(this.mskValorPagar_Leave);
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
            this.mskDesconto.Enter += new System.EventHandler(this.mskDesconto_Enter);
            this.mskDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskDesconto_KeyPress);
            this.mskDesconto.Leave += new System.EventHandler(this.mskDesconto_Leave);
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
            this.mskAcrescimo.Enter += new System.EventHandler(this.mskAcrescimo_Enter);
            this.mskAcrescimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskAcrescimo_KeyPress);
            this.mskAcrescimo.Leave += new System.EventHandler(this.mskAcrescimo_Leave);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ttbCliente);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 51);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // ttbCliente
            // 
            this.ttbCliente.Enabled = false;
            this.ttbCliente.Location = new System.Drawing.Point(50, 19);
            this.ttbCliente.Name = "ttbCliente";
            this.ttbCliente.Size = new System.Drawing.Size(714, 20);
            this.ttbCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // FecharAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(824, 477);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "FecharAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H.L - FECHAR ATENDIMENTO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvformasPagamento)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ttbCliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Button btnExcluirForma;
        private System.Windows.Forms.DataGridView dgvformasPagamento;
        public System.Windows.Forms.Button btnAdicionarPagamento;
        private System.Windows.Forms.ComboBox cbbForma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskValorPagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskDesconto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskAcrescimo;
        private System.Windows.Forms.Label label2;
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
        public System.Windows.Forms.Button btnFecharVenda;
        public System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}