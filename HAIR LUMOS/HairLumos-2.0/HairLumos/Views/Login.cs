using HairLumos.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            UsuarioController uc = new UsuarioController();
            DataTable usuarioLogado = uc.realizaLogin(ttbUsuario.Text, ttbSenha.Text);
            if (usuarioLogado != null && usuarioLogado.Rows.Count > 0)
            {
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.ShowDialog();
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
