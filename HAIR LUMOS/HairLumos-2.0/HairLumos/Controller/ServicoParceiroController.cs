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

        public int gravaServico(int codPessoaJuridica, int codServico, double valor, double percentual, string recebido)
        {
            return _ServicoParceiroModel.gravaServicoParceiro(codPessoaJuridica, codServico, valor, percentual, recebido);
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

    }
}
