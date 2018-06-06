using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class ParametrizacaoModels
    {
        DAO.ParametrizaçãoDAO _DAOParam = new DAO.ParametrizaçãoDAO();

        public int gravarParametrizacao(int cod, string razao, string fantasia, string email, string endereco, 
            string complemento, string numero, string fone, string cel, byte[] logo)
        {
            Entidades.Parametrizacao _entParam = new Entidades.Parametrizacao();
            _entParam.carregaParametro(cod, razao, fantasia, email, endereco, complemento, numero, fone, cel, logo);

            return _DAOParam.GravarParametro(_entParam);
        }

        public DataTable retornoParametrizacao()
        {
            Entidades.Parametrizacao _entParam = new Entidades.Parametrizacao();
            return _DAOParam.VerificaParametro();
        }

        public bool excluirParametro(int intCod)
        {

            return _DAOParam.ExcluirParametrização(intCod);
        }
    }
}
