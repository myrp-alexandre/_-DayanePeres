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
            this.cadastrodePessoa = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroCategoriaProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroMarcaProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFormaDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroServiçosDeParceirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeDespesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeDespesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELATÓRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFORMAÇÕESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrizaçãoDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bACKUPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lançarDespesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.compraToolStripMenuItem,
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
            this.cadastroDeFormaDePagamentoToolStripMenuItem,
            this.cadastroServiçoToolStripMenuItem,
            this.cadastroDeDespesaToolStripMenuItem});
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.cADASTROToolStripMenuItem.Text = "CADASTROS";
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pessoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrodePessoa,
            this.cadastroDeUsuárioToolStripMenuItem});
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.pessoaToolStripMenuItem.Text = "Cadastro de Pessoa";
            // 
            // cadastrodePessoa
            // 
            this.cadastrodePessoa.BackColor = System.Drawing.Color.Goldenrod;
            this.cadastrodePessoa.Name = "cadastrodePessoa";
            this.cadastrodePessoa.Size = new System.Drawing.Size(184, 22);
            this.cadastrodePessoa.Text = "Cadastro de Pessoa";
            this.cadastrodePessoa.Click += new System.EventHandler(this.cadastrodePessoa_Click);
            // 
            // cadastroDeUsuárioToolStripMenuItem
            // 
            this.cadastroDeUsuárioToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.cadastroDeUsuárioToolStripMenuItem.Name = "cadastroDeUsuárioToolStripMenuItem";
            this.cadastroDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cadastroDeUsuárioToolStripMenuItem.Text = "Cadastro de Usuário";
            this.cadastroDeUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeUsuárioToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroCategoriaProdutoToolStripMenuItem,
            this.cadastroMarcaProdutoToolStripMenuItem,
            this.cadastroProdutoToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.usuárioToolStripMenuItem.Text = "Cadastro Produto";
            // 
            // cadastroCategoriaProdutoToolStripMenuItem
            // 
            this.cadastroCategoriaProdutoToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
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
            this.cadastroProdutoToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cadastroProdutoToolStripMenuItem.Name = "cadastroProdutoToolStripMenuItem";
            this.cadastroProdutoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cadastroProdutoToolStripMenuItem.Text = "Cadastro Produto";
            this.cadastroProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastroProdutoToolStripMenuItem_Click);
            // 
            // cadastroDeFormaDePagamentoToolStripMenuItem
            // 
            this.cadastroDeFormaDePagamentoToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cadastroDeFormaDePagamentoToolStripMenuItem.Name = "cadastroDeFormaDePagamentoToolStripMenuItem";
            this.cadastroDeFormaDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.cadastroDeFormaDePagamentoToolStripMenuItem.Text = "Cadastro Forma de Pagamento";
            this.cadastroDeFormaDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFormaDePagamentoToolStripMenuItem_Click);
            // 
            // cadastroServiçoToolStripMenuItem
            // 
            this.cadastroServiçoToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.cadastroServiçoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeServiçoToolStripMenuItem,
            this.cadastroServiçosDeParceirosToolStripMenuItem});
            this.cadastroServiçoToolStripMenuItem.Name = "cadastroServiçoToolStripMenuItem";
            this.cadastroServiçoToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.cadastroServiçoToolStripMenuItem.Text = "Cadastro Serviços";
            this.cadastroServiçoToolStripMenuItem.Click += new System.EventHandler(this.cadastroServiçoToolStripMenuItem_Click);
            // 
            // cadastroDeServiçoToolStripMenuItem
            // 
            this.cadastroDeServiçoToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cadastroDeServiçoToolStripMenuItem.Name = "cadastroDeServiçoToolStripMenuItem";
            this.cadastroDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.cadastroDeServiçoToolStripMenuItem.Text = "Cadastro de Tipo Serviço";
            this.cadastroDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeServiçoToolStripMenuItem_Click);
            // 
            // cadastroServiçosDeParceirosToolStripMenuItem
            // 
            this.cadastroServiçosDeParceirosToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.cadastroServiçosDeParceirosToolStripMenuItem.Name = "cadastroServiçosDeParceirosToolStripMenuItem";
            this.cadastroServiçosDeParceirosToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.cadastroServiçosDeParceirosToolStripMenuItem.Text = "Cadastro Serviços de Parceiros";
            this.cadastroServiçosDeParceirosToolStripMenuItem.Click += new System.EventHandler(this.cadastroServiçosDeParceirosToolStripMenuItem_Click);
            // 
            // cadastroDeDespesaToolStripMenuItem
            // 
            this.cadastroDeDespesaToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cadastroDeDespesaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeDespesaToolStripMenuItem});
            this.cadastroDeDespesaToolStripMenuItem.Name = "cadastroDeDespesaToolStripMenuItem";
            this.cadastroDeDespesaToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.cadastroDeDespesaToolStripMenuItem.Text = "Cadastro Despesa";
            // 
            // tipoDeDespesaToolStripMenuItem
            // 
            this.tipoDeDespesaToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.tipoDeDespesaToolStripMenuItem.Name = "tipoDeDespesaToolStripMenuItem";
            this.tipoDeDespesaToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.tipoDeDespesaToolStripMenuItem.Text = "Cadastro Tipo de Despesa";
            this.tipoDeDespesaToolStripMenuItem.Click += new System.EventHandler(this.tipoDeDespesaToolStripMenuItem_Click);
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarCompraToolStripMenuItem,
            this.lançarDespesasToolStripMenuItem});
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.compraToolStripMenuItem.Text = "COMPRA";
            // 
            // gerenciarCompraToolStripMenuItem
            // 
            this.gerenciarCompraToolStripMenuItem.Name = "gerenciarCompraToolStripMenuItem";
            this.gerenciarCompraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerenciarCompraToolStripMenuItem.Text = "Gerenciar Compra";
            this.gerenciarCompraToolStripMenuItem.Click += new System.EventHandler(this.gerenciarCompraToolStripMenuItem_Click);
            // 
            // rELATÓRIOSToolStripMenuItem
            // 
            this.rELATÓRIOSToolStripMenuItem.Name = "rELATÓRIOSToolStripMenuItem";
            this.rELATÓRIOSToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.rELATÓRIOSToolStripMenuItem.Text = "RELATÓRIOS";
            // 
            // iNFORMAÇÕESToolStripMenuItem
            // 
            this.iNFORMAÇÕESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrizaçãoDoSistemaToolStripMenuItem});
            this.iNFORMAÇÕESToolStripMenuItem.Name = "iNFORMAÇÕESToolStripMenuItem";
            this.iNFORMAÇÕESToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.iNFORMAÇÕESToolStripMenuItem.Text = "INFORMAÇÕES";
            // 
            // parametrizaçãoDoSistemaToolStripMenuItem
            // 
            this.parametrizaçãoDoSistemaToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.parametrizaçãoDoSistemaToolStripMenuItem.Name = "parametrizaçãoDoSistemaToolStripMenuItem";
            this.parametrizaçãoDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.parametrizaçãoDoSistemaToolStripMenuItem.Text = "Parametrização do Sistema";
            this.parametrizaçãoDoSistemaToolStripMenuItem.Click += new System.EventHandler(this.parametrizaçãoDoSistemaToolStripMenuItem_Click);
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
            this.trocarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.trocarUsuárioToolStripMenuItem_Click);
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
            this.toolStripStatusLabel1.Text = "Hair Lumus - Usuário:";
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
            // lançarDespesasToolStripMenuItem
            // 
            this.lançarDespesasToolStripMenuItem.Name = "lançarDespesasToolStripMenuItem";
            this.lançarDespesasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lançarDespesasToolStripMenuItem.Text = "Lançar Despesas";
            this.lançarDespesasToolStripMenuItem.Click += new System.EventHandler(this.lançarDespesasToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem cadastroCategoriaProdutoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem rELATÓRIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFORMAÇÕESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bACKUPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroMarcaProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trocarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrodePessoa;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFormaDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrizaçãoDoSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeDespesaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeDespesaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarCompraToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroServiçosDeParceirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançarDespesasToolStripMenuItem;
    }
}

