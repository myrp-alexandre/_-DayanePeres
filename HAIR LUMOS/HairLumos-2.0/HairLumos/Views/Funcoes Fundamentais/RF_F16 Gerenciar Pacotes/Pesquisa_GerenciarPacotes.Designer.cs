﻿namespace HairLumos.Views.Funcoes_Fundamentais.RF_F16_Gerenciar_Pacotes
{
    partial class Pesquisa_GerenciarPacotes
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
            this.dgvPacote = new System.Windows.Forms.DataGridView();
            this.codpacote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pac_pacote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pac_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pac_datainicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pac_datafim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacote)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.dgvPacote);
            this.splitContainer1.Size = new System.Drawing.Size(884, 478);
            this.splitContainer1.SplitterDistance = 80;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(772, 21);
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
            this.btnSelecionar.Location = new System.Drawing.Point(575, 21);
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
            this.btnPesquisar.Location = new System.Drawing.Point(455, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisa";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // ttbDescricao
            // 
            this.ttbDescricao.Location = new System.Drawing.Point(12, 26);
            this.ttbDescricao.Name = "ttbDescricao";
            this.ttbDescricao.Size = new System.Drawing.Size(400, 20);
            this.ttbDescricao.TabIndex = 0;
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
            this.pac_datainicio,
            this.pac_datafim});
            this.dgvPacote.Location = new System.Drawing.Point(12, 14);
            this.dgvPacote.Name = "dgvPacote";
            this.dgvPacote.ReadOnly = true;
            this.dgvPacote.Size = new System.Drawing.Size(860, 368);
            this.dgvPacote.TabIndex = 0;
            this.dgvPacote.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacote_CellDoubleClick);
            // 
            // codpacote
            // 
            this.codpacote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codpacote.DataPropertyName = "codpacote";
            this.codpacote.HeaderText = "Cod";
            this.codpacote.Name = "codpacote";
            this.codpacote.ReadOnly = true;
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
            this.pac_valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pac_valor.DataPropertyName = "pac_valor";
            this.pac_valor.HeaderText = "Valor (R$)";
            this.pac_valor.Name = "pac_valor";
            this.pac_valor.ReadOnly = true;
            // 
            // pac_datainicio
            // 
            this.pac_datainicio.DataPropertyName = "pac_datainicio";
            this.pac_datainicio.FillWeight = 300F;
            this.pac_datainicio.HeaderText = "Data Início";
            this.pac_datainicio.Name = "pac_datainicio";
            this.pac_datainicio.ReadOnly = true;
            // 
            // pac_datafim
            // 
            this.pac_datafim.DataPropertyName = "pac_datafim";
            this.pac_datafim.HeaderText = "Data Fim";
            this.pac_datafim.Name = "pac_datafim";
            this.pac_datafim.ReadOnly = true;
            // 
            // Pesquisa_GerenciarPacotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(884, 478);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Pesquisa_GerenciarPacotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H.L - PESQUISA PACOTES";
            this.Load += new System.EventHandler(this.Pesquisa_GerenciarPacotes_Load);
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
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox ttbDescricao;
        private System.Windows.Forms.DataGridView dgvPacote;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpacote;
        private System.Windows.Forms.DataGridViewTextBoxColumn pac_pacote;
        private System.Windows.Forms.DataGridViewTextBoxColumn pac_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pac_datainicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn pac_datafim;
    }
}