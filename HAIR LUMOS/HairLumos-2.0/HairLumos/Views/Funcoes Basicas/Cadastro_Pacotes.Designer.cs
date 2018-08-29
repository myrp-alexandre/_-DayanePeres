namespace HairLumos.Views
{
    partial class Cadastro_Pacotes
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
            this.ttbObs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ttbPeriodo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.dgvPacote = new System.Windows.Forms.DataGridView();
            this.codpacote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pac_pacote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pac_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pac_periodicidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.Label();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.ttbPacote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacote)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.ttbObs);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.mskValor);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.ttbPeriodo);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelecionar);
            this.splitContainer1.Panel1.Controls.Add(this.dgvPacote);
            this.splitContainer1.Panel1.Controls.Add(this.Código);
            this.splitContainer1.Panel1.Controls.Add(this.ttbCodigo);
            this.splitContainer1.Panel1.Controls.Add(this.ttbPacote);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnSair);
            this.splitContainer1.Panel2.Controls.Add(this.btnExcluir);
            this.splitContainer1.Panel2.Controls.Add(this.btnAlterar);
            this.splitContainer1.Panel2.Controls.Add(this.btnGravar);
            this.splitContainer1.Panel2.Controls.Add(this.btnNovo);
            this.splitContainer1.Size = new System.Drawing.Size(584, 350);
            this.splitContainer1.SplitterDistance = 282;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // ttbObs
            // 
            this.ttbObs.BackColor = System.Drawing.SystemColors.Window;
            this.ttbObs.Location = new System.Drawing.Point(21, 116);
            this.ttbObs.Name = "ttbObs";
            this.ttbObs.Size = new System.Drawing.Size(545, 20);
            this.ttbObs.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Observação";
            // 
            // mskValor
            // 
            this.mskValor.Location = new System.Drawing.Point(314, 66);
            this.mskValor.Name = "mskValor";
            this.mskValor.Size = new System.Drawing.Size(100, 20);
            this.mskValor.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Periodicidade*";
            // 
            // ttbPeriodo
            // 
            this.ttbPeriodo.Location = new System.Drawing.Point(426, 66);
            this.ttbPeriodo.Name = "ttbPeriodo";
            this.ttbPeriodo.Size = new System.Drawing.Size(142, 20);
            this.ttbPeriodo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Valor (R$)*";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelecionar.Location = new System.Drawing.Point(496, 175);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(72, 27);
            this.btnSelecionar.TabIndex = 12;
            this.btnSelecionar.Text = "Seleciona";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            // 
            // dgvPacote
            // 
            this.dgvPacote.AllowUserToAddRows = false;
            this.dgvPacote.AllowUserToDeleteRows = false;
            this.dgvPacote.BackgroundColor = System.Drawing.Color.White;
            this.dgvPacote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codpacote,
            this.pac_pacote,
            this.pac_valor,
            this.pac_periodicidade});
            this.dgvPacote.Location = new System.Drawing.Point(21, 156);
            this.dgvPacote.Name = "dgvPacote";
            this.dgvPacote.ReadOnly = true;
            this.dgvPacote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacote.Size = new System.Drawing.Size(468, 108);
            this.dgvPacote.TabIndex = 12;
            // 
            // codpacote
            // 
            this.codpacote.DataPropertyName = "codpacote";
            this.codpacote.HeaderText = "Cód";
            this.codpacote.Name = "codpacote";
            this.codpacote.ReadOnly = true;
            this.codpacote.Width = 80;
            // 
            // pac_pacote
            // 
            this.pac_pacote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pac_pacote.DataPropertyName = "pac_pacote";
            this.pac_pacote.HeaderText = "Pacote";
            this.pac_pacote.Name = "pac_pacote";
            this.pac_pacote.ReadOnly = true;
            // 
            // pac_valor
            // 
            this.pac_valor.DataPropertyName = "pac_valor";
            this.pac_valor.HeaderText = "Valor (R$)";
            this.pac_valor.Name = "pac_valor";
            this.pac_valor.ReadOnly = true;
            // 
            // pac_periodicidade
            // 
            this.pac_periodicidade.DataPropertyName = "pac_periodicidade";
            this.pac_periodicidade.HeaderText = "Periodicidade";
            this.pac_periodicidade.Name = "pac_periodicidade";
            this.pac_periodicidade.ReadOnly = true;
            // 
            // Código
            // 
            this.Código.AutoSize = true;
            this.Código.Location = new System.Drawing.Point(18, 18);
            this.Código.Name = "Código";
            this.Código.Size = new System.Drawing.Size(40, 13);
            this.Código.TabIndex = 6;
            this.Código.Text = "Código";
            // 
            // ttbCodigo
            // 
            this.ttbCodigo.Location = new System.Drawing.Point(64, 15);
            this.ttbCodigo.Name = "ttbCodigo";
            this.ttbCodigo.Size = new System.Drawing.Size(100, 20);
            this.ttbCodigo.TabIndex = 7;
            // 
            // ttbPacote
            // 
            this.ttbPacote.BackColor = System.Drawing.SystemColors.Window;
            this.ttbPacote.Location = new System.Drawing.Point(21, 66);
            this.ttbPacote.Name = "ttbPacote";
            this.ttbPacote.Size = new System.Drawing.Size(237, 20);
            this.ttbPacote.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pacote*";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(345, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 38);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Location = new System.Drawing.Point(491, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 38);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluir.Location = new System.Drawing.Point(264, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 38);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlterar.Location = new System.Drawing.Point(183, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 38);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGravar.Location = new System.Drawing.Point(102, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 38);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovo.Location = new System.Drawing.Point(21, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 38);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // Cadastro_Pacotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(609, 374);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Cadastro_Pacotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO PACOTES";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.DataGridView dgvPacote;
        public System.Windows.Forms.Label Código;
        public System.Windows.Forms.TextBox ttbCodigo;
        public System.Windows.Forms.TextBox ttbPacote;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnNovo;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox ttbPeriodo;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskValor;
        public System.Windows.Forms.TextBox ttbObs;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpacote;
        private System.Windows.Forms.DataGridViewTextBoxColumn pac_pacote;
        private System.Windows.Forms.DataGridViewTextBoxColumn pac_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pac_periodicidade;
    }
}