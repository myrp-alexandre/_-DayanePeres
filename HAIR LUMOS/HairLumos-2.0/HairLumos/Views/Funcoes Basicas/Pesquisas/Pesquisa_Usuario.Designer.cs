namespace HairLumos.Views.Funcoes_Basicas.Pesquisas
{
    partial class Pesquisa_Usuario
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
            this.codusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codpessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usu_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usu_nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.splitContainer1.TabIndex = 1;
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
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
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
            this.codusuario,
            this.codpessoa,
            this.usu_usuario,
            this.usu_nivel});
            this.dgvUsuário.Location = new System.Drawing.Point(12, 14);
            this.dgvUsuário.Name = "dgvUsuário";
            this.dgvUsuário.ReadOnly = true;
            this.dgvUsuário.Size = new System.Drawing.Size(860, 368);
            this.dgvUsuário.TabIndex = 0;
            this.dgvUsuário.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuário_CellDoubleClick);
            // 
            // codusuario
            // 
            this.codusuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codusuario.DataPropertyName = "codusuario";
            this.codusuario.HeaderText = "Cod User";
            this.codusuario.Name = "codusuario";
            this.codusuario.ReadOnly = true;
            // 
            // codpessoa
            // 
            this.codpessoa.DataPropertyName = "codpessoa";
            this.codpessoa.HeaderText = "Cod Pessoa";
            this.codpessoa.Name = "codpessoa";
            this.codpessoa.ReadOnly = true;
            // 
            // usu_usuario
            // 
            this.usu_usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.usu_usuario.DataPropertyName = "usu_usuario";
            this.usu_usuario.HeaderText = "Usuário";
            this.usu_usuario.Name = "usu_usuario";
            this.usu_usuario.ReadOnly = true;
            this.usu_usuario.Width = 400;
            // 
            // usu_nivel
            // 
            this.usu_nivel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usu_nivel.DataPropertyName = "usu_nivel";
            this.usu_nivel.FillWeight = 300F;
            this.usu_nivel.HeaderText = "Nível de Acesso";
            this.usu_nivel.Name = "usu_nivel";
            this.usu_nivel.ReadOnly = true;
            // 
            // Pesquisa_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 478);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Pesquisa_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PESQUISA USÁRIO";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn codusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn usu_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usu_nivel;
    }
}