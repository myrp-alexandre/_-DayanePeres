using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace HairLumos.Models
{
    class ContasReceberModels
    {
        DAO.ContasReceberDAO contaDAO = new DAO.ContasReceberDAO();

        public DataTable retornaContasReceber(DateTime dataI, DateTime dataF, String situacao)
        {
            return contaDAO.retornaContasReceber(dataI, dataF, situacao);
        }

        public int gerarContasReceber(Entidades.ContasReceber cr)
        {
            return contaDAO.gravarContasReceber(cr);
        }
    }
}