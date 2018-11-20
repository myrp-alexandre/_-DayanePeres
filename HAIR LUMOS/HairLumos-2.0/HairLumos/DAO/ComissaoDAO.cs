using HairLumos.Banco;
using Npgsql;
using System;
using System.Collections.Generic;
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
    }
}
