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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnQuitarParcial = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdbReceber = new System.Windows.Forms.RadioButton();
            this.rdbPagar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.codContasPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.despesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contpag_valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dgvServico);
            // 
            // splitContainer1.Panel2
            // 
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
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnQuitarParcial);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 130);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(20, 93);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker2.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Até:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // btnQuitarParcial
            // 
            this.btnQuitarParcial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuitarParcial.Location = new System.Drawing.Point(644, 52);
            this.btnQuitarParcial.Name = "btnQuitarParcial";
            this.btnQuitarParcial.Size = new System.Drawing.Size(97, 38);
            this.btnQuitarParcial.TabIndex = 14;
            this.btnQuitarParcial.Text = "Quitar Parcial";
            this.btnQuitarParcial.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.rdbReceber);
            this.groupBox2.Controls.Add(this.rdbPagar);
            this.groupBox2.Location = new System.Drawing.Point(231, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 65);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contas";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(206, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Todos";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdbReceber
            // 
            this.rdbReceber.AutoSize = true;
            this.rdbReceber.Location = new System.Drawing.Point(105, 28);
            this.rdbReceber.Name = "rdbReceber";
            this.rdbReceber.Size = new System.Drawing.Size(66, 17);
            this.rdbReceber.TabIndex = 24;
            this.rdbReceber.TabStop = true;
            this.rdbReceber.Text = "Receber";
            this.rdbReceber.UseVisualStyleBackColor = true;
            // 
            // rdbPagar
            // 
            this.rdbPagar.AutoSize = true;
            this.rdbPagar.Location = new System.Drawing.Point(17, 28);
            this.rdbPagar.Name = "rdbPagar";
            this.rdbPagar.Size = new System.Drawing.Size(53, 17);
            this.rdbPagar.TabIndex = 23;
            this.rdbPagar.TabStop = true;
            this.rdbPagar.Text = "Pagar";
            this.rdbPagar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "De:";
            // 
            // dgvServico
            // 
            this.dgvServico.AllowUserToAddRows = false;
            this.dgvServico.AllowUserToDeleteRows = false;
            this.dgvServico.BackgroundColor = System.Drawing.Color.White;
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codContasPagar,
            this.despesa,
            this.contpag_valortotal,
            this.parcela,
            this.qtdeParcela,
            this.valorParcela,
            this.contpag_valorpago,
            this.contpag_datapagamento,
            this.contpag_datavencimento,
            this.contpag_status});
            this.dgvServico.Location = new System.Drawing.Point(21, 157);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.ReadOnly = true;
            this.dgvServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServico.Size = new System.Drawing.Size(758, 180);
            this.dgvServico.TabIndex = 12;
            // 
            // codContasPagar
            // 
            this.codContasPagar.DataPropertyName = "codContasPagar";
            this.codContasPagar.HeaderText = "Cód";
            this.codContasPagar.Name = "codContasPagar";
            this.codContasPagar.ReadOnly = true;
            this.codContasPagar.Width = 50;
            // 
            // despesa
            // 
            this.despesa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.despesa.HeaderText = "Despesa";
            this.despesa.Name = "despesa";
            this.despesa.ReadOnly = true;
            // 
            // contpag_valortotal
            // 
            this.contpag_valortotal.DataPropertyName = "contpag_valortotal";
            this.contpag_valortotal.HeaderText = "Valor Total (R$)";
            this.contpag_valortotal.Name = "contpag_valortotal";
            this.contpag_valortotal.ReadOnly = true;
            // 
            // parcela
            // 
            this.parcela.DataPropertyName = "parcela";
            this.parcela.HeaderText = "Parc.";
            this.parcela.Name = "parcela";
            this.parcela.ReadOnly = true;
            this.parcela.Width = 50;
            // 
            // qtdeParcela
            // 
            this.qtdeParcela.HeaderText = "Qtde Parc.";
            this.qtdeParcela.Name = "qtdeParcela";
            this.qtdeParcela.ReadOnly = true;
            this.qtdeParcela.Width = 50;
            // 
            // valorParcela
            // 
            this.valorParcela.HeaderText = "Valor Parcel. (R$)";
            this.valorParcela.Name = "valorParcela";
            this.valorParcela.ReadOnly = true;
            // 
            // contpag_valorpago
            // 
            this.contpag_valorpago.HeaderText = "Valor Pago (R$)";
            this.contpag_valorpago.Name = "contpag_valorpago";
            this.contpag_valorpago.ReadOnly = true;
            // 
            // contpag_datapagamento
            // 
            this.contpag_datapagamento.HeaderText = "Data Pagam.";
            this.contpag_datapagamento.Name = "contpag_datapagamento";
            this.contpag_datapagamento.ReadOnly = true;
            this.contpag_datapagamento.Width = 80;
            // 
            // contpag_datavencimento
            // 
            this.contpag_datavencimento.HeaderText = "Data Venc.";
            this.contpag_datavencimento.Name = "contpag_datavencimento";
            this.contpag_datavencimento.ReadOnly = true;
            this.contpag_datavencimento.Width = 80;
            // 
            // contpag_status
            // 
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
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(816, 488);
            this.Controls.Add(this.splitContainer1);
            this.Name = "QuitarDespesa";
            this.Text = "QuitarDespesa";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Button btnQuitarParcial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdbReceber;
        private System.Windows.Forms.RadioButton rdbPagar;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvServico;
        public System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.Button btnEstornar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codContasPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn despesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn contpag_valortotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn contpag_valorpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn contpag_datapagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn contpag_datavencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn contpag_status;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ttbTotalVencido;
        private System.Windows.Forms.TextBox ttbTotalPago;
        private System.Windows.Forms.TextBox ttbTotalPagar;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
    }
}