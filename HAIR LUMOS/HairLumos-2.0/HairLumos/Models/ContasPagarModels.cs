using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class ContasPagarModels
    {
        //------------------------ LANÇAR DESPESA ---------------------------

        DAO.ContasPagarDAO ContasPagarDAO = new DAO.ContasPagarDAO();
        DAO.DespesaDAO DespesaDAO = new DAO.DespesaDAO();

        public int gravarLancamentoConta(Entidades.ContasPagar contasPagar)
        {
           
            Entidades.ContasPagar _contas = new Entidades.ContasPagar();
            Entidades.Pessoa _pessoa = new Entidades.Pessoa();
            Entidades.Despesa _despesa = new Entidades.Despesa();
            Entidades.Usuario _usuario = new Entidades.Usuario();

            DataTable dtDespesa = DespesaDAO.RetornaObjServico(contasPagar.Despesa.Codigo);
            if (dtDespesa != null && dtDespesa.Rows.Count > 0)
            {
                DataRow dr = dtDespesa.Rows[0];
                _despesa.Codigo = Convert.ToInt32(dr["coddespesa"].ToString());
                _despesa.Descricao = dr["desp_descricao"].ToString();
                _despesa.Status = dr["desp_status"].ToString();
            }
            Entidades.Compra _compra = new Entidades.Compra();
            DataTable dtCompra = new Controller.CompraController().retornaCompra(contasPagar.Compra.Codigo);
            if(dtCompra!=null && dtCompra.Rows.Count > 0)
            {
                DataRow drCompra = dtCompra.Rows[0];
                _compra.Codigo = Convert.ToInt32(drCompra["codcompra"].ToString());
                _compra.Despesa = _despesa;
                _compra.Data = Convert.ToDateTime(drCompra["comp_datacompra"].ToString());
                _compra.Situacao = drCompra["comp_situacao"].ToString();
                _compra.Consignado = Convert.ToBoolean(drCompra["comp_statusconsignado"].ToString());
                _compra.ValorTotal = Convert.ToDouble(drCompra["comp_valortotal"].ToString());
                _compra.Obs = drCompra["comp_obs"].ToString();
                DataTable dtPessoa = new Controller.PessoaController().retornaPessoaCod(drCompra["codpessoa"].ToString());
                if (dtPessoa != null && dtPessoa.Rows.Count > 0)
                {
                    DataRow drPessoa = dtPessoa.Rows[0];
                    _pessoa.Codigo = Convert.ToInt32(drPessoa["codpessoa"].ToString());
                    _pessoa.Nome = drPessoa["pes_nome"].ToString();
                    _pessoa.DataCadastro = Convert.ToDateTime(drPessoa["pes_datacadastro"].ToString());
                    _pessoa.TipoPessoa = drPessoa["pes_tipopessoa"].ToString();
                    _pessoa.StatusPessoa = Convert.ToBoolean(drPessoa["pes_statuspessoa"].ToString());
                    _pessoa.Observacao = drPessoa["pes_obs"].ToString();
                    _pessoa.Fiado = Convert.ToBoolean(drPessoa["pes_fiado"].ToString());
                    _pessoa.Email = drPessoa["pes_email"].ToString();
                    _pessoa.Telefone = drPessoa["pes_fone"].ToString();
                    _pessoa.Celular = drPessoa["pes_cel"].ToString();
                }
                _compra.Pessoa = _pessoa;
            }
            Entidades.Caixa _caixa = new Entidades.Caixa();
            DataTable dtCaixa = new Controller.CaixaController().retornacaixaAbetoDia();
            if(dtCaixa!=null && dtCaixa.Rows.Count > 0)
            {
                DataRow drCaixa = dtCaixa.Rows[0];
                _caixa.CodCaixa = Convert.ToInt32(drCaixa["codcaixa"].ToString());
                _caixa.DataAbertura = Convert.ToDateTime(drCaixa["caixa_datahoraabertura"].ToString());
                _caixa.DataFechamento = Convert.ToDateTime(drCaixa["caixa_datahorafecha"].ToString());
                _caixa.SaldoInicial = Convert.ToDouble(drCaixa["caixa_saldoinicial"].ToString());
                _caixa.Troco = Convert.ToDouble(drCaixa["caixa_troco"].ToString());
                _caixa.TotalEntrada = Convert.ToDouble(drCaixa["caixa_totalentra"].ToString());
                _caixa.TotalSaida = Convert.ToDouble(drCaixa["caixa_totalsaida"].ToString());
                DataTable dtPessoa = new Controller.PessoaController().retornaPessoaCod(drCaixa["codpessoa"].ToString());
                if (dtPessoa != null && dtPessoa.Rows.Count > 0)
                {
                    _pessoa = new Entidades.Pessoa();
                    DataRow drPessoa = dtPessoa.Rows[0];
                    _pessoa.Codigo = Convert.ToInt32(drPessoa["codpessoa"].ToString());
                    _pessoa.Nome = drPessoa["pes_nome"].ToString();
                    _pessoa.DataCadastro = Convert.ToDateTime(drPessoa["pes_datacadastro"].ToString());
                    _pessoa.TipoPessoa = drPessoa["pes_tipopessoa"].ToString();
                    _pessoa.StatusPessoa = Convert.ToBoolean(drPessoa["pes_statuspessoa"].ToString());
                    _pessoa.Observacao = drPessoa["pes_obs"].ToString();
                    _pessoa.Fiado = Convert.ToBoolean(drPessoa["pes_fiado"].ToString());
                    _pessoa.Email = drPessoa["pes_email"].ToString();
                    _pessoa.Telefone = drPessoa["pes_fone"].ToString();
                    _pessoa.Celular = drPessoa["pes_cel"].ToString();
                }
                _caixa.Pessoa = _pessoa;
                DataTable dtUsuario = new Controller.UsuarioController().retornaObjUsuario(Convert.ToInt32(drCaixa["codusuario"].ToString()));
                if (dtUsuario != null && dtUsuario.Rows.Count > 0)
                {
                    DataRow drUsuario = dtUsuario.Rows[0];
                    _usuario.UsuarioCodigo = Convert.ToInt32(drUsuario["codusuario"].ToString());
                    _usuario.Login = drUsuario["usu_usuario"].ToString();
                    _usuario.Senha = drUsuario["usu_senha"].ToString();
                    _usuario.Nivel = Convert.ToInt32(drUsuario["usu_nivel"].ToString());
                }
                _caixa.Usuario = _usuario;
            }
            Entidades.FormaPagamento _formaPagamento = new Entidades.FormaPagamento();
            if(contasPagar.FormaPagamento!=null && contasPagar.FormaPagamento.Codigo != 0)
            {
                DataTable dtForma = new Controller.PagamentoController().retornaObjFormaPagamento(contasPagar.FormaPagamento.Codigo);
                if(dtForma!=null && dtForma.Rows.Count > 0)
                {
                    DataRow drForma = dtForma.Rows[0];
                    _formaPagamento.Codigo = Convert.ToInt32(drForma["codformapag"].ToString());
                    _formaPagamento.Forma = drForma["formpag_descricao"].ToString();
                }
            }
            else
            {
                _formaPagamento = new Entidades.FormaPagamento();
            }
            

            Entidades.Comissao _comissao = new Entidades.Comissao();
            if (contasPagar.Comissao != null && contasPagar.Comissao.CodigoComissao != 0)
            {
                _comissao = contasPagar.Comissao;
            }
            else
            {
                _comissao = new Entidades.Comissao();
            }

            _contas.Caixa = _caixa;
            _contas.CodParcela = contasPagar.CodParcela;
            _contas.Compra = _compra;
            _contas.DataPagamento = contasPagar.DataPagamento;
            _contas.DataVencimento = contasPagar.DataVencimento;
            _contas.ValorPago = 0;
            _contas.ValorTotal = contasPagar.ValorTotal;
            _contas.ValorParcela = contasPagar.ValorParcela;
            _contas.Parcela = contasPagar.Parcela;
            _contas.FormaPagamento = _formaPagamento;
            _contas.Comissao = _comissao;
            _contas.Despesa = _despesa;
            _contas.CodigoContasaPagar = contasPagar.CodigoContasaPagar;

            return ContasPagarDAO.GravaLancamentoDespesa(_contas);

            
        }

        public DataTable retornaPeriodo(DateTime datai, DateTime dataf)
        {
            return ContasPagarDAO.retornaContasPeriodo(datai, dataf);
        }

        public int retornaMax()
        {
            return ContasPagarDAO.max();
        }

    }
}
