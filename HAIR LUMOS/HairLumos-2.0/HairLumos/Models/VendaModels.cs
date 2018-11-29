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
    }
}
