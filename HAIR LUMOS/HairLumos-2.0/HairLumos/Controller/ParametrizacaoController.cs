using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    class ParametrizacaoController
    {
        Models.ParametrizacaoModels _MdlParam = new Models.ParametrizacaoModels();

        public int gravarParametrizacao(int cod, string razao, string fantasia, string email, string endereco,
            string complemento, string numero, string fone, string cel, byte[] logo)
        {
            
            return _MdlParam.gravarParametrizacao(cod, razao, fantasia, email, endereco, complemento, numero, fone, cel, logo);
        }

        public DataTable retornaParametrização()
        {
            Entidades.Parametrizacao _entParam = new Entidades.Parametrizacao();
            return _MdlParam.retornoParametrizacao();
        }

        public bool excluirParametro(int intCod)
        {
            return _MdlParam.excluirParametro(intCod);
        }
    }
}
