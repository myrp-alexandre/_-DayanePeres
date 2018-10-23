using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    class ServicoController
    {
        private Models.ServicoModel _MdlServ = new Models.ServicoModel();
        
        public int gravaServico(int cod, string servico, double valor, string tempo, string obs)
        {
            return _MdlServ.gravaServico(cod, servico, valor, tempo, obs);
        }

        public DataTable retornaServico()
        {
            return _MdlServ.retornaServico();
        }

        public DataTable retornaServicoCod(int cod)
        {
            return _MdlServ.retornaServicoCod(cod);
        }

        public DataTable retornaObjServico(int cod)
        {
            return _MdlServ.retornaObjServico(cod);
        }

        public DataTable retornaPacoteServico(int cod)
        {
            return _MdlServ.retornaPacoteServico(cod);
        }

        public bool excluirServico(int intCod)
        {
            return _MdlServ.excluirServico(intCod);
        }
    }
}
