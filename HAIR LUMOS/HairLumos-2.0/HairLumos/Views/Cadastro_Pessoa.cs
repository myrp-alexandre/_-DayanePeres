using HairLumos.Entidades;
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
    public partial class Cadastro_Pessoa : Form
    {
        List<Endereco> arrEndreco = null;
        List<Contato> arrContato = null;

        int intCodPessoa = 0;
        string tipoContato = "";

        public Cadastro_Pessoa()
        {
            InitializeComponent();
            this.arrEndreco = new List<Endereco>();
            this.arrContato = new List<Contato>();
            dgvEndereco.AutoGenerateColumns = false;
            dgvContato.AutoGenerateColumns = false;
            
            _inicializa();
            _limpaCampos();
        }

       
        public void _inicializa()
        {
            // ttb
            ttbCodigo.Enabled = false;
            ttbNome.Enabled = false;
            ttbRazao.Enabled = false;
            ttbRg.Enabled = false;
            mskCPF.Enabled = false;
            mskCNPJ.Enabled = false;
            dtpDataNascimento.Enabled = false;
            ttbEmail.Enabled = false;

            rbAtivo.Enabled = false;
            rbInativo.Enabled = false;
            rbFisica.Enabled = false;
            rbJuridica.Enabled = false;

            dgvEndereco.Enabled = true;

            //btn
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;
            btnIncluirEndereco.Enabled = false;
            btnSair.Enabled = true;

            //pesquisaMarca();
            _limpaCampos();
            

        }

        public void _limpaCampos()
        {
            ttbCodigo.Text = "";
            ttbNome.Text = "";
            ttbRazao.Text = "";
            ttbRg.Text = "";
            mskCNPJ.Text = "";
            mskCPF.Text = "";
            ttbEmail.Text = "";
            dtpDataNascimento.Value = DateTime.Now.Date;

            rbAtivo.Checked = true;
            rbFisica.Checked = true;
        }

        public void _btnNovo()
        {
            ttbCodigo.Text = "0";
            ttbCodigo.Enabled = false;
            ttbNome.Enabled = true;
            ttbRazao.Enabled = true;
            ttbRg.Enabled = true;
            mskCPF.Enabled = true;
            mskCNPJ.Enabled = true;
            dtpDataNascimento.Enabled = true;
            ttbEmail.Enabled = true;

            rbAtivo.Enabled = true;
            rbAtivo.Checked = true;
            rbInativo.Enabled = true;

            rbFisica.Enabled = true;
            rbFisica.Checked = true;
            rbJuridica.Enabled = true;

            dgvEndereco.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnPesquisar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;
            btnIncluirEndereco.Enabled = true;

            ttbNome.Focus();
        }

        public void _btnAlterar()
        {
            ttbCodigo.Enabled = false;
            ttbCodigo.Enabled = false;
            ttbNome.Enabled = true;
            ttbRazao.Enabled = true;
            ttbRg.Enabled = true;
            mskCPF.Enabled = true;
            mskCNPJ.Enabled = true;
            dtpDataNascimento.Enabled = true;
            ttbEmail.Enabled = true;

            rbAtivo.Enabled = true;
            rbAtivo.Checked = true;
            rbInativo.Enabled = true;

            rbFisica.Enabled = true;
            rbFisica.Checked = true;
            rbJuridica.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;

            ttbNome.Focus();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Controller.PessoaController _ctrlPessoa = new PessoaController();

            int intCod = 0;
            int.TryParse(ttbCodigo.Text, out intCod);

            if (intCod > 0)
            {
                if (MessageBox.Show("Confirma exclusão da Pessoa?", "Pessoa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int blnExcluiu = _ctrlPessoa.excluiPessoaFisica(intCod); 
                    if (intCod>0)
                    {
                        MessageBox.Show("Pessoa Excluída");
                        _limpaCampos();
                        _inicializa();

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _limpaCampos();
            
        }

        private void Cadastro_Pessoa_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIncluirEndereco_Click(object sender, EventArgs e)
        {
            pnlEndereco.Visible = true;
   
            
        }
        
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIncluirContato_Click(object sender, EventArgs e)
        {
            pnlContato.Visible = true;
            dgvContato.Visible = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Controller.PessoaController _ctrlPessoa = new PessoaController();

            string strMensagem = string.Empty;

            try
            {
                int intCodigo = 0;
                Int32.TryParse(ttbCodigo.Text, out intCodPessoa);
                string tipoPessoa = "";

                if(rbFisica.Checked == true)
                {
                    tipoPessoa = "FISICA";
                }
                if (rbJuridica.Checked == true)
                {
                    tipoPessoa = "JURIDICA";
                }

                bool statusPessoa = false;
                if(rbAtivo.Checked == true)
                {
                    statusPessoa = true;
                }
                if (rbInativo.Checked == true)
                {
                    statusPessoa = true;
                }

                bool fiado = false;
                if(rbPagaSim.Checked == true)
                {
                    fiado = true;
                }
                if (rbPagaNao.Checked == true)
                {
                    fiado = true;
                }


                if (string.IsNullOrWhiteSpace(ttbNome.Text))
                    strMensagem += $"Informe a categoria do Produto.";

                if (intCodPessoa == 0) { 
                    //verificar se houve alguma anormalidade no cadastro
                    if (string.IsNullOrEmpty(strMensagem))
                    {

                        int retorno = _ctrlPessoa.gravarPessoaFisica(intCodigo, ttbNome.Text, DateTime.Now, tipoPessoa, statusPessoa,
                            ttbObservação.Text, fiado, ttbEmail.Text, arrEndreco, arrContato, mskCPF.Text, ttbRg.Text, dtpDataNascimento.Value);
                        if (retorno > 0)
                        {
                            _limpaCampos();
                            _inicializa();
                        }
                        else
                        {
                            MessageBox.Show("Erro :$");
                        }
                        _limpaCampos();
                        _inicializa();
                    }
                    else
                        MessageBox.Show(strMensagem, "Aviso!!");
                }
                else
                {
                    if (string.IsNullOrEmpty(strMensagem))
                    {

                        int retorno = _ctrlPessoa.alteraPessoaFisica(intCodigo, ttbNome.Text, DateTime.Now, tipoPessoa, statusPessoa,
                            ttbObservação.Text, fiado, ttbEmail.Text, arrEndreco, arrContato, mskCPF.Text, ttbRg.Text, dtpDataNascimento.Value);
                        if (retorno > 0)
                        {
                            MessageBox.Show("Alterou");
                            _limpaCampos();
                            _inicializa();
                        }
                        else
                        {
                            MessageBox.Show("Erro :$");
                        }
                        _limpaCampos();
                        _inicializa();
                    }
                    else
                        MessageBox.Show(strMensagem, "Aviso!!");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex + "");
            }
        }

        private void btnSalvarEndereco_Click(object sender, EventArgs e)
        {
            //Valida se as informaçoes foram digitadas
            
            Endereco obj = new Endereco();
            obj._logradouro = ttbLogradouro.Text.Trim();
            obj._numero = ttbNumero.Text.Trim();
            obj._bairro = ttbBairro.Text.Trim();
            obj._complemento = ttbComplemento.Text.Trim();
            //obj._codUf = cbb

            this.arrEndreco.Add(obj);
            dgvEndereco.DataSource = arrEndreco;
            dgvEndereco.ClearSelection();
        }

        private void btnSalvarContato_Click(object sender, EventArgs e)
        {
            Entidades.Contato obj = new Entidades.Contato();
            obj._telefone = mskTelefone.Text.Trim();
            
            if(rbTelefone.Checked == true)
            {
                tipoContato = "TELEFONE";
            }
            if (rbCelular.Checked == true)
            {
                tipoContato = "CELULAR";
            }
            if (rbComercial.Checked == true)
            {
                tipoContato = "COMERCIAL";
            }
            this.arrContato.Add(obj);
            dgvContato.DataSource = arrContato;
            dgvContato.ClearSelection();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _btnNovo();
        }

        public void estados(Boolean estado)
        {
            ttbRg.Enabled = estado;
            mskCPF.Enabled = estado;
            dtpDataNascimento.Enabled = estado;
            mskCNPJ.Enabled = !estado;
            ttbRazao.Enabled = !estado;
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFisica.Checked == true)
            {
                estados(true);

            }
            if (rbJuridica.Checked == true)
            {
                estados(false);
            }
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFisica.Checked == true)
            {
                estados(true);

            }
            if (rbJuridica.Checked == true)
            {
                estados(false);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            _btnAlterar();
        }

        public void PreencheTela(string cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, 
            string obs, bool fiado, string email)
        {
            ttbCodigo.Text = cod;
            ttbNome.Text = nome;
            dtpDataNascimento.Value = dataCadastro;

            if (tipopes.Contains("F"))
            {
                rbFisica.Checked = true;
            }
            if (tipopes.Contains("J"))
            {
                rbJuridica.Checked = true;
            }

            if (statusPessoa == true)
            {
                rbAtivo.Checked = true;
            }
            else
            {
                rbInativo.Checked = true;
            }

            if(fiado == true)
            {
                rbPagaSim.Checked = true;
            }
            else
            {
                rbPagaNao.Checked = true;
            }

            ttbEmail.Text = email;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            _btnAlterar();
            this.PreencheTela("", "", DateTime.Now, "", true, "", true, "");
            Pesquisa_Pessoa objTela = new Pesquisa_Pessoa();

            objTela.ShowDialog();
            if (objTela.intCodigoPessoa > 0)
            {
                PessoaController _pes = new PessoaController();
                DataTable dtRetorno = _pes.retornaPessoa(objTela.intCodigoPessoa.ToString());
                if (dtRetorno != null && dtRetorno.Rows.Count > 0)
                {
                    DataRow dr = dtRetorno.Rows[0];
                    this.PreencheTela(dr["codpessoa"].ToString(), 
                        dr["pes_nome"].ToString(), 
                        DateTime.Parse(dr["pes_datacadastro"].ToString()), 
                        dr["pes_tipopessoa"].ToString(), 
                        Boolean.Parse(dr["pes_statuspessoa"].ToString()),
                        dr["pes_obs"].ToString(), 
                        Boolean.Parse(dr["pes_fiado"].ToString()), 
                        dr["pes_email"].ToString());


                }
            }
        }
   
    }
}
