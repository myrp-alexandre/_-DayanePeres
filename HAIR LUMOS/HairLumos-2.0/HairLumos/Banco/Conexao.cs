using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace HairLumos.Banco
{
    public class Conexao
    {
        //sealed impede que outras classes façam herança dessa
         //Crinado instancia interna da classe
            private static readonly Conexao _instancia = new Conexao();
            private NpgsqlConnection _conn;

            private NpgsqlTransaction sqlTrans = null;
            private NpgsqlCommand _sqlCmd = null; //seria isso ? sim, so  que, olha
            private bool _autoConexao = true;

            //Contrutor privado da classe
            public Conexao()
            {
                string _strConexao = "Server = 127.0.0.1; Port = 5432; User Id = postgres; Password = postgres123; Database = banco_HL_corrigido_08_08; ";
                _conn = new NpgsqlConnection(_strConexao);
                _conn.Open();
                _sqlCmd = new NpgsqlCommand();
                _sqlCmd.Connection = _conn;
        }

            public static Conexao getIntancia()
            {
                return _instancia;
            }
            public NpgsqlConnection openConn()
            {
                return (_conn);
            }

            public bool AutoConexao
            {
                get { return _autoConexao; }
                set { _autoConexao = value; }
            }

            public NpgsqlCommand SqlCmd
            {
                get { return _sqlCmd; }
                set { _sqlCmd = value; }
            }

            public void abrirConexao()
            {
                if (_conn.State == ConnectionState.Closed)
                    _conn.Open();
            }

            public void fecharConexao()
            {
                if ((_conn != null) && (_conn.State == ConnectionState.Open))
                {
                    _conn.Close();
                    _sqlCmd.CommandText = "";
                    _sqlCmd.Parameters.Clear();
                }
            }

            /// <summary>
            /// Método que associa uma transacao ao comando
            /// Utilizar banco.AutoConexao = false;
            /// </summary>
            public void iniciarTransacao()
            {
                abrirConexao();
                sqlTrans = _conn.BeginTransaction();
                _sqlCmd.Transaction = sqlTrans;
            }

            public bool commitTransacao()
            {
                try
                {
                    sqlTrans.Commit();
                    sqlTrans = null;
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public void rollbackTransacao()
            {
                sqlTrans.Rollback();
                sqlTrans = null;
            }

            /// <summary>
            /// Método que executa comando sql: insert, update e delete
            /// </summary>
            /// <returns>bool</returns>
            public bool executarComando()
            {
                try
                {

                    abrirConexao();
                    SqlCmd.ExecuteNonQuery();
                    if (_autoConexao)
                    {
                        SqlCmd.Parameters.Clear();
                        fecharConexao();
                    }

                    return true;
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message);
                    return false;
                    //Tratamento de erro em camadas
                    //throw new Exception(ex.Message,ex.InnerException);
                }
            }

            /// <summary>
            /// Método que executa uma consulta SQL e retorna uma Datatable preenchida
            /// </summary>
            /// <returns>Datatable</returns>
            public DataTable executarReader()
            {
                DataTable dtRetorno = new DataTable();
                try
                {

                    abrirConexao();
                    dtRetorno.Load(SqlCmd.ExecuteReader());
                    if (_autoConexao)
                    {
                        SqlCmd.Parameters.Clear();
                        fecharConexao();
                    }

                    return dtRetorno;
                }
                catch //(Exception ex)
                {

                    fecharConexao();
                    return null;
                }

            }

            /// <summary>
            /// Método que executa comando select count, sum, etc com um único valor de retorno
            /// </summary>
            /// <returns>object genérico</returns>
            public object executarScalar()
            {

                object ret;

                abrirConexao();
                ret = SqlCmd.ExecuteScalar();
                if (_autoConexao)
                {
                    SqlCmd.Parameters.Clear();
                    fecharConexao();//se tiver com transação ativa, não pode fechar a conexao
                }

                return ret;
            }

        }
    
}
