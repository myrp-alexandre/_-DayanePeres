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

        public int gravaPacote(int cod, string pacote, List<Entidades.PacoteServico> servicos, double valor, string obs, string periodo, DateTime dtIni, DateTime dtFim)
        {
            Entidades.Pacote _entPacote = new Entidades.Pacote();
            _entPacote.carregaPacote(cod, pacote, valor, obs, periodo, servicos, dtIni, dtFim);

            return _DAOPac.GravarPacote(_entPacote);
        }

        public int contratarPacote(int codigo, DateTime data, string obs, Entidades.Pacote pacote, Entidades.PessoaFisica pessoa, List<Entidades.PacotesAdicionais> listaPacoteAdicionais)
        {
            Entidades.Contrato contrato = new Entidades.Contrato();
            contrato.Codigo = codigo;
            contrato.DataContrato = data;
            contrato.Observacao = obs;
            contrato.Pacote = pacote;
            contrato.CodigoPessoa = pessoa;
            contrato.Lista = listaPacoteAdicionais;
            return _DAOPac.contratarPacote(contrato);
        }

        public DataTable retornoPacoteText(string text)
        {

            return _DAOPac.RetornaPacote(text);
        }

        public DataTable retornaContratoServicos()
        {

            return _DAOPac.RetornaContratoServicos();
        }

        public DataTable retornoPacote()
        {

            return _DAOPac.RetornaPacote();
        }

        public DataTable retornoObjPacote(int cod)
        {

            return _DAOPac.RetornaObjPacote(cod);
        }

        public DataTable retornaListaPacote(int cod)
        {

            return _DAOPac.retornaListaPacote(cod);
        }

        public bool excluirPacote(int intCod)
        {

            return _DAOPac.ExcluirPacote(intCod);
        }

        public DataTable retornaContrato()
        {

            return _DAOPac.RetornaContrato();
        }
    }
}
