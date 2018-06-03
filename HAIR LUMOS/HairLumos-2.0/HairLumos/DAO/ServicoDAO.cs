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
    class ServicoDAO
    {
        private string _sql;

        public ServicoDAO()
        {
            this._sql = string.Empty;
        }

      
        public int GravarServico(Entidades.Servico _servico)
        {

            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

            //int _controle = 0;
            try
            {
                if (_servico.Codigo == 0)
                {
                    _sql = "INSERT INTO tbservico" +
                        "(serv_servico, serv_valorservico, serv_temposervico, serv_obsservico)" +
                        " VALUES(@servico, @valor, @tempo, @obs)";

                }
                else
                {
                    _sql = "UPDATE tbservico" +
                            " SET serv_servico = @servico, serv_valorservico = @valor, serv_temposervico = @tempo, serv_obsservico = @obs" +
                        " WHERE codservico = @codigo";
                }

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codigo", _servico.Codigo);
                cmd.Parameters.AddWithValue("@servico", _servico.ServicoNome);
                cmd.Parameters.AddWithValue("@valor", _servico.Valor);
                cmd.Parameters.AddWithValue("@tempo", _servico.Tempo);
                cmd.Parameters.AddWithValue("@obs", _servico.Observacao);

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

        public DataTable RetornaServico()
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codservico, serv_servico, serv_valorservico, serv_temposervico, serv_obsservico" +
                        " FROM tbservico; ";

            // int intCodigo = 0;


            //_sql += $"OR codcategoria = @cod";
            //_sql += $"OR cat_categoria = @categoria";
            //_sql += $"OR cat_obscategoria = @obs";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codservico");
                cmd.Parameters.AddWithValue("@serv_servico");
                cmd.Parameters.AddWithValue("@serv_valorservico");
                cmd.Parameters.AddWithValue("@serv_temposervico");
                cmd.Parameters.AddWithValue("@serv_temposervico");
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

        public DataTable RetornaObjServico(int cod)
        {

            DataTable dt = new DataTable();

            _sql = "SELECT codservico, serv_servico, serv_valorservico, serv_temposervico, serv_obsservico" +
                    "FROM tbservico " +
                    "WHERE codservico = " + cod;

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codservico");
                cmd.Parameters.AddWithValue("@serv_servico");
                cmd.Parameters.AddWithValue("@serv_valorservico");
                cmd.Parameters.AddWithValue("@serv_temposervico");
                cmd.Parameters.AddWithValue("@serv_temposervico");

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

        public bool ExcluirServico(int intCod)
        {
            _sql = "DELETE FROM tbservico WHERE codservico = @cod";

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
