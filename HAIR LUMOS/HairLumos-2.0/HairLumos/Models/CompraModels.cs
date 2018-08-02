using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class CompraModels
    {

        DAO.CompraDAO _DAOComp = new DAO.CompraDAO();

        public int gravarCompra(int cod, int despesa, DateTime data, string situacao, bool consignado, double valor, string obs, int pessoa)
        {
            Entidades.Compra compra = new Entidades.Compra();
            compra.Codigo = cod;
            compra.Despesa.Codigo = despesa;
            compra.Data = data;
            compra.Situacao = situacao;
            compra.Consignado = consignado;
            compra.ValorTotal = valor;
            compra.Obs = obs;
            compra.PJ.Codigo = pessoa;

            return _DAOComp.gravarCompra(compra);
        }
    }
}
