using HairLumos.Banco;
using HairLumos.Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.DAO
{
    class usuarioDAO
    {
        private string _sql;

        public usuarioDAO()
        {
            this._sql = string.Empty;
        }

        public DataTable RetornaPessoa(string texto)
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codpessoa, pes_nome, pes_tipopessoa, pes_statuspessoa" +
                        " FROM tbpessoa" +
                        "WHERE pes_statuspessoa = "+ true;

            int intCodigo = 0;
            
            int.TryParse(texto, out intCodigo);

            if (intCodigo > 0)
                _sql += $"OR codpessoa = @codigo ";

            _sql += $"OR UPPER (pes_nome) LIKE @produto";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codpessoa");
                cmd.Parameters.AddWithValue("@pes_nome");
                cmd.Parameters.AddWithValue("@pes_tipopessoa");
                cmd.Parameters.AddWithValue("@pes_statuspessoa");
                

                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao retronar Despesa");
            }
            return dt;
        }

        public bool ExcluirUsuario(int intCod)
        {

            _sql = "DELETE FROM tbusuario" +
                    "WHERE codusuario = @intcod";

            int _controle = 0;
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.Parameters.AddWithValue("@cod", intCod);
                _controle = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            return (_controle > 0);
        }

        public int GravaUsuario(Usuario objPessoa)
        {
            int intRetorno = 0;

            string strSQL = "";
            Conexao objConexao = null;
            try
            {

                objConexao = new Conexao();



                strSQL = "INSERT INTO tbusuario( codpessoa, usu_usuario, usu_senha, usu_nivel)";
                strSQL += " VALUES(@codPessoa, @usuario, @senha, @nivel)";


                objConexao.SqlCmd.CommandText = strSQL;
                objConexao.SqlCmd.Parameters.AddWithValue("@codPessoa", objPessoa.PessoaCod);
                objConexao.SqlCmd.Parameters.AddWithValue("@usuario", objPessoa.Login);
                objConexao.SqlCmd.Parameters.AddWithValue("@senha", objPessoa.Senha);
                objConexao.SqlCmd.Parameters.AddWithValue("@nivel", objPessoa.Nivel);



                objConexao.iniciarTransacao();
                objConexao.AutoConexao = false;

                int cod = (int)objConexao.executarScalar();
                //int cod = 0;
                //objConexao.executarComando();
                if (cod <= 0)
                {
                    return -1;
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
    }
}
