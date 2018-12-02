using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    class VendaController
    {
        Models.VendaModels VendaModels = new Models.VendaModels();

        public int gravaVendaProduto(DateTime data, string situacao, double total, string obs, int codCliente, List<Entidades.VendaProduto> vendaProdutos)
        {
            Entidades.Venda venda = new Entidades.Venda();
            venda.Data = data;
            venda.Situacao = situacao;
            venda.ValorTotal = total;
            venda.Observacao = obs;
            venda.ListavendaProdutos = vendaProdutos;

            Entidades.Pessoa _pessoa = new Entidades.Pessoa();
            DataTable dtPessoa = new Controller.PessoaController().retornaPessoaCod(codCliente + "");

            if(dtPessoa != null && dtPessoa.Rows.Count > 0)
            {
                DataRow drPessoa = dtPessoa.Rows[0];
                _pessoa.Codigo = Convert.ToInt32(drPessoa["codpessoa"].ToString());
                _pessoa.Nome = drPessoa["pes_nome"].ToString();
                _pessoa.DataCadastro = Convert.ToDateTime(drPessoa["pes_datacadastro"].ToString());
                _pessoa.TipoPessoa = drPessoa["pes_tipopessoa"].ToString();
                _pessoa.StatusPessoa = Convert.ToBoolean(drPessoa["pes_statuspessoa"].ToString());
                _pessoa.Observacao = drPessoa["pes_obs"].ToString();
                _pessoa.Fiado = Convert.ToBoolean(drPessoa["pes_fiado"].ToString());
                _pessoa.Email = drPessoa["pes_email"].ToString();
                _pessoa.Telefone = drPessoa["pes_fone"].ToString();
                _pessoa.Celular = drPessoa["pes_cel"].ToString();
            }
            venda.Pessoa = _pessoa;

            int rest = VendaModels.gravaVendaProduto(venda);

            if (rest > 0)
            {
                for (int i = 0; i < vendaProdutos.Count; i++)
                {
                    Entidades.Produto produto = new Entidades.Produto();
                    Controller.ProdutoController produtoController = new ProdutoController();

                    produto = vendaProdutos.ElementAt(i).Produto;
                    produto.Quantidade -= vendaProdutos.ElementAt(i).Quantidade;
                    produtoController.atualizaEstoque(produto);

                }
                return rest;
            }
            else
                return -1;

            
        }

        public int retornaUltimaVendaProduto()
        {
            return VendaModels.retornaUltimaVendaProduto();
        }

        public DataTable retornaVendaCod(int cod)
        {
            return VendaModels.retornaVendaCod(cod);
        }

        public DataTable retornaVendaProdutoCod(int cod)
        {
            return VendaModels.retornaVendaProdutoCod(cod);
        }
    }
}
