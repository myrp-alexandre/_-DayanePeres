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
            this._sql = "";
        }

        public int GravarCategoria(Entidades.Categoria _categoria)
        {
            bool blnRetorno = false;

            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

            int _controle = 0;
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
                            "SET cat_categoria = @categoria, cat_obscategoria = @obs" +
                        "WHERE codCategoria = @codigo";
                }

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@categoria", _categoria.CategoriaNome);
                cmd.Parameters.AddWithValue("@obs", _categoria.Observacao);

                cmd.ExecuteNonQuery();

                return 1;
            }
            catch(Exception ex)
            {

            }
            if (_controle > 0)
                return 1;
            return 0;
        }

        public DataTable retornaCategoria()
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codcategoria, cat_categoria, cat_obscategoria"+
                        " FROM tbcategoria; ";

            int intCodigo = 0;
            
            
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
            catch (Exception ex)
            {

            }
            return (_controle > 0);
        }
    }
}
