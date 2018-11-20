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
                    _sql = "INSERT INTO tbtiposervico" +
                        "(tiposerv_descricao, tiposerv_obs, tiposerv_valor, tiposerv_temposervico)" +
                        " VALUES (@descricao, @obs, @valor, @tempo)";

                }
                else
                {
                    _sql = "UPDATE tbtiposervico" +
                            " SET tiposerv_descricao = @descricao, tiposerv_obs = @obs, tiposerv_valor = @valor, tiposerv_temposervico = @tempo" +
                        " WHERE codtiposervico = @codigo";
                }

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codigo", _servico.Codigo);
                cmd.Parameters.AddWithValue("@descricao", _servico.ServicoNome);
                cmd.Parameters.AddWithValue("@obs", _servico.Observacao);
                cmd.Parameters.AddWithValue("@valor", _servico.Valor);
                DateTime data = DateTime.Now;
                data = Convert.ToDateTime(_servico.Tempo.ToString());
                TimeZoneInfo.ConvertTimeToUtc(data);
                cmd.Parameters.AddWithValue("@tempo", data);// _servico.Tempo);

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

            _sql = "SELECT codtiposervico, tiposerv_descricao, tiposerv_obs, tiposerv_valor, tiposerv_temposervico" +
                        " FROM tbtiposervico; ";


            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codtiposervico");
                cmd.Parameters.AddWithValue("@tiposerv_descricao");
                cmd.Parameters.AddWithValue("@tiposerv_obs");
                cmd.Parameters.AddWithValue("@tiposerv_valor");
                cmd.Parameters.AddWithValue("@tiposerv_temposervico");
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

        public DataTable RetornaServicoCod(int cod)
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codtiposervico, tiposerv_descricao, tiposerv_obs, tiposerv_valor, tiposerv_temposervico" +
                        " FROM tbtiposervico "+
                        "WHERE codtiposervico = " +cod;

           
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codtiposervico");
                cmd.Parameters.AddWithValue("@tiposerv_descricao");
                cmd.Parameters.AddWithValue("@tiposerv_obs");
                cmd.Parameters.AddWithValue("@tiposerv_valor");
                cmd.Parameters.AddWithValue("@tiposerv_temposervico");
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

            _sql = "SELECT codtiposervico, tiposerv_descricao, tiposerv_obs, tiposerv_valor, tiposerv_temposervico" +
                        " FROM tbtiposervico " +
                    "WHERE codtiposervico = " + cod;

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codtiposervico");
                cmd.Parameters.AddWithValue("@tiposerv_descricao");
                cmd.Parameters.AddWithValue("@tiposerv_obs");
                cmd.Parameters.AddWithValue("@tiposerv_valor");
                cmd.Parameters.AddWithValue("@tiposerv_temposervico");

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
            _sql = "DELETE FROM tbtiposervico WHERE codtiposervico = @cod";

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

        public DataTable RetornaServPrestador(int cod)
        {
            DataTable dt = new DataTable();

            _sql = "select s.codtiposervico, s.tiposerv_descricao, s.tiposerv_valor, p.prestserv_valor, p.prestserv_percentual, p.prestser_pagrec  from tbprestadorservico p inner join tbtiposervico s on p.codtiposervico = s.codtiposervico where p.codpessoa = " + cod;

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codtiposervico");
                cmd.Parameters.AddWithValue("@tiposerv_descricao");
                cmd.Parameters.AddWithValue("@tiposerv_valor");
                cmd.Parameters.AddWithValue("@prestserv_valor");
                cmd.Parameters.AddWithValue("@prestserv_percentual");
                cmd.Parameters.AddWithValue("@prestser_pagrec");

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

        public DataTable RetornaServPrestador(int cod, int serv)
        {
            DataTable dt = new DataTable();

            _sql = "select s.codtiposervico, s.tiposerv_descricao, s.tiposerv_valor, p.prestserv_valor, p.prestserv_percentual, p.prestser_pagrec  from tbprestadorservico p inner join tbtiposervico s on p.codtiposervico = s.codtiposervico where p.codpessoa = " + cod + " and p.codtiposervico = "+serv;

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codtiposervico");
                cmd.Parameters.AddWithValue("@tiposerv_descricao");
                cmd.Parameters.AddWithValue("@tiposerv_valor");
                cmd.Parameters.AddWithValue("@prestserv_valor");
                cmd.Parameters.AddWithValue("@prestserv_percentual");
                cmd.Parameters.AddWithValue("@prestser_pagrec");

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
