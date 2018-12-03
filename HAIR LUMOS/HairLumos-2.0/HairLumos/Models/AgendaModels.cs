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

        public DataTable buscaData(string cnpj, string data)
        {
            return _DAOAgenda.retornaAgenda(cnpj, data);
        }

        public int gravarAgenda(Entidades.Agenda agenda)
        {
            return _DAOAgenda.gravarAgenda(agenda);
        }

        public int updateStatus(Entidades.Agenda agenda)
        {
            return _DAOAgenda.atualizaStatus(agenda);
        }

        public int retornaComissao(Entidades.Agenda agenda)
        {
            return _DAOAgenda.retornaComissao(agenda);
        }

        public DataTable retornaServicosCliente(int codigo)
        {
            return _DAOAgenda.retornaServicosCliente(codigo);
        }
    }
}
