using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    class ContasReceberController
    {
        private Models.ContasReceberModels cm = new Models.ContasReceberModels();

        public DataTable retornaContasReceber(string dataI, string dataF, string situacao)
        {
            return cm.retornaContasReceber(dataI, dataF, situacao);
        }

        public int gerarContasReceber(int cod, List<Entidades.Parcela> listaP)
        {
            Controller.VendaController vc = new VendaController();
            Controller.PessoaController pc = new PessoaController();

            Entidades.Venda v = new Entidades.Venda();
            Entidades.Pessoa p = new Entidades.Pessoa();
            Entidades.ContasReceber cr = new Entidades.ContasReceber();

            DataTable dtVenda = vc.retornaVendaCod(cod);
            if(dtVenda!=null && dtVenda.Rows.Count > 0)
            {
                DataRow drVenda = dtVenda.Rows[0];
                v.Codigo = Convert.ToInt32(drVenda["codvenda"].ToString());
                v.Data = Convert.ToDateTime(drVenda["vend_datavenda"].ToString());
                v.Situacao = drVenda["vend_situacao"].ToString();
                v.ValorTotal = Convert.ToDouble(drVenda["vend_valortotal"].ToString());
                v.Observacao = drVenda["vend_obs"].ToString();
                DataTable dtPessoa = pc.retornaPessoaCod(drVenda["codpessoa"].ToString());
                if(dtPessoa!=null && dtPessoa.Rows.Count > 0)
                {
                    DataRow drPessoa = dtPessoa.Rows[0];
                    p.Codigo = Convert.ToInt32(drPessoa["codpessoa"].ToString());
                    p.Nome = drPessoa["pes_nome"].ToString();
                    p.DataCadastro = Convert.ToDateTime(drPessoa["pes_datacadastro"].ToString());
                    p.TipoPessoa = drPessoa["pes_tipopessoa"].ToString();
                    p.StatusPessoa = Convert.ToBoolean(drPessoa["pes_statuspessoa"].ToString());
                    p.Observacao = drPessoa["pes_obs"].ToString();
                    p.Fiado = Convert.ToBoolean(drPessoa["pes_fiado"].ToString());
                    p.Email = drPessoa["pes_email"].ToString();
                    p.Telefone = drPessoa["pes_fone"].ToString();
                    p.Celular = drPessoa["pes_cel"].ToString();
                }
                v.Pessoa = p;
            }


            cr.Comissao = new Entidades.Comissao();
            cr.Contrato = new Entidades.Contrato();
            cr.CodigoFechamento = 1;
            cr.DtVencimento = v.Data;
            cr.ValorTotal = v.ValorTotal;
            cr.Obs = "aberta";
            cr.Venda = v;
            cr.Pessoaf = v.Pessoa;
            cr.Lista = listaP;

            return cm.gerarContasReceber(cr);
        }

        public int gerarContasReceber(Entidades.ContasReceber obj)
        {

            return cm.gerarContasReceber(obj);
        }

        public int realizarRecebimento(Entidades.Parcela parcela, int codigo)
        {
            return cm.realizaRecebimento(parcela, codigo);
        }

        public int atualizaStatus(int codigo, string situacao)
        {
            return cm.atualizaStatus(codigo, situacao);
        }

        public DataTable retornaContasCod(int codigo)
        {
            return cm.retornaContasCod(codigo);
        }

        public DataTable retornaParcelaContaReceber(int codRe, int codP)
        {
            return cm.retornaParcelaContaReceber(codRe, codP);
        }

        public bool verificaParcelas(int cod)
        {
            return cm.verificaParcelas(cod);
        }

        public int retornaVenda(int cod)
        {
            return cm.retornaVenda(cod);
        }
    }
}
