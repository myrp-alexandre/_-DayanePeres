using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    class CompraController
    {
        private Controller.ProdutoController pc = new ProdutoController();
        private Models.CompraModels _MdlComp = new Models.CompraModels();

        public int geravaCompra(int cod, int despesa, DateTime data, string situacao, bool consignado, double valor, string obs, int pessoa, List<Entidades.CompraProduto> lista)
        {
            int rest = _MdlComp.gravarCompra(cod, despesa, data, situacao, consignado, valor, obs, pessoa, lista);
            if (rest > 0)
            {
                int i = 0;
                bool teste = false;
                while(i < lista.Count && !teste)
                {
                    Entidades.Produto p = new Entidades.Produto();
                    p = lista.ElementAt(i).Produto;
                    p.Quantidade += lista.ElementAt(i).Qtde;
                    int t = pc.atualizaEstoque(p);
                    if (t > 0)
                        i++;
                    else
                    {
                        teste = true;
                    }
                }
                if(i< lista.Count)
                {
                    Entidades.Compra c = new Entidades.Compra();
                    DataTable dt = retornaCompraMAX();
                    if(dt!=null && dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        c.Codigo = Convert.ToInt32(dr["codcompra"].ToString());
                    }
                    excluirCompra(c.Codigo);
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 0;
            }
        }


        public DataTable retornaCompra()
        {
            return _MdlComp.retornaCompra();
        }

        public DataTable retornaCompraMAX()
        {
            return _MdlComp.retornaCompraMax();
        }

        public DataTable retornaCompra(int codigo)
        {
            return _MdlComp.retornaCompra(codigo);
        }

        public List<Entidades.CompraProduto> retornaLista(int codigo)
        {
            return _MdlComp.retornaLista(codigo);
        }

        public int excluirCompra(int codigo)
        {
            return _MdlComp.excluirCompra(codigo);
        }
    }
}
