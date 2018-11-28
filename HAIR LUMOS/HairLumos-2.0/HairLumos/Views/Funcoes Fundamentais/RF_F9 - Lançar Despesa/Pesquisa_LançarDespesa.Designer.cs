namespace HairLumos.Views.Funcoes_Fundamentais.RF_F9___Lançar_Despesa
{
    partial class Pesquisa_LançarDespesa
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
            this.dgvDespesa = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.ttbDescricao = new System.Windows.Forms.TextBox();
            this.coddespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desp_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contpag_datavencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contpag_valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDespesa
            // 
            this.dgvDespesa.AllowUserToAddRows = false;
            this.dgvDespesa.AllowUserToDeleteRows = false;
            this.dgvDespesa.BackgroundColor = System.Drawing.Color.White;
            this.dgvDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coddespesa,
            this.desp_descricao,
            this.contpag_datavencimento,
            this.contpag_valortotal});
            this.dgvDespesa.Location = new System.Drawing.Point(12, 83);
            this.dgvDespesa.Name = "dgvDespesa";
            this.dgvDespesa.ReadOnly = true;
            this.dgvDespesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDespesa.Size = new System.Drawing.Size(860, 368);
            this.dgvDespesa.TabIndex = 14;
            this.dgvDespesa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDespesa_CellDoubleClick);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(772, 28);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 30);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.White;
            this.btnSelecionar.Location = new System.Drawing.Point(593, 28);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(100, 30);
            this.btnSelecionar.TabIndex = 12;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(473, 28);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisa";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // ttbDescricao
            // 
            this.ttbDescricao.Location = new System.Drawing.Point(12, 33);
            this.ttbDescricao.Name = "ttbDescricao";
            this.ttbDescricao.Size = new System.Drawing.Size(400, 20);
            this.ttbDescricao.TabIndex = 10;
            // 
            // coddespesa
            // 
            this.coddespesa.DataPropertyName = "coddespesa";
            this.coddespesa.HeaderText = "Cód";
            this.coddespesa.Name = "coddespesa";
            this.coddespesa.ReadOnly = true;
            // 
            // desp_descricao
            // 
            this.desp_descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desp_descricao.DataPropertyName = "desp_descricao";
            this.desp_descricao.HeaderText = "Despesa";
            this.desp_descricao.Name = "desp_descricao";
            this.desp_descricao.ReadOnly = true;
            // 
            // contpag_datavencimento
            // 
            this.contpag_datavencimento.DataPropertyName = "contpag_datavencimento";
            this.contpag_datavencimento.HeaderText = "Data";
            this.contpag_datavencimento.Name = "contpag_datavencimento";
            this.contpag_datavencimento.ReadOnly = true;
            this.contpag_datavencimento.Width = 150;
            // 
            // contpag_valortotal
            // 
            this.contpag_valortotal.DataPropertyName = "contpag_valortotal";
            this.contpag_valortotal.HeaderText = "Valor (R$)";
            this.contpag_valortotal.Name = "contpag_valortotal";
            this.contpag_valortotal.ReadOnly = true;
            this.contpag_valortotal.Width = 150;
            // 
            // Pesquisa_LançarDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(884, 478);
            this.ControlBox = false;
            this.Controls.Add(this.dgvDespesa);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.ttbDescricao);
            this.Name = "Pesquisa_LançarDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H.L - PESQUISA DE DESPESAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDespesa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox ttbDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn desp_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn contpag_datavencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn contpag_valortotal;
    }
}