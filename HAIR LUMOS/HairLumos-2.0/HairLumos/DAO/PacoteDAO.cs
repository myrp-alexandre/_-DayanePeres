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
    /*
     * Inset into tb () values() RETURNING codServico INTO: codRetorno";
     * */

    class PacoteDAO
    {
        private string _sql;

        public PacoteDAO()
        {
            this._sql = string.Empty;
        }


        public int GravarPacote(Entidades.Pacote _pacote)
        {

            //NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

            int intRetorno = 0;

            string strSQL = "";
            Conexao objConexao = null;
            //int _controle = 0;
            try
            {
                objConexao = new Conexao();

                if (_pacote.Codigo == 0)
                {
                    _sql = "INSERT INTO tbpacote" +
                        "(pac_pacote, pac_valor, pac_obs, pac_periodicidade, pac_datainicio, pac_datafim)" +
                        " VALUES(@pacote, @valor, @obs, @periodo, @dtIni, @dtFim); SELECT MAX(codpacote) FROM tbpacote;";

                }
                else
                {
                    _sql = "UPDATE tbpacote" +
                            " SET pac_pacote = @pacote, pac_valor = @valor, pac_obs = @obs, pac_periodicidade = @periodo, pac_datainicio = @dtIni, pac_datafim = @dtFim" +
                        " WHERE codpacote = @codigo";
                }

                objConexao.SqlCmd.CommandText = _sql;
                objConexao.SqlCmd.Parameters.AddWithValue("@codigo", _pacote.Codigo);
                objConexao.SqlCmd.Parameters.AddWithValue("@pacote", _pacote.PaccoteNome);
                objConexao.SqlCmd.Parameters.AddWithValue("@valor", _pacote.Valor);
                objConexao.SqlCmd.Parameters.AddWithValue("@obs", _pacote.Observacao);
                objConexao.SqlCmd.Parameters.AddWithValue("@periodo", _pacote.Periodo);
                objConexao.SqlCmd.Parameters.AddWithValue("@dtIni", _pacote.DataInicio);
                objConexao.SqlCmd.Parameters.AddWithValue("@dtFim", _pacote.DataFim);


                objConexao.iniciarTransacao();
                objConexao.AutoConexao = false;

                int cod = (int)objConexao.executarScalar();
                if (cod <= 0)
                {
                    return -1;
                }

                if (_pacote.ListaServico != null)
                {
                    //Fazer o insert dos Endereços
                    foreach (var item in _pacote.ListaServico)
                    {
                        
                        strSQL = "INSERT INTO tbpacoteservico(codpacote,codtiposervico,pacserv_qtde, pacServ_periodicidade) ";
                        strSQL += "VALUES(@codpacote, @codServico, @qtde, @periodicidade)";

                        objConexao.SqlCmd.Parameters.Clear();
                        objConexao.SqlCmd.CommandText = strSQL;

                        objConexao.SqlCmd.Parameters.AddWithValue("@qtde", item.Quantidade);
                        objConexao.SqlCmd.Parameters.AddWithValue("@periodicidade", item.Periodicidade);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codServico", NpgsqlTypes.NpgsqlDbType.Integer, item.Servico.Codigo);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codPacote", cod);
                        


                        if (!objConexao.executarComando())
                            return -1;
                    }
                }
                objConexao.commitTransacao();
                return 1;
                
            }
            catch (Exception e)
            {
                objConexao?.rollbackTransacao();
            }
            finally
            {
                objConexao?.fecharConexao();
            }

            return intRetorno;
        }

        public DataTable RetornaPacote()
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codpacote, pac_pacote, pac_valor, pac_obs, pac_periodicidade, pac_datainicio, pac_datafim" +
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
                cmd.Parameters.AddWithValue("@pac_datainicio");
                cmd.Parameters.AddWithValue("@pac_datafim"); 

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

            _sql = "SELECT codpacote, pac_pacote, pac_valor, pac_obs, pac_periodicidade, pac_datainicio, pac_datafim FROM tbpacote WHERE codpacote = " + cod;

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                //cmd.Parameters.AddWithValue("@codpacote");
                //cmd.Parameters.AddWithValue("@pac_pacote");
                //cmd.Parameters.AddWithValue("@pac_valor");
                //cmd.Parameters.AddWithValue("@pac_obspacote");
                //cmd.Parameters.AddWithValue("@pac_periodicidade");
                //cmd.Parameters.AddWithValue("@pac_datainicio");
                //cmd.Parameters.AddWithValue("@pac_datafim");
                //cmd.Parameters.AddWithValue("@cod", cod);

                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw;
            }
            return dt;
        }

        public bool ExcluirPacote(int intCod)
        {
            _sql = "DELETE FROM tbpacote WHERE codpacote = @cod";
            string _sql1 = "DELETE FROM tbpacoteservico WHERE codpacote = @cod";

            int _controle = 0;
            try
            {
                NpgsqlCommand cmd1 = new NpgsqlCommand(_sql1, Conexao.getIntancia().openConn());
                cmd1.Parameters.AddWithValue("@cod", intCod);
                _controle = cmd1.ExecuteNonQuery();
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
                cmd.Parameters.AddWithValue("@cod", intCod);
                _controle = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            return (_controle > 0);
        }

        public DataTable RetornaPacote(string texto)
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codpacote, pac_pacote, pac_valor, pac_obs, pac_periodicidade,  pac_datainicio, pac_datafim" +
                    "FROM tbpacote " +
                    "WHERE pac_pacote LIKE %" + texto + "%";

            int intCodigo = 0;

            int.TryParse(texto, out intCodigo);

            if (intCodigo > 0)
                _sql += $"OR codpacote = @codpacote ";

            // _sql += $"OR UPPER (usu_usuario) LIKE @usu_usuario";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codpacote");
                cmd.Parameters.AddWithValue("@pac_pacote");
                cmd.Parameters.AddWithValue("@pac_valor");
                cmd.Parameters.AddWithValue("@pac_obs");
                cmd.Parameters.AddWithValue("@pac_periodicidade");
                cmd.Parameters.AddWithValue("@pac_datainicio");
                cmd.Parameters.AddWithValue("@pac_datafim");


                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao retornar Pacote");
            }
            return dt;
        }

        public DataTable retornaListaPacote(int codigo)
        {
            DataTable dt = new DataTable();
            _sql = "SELECT * FROM tbpacoteservico WHERE codpacote = " + codigo;
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
                cmd.CommandText = _sql;

                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
                return dt;
            }catch(Exception e)
            {
                throw;
            }
        }
    }
}
