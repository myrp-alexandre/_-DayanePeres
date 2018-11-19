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

        private Controller.PessoaController pc = new PessoaController();

        public Cadastro_Pessoa()
        {
            InitializeComponent();

            _inicializa(false);
            carregaEstado();
            ttbCodigo.Enabled = false;
        }

        private void _inicializa(bool estado)
        {
            //LimpaCampos();

            btnNovo.Enabled = !estado;
            btnPesquisar.Enabled = !estado;
            btnAlterar.Enabled = !estado;
            btnGravar.Enabled = estado;
            btnExcluir.Enabled = estado;
            btnCancelar.Enabled = estado;
            btnSair.Enabled = !estado;

            //ttbCodigo.Enabled = !estado;
            rbAtivo.Enabled = estado;
            rbInativo.Enabled = estado;
            rbFisica.Enabled = estado;
            rbJuridica.Enabled = estado;
            rbPagaNao.Enabled = estado;
            rbPagaSim.Enabled = estado;
            ttbNome.Enabled = estado;
            ttbRazao.Enabled = estado;
            ttbRg.Enabled = estado;
            mskCNPJ.Enabled = estado;
            mskCPF.Enabled = estado;
            dtpDataNascimento.Enabled = estado;
            ttbEmail.Enabled = estado;
            maskCelular.Enabled = estado;
            maskTelefone.Enabled = estado;
            ttbBairro.Enabled = estado;
            ttbComplemento.Enabled = estado;
            ttbLogradouro.Enabled = estado;
            ttbNumero.Enabled = estado;
            mtbCEP.Enabled = estado;
            cbbCidade.Enabled = estado;
            cbbEstado.Enabled = estado;
            ttbObservação.Enabled = estado;
            grpPessoa.Enabled = estado;
            grpFiado.Enabled = estado;

            tabcInformaçõesPessoa.Enabled = estado;
        }

        private void LimpaEndereco()
        {
            ttbLogradouro.Text = "";
            ttbNumero.Text = "";
            ttbBairro.Text = "";
            ttbComplemento.Text = "";
            mtbCEP.Text = "";
            cbbEstado.SelectedIndex = -1;
            cbbCidade.SelectedIndex = -1;
        }

        private void LimpaContato()
        {
            maskCelular.Text = "";
            maskTelefone.Text = "";
        }

        private void LimpaCampos()
        {
            ttbCodigo.Text = "";
            rbAtivo.Checked = true;
            rbInativo.Checked = false;
            rbFisica.Checked = true;
            rbJuridica.Checked = false;
            ttbNome.Text = "";
            ttbRazao.Text = "";
            ttbRg.Text = "";
            mskCNPJ.Text = "";
            mskCPF.Text = "";
            dtpDataNascimento.Value = System.DateTime.Now;
            ttbEmail.Text = "";
            rbPagaNao.Checked = true;
            rbPagaSim.Checked = false;
            LimpaEndereco();
            LimpaContato();
            ttbObservação.Text = "";

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _inicializa(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            _inicializa(false);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            int rest = 0;
            if (!String.IsNullOrEmpty(ttbCodigo.Text))
            {
                codigo = Convert.ToInt32(ttbCodigo.Text.ToString());
                if (rbFisica.Checked)
                    rest = pc.excluiPessoaFisica(codigo);
                else
                    rest = pc.excluiPessoaJuridica(codigo);

                if (rest > 0)
                {
                    MessageBox.Show("Pessoa Excluida com Sucesso!");
                    LimpaCampos();
                    _inicializa(false);
                }
                else
                {
                    MessageBox.Show("Erro ao excluir Pessoa!");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma pessoa para excluir!");
            } 
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            _inicializa(false);
            int cod = 0;

            Views.Funcoes_Basicas.Pesquisas.Pesquisa_Pessoa pesquisa_Pessoa = new Funcoes_Basicas.Pesquisas.Pesquisa_Pessoa();
            pesquisa_Pessoa.ShowDialog();
            cod = pesquisa_Pessoa.intCodigoPessoa;
            if (cod > 0)
            {
                DataTable dtPessoa = pc.retornaPessoaCod(cod+"");
                if(dtPessoa!=null && dtPessoa.Rows.Count > 0)
                {
                    DataRow drPessoa = dtPessoa.Rows[0];
                    ttbCodigo.Text = drPessoa["codpessoa"].ToString();

                    if (drPessoa["pes_tipopessoa"].ToString().Equals("Física"))
                    {
                        rbFisica.Checked = true;
                        rbJuridica.Checked = false;
                    }
                    else
                    {
                        rbFisica.Checked = false;
                        rbJuridica.Checked = true;
                    }
                    if (Convert.ToBoolean(drPessoa["pes_statuspessoa"].ToString()))
                    {
                        rbAtivo.Checked = true;
                        rbInativo.Checked = false;
                    }
                    else
                    {
                        rbAtivo.Checked = false;
                        rbInativo.Checked = true;
                    }
                    if (Convert.ToBoolean(drPessoa["pes_fiado"].ToString()))
                    {
                        rbPagaNao.Checked = false;
                        rbPagaSim.Checked = true;
                    }
                    else
                    {
                        rbPagaNao.Checked = true;
                        rbPagaSim.Checked = false;
                    }
                    ttbNome.Text = drPessoa["pes_nome"].ToString();
                    maskTelefone.Text = drPessoa["pes_fone"].ToString();
                    maskCelular.Text = drPessoa["pes_cel"].ToString();
                    DataTable dtEndereco = pc.retornaEndereco(cod);
                    if(dtEndereco!=null && dtEndereco.Rows.Count > 0)
                    {
                        DataRow drEndereco = dtEndereco.Rows[0];
                        ttbLogradouro.Text = drEndereco["end_logradouro"].ToString();
                        ttbNumero.Text = drEndereco["end_numero"].ToString();
                        ttbBairro.Text = drEndereco["end_bairro"].ToString();
                        ttbComplemento.Text = drEndereco["edn_complemento"].ToString();
                        mtbCEP.Text = drEndereco["end_cep"].ToString();
                        cbbEstado.SelectedIndex = Convert.ToInt32(drEndereco["coduf"].ToString()) - 1;
                        DataTable dtCidade = pc.retornaCidCodigo(Convert.ToInt32(drEndereco["codcidade"].ToString()));
                        DataRow drCidade = dtCidade.Rows[0];
                        cbbCidade.SelectedValue = Convert.ToInt32(drCidade["codcidade"].ToString());
                        
                    }
                    if (rbFisica.Checked)
                    {
                        ttbRazao.Enabled = false;
                        mskCNPJ.Enabled = false;
                        DataTable dtFisica = pc.retornaPessoaFisicaCod(cod);
                        if(dtFisica!=null && dtFisica.Rows.Count > 0)
                        {
                            DataRow drFisica = dtFisica.Rows[0];
                            mskCPF.Text = drFisica["fis_cpf"].ToString();
                            ttbRg.Text = drFisica["fis_rg"].ToString();
                            dtpDataNascimento.Value = Convert.ToDateTime(drFisica["fis_datanascimento"].ToString());
                        }
                    }
                    else
                    {
                        mskCPF.Enabled = false;
                        ttbRg.Enabled = false;
                        dtpDataNascimento.Enabled = false;
                        DataTable dtJuridica = pc.retornaPessoaJuridica(drPessoa["pes_nome"].ToString());
                        if(dtJuridica!=null && dtJuridica.Rows.Count > 0)
                        {
                            DataRow drJuridica = dtJuridica.Rows[0];
                            ttbRazao.Text = drJuridica["jur_razaosocial"].ToString();
                            mskCNPJ.Text = drJuridica["jur_cnpj"].ToString();
                        }
                    }
                    ttbObservação.Text = drPessoa["pes_obs"].ToString();
                    ttbEmail.Text = drPessoa["pes_email"].ToString();
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnNovo.Enabled = false;
                }
            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            int cid, uf;
            bool status = false;
            bool fiado = false;
            string tipo = "Jurídica";
            string cpf = "";
            string cnpj = "";

            if (!String.IsNullOrEmpty(ttbCodigo.Text))
            {
                codigo = Convert.ToInt32(ttbCodigo.Text);
            }
            cid = Convert.ToInt32(cbbCidade.SelectedValue);
            uf = cbbEstado.SelectedIndex+1;
            if (rbAtivo.Checked)
                status = true;
            if (rbFisica.Checked) 
                tipo = "Física";
            if (rbPagaSim.Checked)
                fiado = true;
            cpf = mskCPF.Text.ToString().Replace(",", ".");
            //cpf = cpf.Replace("-", "");
            cnpj = mskCNPJ.Text.ToString().Replace(",", ".");
            Views.Outras_Fundamentais.CpfCnpj cpfCnpj = new Outras_Fundamentais.CpfCnpj();

            Entidades.Endereco end = new Entidades.Endereco(mtbCEP.Text, ttbLogradouro.Text, ttbNumero.Text, ttbBairro.Text, ttbComplemento.Text, uf, cid);
            if (rbFisica.Checked)
            {
                bool cpfVal = cpfCnpj.IsValid(cpf);

                if (!cpfVal)
                {
                    MessageBox.Show("Cpf Inválido!");
                }
                else
                {
                    if (codigo == 0)
                    {


                        int resp = pc.gravarPessoaFisica(codigo, ttbNome.Text, DateTime.Now, tipo, status, ttbObservação.Text, fiado, ttbEmail.Text, end, maskTelefone.Text, maskCelular.Text, cpf, ttbRg.Text, dtpDataNascimento.Value);
                        if (resp > 0)
                        {
                            MessageBox.Show("Pessoa Gravada Com Sucesso!");
                            LimpaCampos();
                            _inicializa(false);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao gravar pessoa!");
                        }
                    }
                    else
                    {
                        int resp = pc.alteraPessoaFisica(codigo, ttbNome.Text, DateTime.Now, tipo, status, ttbObservação.Text, fiado, ttbEmail.Text, end, maskTelefone.Text, maskCelular.Text, cpf, ttbRg.Text, dtpDataNascimento.Value);
                        if (resp > 0)
                        {
                            MessageBox.Show("Pessoa alterada Com Sucesso!");
                            LimpaCampos();
                            _inicializa(false);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao alterar pessoa!");
                        }
                    }
                }
                
            }
            else
            {
                bool cnpjVal = cpfCnpj.IsValid(cnpj);

                if (!cnpjVal)
                {
                    MessageBox.Show("CNPJ Inválido!");
                }

                if (codigo == 0)
                {
                    int resp = pc.gravarPessoaJuridica(codigo, ttbNome.Text, DateTime.Now, tipo, status, ttbObservação.Text, fiado, ttbEmail.Text, end, maskTelefone.Text, maskCelular.Text, mskCNPJ.Text, ttbRazao.Text);
                    if (resp > 0)
                    {
                        MessageBox.Show("Pessoa Jurídica Gravada Com Sucesso!");
                        LimpaCampos();
                        _inicializa(false);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar pessoa jurídica!");
                    }
                }
                else
                {
                    int resp = pc.alteraPessoaJuridica(codigo, ttbNome.Text, DateTime.Now, tipo, status, ttbObservação.Text, fiado, ttbEmail.Text, end, maskTelefone.Text, maskCelular.Text, mskCNPJ.Text, ttbRazao.Text);
                    if (resp > 0)
                    {
                        MessageBox.Show("Pessoa Jurídica alterada Com Sucesso!");
                        LimpaCampos();
                        _inicializa(false);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar pessoa jurídica!");
                    }
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void carregaEstado()
        {
            DataTable dtEstado = pc.retornaEstado();
            cbbEstado.DataSource = dtEstado;
            cbbEstado.ValueMember = "coduf";
            cbbEstado.DisplayMember = "uf";
        }

        private void carregaCidade()
        {
            int codigo = cbbEstado.SelectedIndex+1;
            DataTable dtCidade = pc.retornaCidade(codigo);
            cbbCidade.DataSource = dtCidade;
            cbbCidade.ValueMember = "codcidade";
            cbbCidade.DisplayMember = "nome";
        }

        private void cbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaCidade();
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFisica.Checked)
            {
                ttbRazao.Enabled = false;
                mskCNPJ.Enabled = false;
                ttbRg.Enabled = true;
                mskCPF.Enabled = true;
                dtpDataNascimento.Enabled = true;
            }
            else
            {
                ttbRg.Enabled = false;
                mskCPF.Enabled = false;
                dtpDataNascimento.Enabled = false;
                ttbRazao.Enabled = true;
                mskCNPJ.Enabled = true;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(ttbCodigo.Text))
                _inicializa(true);

            if (rbFisica.Checked)
            {
                ttbRazao.Enabled = false;
                mskCNPJ.Enabled = false;
                ttbRg.Enabled = true;
                mskCPF.Enabled = true;
                dtpDataNascimento.Enabled = true;
                rbJuridica.Enabled = false;
            }
            else
            {
                ttbRg.Enabled = false;
                mskCPF.Enabled = false;
                dtpDataNascimento.Enabled = false;
                ttbRazao.Enabled = true;
                mskCNPJ.Enabled = true;
                rbFisica.Enabled = false;
            }
        }
    }
}
