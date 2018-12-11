namespace HairLumos.Views.Funcoes_Fundamentais.RF_F5___Gerenciar_Compras
{
    partial class PesquisarCompras
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.ttbDescricao = new System.Windows.Forms.TextBox();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(772, 24);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 30);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.White;
            this.btnSelecionar.Location = new System.Drawing.Point(593, 24);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(100, 30);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(473, 24);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisa";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // ttbDescricao
            // 
            this.ttbDescricao.Location = new System.Drawing.Point(12, 29);
            this.ttbDescricao.Name = "ttbDescricao";
            this.ttbDescricao.Size = new System.Drawing.Size(400, 20);
            this.ttbDescricao.TabIndex = 0;
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.PJ,
            this.Data,
            this.Situacao,
            this.Consignado,
            this.ValorTotal});
            this.dgvCompras.Enabled = false;
            this.dgvCompras.Location = new System.Drawing.Point(12, 79);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.Size = new System.Drawing.Size(860, 368);
            this.dgvCompras.TabIndex = 9;
            this.dgvCompras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codcompra";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // PJ
            // 
            this.PJ.DataPropertyName = "codpessoa";
            this.PJ.HeaderText = "Fornecedor";
            this.PJ.Name = "PJ";
            this.PJ.ReadOnly = true;
            this.PJ.Width = 200;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "comp_datacompra";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 150;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "comp_situacao";
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            // 
            // Consignado
            // 
            this.Consignado.DataPropertyName = "comp_statusconsignado";
            this.Consignado.HeaderText = "Consignado";
            this.Consignado.Name = "Consignado";
            this.Consignado.ReadOnly = true;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "comp_valortotal";
            this.ValorTotal.HeaderText = "ValorTotal";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Width = 150;
            // 
            // PesquisarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(884, 478);
            this.ControlBox = false;
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.ttbDescricao);
            this.Name = "PesquisarCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H.L - PESQUISA DE COMPRAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox ttbDescricao;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
    }
}