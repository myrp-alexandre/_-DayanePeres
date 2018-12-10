using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class VendaModels
    {
        DAO.VendaDAO VendaDAO = new DAO.VendaDAO();

        public int gravaVendaProduto(Entidades.Venda venda)
        {
            return VendaDAO.GravaVenda(venda);
        }

        public int retornaUltimaVendaProduto()
        {
            return VendaDAO.retornaUltimaVenda();
        }

        public DataTable retornaVendaCod(int cod)
        {
            return VendaDAO.retornaVenda(cod);
        }

        public DataTable retornaVendaProdutoCod(int cod)
        {
            return VendaDAO.retornaVendaProdutoCod(cod);
        }

        public DataTable retornaProdutos(int cod)
        {
            return VendaDAO.retornaProdutos(cod);
        }

        public int atualizaStatus(int cod, string status)
        {
            return VendaDAO.atualizaStatus(cod, status);
        }

        public DataTable retornaVendaPessoa(int cod)
        {
            return VendaDAO.retornaVendaPessoa(cod);
        }
    }
}
