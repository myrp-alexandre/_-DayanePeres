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

        DAO.ProdutoDAO _DAOProd = new DAO.ProdutoDAO();


        /*  
         *************** CATEGORIA *************************************  
         *  
         */
        public bool validaCadastro()
        {
            Entidades.Categoria _entCategoria = new Entidades.Categoria();
            if (string.IsNullOrEmpty(_entCategoria.CategoriaNome))
                _entCategoria.Erro += "Informa a Categoria.";

            return string.IsNullOrEmpty(_entCategoria.Erro);
        }

        public int gravarCategoria(int cod, string categoria, string obs)
        {
            Entidades.Categoria _entCategoria = new Entidades.Categoria();
            _entCategoria.carregaCategoria(cod, categoria, obs);
            
            return _DAOProd.GravarCategoria(_entCategoria);
        }

        public DataTable retornaCategoria()
        {
            Entidades.Categoria _entCategoria = new Entidades.Categoria();
            return _DAOProd.retornaCategoria();
        }

        public bool excluirCategoria(int intCod)
        {
            Entidades.Categoria _entCategoria = new Entidades.Categoria();
            return _DAOProd.excluirCategoria(intCod);
        }

        /*  
         *************** M A R C A *************************************  
         *  
         */


        public bool validaCadastroMarca()
        {
            Entidades.Marca _entMarca = new Entidades.Marca();
            if (string.IsNullOrEmpty(_entMarca.MarcaProduto))
                _entMarca.Erro += "Informe a Marca.";

            return string.IsNullOrEmpty(_entMarca.Erro);
        }

        public int gravarMarca(int cod, string marca)
        {
            Entidades.Marca _entMarca = new Entidades.Marca();
            _entMarca.carregaMarca(cod, marca);

            return _DAOProd.GravarMarca(_entMarca);
        }

        public DataTable retornaMarca()
        {
            Entidades.Marca _entMarca = new Entidades.Marca();
            return _DAOProd.RetornaMarca();
        }

        public bool excluirMarca(int intCod)
        {
            Entidades.Marca _entMarca = new Entidades.Marca();
            return _DAOProd.ExcluirMarca(intCod);
        }

    }
}
