using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class ServicoModel
    {

        // validar informações para enviar/receber do Banco 

        DAO.ServicoDAO _DAOServ = new DAO.ServicoDAO();
        DAO.PacoteDAO _DAOPacoteServico = new DAO.PacoteDAO();

       
        public int gravaServico(int cod, string servico, double valor,string tempo,  string obs)
        {
            Entidades.Servico _entServico = new Entidades.Servico();
            _entServico.carregaServico(cod, servico, obs, valor, tempo);

            return _DAOServ.GravarServico(_entServico);
        }

        public DataTable retornaServico()
        {
            Entidades.Servico _entServico = new Entidades.Servico();
            return _DAOServ.RetornaServico();
        }

        public DataTable retornaServicoCod(int cod)
        {
            Entidades.Servico _entServico = new Entidades.Servico();
            return _DAOServ.RetornaServicoCod(cod);
        }

        public DataTable retornaObjServico(int cod)
        {
            Entidades.Servico _entServico = new Entidades.Servico();
            return _DAOServ.RetornaObjServico(cod);
        }

        public DataTable retornaPacoteServico(int cod)
        {
            Entidades.Servico _entServico = new Entidades.Servico();
            return _DAOPacoteServico.RetornaPacoteServicos(cod);
        }

        public bool excluirServico(int intCod)
        {
            //Entidades.Servico _entServico= new Entidades.Servico();
            return _DAOServ.ExcluirServico(intCod);
        }
    }
}
