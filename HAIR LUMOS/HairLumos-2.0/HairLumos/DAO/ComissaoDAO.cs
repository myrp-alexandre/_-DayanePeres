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

    class ComissaoDAO
    {
        private string _sql;

        public int gravarComissao(Entidades.Comissao obj)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
            try
            {
              
                _sql = "INSERT INTO tbcomissao(comis_datapagamento, comis_valortotal, comis_valorpago, comis_valordevedor, comis_statuscomissao, comis_statuspagamento)"+
                    " VALUES(@dtpagamento, @valortotal, @valorpago, @valordevedor, @statuscomissao, @statuspagamento)";

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@dtpagamento", obj.DataPagamento);
                cmd.Parameters.AddWithValue("@valortotal", obj.ValorTotal);
                cmd.Parameters.AddWithValue("@valorpago", obj.ValorPago);
                cmd.Parameters.AddWithValue("@valordevedor", obj.ValorDevolver);
                cmd.Parameters.AddWithValue("@statuscomissao", obj.StatusComissao);
                cmd.Parameters.AddWithValue("@statuspagamento", obj.StatusPagamento);

                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int excluiComissao(Entidades.Comissao obj)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
            try
            {

                _sql = "DELETE FROM tbcomissao WHERE codcomissao = @cod";

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@cod", obj.CodigoComissao);

                return cmd.ExecuteNonQuery(); ;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int retornaMax()
        {
            DataTable dt = new DataTable();
            int cont = 0;

            _sql = "SELECT max(codcomissao) FROM tbcomissao";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);
                dr.Close();//Fecho o DataReader

                DataRow dtr = dt.Rows[0];
                cont = Convert.ToInt32(dtr[0].ToString());
            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao retronar Contas");
            }
            return cont;
        }

        public DataTable retornaComissao(int cod)
        {
            DataTable dt = new DataTable();
            _sql = "SELECT * FROM tbcomissao WHERE codcomissao = "+cod;

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);
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
