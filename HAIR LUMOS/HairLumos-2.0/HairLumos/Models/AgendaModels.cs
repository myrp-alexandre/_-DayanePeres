using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class AgendaModels
    {
        DAO.AgendaDAO _DAOAgenda = new DAO.AgendaDAO();

        public DataTable buscaData(int codigo, string data)
        {
            return _DAOAgenda.retornaAgenda(codigo, data);
        }

        public int gravarAgenda(Entidades.Agenda agenda)
        {
            return _DAOAgenda.gravarAgenda(agenda);
        }
    }
}
