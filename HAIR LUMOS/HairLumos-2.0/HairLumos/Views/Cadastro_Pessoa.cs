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
    public partial class Cadastro_Pessoa : Form
    {
        List<Endereco> arrEndreco = null;
        List<Contato> arrContato = null;

        int intCodPessoa = 0;

        public Cadastro_Pessoa()
        {
            InitializeComponent();
            this.arrEndreco = new List<Endereco>();
            this.arrContato = new List<Contato>();
            dgvEndereco.AutoGenerateColumns = false;
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

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

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
            //Validar os dados
            Controller.PessoaController _ctrlPes = new Controller.PessoaController();
            
            string strMensagem = string.Empty;

            try
            {
                //validações
                string tipoPes = "";
                DateTime dataCadastro = new DateTime();
                dataCadastro = DateTime.Now;
                int intCodigo = 0;
                if (intCodPessoa != 0)
                {
                    if (!int.TryParse(ttbCodigo.Text, out intCodigo))
                        strMensagem += $"Código inválido{Environment.NewLine}";
                }
                if(rbFisica.Checked == true)
                {
                    tipoPes = "F";
                    if (string.IsNullOrWhiteSpace(ttbNome.Text))
                        strMensagem += $"Informe Nome da Pessoa.";

                    if (string.IsNullOrWhiteSpace(mskTelefone.Text) || string.IsNullOrWhiteSpace(mskCelular.Text))
                        strMensagem += $"Informe um contato.";

                }
               
                if(rbJuridica.Checked == true)
                {
                    tipoPes = "J";
                    if (string.IsNullOrWhiteSpace(ttbNome.Text))
                        strMensagem += $"Informe Nome Fantasia da Empresa.";

                    if (string.IsNullOrWhiteSpace(ttbRazao.Text))
                        strMensagem += $"Informe a Razão Social da Empresa.";
                }
                
                bool pagamento = false;

                if(rbPagaNao.Enabled == true)
                {
                    pagamento = true;
                }
                if(rbPagaSim.Enabled == true)
                {
                    pagamento = true;
                }

                
                int intRetorno = _ctrlPes.gravarPessoa(intCodigo, ttbNome.Text.Trim(), dataCadastro, ttbRazao.Text.Trim(), ttbRg.Text.Trim(), mskCPF.Text.Trim(),
                    mskCNPJ.Text.Trim(), dtpDataNascimento.Value, pagamento, arrEndreco, arrContato, ttbObservação.Text.Trim(), tipoPes);
                

                if (intRetorno == 1)
                {
                    MessageBox.Show("Gravado com sucesso!");
                    _limpaCampos();
                    _inicializa();
                }
                else
                {
                    MessageBox.Show("Erro ao gravar.");
                }
                if (strMensagem.Equals(""))
                {
                    MessageBox.Show(strMensagem + "Aviso!!!");
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
            obj._celular = mskCelular.Text.Trim();
            obj._email = ttbEmail.Text.Trim();
            
            this.arrContato.Add(obj);
            dgvContato.DataSource = arrContato;
            dgvContato.ClearSelection();
        }
    }
}
