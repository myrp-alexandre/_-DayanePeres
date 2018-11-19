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
            this.ttbTotalVencido = new System.Windows.Forms.TextBox();
            this.ttbTotalPago = new System.Windows.Forms.TextBox();
            this.ttbTotalPagar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.btnQuitarParcial = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.ttbTotalVencido);
            this.splitContainer1.Panel1.Controls.Add(this.ttbTotalPago);
            this.splitContainer1.Panel1.Controls.Add(this.ttbTotalPagar);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
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
            // ttbTotalVencido
            // 
            this.ttbTotalVencido.ForeColor = System.Drawing.Color.Red;
            this.ttbTotalVencido.Location = new System.Drawing.Point(647, 363);
            this.ttbTotalVencido.Name = "ttbTotalVencido";
            this.ttbTotalVencido.Size = new System.Drawing.Size(89, 20);
            this.ttbTotalVencido.TabIndex = 44;
            // 
            // ttbTotalPago
            // 
            this.ttbTotalPago.ForeColor = System.Drawing.Color.Green;
            this.ttbTotalPago.Location = new System.Drawing.Point(536, 363);
            this.ttbTotalPago.Name = "ttbTotalPago";
            this.ttbTotalPago.Size = new System.Drawing.Size(89, 20);
            this.ttbTotalPago.TabIndex = 43;
            // 
            // ttbTotalPagar
            // 
            this.ttbTotalPagar.ForeColor = System.Drawing.Color.Blue;
            this.ttbTotalPagar.Location = new System.Drawing.Point(420, 363);
            this.ttbTotalPagar.Name = "ttbTotalPagar";
            this.ttbTotalPagar.Size = new System.Drawing.Size(89, 20);
            this.ttbTotalPagar.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(644, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Total Vencido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(533, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Total Pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(417, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Total a Pagar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.btnQuitarParcial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 94);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(155, 37);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(97, 20);
            this.dtpFim.TabIndex = 38;
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
            this.dtpInicio.TabIndex = 36;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // btnQuitarParcial
            // 
            this.btnQuitarParcial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuitarParcial.Location = new System.Drawing.Point(644, 32);
            this.btnQuitarParcial.Name = "btnQuitarParcial";
            this.btnQuitarParcial.Size = new System.Drawing.Size(97, 38);
            this.btnQuitarParcial.TabIndex = 14;
            this.btnQuitarParcial.Text = "Quitar Parcial";
            this.btnQuitarParcial.UseVisualStyleBackColor = false;
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
            this.dgvContas.Size = new System.Drawing.Size(758, 226);
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
            this.BtnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCancelar.Location = new System.Drawing.Point(213, 12);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(90, 46);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEstornar
            // 
            this.btnEstornar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEstornar.Location = new System.Drawing.Point(117, 12);
            this.btnEstornar.Name = "btnEstornar";
            this.btnEstornar.Size = new System.Drawing.Size(90, 46);
            this.btnEstornar.TabIndex = 12;
            this.btnEstornar.Text = "Estornar";
            this.btnEstornar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Location = new System.Drawing.Point(687, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 46);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuitar.Location = new System.Drawing.Point(21, 12);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(90, 46);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            // 
            // QuitarDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(816, 488);
            this.Controls.Add(this.splitContainer1);
            this.Name = "QuitarDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H . L - QUITAR DESPESAS";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        public System.Windows.Forms.Button btnQuitarParcial;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvContas;
        public System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.Button btnEstornar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnQuitar;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ttbTotalVencido;
        private System.Windows.Forms.TextBox ttbTotalPago;
        private System.Windows.Forms.TextBox ttbTotalPagar;
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
    }
}