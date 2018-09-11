﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    class PacoteController
    {
        private Models.PacoteModels _MdlPac = new Models.PacoteModels();

        public int gravarPacote(int cod, string pacote, List<Entidades.PacoteServico> servicos, double valor, string obs, string periodo, DateTime dtIni, DateTime dtFim)
        {
            return _MdlPac.gravaPacote(cod, pacote, servicos, valor, obs, periodo,dtIni,dtFim);
        }

        public DataTable retornaPacote()
        {
            return _MdlPac.retornoPacote();
        }

        public DataTable retornaObjPacote(int cod)
        {
            return _MdlPac.retornoObjPacote(cod);
        }

        public DataTable retornaPacoteText(string texto)
        {
            return _MdlPac.retornoPacoteText(texto);
        }

        public DataTable retornaListaPacote(int cod)
        {
            return _MdlPac.retornaListaPacote(cod);
        }

        public bool excluirPacote(int intCod)
        {
            return _MdlPac.excluirPacote(intCod);
        }
    }
}
