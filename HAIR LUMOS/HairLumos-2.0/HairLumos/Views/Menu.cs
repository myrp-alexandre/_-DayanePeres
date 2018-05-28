
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cadastroCategoriaProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Cadastro_CategoriaProduto CategoProd = new Views.Cadastro_CategoriaProduto();
            CategoProd.Show();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
