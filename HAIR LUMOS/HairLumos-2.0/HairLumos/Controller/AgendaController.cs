using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    class AgendaController
    {
        private Models.AgendaModels _MdlAgenda = new Models.AgendaModels();

        public DataTable buscaAgenda(string cnpj, string data)
        {
            return _MdlAgenda.buscaData(cnpj, data);
        }

        public int atualizaStatus(Entidades.Agenda agenda)
        {
            return _MdlAgenda.updateStatus(agenda);
        }

        public int retornaComissao(Entidades.Agenda agenda)
        {
            return _MdlAgenda.retornaComissao(agenda);
        }

        public int gravarAgenda(int codigo, DateTime data, DateTime hora, string status, int valor, int comissao, int servico, int prestador, int fechamento)
        {
            Controller.PessoaController pc = new Controller.PessoaController();
            Controller.ServicoController sc = new Controller.ServicoController();
            Controller.ServicoParceiroController spc = new Controller.ServicoParceiroController();
            Controller.ComissaoController cmc = new Controller.ComissaoController();
            Entidades.Agenda agenda = new Entidades.Agenda();
            Entidades.Pessoa cliente = new Entidades.Pessoa(); //ja foi
            Entidades.PessoaJuridica funcionario = new Entidades.PessoaJuridica(); //ja foi
            Entidades.Fechamento fechar = new Entidades.Fechamento(); //ja foi
            Entidades.Comissao comis = new Entidades.Comissao();
            Entidades.Servico serv = new Entidades.Servico(); //ja foi
            Entidades.ServicoParceiro servparc = new Entidades.ServicoParceiro(); //ja foi

            DataTable dtCliente = pc.retornaPessoaCod(codigo + "");
            if (dtCliente != null && dtCliente.Rows.Count > 0)
            {
                DataRow drPessoa = dtCliente.Rows[0];
                cliente.Codigo = Convert.ToInt32(drPessoa["codpessoa"].ToString());
                cliente.Nome = drPessoa["pes_nome"].ToString();
                cliente.DataCadastro = Convert.ToDateTime(drPessoa["pes_datacadastro"].ToString());
                cliente.TipoPessoa = drPessoa["pes_tipopessoa"].ToString();
                cliente.StatusPessoa = Convert.ToBoolean(drPessoa["pes_statuspessoa"].ToString());
                cliente.Observacao = drPessoa["pes_obs"].ToString();
                cliente.Fiado = Convert.ToBoolean(drPessoa["pes_fiado"].ToString());
                cliente.Email = drPessoa["pes_email"].ToString();
                cliente.Telefone = drPessoa["pes_fone"].ToString();
                cliente.Celular = drPessoa["pes_cel"].ToString();
            }

            DataTable dtJuridica = pc.retornaPessoaJuridicaCod(prestador);
            if (dtJuridica != null && dtJuridica.Rows.Count > 0)
            {
                DataRow drJuridica = dtJuridica.Rows[0];

                funcionario.Codigo = Convert.ToInt32(drJuridica["codpessoa"].ToString());
                funcionario.RazaoSocial = drJuridica["jur_razaosocial"].ToString();
                funcionario.CNPJ = drJuridica["jur_cnpj"].ToString();
            }

            DataTable dtServico = sc.retornaServicoCod(servico);
            if(dtServico!=null && dtServico.Rows.Count > 0)
            {
                DataRow drServico = dtServico.Rows[0];
                serv.Codigo = Convert.ToInt32(drServico["codtiposervico"].ToString());
                serv.ServicoNome = drServico["tiposerv_descricao"].ToString();
                serv.Observacao = drServico["tiposerv_obs"].ToString();
                serv.Valor = Convert.ToDouble(drServico["tiposerv_valor"].ToString());
                serv.Tempo = drServico["tiposerv_temposervico"].ToString();
            }

            DataTable dtServParc = spc.retornaParceiroServico(prestador, servico);
            if(dtServParc!=null && dtServParc.Rows.Count > 0)
            {
                Entidades.Servico sv = new Entidades.Servico();
                Entidades.PessoaJuridica pes = new Entidades.PessoaJuridica();
                DataRow drServParc = dtServParc.Rows[0];
                DataTable dtP = pc.retornaPessoaJuridicaCod(Convert.ToInt32(drServParc["codpessoa"].ToString()));
                if(dtP!=null && dtP.Rows.Count > 0)
                {
                    
                    DataRow drPJuridica = dtP.Rows[0];
                    pes.Codigo = Convert.ToInt32(drPJuridica["codpessoa"].ToString());
                    pes.RazaoSocial = drPJuridica["jur_razaosocial"].ToString();
                    pes.CNPJ = drPJuridica["jur_cnpj"].ToString();
                }
                DataTable dtS = sc.retornaServicoCod(servico);
                if (dtS != null && dtS.Rows.Count > 0)
                {
                    
                    DataRow drS = dtS.Rows[0];
                    sv.Codigo = Convert.ToInt32(drS["codtiposervico"].ToString());
                    sv.ServicoNome = drS["tiposerv_descricao"].ToString();
                    sv.Observacao = drS["tiposerv_obs"].ToString();
                    sv.Valor = Convert.ToDouble(drS["tiposerv_valor"].ToString());
                    sv.Tempo = drS["tiposerv_temposervico"].ToString();
                }
                servparc.PessoaJuridica = pes;
                servparc.Servico = sv;
                servparc.Valor = Convert.ToInt32(drServParc["prestserv_valor"].ToString());
                servparc.Percentual = Convert.ToDouble(drServParc["prestserv_percentual"].ToString());
                servparc.PagamentoRecebido = drServParc["prestser_pagrec"].ToString();
                servparc.Estado = Convert.ToBoolean(drServParc["estado"].ToString());
            }

            if (!servparc.PagamentoRecebido.Equals("PAGAR"))
            {
                comis.ValorDevolver = servparc.Valor;
                comis.StatusComissao = "RECEBER";
            }

            else
            {
                comis.ValorDevolver = 0;
                comis.StatusComissao = "PAGAR";
            }
            comis.ValorTotal = servparc.Valor;
            comis.ValorPago = 0;
            comis.DataPagamento = DateTime.MaxValue;
            comis.StatusPagamento = "";

            //agenda.Comissao = comis;
            agenda.DtAgendamento = data;
            agenda.Hora = hora.ToString("HH:mm");
            agenda.ServicoParceiro = servparc;
            agenda.Pes = cliente;
            agenda.Status = status;
            agenda.Valor = serv.Valor;
            agenda.Fechamento = new Entidades.Fechamento();

            int result = cmc.gravaComissao(comis);
            if (result > 0)
            {
                comis.CodigoComissao = cmc.retornaMax();
                agenda.Comissao = comis;
                int tes = _MdlAgenda.gravarAgenda(agenda);
                if (tes > 0)
                    return 1;
                else
                    return 0;
            }
            else
                return 0;
        }

        public DataTable retornaServicosCliente(int codigo)
        {
            return _MdlAgenda.retornaServicosCliente(codigo);
        }
    }
}
