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

        public DataTable retornaContasReceber(string dataI, string dataF, String situacao)
        {
            return contaDAO.retornaContasReceber(dataI, dataF, situacao);
        }

        public int gerarContasReceber(Entidades.ContasReceber cr)
        {
            return contaDAO.gravarContasReceber(cr);
        }

        public int realizaRecebimento(Entidades.Parcela parcela, int cod)
        {
            return contaDAO.realizarRecebimento(parcela, cod);
        }

        public int atualizaStatus(int codigo, string status)
        {
            return contaDAO.atualizaStatus(codigo, status);
        }

        public DataTable retornaContasCod(int codigo)
        {
            return contaDAO.retornaContasCod(codigo);
        }

        public DataTable retornaParcelaContaReceber(int codRe, int codP)
        {
            return contaDAO.retornaParcelaContaReceber(codRe, codP);
        }
    }
}