namespace HairLumos.Views.Funcoes_Fundamentais.RF_F9___Lançar_Despesa
{
    partial class PesquisaDespesa
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.ttbDescricao = new System.Windows.Forms.TextBox();
            this.dgvUsuário = new System.Windows.Forms.DataGridView();
            this.codcontaspagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contpag_datavencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contpag_valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contpag_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuário)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Goldenrod;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.splitContainer1.Panel1.Controls.Add(this.btnSair);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelecionar);
            this.splitContainer1.Panel1.Controls.Add(this.btnPesquisar);
            this.splitContainer1.Panel1.Controls.Add(this.ttbDescricao);
            this.splitContainer1.Panel1MinSize = 80;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.splitContainer1.Panel2.Controls.Add(this.dgvUsuário);
            this.splitContainer1.Size = new System.Drawing.Size(884, 478);
            this.splitContainer1.SplitterDistance = 80;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(772, 21);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 30);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.White;
            this.btnSelecionar.Location = new System.Drawing.Point(575, 21);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(100, 30);
            this.btnSelecionar.TabIndex = 3;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(455, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisa";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // ttbDescricao
            // 
            this.ttbDescricao.Location = new System.Drawing.Point(12, 26);
            this.ttbDescricao.Name = "ttbDescricao";
            this.ttbDescricao.Size = new System.Drawing.Size(400, 20);
            this.ttbDescricao.TabIndex = 1;
            // 
            // dgvUsuário
            // 
            this.dgvUsuário.AllowUserToAddRows = false;
            this.dgvUsuário.AllowUserToDeleteRows = false;
            this.dgvUsuário.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuário.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuário.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codcontaspagar,
            this.contpag_datavencimento,
            this.contpag_valortotal,
            this.contpag_status});
            this.dgvUsuário.Location = new System.Drawing.Point(12, 14);
            this.dgvUsuário.Name = "dgvUsuário";
            this.dgvUsuário.ReadOnly = true;
            this.dgvUsuário.Size = new System.Drawing.Size(860, 368);
            this.dgvUsuário.TabIndex = 0;
            this.dgvUsuário.DoubleClick += new System.EventHandler(this.dgvUsuário_DoubleClick);
            // 
            // codcontaspagar
            // 
            this.codcontaspagar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codcontaspagar.DataPropertyName = "codcontaspagar";
            this.codcontaspagar.HeaderText = "Cod";
            this.codcontaspagar.Name = "codcontaspagar";
            this.codcontaspagar.ReadOnly = true;
            // 
            // contpag_datavencimento
            // 
            this.contpag_datavencimento.DataPropertyName = "contpag_datavencimento";
            this.contpag_datavencimento.HeaderText = "Data Vencimento";
            this.contpag_datavencimento.Name = "contpag_datavencimento";
            this.contpag_datavencimento.ReadOnly = true;
            this.contpag_datavencimento.Width = 200;
            // 
            // contpag_valortotal
            // 
            this.contpag_valortotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.contpag_valortotal.DataPropertyName = "contpag_valortotal";
            this.contpag_valortotal.HeaderText = "Valor Total (R$)";
            this.contpag_valortotal.Name = "contpag_valortotal";
            this.contpag_valortotal.ReadOnly = true;
            this.contpag_valortotal.Width = 400;
            // 
            // contpag_status
            // 
            this.contpag_status.DataPropertyName = "contpag_status";
            this.contpag_status.FillWeight = 300F;
            this.contpag_status.HeaderText = "Status";
            this.contpag_status.Name = "contpag_status";
            this.contpag_status.ReadOnly = true;
            this.contpag_status.Width = 217;
            // 
            // PesquisaDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(884, 478);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "PesquisaDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H.L - PESQUISA DESPESA";
            this.Load += new System.EventHandler(this.PesquisaDespesa_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuário)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox ttbDescricao;
        private System.Windows.Forms.DataGridView dgvUsuário;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcontaspagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn contpag_datavencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn contpag_valortotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn contpag_status;
    }
}