using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class PacoteModels
    {
        DAO.PacoteDAO _DAOPac = new DAO.PacoteDAO();


        public int gravaPacote(int cod, string pacote, double valor, string obs, string periodo)
        {
            Entidades.Pacote _entPacote = new Entidades.Pacote();
            _entPacote.carregaPacote(cod, pacote, valor, obs, periodo);

            return _DAOPac.GravarPacote(_entPacote);
        }

        public DataTable retornoPacote()
        {
            
            return _DAOPac.RetornaPacote();
        }

        public DataTable retornoObjPacote(int cod)
        {
            
            return _DAOPac.RetornaObjPacote(cod);
        }

        public bool excluirPacote(int intCod)
        {
            
            return _DAOPac.ExcluirPacote(intCod);
        }
    }
}
