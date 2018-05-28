using HairLumos.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class ProdutoModels
    {
        // validar informações para enviar/receber do Banco 

        Entidades.Categoria _entCategoria = new Entidades.Categoria();
        DAO.ProdutoDAO _DAOProd = new DAO.ProdutoDAO();

        public bool validaCadastro()
        {
            if (string.IsNullOrEmpty(_entCategoria.CategoriaNome))
                _entCategoria.Erro += "Informa a Categoria.";

            return string.IsNullOrEmpty(_entCategoria.Erro);
        }

        public int gravarCategoria(int cod, string categoria, string obs)
        {

            _entCategoria.carregaCategoria(cod, categoria, obs);
            
            return _DAOProd.GravarCategoria(_entCategoria);
        }

        public DataTable retornaCategoria()
        {
            return _DAOProd.retornaCategoria();
        }

        public bool excluirCategoria(int intCod)
        {
            return _DAOProd.excluirCategoria(intCod);
        }
    }
}
