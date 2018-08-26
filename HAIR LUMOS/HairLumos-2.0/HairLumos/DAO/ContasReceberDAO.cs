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
    class ContasReceberDAO
    {
        private string _sql;

        public DataTable retornaContasPeriodo(DateTime data)
        {
            DataTable dt = new DataTable();

            _sql = "SELECT * FROM tbcontasreceber where contrec_datapagamento BETWEEN @datai AND @dataa; ";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@datai", data);
                cmd.Parameters.AddWithValue("@dataa", DateTime.Now);
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao retronar Contas");
            }
            return dt;
        }
    }
}
