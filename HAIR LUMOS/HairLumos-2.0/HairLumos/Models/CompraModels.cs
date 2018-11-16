using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class CompraModels
    {

        DAO.CompraDAO _DAOComp = new DAO.CompraDAO();

        public int gravarCompra(int cod, int despesa, DateTime data, string situacao, bool consignado, double valor, string obs, int pessoa, List<Entidades.CompraProduto> lista)
        {
            Entidades.Compra compra = new Entidades.Compra();
            compra.Codigo = cod;
            compra.Despesa.Codigo = despesa;
            compra.Data = data;
            compra.Situacao = situacao;
            compra.Consignado = consignado;
            compra.ValorTotal = valor;
            compra.Obs = obs;
            compra.Pessoa.Codigo = pessoa;
            compra.Lista = lista;

            return _DAOComp.gravarCompra(compra);
        }

        public DataTable retornaCompra()
        {
            return _DAOComp.retornaCompra();
        }

        public DataTable retornaCompraMax()
        {
            return _DAOComp.retornaCompraMax();
        }

        public DataTable retornaCompra(int codigo)
        {
            return _DAOComp.retornaCompra(codigo);
        }

        public List<Entidades.CompraProduto> retornaLista(int codigo)
        {
            return _DAOComp.retornaLista(codigo);
        }

        public int excluirCompra(int codigo)
        {
            return _DAOComp.excluirCompra(codigo);
        }
    }
}
