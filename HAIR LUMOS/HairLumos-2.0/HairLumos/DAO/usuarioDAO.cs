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

        
    }
}
