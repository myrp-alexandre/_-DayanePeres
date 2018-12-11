namespace HairLumos.Views.Funcoes_Fundamentais.RF_F5
{
    partial class GerarContaPagar
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
            this.mskValorTotoalPagar = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.CodParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ttbObservacao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbManual = new System.Windows.Forms.CheckBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.mskValorParcela = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.mskValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.ttbQtdeParcela = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.mskValorTotoalPagar);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.splitContainer1.Panel2.Controls.Add(this.btnSair);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnFinalizar);
            this.splitContainer1.Size = new System.Drawing.Size(502, 383);
            this.splitContainer1.SplitterDistance = 327;
            this.splitContainer1.TabIndex = 3;
            // 
            // mskValorTotoalPagar
            // 
            this.mskValorTotoalPagar.Enabled = false;
            this.mskValorTotoalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskValorTotoalPagar.ForeColor = System.Drawing.Color.Red;
            this.mskValorTotoalPagar.Location = new System.Drawing.Point(421, 285);
            this.mskValorTotoalPagar.Name = "mskValorTotoalPagar";
            this.mskValorTotoalPagar.Size = new System.Drawing.Size(67, 21);
            this.mskValorTotoalPagar.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(413, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Valor Total (R$)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 125);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(396, 199);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvContas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(388, 173);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contas a Pagar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvContas
            // 
            this.dgvContas.AllowUserToAddRows = false;
            this.dgvContas.AllowUserToDeleteRows = false;
            this.dgvContas.BackgroundColor = System.Drawing.Color.White;
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodParcela,
            this.ValorParcela,
            this.DataVencimento});
            this.dgvContas.Enabled = false;
            this.dgvContas.Location = new System.Drawing.Point(9, 8);
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.ReadOnly = true;
            this.dgvContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContas.Size = new System.Drawing.Size(373, 162);
            this.dgvContas.TabIndex = 34;
            // 
            // CodParcela
            // 
            this.CodParcela.DataPropertyName = "CodParcela";
            this.CodParcela.HeaderText = "Parcela";
            this.CodParcela.Name = "CodParcela";
            this.CodParcela.ReadOnly = true;
            // 
            // ValorParcela
            // 
            this.ValorParcela.DataPropertyName = "ValorParcela";
            this.ValorParcela.HeaderText = "Valor Parcela (R$)";
            this.ValorParcela.Name = "ValorParcela";
            this.ValorParcela.ReadOnly = true;
            this.ValorParcela.Width = 125;
            // 
            // DataVencimento
            // 
            this.DataVencimento.DataPropertyName = "DataVencimento";
            this.DataVencimento.HeaderText = "Data Vencimento";
            this.DataVencimento.Name = "DataVencimento";
            this.DataVencimento.ReadOnly = true;
            this.DataVencimento.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ttbObservacao);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(388, 173);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Observações";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ttbObservacao
            // 
            this.ttbObservacao.Location = new System.Drawing.Point(9, 20);
            this.ttbObservacao.Multiline = true;
            this.ttbObservacao.Name = "ttbObservacao";
            this.ttbObservacao.Size = new System.Drawing.Size(373, 138);
            this.ttbObservacao.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbManual);
            this.groupBox1.Controls.Add(this.btnIncluir);
            this.groupBox1.Controls.Add(this.mskValorParcela);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDataVencimento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mskValorTotal);
            this.groupBox1.Controls.Add(this.ttbQtdeParcela);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 109);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // cbManual
            // 
            this.cbManual.AutoSize = true;
            this.cbManual.Location = new System.Drawing.Point(301, 39);
            this.cbManual.Name = "cbManual";
            this.cbManual.Size = new System.Drawing.Size(61, 17);
            this.cbManual.TabIndex = 32;
            this.cbManual.Text = "Manual";
            this.cbManual.UseVisualStyleBackColor = true;
            this.cbManual.CheckedChanged += new System.EventHandler(this.cbManual_CheckedChanged);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.White;
            this.btnIncluir.Location = new System.Drawing.Point(391, 39);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(67, 27);
            this.btnIncluir.TabIndex = 2;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // mskValorParcela
            // 
            this.mskValorParcela.Enabled = false;
            this.mskValorParcela.Location = new System.Drawing.Point(165, 82);
            this.mskValorParcela.Name = "mskValorParcela";
            this.mskValorParcela.Size = new System.Drawing.Size(100, 20);
            this.mskValorParcela.TabIndex = 4;
            this.mskValorParcela.Enter += new System.EventHandler(this.mskValorParcela_Enter);
            this.mskValorParcela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskValorParcela_KeyPress);
            this.mskValorParcela.Leave += new System.EventHandler(this.mskValorParcela_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Valor da Parcela (R$):";
            // 
            // dtpDataVencimento
            // 
            this.dtpDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimento.Location = new System.Drawing.Point(9, 34);
            this.dtpDataVencimento.Name = "dtpDataVencimento";
            this.dtpDataVencimento.Size = new System.Drawing.Size(101, 20);
            this.dtpDataVencimento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Data de Vencimento";
            // 
            // mskValorTotal
            // 
            this.mskValorTotal.Enabled = false;
            this.mskValorTotal.Location = new System.Drawing.Point(9, 82);
            this.mskValorTotal.Name = "mskValorTotal";
            this.mskValorTotal.Size = new System.Drawing.Size(100, 20);
            this.mskValorTotal.TabIndex = 3;
            this.mskValorTotal.Enter += new System.EventHandler(this.mskValorTotal_Enter);
            this.mskValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskValorTotal_KeyPress);
            this.mskValorTotal.Leave += new System.EventHandler(this.mskValorTotal_Leave);
            // 
            // ttbQtdeParcela
            // 
            this.ttbQtdeParcela.Location = new System.Drawing.Point(165, 34);
            this.ttbQtdeParcela.Name = "ttbQtdeParcela";
            this.ttbQtdeParcela.Size = new System.Drawing.Size(63, 20);
            this.ttbQtdeParcela.TabIndex = 1;
            this.ttbQtdeParcela.TextChanged += new System.EventHandler(this.ttbQtdeParcela_TextChanged);
            this.ttbQtdeParcela.Enter += new System.EventHandler(this.ttbQtdeParcela_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Qtde Parcela";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Valor Total (R$):";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(421, 7);
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
            this.btnCancelar.Location = new System.Drawing.Point(141, 7);
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
            this.btnFinalizar.Location = new System.Drawing.Point(28, 7);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(105, 38);
            this.btnFinalizar.TabIndex = 0;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // GerarContaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(526, 404);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "GerarContaPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HL - GERAR CONTAS A PAGAR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GerarContaPagar_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TextBox ttbQtdeParcela;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskValorTotal;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDataVencimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskValorParcela;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvContas;
        public System.Windows.Forms.Button btnIncluir;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox ttbObservacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVencimento;
        private System.Windows.Forms.CheckBox cbManual;
        private System.Windows.Forms.MaskedTextBox mskValorTotoalPagar;
        public System.Windows.Forms.Label label5;
    }
}