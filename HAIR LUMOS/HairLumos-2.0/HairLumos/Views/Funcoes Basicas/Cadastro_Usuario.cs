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
    public partial class Cadastro_Usuario : Form
    {
        int intCodPessoa = 0;


        public Cadastro_Usuario()
        {
            InitializeComponent();
            _inicializa();
            _limpaCampos();
        }

        private void btnPesquisaPessoa_Click(object sender, EventArgs e)
        {


            try
            {
                Views.Pesquisa_Pessoa objPessoa = new Pesquisa_Pessoa();

                objPessoa.ShowDialog();
                if (objPessoa.intCodigoPessoa > 0)
                {
                    Controller.PessoaController pessoaController = new Controller.PessoaController();
                    DataTable dtRetorno = pessoaController.retornaPessoaCod(objPessoa.intCodigoPessoa.ToString());

                    if (dtRetorno != null && dtRetorno.Rows.Count > 0)
                    {
                        DataRow dr = dtRetorno.Rows[0];
                        ttbCodigo.Text = dr["codpessoa"].ToString();
                        ttbPessoa.Text = dr["pes_nome"].ToString();

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void _inicializa()
        {
            // ttb
            ttbCodigo.Enabled = false;
            ttbPessoa.Enabled = false;
            ttbLogin.Enabled = false;
            mskSenha.Enabled = false;
            mskConfirmaSenha.Enabled = false;
            cbbNivel.Enabled = false;

            //btn
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            btnSair.Enabled = true;


            _limpaCampos();

        }

        public void _limpaCampos()
        {
            ttbCodigo.Text = "";
            ttbPessoa.Text = "";
            ttbLogin.Text = "";
            mskSenha.Text = "";
            mskConfirmaSenha.Text = "";
            cbbNivel.SelectedIndex = -1;
        }

        public void _btnNovo()
        {
            //ttbCodigo.Text = "0";
            ttbCodigo.Enabled = false;
            ttbPessoa.Enabled = true;
            ttbLogin.Enabled = true;
            mskSenha.Enabled = true;
            mskConfirmaSenha.Enabled = true;
            cbbNivel.Enabled = true;


            //botões
            btnNovo.Enabled = true;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = false;
            btnSair.Enabled = true;

            ttbPessoa.Focus();
        }

        public void _btnAlterar()
        {
            ttbCodigo.Enabled = false;

            ttbPessoa.Enabled = true;
            ttbLogin.Enabled = true;
            mskSenha.Enabled = true;
            mskConfirmaSenha.Enabled = true;
            cbbNivel.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            btnSair.Enabled = true;

            ttbPessoa.Focus();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _btnNovo();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cadastro_Usuario_Load(object sender, EventArgs e)
        {
            _inicializa();
            cbbNivel.ValueMember = "1";
            cbbNivel.DisplayMember = "1";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            _btnAlterar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _limpaCampos();
            _inicializa();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Controller.UsuarioController usuarioController = new Controller.UsuarioController();
            int intcodUser = 0;
            string strmensagem = string.Empty;

            try
            {

                Int32.TryParse(ttbCodigo.Text, out intCodPessoa);

                if (string.IsNullOrWhiteSpace(ttbPessoa.Text))
                    strmensagem += $"Informe Nome de Usuário/Login";


                if (string.IsNullOrWhiteSpace(mskSenha.Text))
                    strmensagem += $"Informe sua Senha.";

                if (string.IsNullOrWhiteSpace(mskConfirmaSenha.Text))
                    strmensagem += $"Confirme sua senha.";

                if (mskSenha.Equals(mskConfirmaSenha.Text))
                    strmensagem += $"Senhas não conferem.";

                object pessoa = new StringBuilder();

                if (intCodPessoa != 0)
                {
                    if (string.IsNullOrEmpty(strmensagem))
                    {
                        DataTable usuario = new DataTable();
                        usuario = usuarioController.verificaCadastroUser(intCodPessoa);


                        if (usuario.Rows.Count == 0)
                        {

                            int retorno = usuarioController.gravaUsuario(intcodUser, intCodPessoa, ttbLogin.Text.Trim(), mskSenha.Text.Trim(), Convert.ToInt32(cbbNivel.SelectedItem.ToString()));

                            if (retorno > 0)
                            {
                                _limpaCampos();
                                _inicializa();
                                MessageBox.Show("Usuário gravado com sucesso :");
                            }
                            else
                            {
                                MessageBox.Show("Erro :");
                            }
                            _limpaCampos();
                            _inicializa();

                        }
                        else
                        {
                            DataRow dr = usuario.Rows[0];
                            intcodUser = Convert.ToInt32(dr["codusuario"]);
                            int retorno = usuarioController.gravaUsuario(intcodUser, intCodPessoa, ttbLogin.Text.Trim(), mskSenha.Text.Trim(), Convert.ToInt32(cbbNivel.SelectedItem.ToString()));

                            if (retorno > 0)
                            {
                                _limpaCampos();
                                _inicializa();
                                MessageBox.Show("Usuário alterado com sucesso :");
                            }
                            else
                            {
                                MessageBox.Show("Erro :");
                            }
                            _limpaCampos();
                            _inicializa();

                        }

                    }
                    else
                        MessageBox.Show(strmensagem, "Aviso!!");
                }
                else
                {
                    MessageBox.Show("Informe a pessoa.");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex + "");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Controller.UsuarioController _ctrlUser = new Controller.UsuarioController();

            int intCod = 0;

            int.TryParse(ttbCodigo.Text, out intCod);

            if (intCod > 0)
            {
                if (MessageBox.Show("Confirma exclusão do Usuário?", "Usuário", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bool blnExcluiu = _ctrlUser.excluiUsuario(intCod);
                    if (blnExcluiu)
                    {
                        MessageBox.Show("Usuário Excluída");
                        _limpaCampos();
                        //pesquisaMarca();
                        _btnNovo();
                    }
                    else
                        MessageBox.Show("Erro ao excluir!");
                }
                else
                {
                    MessageBox.Show("cancela ?");
                }
            }
        }

        public void preencheUsuário(int coduser, string login, string senha, int nivel)
        {
            ttbCodigo.Text = Convert.ToString(coduser);
            ttbLogin.Text = login;
            mskSenha.Text = senha;
            mskConfirmaSenha.Text = mskSenha.Text;
            cbbNivel.Text = Convert.ToString(nivel);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            _limpaCampos();
            int intcodUser = 0;
            _btnAlterar();
            this.preencheUsuário(0, "", "", 0);
            Views.Funcoes_Basicas.Pesquisas.Pesquisa_Usuario pesquisa_Usuario = new Funcoes_Basicas.Pesquisas.Pesquisa_Usuario();

            pesquisa_Usuario.ShowDialog();
            if (pesquisa_Usuario.intCodigoPessoa > 0)
            {
                Controller.UsuarioController usuarioController = new Controller.UsuarioController();
                Controller.PessoaController pessoaController = new Controller.PessoaController();
                DataTable dtRetorno = usuarioController.retornaObjUsuario(Convert.ToInt32(pesquisa_Usuario.intCodigoPessoa.ToString()));

                if (dtRetorno != null && dtRetorno.Rows.Count > 0)
                {
                    DataRow dr = dtRetorno.Rows[0];
                    string codPessoa = dr["codpessoa"].ToString();
                    DataTable dtPessoa = pessoaController.retornaPessoaCod(codPessoa);

                    if (dtPessoa != null && dtPessoa.Rows.Count > 0)
                    {
                        DataRow drPes = dtPessoa.Rows[0];
                        ttbPessoa.Text = drPes["pes_nome"].ToString();

                    }

                    this.preencheUsuário(
                        int.Parse(dr["codpessoa"].ToString()),
                        dr["usu_usuario"].ToString(),
                        dr["usu_senha"].ToString(),
                        int.Parse(dr["usu_nivel"].ToString()));

                }
            }
        }
    }
}
