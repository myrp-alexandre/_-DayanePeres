using HairLumos.Banco;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairLumos.Entidades;
using System.Data;

namespace HairLumos.DAO
{
    class ProdutoDAO
    {
        private string _sql;

        public ProdutoDAO()
        {
            this._sql = string.Empty;
        }

        // ************************** CADASTRO DE CATEGORIA *******************************************
       
        public int GravarCategoria(Entidades.Categoria _categoria)
        {
            
            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

            //int _controle = 0;
            try
            {
                if(_categoria.Codigo == 0)
                {
                    _sql = "INSERT INTO tbcategoria" +
                        "(cat_categoria, cat_obscategoria)"+
                        "VALUES(@categoria, @obs)";

                }
                else
                {
                    _sql = "UPDATE tbcategoria" +
                            " SET cat_categoria = @categoria, cat_obscategoria = @obs" +
                        " WHERE codCategoria = @codigo";
                }

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codigo", _categoria.Codigo);
                cmd.Parameters.AddWithValue("@categoria", _categoria.CategoriaNome);
                cmd.Parameters.AddWithValue("@obs", _categoria.Observacao);

                cmd.ExecuteNonQuery();

                return 1;
            }
            catch(Exception )
            {
                return 0;
            }
            //if (_controle > 0)
                //return 1;
            //return 0;
        }

        public DataTable retornaCategoria()
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codcategoria, cat_categoria, cat_obscategoria"+
                        " FROM tbcategoria; ";

           // int intCodigo = 0;
            
            
            //_sql += $"OR codcategoria = @cod";
            //_sql += $"OR cat_categoria = @categoria";
            //_sql += $"OR cat_obscategoria = @obs";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codcategoria");
                cmd.Parameters.AddWithValue("@cat_categoria");
                cmd.Parameters.AddWithValue("@cat_obscategoria");
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        public DataTable retornaObjCateria (int cod)
        {

            DataTable dt = new DataTable();

            _sql = "SELECT codcategoria, cat_categoria, cat_obscategoria " +
                    "FROM tbcategoria " +
                    "WHERE codcategoria = " + cod;

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codcategoria");
                cmd.Parameters.AddWithValue("@cat_categoria");
                cmd.Parameters.AddWithValue("@cat_obscategoria");

                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        public bool excluirCategoria (int intCod)
        {
            _sql = "DELETE FROM tbcategoria WHERE codcategoria = @cod";

            int _controle = 0;
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
                cmd.Parameters.AddWithValue("@cod", intCod);
                _controle = cmd.ExecuteNonQuery();
            }
            catch (Exception )
            {

            }
            return (_controle > 0);
        }

        // ************************** FIM DE CATEGORIA *******************************************


        // ************************** M A R C A *******************************************
        public int GravarMarca(Entidades.Marca _marca)
        {

            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

            //int _controle = 0;
            try
            {
                if (_marca.Codigo == 0)
                {
                    _sql = "INSERT INTO tbmarca" +
                        "(marc_nome)" +
                        "VALUES(@marca)";

                }
                else
                {
                    _sql = "UPDATE tbmarca" +
                            " SET marc_nome = @marca" +
                        " WHERE codmarca = @cod";
                }

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@cod", _marca.Codigo);
                cmd.Parameters.AddWithValue("@marca", _marca.MarcaProduto);
                

                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
            //if (_controle > 0)
            //return 1;
            //return 0;
        }

        public DataTable retornaObjMarca(int cod)
        {

            DataTable dt = new DataTable();

            _sql = "SELECT codmarca, marc_nome " +
                "FROM tbmarca " +
                "WHERE codmarca = " + cod;

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codmarca");
                cmd.Parameters.AddWithValue("@marc_nome");

                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        public DataTable RetornaMarca()
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codmarca, marc_nome" +
                        " FROM tbmarca; ";

            // int intCodigo = 0;


            //_sql += $"OR codcategoria = @cod";
            //_sql += $"OR cat_categoria = @categoria";
            //_sql += $"OR cat_obscategoria = @obs";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codmarca");
                cmd.Parameters.AddWithValue("@marc_nome");
                
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        public bool ExcluirMarca(int intCod)
        {
            _sql = "DELETE FROM tbmarca WHERE codmarca= @cod";

            int _controle = 0;
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.Parameters.AddWithValue("@cod", intCod);
                _controle = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            return (_controle > 0);
        }

        // ************************** CADASTRO DE PRODUTO *******************************************

        public int GravarProduto(Entidades.Produto _produto)
        {

            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

            //int _controle = 0;
            try
            {
                if (_produto.CodigoProduto == 0)
                {
                    _sql = "INSERT INTO tbproduto" +
                                " (prod_produto, prod_precocusto, prod_precovenda, prod_qtde, prod_obs, codcategoria, codmarca )" +
                        " VALUES( @nomeProd, @custoProd, @vendaProd, @qtdeProd, @obsProd,  @codCateria, @codMarca)";

                }
                else
                {
                    
                    _sql = "UPDATE tbproduto" +
                        " SET codproduto = @codproduto," +
                                "prod_produto = @nomeProd," +
                                "prod_precocusto = @custoProd," +
                                "prod_precovenda = @vendaProd," +
                                "prod_qtde = @qtdeProd," +
                                "prod_obs = @obsProd," +
                                "codcategoria = @codCateria," +
                                "codmarca = @codMarca" +
                        " WHERE codproduto = @codproduto";
    }

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codproduto", _produto.CodigoProduto);
                cmd.Parameters.AddWithValue("@nomeProd", _produto.NomeProduto);
                cmd.Parameters.AddWithValue("@custoProd", _produto.Custo);
                cmd.Parameters.AddWithValue("@vendaProd", _produto.Venda);                
                cmd.Parameters.AddWithValue("@qtdeProd", _produto.Quantidade);
                cmd.Parameters.AddWithValue("@obsProd", _produto.Observacao);
                cmd.Parameters.AddWithValue("@codCateria", _produto.Categoria.Codigo);
                cmd.Parameters.AddWithValue("@codMarca", _produto.Marca.Codigo);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return 1;
            }
            catch (Exception E)
            {
                
                return 0;
            }
            //if (_controle > 0)
            //return 1;
            //return 0;
        }

        public DataTable RetornaProduto() //string Texto
        {
            DataTable dt = new DataTable();


            _sql = "SELECT codproduto, prod_produto, prod_precocusto, prod_precovenda, prod_qtde," +
                        "prod_obs, codcategoria, codmarca" +
                    " FROM tbproduto;";   

            
            //int intCodigo = 0;
            //int.TryParse(Texto, out intCodigo);
            
            //if (intCodigo > 0)
            //    _sql += $"OR codproduto = @codigo ";

            //_sql += $"OR codproduto = @codigo ";
            //_sql += $"OR UPPER (prod_produto) LIKE @produto";

            // _sql += $"OR UPPER(pes_nome) LIKE @nome ";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codproduto");
                cmd.Parameters.AddWithValue("@nomeProd");
                cmd.Parameters.AddWithValue("@custoProd");
                cmd.Parameters.AddWithValue("@vendaProd");
                cmd.Parameters.AddWithValue("@qtdeProd");
                cmd.Parameters.AddWithValue("@obsProd");
                cmd.Parameters.AddWithValue("@codCateria");
                cmd.Parameters.AddWithValue("@codMarca");

                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception )
            {

                throw;
            }
            return dt;
        }

        public bool ExcluirProduto(int intCod)
        {
            _sql = "DELETE FROM tbproduto WHERE codproduto = @cod";

            int _controle = 0;
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
                cmd.Parameters.AddWithValue("@cod", intCod);
                _controle = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            return (_controle > 0);
        }

        public DataTable RetornaProduto(string texto) //string Texto
        {
            DataTable dt = new DataTable();


            _sql = "SELECT codproduto, prod_produto, prod_precocusto, prod_precovenda, prod_qtde, prod_obs, p.codcategoria, cat_categoria, p.codmarca, marc_nome" +
                    " FROM tbproduto p INNER JOIN tbmarca m ON m.codmarca = p.codmarca" +
                    " INNER JOIN tbcategoria c ON c.codcategoria = p.codcategoria";

            if(texto != null && texto != "")
                _sql += $" WHERE UPPER(prod_produto) LIKE @produto";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                if (texto != null && texto != "")
                    cmd.Parameters.AddWithValue("@produto", texto.ToUpper());


                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        public DataTable RetornaProduto(int cod) //inteiro
        {
            DataTable dt = new DataTable();


            _sql = "SELECT codproduto, prod_produto, prod_precocusto, prod_precovenda, prod_qtde," +
                        "prod_obs, codcategoria, codmarca" +
                    " FROM tbproduto WHERE codproduto = @codigo;";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codigo", cod);
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

    }
}
