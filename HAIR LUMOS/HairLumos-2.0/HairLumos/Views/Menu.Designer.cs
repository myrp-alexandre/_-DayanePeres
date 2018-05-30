namespace HairLumos
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroCategoriaProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroMarcaProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELATÓRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFORMAÇÕESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bACKUPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Goldenrod;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROToolStripMenuItem,
            this.rELATÓRIOSToolStripMenuItem,
            this.iNFORMAÇÕESToolStripMenuItem,
            this.bACKUPToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaToolStripMenuItem,
            this.usuárioToolStripMenuItem,
            this.cadastroDeFuncionárioToolStripMenuItem,
            this.cadastroUsuárioToolStripMenuItem});
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.cADASTROToolStripMenuItem.Text = "CADASTROS";
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.pessoaToolStripMenuItem.Text = "Cadastro de Pessoa";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroCategoriaProdutoToolStripMenuItem,
            this.cadastroMarcaProdutoToolStripMenuItem,
            this.cadastroProdutoToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.usuárioToolStripMenuItem.Text = "Cadastro de Produto";
            // 
            // cadastroCategoriaProdutoToolStripMenuItem
            // 
            this.cadastroCategoriaProdutoToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.cadastroCategoriaProdutoToolStripMenuItem.Name = "cadastroCategoriaProdutoToolStripMenuItem";
            this.cadastroCategoriaProdutoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cadastroCategoriaProdutoToolStripMenuItem.Text = "Cadastro Categoria Produto";
            this.cadastroCategoriaProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastroCategoriaProdutoToolStripMenuItem_Click);
            // 
            // cadastroMarcaProdutoToolStripMenuItem
            // 
            this.cadastroMarcaProdutoToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.cadastroMarcaProdutoToolStripMenuItem.Name = "cadastroMarcaProdutoToolStripMenuItem";
            this.cadastroMarcaProdutoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cadastroMarcaProdutoToolStripMenuItem.Text = "Cadastro Marca Produto";
            this.cadastroMarcaProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastroMarcaProdutoToolStripMenuItem_Click);
            // 
            // cadastroProdutoToolStripMenuItem
            // 
            this.cadastroProdutoToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.cadastroProdutoToolStripMenuItem.Name = "cadastroProdutoToolStripMenuItem";
            this.cadastroProdutoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cadastroProdutoToolStripMenuItem.Text = "Cadastro Produto";
            this.cadastroProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastroProdutoToolStripMenuItem_Click);
            // 
            // cadastroDeFuncionárioToolStripMenuItem
            // 
            this.cadastroDeFuncionárioToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.cadastroDeFuncionárioToolStripMenuItem.Name = "cadastroDeFuncionárioToolStripMenuItem";
            this.cadastroDeFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.cadastroDeFuncionárioToolStripMenuItem.Text = "Cadastro de Funcionário";
            // 
            // cadastroUsuárioToolStripMenuItem
            // 
            this.cadastroUsuárioToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.cadastroUsuárioToolStripMenuItem.Name = "cadastroUsuárioToolStripMenuItem";
            this.cadastroUsuárioToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.cadastroUsuárioToolStripMenuItem.Text = "Cadastro de Usuário";
            // 
            // rELATÓRIOSToolStripMenuItem
            // 
            this.rELATÓRIOSToolStripMenuItem.Name = "rELATÓRIOSToolStripMenuItem";
            this.rELATÓRIOSToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.rELATÓRIOSToolStripMenuItem.Text = "RELATÓRIOS";
            // 
            // iNFORMAÇÕESToolStripMenuItem
            // 
            this.iNFORMAÇÕESToolStripMenuItem.Name = "iNFORMAÇÕESToolStripMenuItem";
            this.iNFORMAÇÕESToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.iNFORMAÇÕESToolStripMenuItem.Text = "INFORMAÇÕES";
            // 
            // bACKUPToolStripMenuItem
            // 
            this.bACKUPToolStripMenuItem.Name = "bACKUPToolStripMenuItem";
            this.bACKUPToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.bACKUPToolStripMenuItem.Text = "BACKUP";
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem1,
            this.trocarUsuárioToolStripMenuItem});
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // trocarUsuárioToolStripMenuItem
            // 
            this.trocarUsuárioToolStripMenuItem.Name = "trocarUsuárioToolStripMenuItem";
            this.trocarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.trocarUsuárioToolStripMenuItem.Text = "Trocar Usuário";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Goldenrod;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(972, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "text";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.LinkColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(122, 17);
            this.toolStripStatusLabel1.Text = "Hair Lumos - Usuário:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.BurlyWood;
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(948, 629);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(972, 681);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroCategoriaProdutoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem rELATÓRIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFORMAÇÕESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bACKUPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroMarcaProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trocarUsuárioToolStripMenuItem;
    }
}

