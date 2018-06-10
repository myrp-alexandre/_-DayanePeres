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
    class DespesaDAO
    {

        private string _sql;

        public DespesaDAO()
        {
            this._sql = string.Empty;
        }


        public int GravaDespesa(Entidades.Despesa _despesa)
        {

            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

            //int _controle = 0;
            try
            {
                if (_despesa.Codigo == 0)
                {
                    _sql = "INSERT INTO tbdespesa" +
                                "(desp_descricao, desp_status)" +
                        " VALUES(@descricao, @status)";

                }
                else
                {
                    _sql = "UPDATE tbdespesa" +
                            " SET desp_descricao = @descricao, desp_status = @status" +
                        " WHERE coddespesa = @codigo";
                }

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codigo", _despesa.Codigo);
                cmd.Parameters.AddWithValue("@descricao", _despesa.Descricao);
                cmd.Parameters.AddWithValue("@status", _despesa.Status);
                

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

        public DataTable RetornaDespesa()
        {
            DataTable dt = new DataTable();

            _sql = "SELECT coddespesa, desp_descricao, desp_status" +
                        " FROM tbdespesa; ";

            // int intCodigo = 0;
            //int intCodigo = 0;
            //int.TryParse(Texto, out intCodigo);

            //if (intCodigo > 0)
            //    _sql += $"OR coddespesa = @codigo ";

            //_sql += $"OR UPPER (desp_descricao) LIKE @produto";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@coddespesa");
                cmd.Parameters.AddWithValue("@desp_descricao");
                cmd.Parameters.AddWithValue("@desp_status");
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw new SystemException(e +"Erro ao retronar Despesa");
            }
            return dt;
        }

        public DataTable RetornaObjServico(int cod)
        {

            DataTable dt = new DataTable();

            _sql = "SELECT coddespesa, desp_descricao, desp_status" +
                        " FROM tbdespesa " +
                    "WHERE coddespesa = " + cod;

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@coddespesa");
                cmd.Parameters.AddWithValue("@desp_descricao");
                cmd.Parameters.AddWithValue("@desp_status");

                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw new SystemException(e +""); 
            }
            return dt;
        }

        public bool ExcluirServico(int intCod)
        {
            _sql = "DELETE FROM tbdespesa WHERE coddespesa = @cod";

            int _controle = 0;
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
                cmd.Parameters.AddWithValue("@cod", intCod);
                _controle = cmd.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                throw new SystemException(e + "");
            }
            return (_controle > 0);
        }

    }
}
