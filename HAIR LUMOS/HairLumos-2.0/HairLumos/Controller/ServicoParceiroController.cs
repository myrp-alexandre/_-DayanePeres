using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    class ServicoParceiroController
    {
        private Models.ServicoParceiroModel _ServicoParceiroModel = new Models.ServicoParceiroModel();

        public int gravaServico(int codPessoaJuridica, int codServico, double valor, double percentual, string recebido, bool estado)
        {
            return _ServicoParceiroModel.gravaServicoParceiro(codPessoaJuridica, codServico, valor, percentual, recebido, estado);
        }

        public int alteraServico(int codPessoaJuridica, int codServico, double valor, double percentual, string recebido, bool estado)
        {
            return _ServicoParceiroModel.alteraServicoParceiro(codPessoaJuridica, codServico, valor, percentual, recebido, estado);
        }

        public DataTable retornaServicoParceiro()
        {
            return _ServicoParceiroModel.retornaServicoParceiro();
        }

        public DataTable retornaParceiroServico(int codPessoa, int codServico)
        {
            return _ServicoParceiroModel.retornaParceiroServico(codPessoa, codServico);
        }

        public bool excluirServicoParceiro(int intCodP, int codServ)
        {
            //Entidades.Servico _entServico= new Entidades.Servico();
            return _ServicoParceiroModel.excluirServicoParceiro(intCodP, codServ);
        }

        public DataTable retornaPrestador()
        {
            return _ServicoParceiroModel.retornaPrestador();
        }

        public DataTable retornaServicos(int codigo)
        {
            return _ServicoParceiroModel.retornaServicos(codigo);
        }

        public bool verificaAgenda(int intCodS, string cnpj)
        {
            return _ServicoParceiroModel.verificaAgenda(intCodS, cnpj);
        }

        public bool verificaServico(int intCodS, int codPessoa)
        {
            return _ServicoParceiroModel.verificaServico(intCodS, codPessoa);
        }

        public bool verificaServicoDois(int intCodS, int codPessoa)
        {
            return _ServicoParceiroModel.verificaServicoDois(intCodS, codPessoa);
        }

    }
}
