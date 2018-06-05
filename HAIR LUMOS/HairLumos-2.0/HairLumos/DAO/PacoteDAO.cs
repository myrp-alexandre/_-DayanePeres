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
    class PacoteDAO
    {
        private string _sql;

        public PacoteDAO()
        {
            this._sql = string.Empty;
        }


        public int GravarPacote(Entidades.Pacote _pacote)
        {

            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

            //int _controle = 0;
            try
            {
                if (_pacote.Codigo == 0)
                {
                    _sql = "INSERT INTO tbpacote" +
                        "(pac_pacote, pac_valor, pac_obspacote, pac_periodicidade)" +
                        " VALUES(@pacote, @valor, @obs, @periodo)";

                }
                else
                {
                    _sql = "UPDATE tbpacote" +
                            " SET pac_pacote = @pacote, pac_valor = @valor, pac_obspacote = @obs, pac_periodicidade = @periodo" +
                        " WHERE codpacote = @codigo";
                }

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codigo", _pacote.Codigo);
                cmd.Parameters.AddWithValue("@pacote", _pacote.PaccoteNome);
                cmd.Parameters.AddWithValue("@valor", _pacote.Valor);
                cmd.Parameters.AddWithValue("@obs", _pacote.Observacao);
                cmd.Parameters.AddWithValue("@periodo", _pacote.Periodo);

                cmd.ExecuteNonQuery();

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

        public DataTable RetornaPacote()
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codpacote, pac_pacote, pac_valor, pac_obspacote, pac_periodicidade" +
                        " FROM tbpacote; ";

            // int intCodigo = 0;


            //_sql += $"OR codcategoria = @cod";
            //_sql += $"OR cat_categoria = @categoria";
            //_sql += $"OR cat_obscategoria = @obs";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codpacote");
                cmd.Parameters.AddWithValue("@pac_pacote");
                cmd.Parameters.AddWithValue("@pac_valor");
                cmd.Parameters.AddWithValue("@pac_obspacote");
                cmd.Parameters.AddWithValue("@pac_periodicidade");

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

        public DataTable RetornaObjPacote(int cod)
        {

            DataTable dt = new DataTable();

            _sql = "SELECT codpacote, pac_pacote, pac_valor, pac_obspacote, pac_periodicidade" +
                    "FROM tbpacote " +
                    "WHERE codpacote = " + cod;

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codpacote");
                cmd.Parameters.AddWithValue("@pac_pacote");
                cmd.Parameters.AddWithValue("@pac_valor");
                cmd.Parameters.AddWithValue("@pac_obspacote");
                cmd.Parameters.AddWithValue("@pac_periodicidade");

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

        public bool ExcluirPacote(int intCod)
        {
            _sql = "DELETE FROM tbpacote WHERE codpacote = @cod";

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
    }
}
