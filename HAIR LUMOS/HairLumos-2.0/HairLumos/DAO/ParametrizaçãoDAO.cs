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
    class ParametrizaçãoDAO
    {
        private string _sql;

        public ParametrizaçãoDAO()
        {
            this._sql = string.Empty;
        }

        public DataTable VerificaParametro()
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codparametro, param_razaosocial, param_nomefantasia, param_email, param_endereco, " +
                                "param_complemento, param_numero, param_telefone, param_celular, param_logo " +
                   "FROM tbparametro";


            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codparametro");
                cmd.Parameters.AddWithValue("@param_razaosocial");
                cmd.Parameters.AddWithValue("@param_nomefantasia");
                cmd.Parameters.AddWithValue("@param_email");
                cmd.Parameters.AddWithValue("@param_endereco");
                cmd.Parameters.AddWithValue("@param_complemento");
                cmd.Parameters.AddWithValue("@param_numero");
                cmd.Parameters.AddWithValue("@param_telefone");
                cmd.Parameters.AddWithValue("@param_celular");
                cmd.Parameters.AddWithValue("@param_logo");

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

        public int GravarParametro(Entidades.Parametrizacao _entParam)
        {

            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

            DataTable dt = new DataTable();
            dt = VerificaParametro();

            try
            {
                if (dt.Rows.Count == 0)
                {
                    _sql = "INSERT INTO tbparametro(param_razaosocial, param_nomefantasia, param_email, " +
                                    "param_endereco, param_complemento, param_numero, param_telefone, param_celular, param_logo) " +
                        "VALUES(@razao, @fantasia, @email, @endereco, @complemento, @num, @fone, @cel, @logo)";
                }
                else
                {
                    _sql = "UPDATE public.tbparametro SET " +
                                    "param_razaosocial = @razao, " +
                                    "param_nomefantasia = @fantasia, " +
                                    "param_email = @email, " +
                                    "param_endereco = @endereco, " +
                                    "param_complemento = @complemento, " +
                                    "param_numero = @num, " +
                                    "param_telefone = @fone, " +
                                    "param_celular = @cel, " +
                                    "param_logo = @logo " +
                        "WHERE codparametro = @cod";
                }

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codigo", _entParam.Codigo);
                cmd.Parameters.AddWithValue("@razao", _entParam.Razao);
                cmd.Parameters.AddWithValue("@fantasia", _entParam.NomeFantasia);
                cmd.Parameters.AddWithValue("@email", _entParam.Email);
                cmd.Parameters.AddWithValue("@endereco", _entParam.Endereco);
                cmd.Parameters.AddWithValue("@complemento", _entParam.Complemento);
                cmd.Parameters.AddWithValue("@num", _entParam.Numero);
                cmd.Parameters.AddWithValue("@fone", _entParam.Telefone);
                cmd.Parameters.AddWithValue("@cel", _entParam.Celular);
                cmd.Parameters.AddWithValue("@logo", _entParam.Byteimg);

                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception E)
            {
                return 0;
            }
        }
    }
}
