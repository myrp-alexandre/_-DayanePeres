using HairLumos.Controller;
using HairLumos.Entidades;
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
            UsuarioController uc = new UsuarioController();
            DataTable dt = uc.existeUsuario();
            if(dt==null || dt.Rows.Count == 0)
            {
                this.Hide();
                frmMenu menu = new frmMenu(dt);
                menu.ShowDialog();
            }
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            UsuarioController uc = new UsuarioController();


            string login = "admin";
            string senha = "admin";
            DataTable usuarioLogado = uc.realizaLogin(login, senha);//ttbUsuario.Text, ttbSenha.Text);
            if (usuarioLogado != null && usuarioLogado.Rows.Count > 0)
            {
                DataRow dr = usuarioLogado.Rows[0];
                int codigo = Convert.ToInt32(dr["codusuario"]);
                uc.usuarioLogado(codigo, codigo);
                this.Hide();
                frmMenu menu = new frmMenu(usuarioLogado);
                menu.ShowDialog();
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
