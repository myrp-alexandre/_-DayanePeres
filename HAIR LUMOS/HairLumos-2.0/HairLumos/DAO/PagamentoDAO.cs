using HairLumos.Banco;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.DAO
{
    class PagamentoDAO
    {
        private string _sql;

        public PagamentoDAO()
        {
            this._sql = string.Empty;
        }

        // ************************** CADASTRO DE CATEGORIA *******************************************

        public int GravarFormaPagamento(Entidades.FormaPagamento _formaPagamento)
        {

            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

            //int _controle = 0;
            try
            {
                if (_formaPagamento.Codigo == 0)
                {
                    _sql = "INSERT INTO tbformapagamento" +
                        "(forpag_descricaoformapagamento)" +
                        "VALUES(@forma)";

                }
                else
                {
                    _sql = "UPDATE tbformapagamento" +
                            "SET forpag_descricaoformapagamento = @forma" +
                        "WHERE codformapagamento = @codigo";
                }

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codigo", _formaPagamento.Codigo);
                cmd.Parameters.AddWithValue("@forma", _formaPagamento.Forma);

                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public DataTable retornaCategoria()
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codformapagamento, forpag_descricaoformapagamento" +
                        " FROM tbformapagamento; ";

            // int intCodigo = 0;


            //_sql += $"OR codcategoria = @cod";
            //_sql += $"OR cat_categoria = @categoria";
            //_sql += $"OR cat_obscategoria = @obs";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codformapagamento");
                cmd.Parameters.AddWithValue("@forpag_descricaoformapagamento");
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

        public DataTable retornaObjCateria(int cod)
        {

            DataTable dt = new DataTable();

            _sql = "SELECT codformapagamento, forpag_descricaoformapagamento " +
                    "FROM tbformapagamento " +
                    "WHERE codformapagamento = " + cod;

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codformapagamento");
                cmd.Parameters.AddWithValue("@forpag_descricaoformapagamento");

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

        public bool excluirCategoria(int intCod)
        {
            _sql = "DELETE FROM tbformapagamento WHERE codformapagamento = @cod";

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

        // ************************** FIM DE CATEGORIA *******************************************
    }
}
