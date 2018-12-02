namespace HairLumos.Views.Funcoes_Fundamentais.RF_F11_Quitar_Contas_a_Receber
{
    partial class QuitarContasReceber
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
            this.btnListar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttbTotalPago = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ttbTotalVencido = new System.Windows.Forms.MaskedTextBox();
            this.labelVencido = new System.Windows.Forms.Label();
            this.ttbTotalPagar = new System.Windows.Forms.MaskedTextBox();
            this.labelPago = new System.Windows.Forms.Label();
            this.labelEmAberto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbbVencido = new System.Windows.Forms.CheckBox();
            this.cbbPago = new System.Windows.Forms.CheckBox();
            this.cbbEmAberto = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpDataAte = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataDe = new System.Windows.Forms.DateTimePicker();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnEstornar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnListar);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.dgvParcelas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.splitContainer1.Panel2.Controls.Add(this.BtnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnEstornar);
            this.splitContainer1.Panel2.Controls.Add(this.btnSair);
            this.splitContainer1.Panel2.Controls.Add(this.btnQuitar);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer1.Size = new System.Drawing.Size(792, 464);
            this.splitContainer1.SplitterDistance = 387;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.White;
            this.btnListar.Location = new System.Drawing.Point(614, 43);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(165, 40);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar recebimentos";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ttbTotalPago);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ttbTotalVencido);
            this.groupBox1.Controls.Add(this.labelVencido);
            this.groupBox1.Controls.Add(this.ttbTotalPagar);
            this.groupBox1.Controls.Add(this.labelPago);
            this.groupBox1.Controls.Add(this.labelEmAberto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 62);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // ttbTotalPago
            // 
            this.ttbTotalPago.Enabled = false;
            this.ttbTotalPago.ForeColor = System.Drawing.Color.Green;
            this.ttbTotalPago.Location = new System.Drawing.Point(540, 32);
            this.ttbTotalPago.Name = "ttbTotalPago";
            this.ttbTotalPago.Size = new System.Drawing.Size(100, 20);
            this.ttbTotalPago.TabIndex = 51;
            this.ttbTotalPago.Enter += new System.EventHandler(this.ttbTotalPago_Enter);
            this.ttbTotalPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbTotalPago_KeyPress);
            this.ttbTotalPago.Leave += new System.EventHandler(this.ttbTotalPago_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Legenda:";
            // 
            // ttbTotalVencido
            // 
            this.ttbTotalVencido.Enabled = false;
            this.ttbTotalVencido.ForeColor = System.Drawing.Color.Red;
            this.ttbTotalVencido.Location = new System.Drawing.Point(656, 32);
            this.ttbTotalVencido.Name = "ttbTotalVencido";
            this.ttbTotalVencido.Size = new System.Drawing.Size(100, 20);
            this.ttbTotalVencido.TabIndex = 50;
            this.ttbTotalVencido.Enter += new System.EventHandler(this.ttbTotalVencido_Enter);
            this.ttbTotalVencido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbTotalVencido_KeyPress);
            this.ttbTotalVencido.Leave += new System.EventHandler(this.ttbTotalVencido_Leave);
            // 
            // labelVencido
            // 
            this.labelVencido.AutoSize = true;
            this.labelVencido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVencido.Image = global::HairLumos.Properties.Resources._vermelho;
            this.labelVencido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelVencido.Location = new System.Drawing.Point(167, 35);
            this.labelVencido.Name = "labelVencido";
            this.labelVencido.Size = new System.Drawing.Size(66, 15);
            this.labelVencido.TabIndex = 48;
            this.labelVencido.Text = "     Vencido";
            this.labelVencido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ttbTotalPagar
            // 
            this.ttbTotalPagar.Enabled = false;
            this.ttbTotalPagar.ForeColor = System.Drawing.Color.Blue;
            this.ttbTotalPagar.Location = new System.Drawing.Point(420, 32);
            this.ttbTotalPagar.Name = "ttbTotalPagar";
            this.ttbTotalPagar.Size = new System.Drawing.Size(100, 20);
            this.ttbTotalPagar.TabIndex = 49;
            this.ttbTotalPagar.Enter += new System.EventHandler(this.ttbTotalPagar_Enter_1);
            this.ttbTotalPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbTotalPagar_KeyPress);
            this.ttbTotalPagar.Leave += new System.EventHandler(this.ttbTotalPagar_Leave);
            // 
            // labelPago
            // 
            this.labelPago.AutoSize = true;
            this.labelPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPago.Image = global::HairLumos.Properties.Resources._verde;
            this.labelPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPago.Location = new System.Drawing.Point(93, 35);
            this.labelPago.Name = "labelPago";
            this.labelPago.Size = new System.Drawing.Size(51, 15);
            this.labelPago.TabIndex = 47;
            this.labelPago.Text = "     Pago";
            this.labelPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEmAberto
            // 
            this.labelEmAberto.AutoSize = true;
            this.labelEmAberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmAberto.Image = global::HairLumos.Properties.Resources._azul;
            this.labelEmAberto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEmAberto.Location = new System.Drawing.Point(6, 35);
            this.labelEmAberto.Name = "labelEmAberto";
            this.labelEmAberto.Size = new System.Drawing.Size(79, 15);
            this.labelEmAberto.TabIndex = 46;
            this.labelEmAberto.Text = "     Em aberto";
            this.labelEmAberto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(537, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Total pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(653, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Total vencido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(417, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Total a receber:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbbVencido);
            this.groupBox4.Controls.Add(this.cbbPago);
            this.groupBox4.Controls.Add(this.cbbEmAberto);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(289, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 100);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            // 
            // cbbVencido
            // 
            this.cbbVencido.AutoSize = true;
            this.cbbVencido.Checked = true;
            this.cbbVencido.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbbVencido.Location = new System.Drawing.Point(197, 51);
            this.cbbVencido.Name = "cbbVencido";
            this.cbbVencido.Size = new System.Drawing.Size(65, 17);
            this.cbbVencido.TabIndex = 3;
            this.cbbVencido.Text = "Vencido";
            this.cbbVencido.UseVisualStyleBackColor = true;
            this.cbbVencido.Click += new System.EventHandler(this.cbbVencido_Click);
            // 
            // cbbPago
            // 
            this.cbbPago.AutoSize = true;
            this.cbbPago.Location = new System.Drawing.Point(140, 51);
            this.cbbPago.Name = "cbbPago";
            this.cbbPago.Size = new System.Drawing.Size(51, 17);
            this.cbbPago.TabIndex = 2;
            this.cbbPago.Text = "Pago";
            this.cbbPago.UseVisualStyleBackColor = true;
            this.cbbPago.Click += new System.EventHandler(this.cbbPago_Click);
            // 
            // cbbEmAberto
            // 
            this.cbbEmAberto.AutoSize = true;
            this.cbbEmAberto.Checked = true;
            this.cbbEmAberto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbbEmAberto.Location = new System.Drawing.Point(60, 51);
            this.cbbEmAberto.Name = "cbbEmAberto";
            this.cbbEmAberto.Size = new System.Drawing.Size(74, 17);
            this.cbbEmAberto.TabIndex = 1;
            this.cbbEmAberto.Text = "Em aberto";
            this.cbbEmAberto.UseVisualStyleBackColor = true;
            this.cbbEmAberto.Click += new System.EventHandler(this.cbbEmAberto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Situação da conta:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpDataAte);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtpDataDe);
            this.groupBox3.Location = new System.Drawing.Point(12, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 100);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Período";
            // 
            // dtpDataAte
            // 
            this.dtpDataAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAte.Location = new System.Drawing.Point(148, 48);
            this.dtpDataAte.Name = "dtpDataAte";
            this.dtpDataAte.Size = new System.Drawing.Size(97, 20);
            this.dtpDataAte.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Até:";
            // 
            // dtpDataDe
            // 
            this.dtpDataDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDe.Location = new System.Drawing.Point(22, 48);
            this.dtpDataDe.Name = "dtpDataDe";
            this.dtpDataDe.Size = new System.Drawing.Size(97, 20);
            this.dtpDataDe.TabIndex = 0;
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.AllowUserToResizeColumns = false;
            this.dgvParcelas.AllowUserToResizeRows = false;
            this.dgvParcelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParcelas.BackgroundColor = System.Drawing.Color.White;
            this.dgvParcelas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvParcelas.EnableHeadersVisualStyles = false;
            this.dgvParcelas.Location = new System.Drawing.Point(12, 117);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(767, 192);
            this.dgvParcelas.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Parcela";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor Parcela";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Valor Pago";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Data de Vencimento";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Data Pagamento";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Forma Pagamento";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(204, 12);
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
            this.btnEstornar.Location = new System.Drawing.Point(108, 12);
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
            this.btnSair.Location = new System.Drawing.Point(704, 12);
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
            this.btnQuitar.Location = new System.Drawing.Point(12, 12);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(90, 46);
            this.btnQuitar.TabIndex = 0;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // QuitarContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(816, 488);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "QuitarContasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H. L - QUITAR CONTAS A RECEBER";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataAte;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataDe;
        public System.Windows.Forms.Button btnListar;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvParcelas;
        public System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.Button btnEstornar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbbVencido;
        private System.Windows.Forms.CheckBox cbbPago;
        private System.Windows.Forms.CheckBox cbbEmAberto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelVencido;
        private System.Windows.Forms.Label labelPago;
        private System.Windows.Forms.Label labelEmAberto;
        private System.Windows.Forms.MaskedTextBox ttbTotalPago;
        private System.Windows.Forms.MaskedTextBox ttbTotalVencido;
        private System.Windows.Forms.MaskedTextBox ttbTotalPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}