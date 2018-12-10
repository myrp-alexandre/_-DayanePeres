namespace HairLumos.Views.Funcoes_Fundamentais
{
    partial class QuitarDespesa
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
            this.labelVencido = new System.Windows.Forms.Label();
            this.ttbTotalPago = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ttbTotalVencido = new System.Windows.Forms.MaskedTextBox();
            this.ttbTotalPagar = new System.Windows.Forms.MaskedTextBox();
            this.labelEmAberto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPago = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbQuitadas = new System.Windows.Forms.CheckBox();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.codContasPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desp_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contpag_valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contPag_Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contpag_numparc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contPag_valorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contpag_valorpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contpag_datapagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contpag_datavencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contpag_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnEstornar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.cbCompras = new System.Windows.Forms.CheckBox();
            this.cbDespesas = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dgvContas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.splitContainer1.Panel2.Controls.Add(this.BtnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnEstornar);
            this.splitContainer1.Panel2.Controls.Add(this.btnSair);
            this.splitContainer1.Panel2.Controls.Add(this.btnQuitar);
            this.splitContainer1.Size = new System.Drawing.Size(792, 467);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelVencido);
            this.groupBox2.Controls.Add(this.ttbTotalPago);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.ttbTotalVencido);
            this.groupBox2.Controls.Add(this.ttbTotalPagar);
            this.groupBox2.Controls.Add(this.labelEmAberto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labelPago);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(20, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 65);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            // 
            // labelVencido
            // 
            this.labelVencido.AutoSize = true;
            this.labelVencido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVencido.Image = global::HairLumos.Properties.Resources._vermelho;
            this.labelVencido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelVencido.Location = new System.Drawing.Point(171, 39);
            this.labelVencido.Name = "labelVencido";
            this.labelVencido.Size = new System.Drawing.Size(66, 15);
            this.labelVencido.TabIndex = 52;
            this.labelVencido.Text = "     Vencido";
            this.labelVencido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ttbTotalPago
            // 
            this.ttbTotalPago.Enabled = false;
            this.ttbTotalPago.Location = new System.Drawing.Point(542, 34);
            this.ttbTotalPago.Name = "ttbTotalPago";
            this.ttbTotalPago.Size = new System.Drawing.Size(100, 20);
            this.ttbTotalPago.TabIndex = 47;
            this.ttbTotalPago.Enter += new System.EventHandler(this.ttbTotalPago_Enter);
            this.ttbTotalPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbTotalPago_KeyPress);
            this.ttbTotalPago.Leave += new System.EventHandler(this.ttbTotalPago_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(10, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Legenda:";
            // 
            // ttbTotalVencido
            // 
            this.ttbTotalVencido.Enabled = false;
            this.ttbTotalVencido.Location = new System.Drawing.Point(653, 34);
            this.ttbTotalVencido.Name = "ttbTotalVencido";
            this.ttbTotalVencido.Size = new System.Drawing.Size(100, 20);
            this.ttbTotalVencido.TabIndex = 46;
            this.ttbTotalVencido.Enter += new System.EventHandler(this.ttbTotalVencido_Enter);
            this.ttbTotalVencido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbTotalVencido_KeyPress);
            this.ttbTotalVencido.Leave += new System.EventHandler(this.ttbTotalVencido_Leave);
            // 
            // ttbTotalPagar
            // 
            this.ttbTotalPagar.Enabled = false;
            this.ttbTotalPagar.Location = new System.Drawing.Point(426, 34);
            this.ttbTotalPagar.Name = "ttbTotalPagar";
            this.ttbTotalPagar.Size = new System.Drawing.Size(100, 20);
            this.ttbTotalPagar.TabIndex = 45;
            this.ttbTotalPagar.Enter += new System.EventHandler(this.ttbTotalPagar_Enter_1);
            this.ttbTotalPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbTotalPagar_KeyPress);
            this.ttbTotalPagar.Leave += new System.EventHandler(this.ttbTotalPagar_Leave);
            // 
            // labelEmAberto
            // 
            this.labelEmAberto.AutoSize = true;
            this.labelEmAberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmAberto.Image = global::HairLumos.Properties.Resources._azul;
            this.labelEmAberto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEmAberto.Location = new System.Drawing.Point(10, 39);
            this.labelEmAberto.Name = "labelEmAberto";
            this.labelEmAberto.Size = new System.Drawing.Size(79, 15);
            this.labelEmAberto.TabIndex = 50;
            this.labelEmAberto.Text = "     Em aberto";
            this.labelEmAberto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(650, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Total Vencido:";
            // 
            // labelPago
            // 
            this.labelPago.AutoSize = true;
            this.labelPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPago.Image = global::HairLumos.Properties.Resources._verde;
            this.labelPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPago.Location = new System.Drawing.Point(97, 39);
            this.labelPago.Name = "labelPago";
            this.labelPago.Size = new System.Drawing.Size(51, 15);
            this.labelPago.TabIndex = 51;
            this.labelPago.Text = "     Pago";
            this.labelPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(539, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Total Pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(423, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Total a Pagar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDespesas);
            this.groupBox1.Controls.Add(this.cbCompras);
            this.groupBox1.Controls.Add(this.chbQuitadas);
            this.groupBox1.Controls.Add(this.dtpFim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 94);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // chbQuitadas
            // 
            this.chbQuitadas.AutoSize = true;
            this.chbQuitadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbQuitadas.Location = new System.Drawing.Point(353, 38);
            this.chbQuitadas.Name = "chbQuitadas";
            this.chbQuitadas.Size = new System.Drawing.Size(146, 19);
            this.chbQuitadas.TabIndex = 38;
            this.chbQuitadas.Text = "Exibir contas quitadas";
            this.chbQuitadas.UseVisualStyleBackColor = true;
            this.chbQuitadas.CheckedChanged += new System.EventHandler(this.chbQuitadas_CheckedChanged);
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(155, 37);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(97, 20);
            this.dtpFim.TabIndex = 1;
            this.dtpFim.ValueChanged += new System.EventHandler(this.dtpFim_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Até:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(21, 37);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(97, 20);
            this.dtpInicio.TabIndex = 0;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpFim_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "De:";
            // 
            // dgvContas
            // 
            this.dgvContas.AllowUserToAddRows = false;
            this.dgvContas.AllowUserToDeleteRows = false;
            this.dgvContas.BackgroundColor = System.Drawing.Color.White;
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codContasPagar,
            this.desp_descricao,
            this.contpag_valortotal,
            this.contPag_Parcela,
            this.contpag_numparc,
            this.contPag_valorParcela,
            this.contpag_valorpago,
            this.contpag_datapagamento,
            this.contpag_datavencimento,
            this.contpag_status});
            this.dgvContas.Location = new System.Drawing.Point(21, 111);
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.ReadOnly = true;
            this.dgvContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContas.Size = new System.Drawing.Size(758, 197);
            this.dgvContas.TabIndex = 12;
            // 
            // codContasPagar
            // 
            this.codContasPagar.DataPropertyName = "codContasPagar";
            this.codContasPagar.HeaderText = "Cód";
            this.codContasPagar.Name = "codContasPagar";
            this.codContasPagar.ReadOnly = true;
            this.codContasPagar.Width = 35;
            // 
            // desp_descricao
            // 
            this.desp_descricao.DataPropertyName = "desp_descricao";
            this.desp_descricao.HeaderText = "Despesa";
            this.desp_descricao.Name = "desp_descricao";
            this.desp_descricao.ReadOnly = true;
            this.desp_descricao.Width = 80;
            // 
            // contpag_valortotal
            // 
            this.contpag_valortotal.DataPropertyName = "contpag_valortotal";
            this.contpag_valortotal.HeaderText = "Valor Total (R$)";
            this.contpag_valortotal.Name = "contpag_valortotal";
            this.contpag_valortotal.ReadOnly = true;
            this.contpag_valortotal.Width = 80;
            // 
            // contPag_Parcela
            // 
            this.contPag_Parcela.DataPropertyName = "contPag_Parcela";
            this.contPag_Parcela.HeaderText = "Parc.";
            this.contPag_Parcela.Name = "contPag_Parcela";
            this.contPag_Parcela.ReadOnly = true;
            this.contPag_Parcela.Width = 35;
            // 
            // contpag_numparc
            // 
            this.contpag_numparc.DataPropertyName = "contpag_numparc";
            this.contpag_numparc.HeaderText = "Qtde Parc.";
            this.contpag_numparc.Name = "contpag_numparc";
            this.contpag_numparc.ReadOnly = true;
            this.contpag_numparc.Width = 35;
            // 
            // contPag_valorParcela
            // 
            this.contPag_valorParcela.DataPropertyName = "contPag_valorParcela";
            this.contPag_valorParcela.HeaderText = "Valor Parcel. (R$)";
            this.contPag_valorParcela.Name = "contPag_valorParcela";
            this.contPag_valorParcela.ReadOnly = true;
            this.contPag_valorParcela.Width = 90;
            // 
            // contpag_valorpago
            // 
            this.contpag_valorpago.DataPropertyName = "contpag_valorpago";
            this.contpag_valorpago.HeaderText = "Valor Pago (R$)";
            this.contpag_valorpago.Name = "contpag_valorpago";
            this.contpag_valorpago.ReadOnly = true;
            this.contpag_valorpago.Width = 90;
            // 
            // contpag_datapagamento
            // 
            this.contpag_datapagamento.DataPropertyName = "contpag_datapagamento";
            this.contpag_datapagamento.HeaderText = "Data Pagam.";
            this.contpag_datapagamento.Name = "contpag_datapagamento";
            this.contpag_datapagamento.ReadOnly = true;
            this.contpag_datapagamento.Width = 80;
            // 
            // contpag_datavencimento
            // 
            this.contpag_datavencimento.DataPropertyName = "contpag_datavencimento";
            this.contpag_datavencimento.HeaderText = "Data Venc.";
            this.contpag_datavencimento.Name = "contpag_datavencimento";
            this.contpag_datavencimento.ReadOnly = true;
            this.contpag_datavencimento.Width = 80;
            // 
            // contpag_status
            // 
            this.contpag_status.DataPropertyName = "contpag_status";
            this.contpag_status.HeaderText = "Status";
            this.contpag_status.Name = "contpag_status";
            this.contpag_status.ReadOnly = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(213, 12);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(90, 46);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnEstornar
            // 
            this.btnEstornar.BackColor = System.Drawing.Color.White;
            this.btnEstornar.Location = new System.Drawing.Point(117, 12);
            this.btnEstornar.Name = "btnEstornar";
            this.btnEstornar.Size = new System.Drawing.Size(90, 46);
            this.btnEstornar.TabIndex = 1;
            this.btnEstornar.Text = "Estornar";
            this.btnEstornar.UseVisualStyleBackColor = false;
            this.btnEstornar.Click += new System.EventHandler(this.btnEstornar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(687, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 46);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.White;
            this.btnQuitar.Location = new System.Drawing.Point(21, 12);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(90, 46);
            this.btnQuitar.TabIndex = 0;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // cbCompras
            // 
            this.cbCompras.AutoSize = true;
            this.cbCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompras.Location = new System.Drawing.Point(505, 38);
            this.cbCompras.Name = "cbCompras";
            this.cbCompras.Size = new System.Drawing.Size(76, 19);
            this.cbCompras.TabIndex = 39;
            this.cbCompras.Text = "Compras";
            this.cbCompras.UseVisualStyleBackColor = true;
            this.cbCompras.CheckedChanged += new System.EventHandler(this.cbCompras_CheckedChanged);
            // 
            // cbDespesas
            // 
            this.cbDespesas.AutoSize = true;
            this.cbDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDespesas.Location = new System.Drawing.Point(587, 38);
            this.cbDespesas.Name = "cbDespesas";
            this.cbDespesas.Size = new System.Drawing.Size(120, 19);
            this.cbDespesas.TabIndex = 40;
            this.cbDespesas.Text = "Outras Despesas";
            this.cbDespesas.UseVisualStyleBackColor = true;
            this.cbDespesas.CheckedChanged += new System.EventHandler(this.cbDespesas_CheckedChanged);
            // 
            // QuitarDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(816, 488);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "QuitarDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H . L - QUITAR DESPESAS";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFim;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvContas;
        public System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.Button btnEstornar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnQuitar;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn codContasPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn desp_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn contpag_valortotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn contPag_Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn contpag_numparc;
        private System.Windows.Forms.DataGridViewTextBoxColumn contPag_valorParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn contpag_valorpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn contpag_datapagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn contpag_datavencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn contpag_status;
        private System.Windows.Forms.MaskedTextBox ttbTotalPago;
        private System.Windows.Forms.MaskedTextBox ttbTotalVencido;
        private System.Windows.Forms.MaskedTextBox ttbTotalPagar;
        private System.Windows.Forms.CheckBox chbQuitadas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelVencido;
        private System.Windows.Forms.Label labelPago;
        private System.Windows.Forms.Label labelEmAberto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbDespesas;
        private System.Windows.Forms.CheckBox cbCompras;
    }
}