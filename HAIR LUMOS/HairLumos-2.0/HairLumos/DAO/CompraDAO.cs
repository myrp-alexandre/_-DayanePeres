using HairLumos.Banco;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.DAO
{
    class CompraDAO
    {

        private string _sql;

        public int gravarCompra(Entidades.Compra compra)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
            try
            {
                if (compra.Codigo == 0)
                {
                    _sql = "INSERT INTO tbcompra "+
                           "(codcompra, coddespesa, comp_datacompra, comp_situacao, comp_statusconsignado, comp_valortotal, comp_obs, codpessoa)"+
                           " VALUES(@codcompra, @coddespesa, @comp_datacompra, @comp_situacao, @comp_statusconsignado, @comp_valortotal, @comp_obs, @codpessoa)";

                }
                else
                {
                    _sql = "UPDATE tbmarca" +
                            " SET marc_nome = @marca" +
                        " WHERE codmarca = @cod";
                }

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codcompra", compra.Codigo);
                cmd.Parameters.AddWithValue("@coddespesa", compra.Despesa.Codigo);
                cmd.Parameters.AddWithValue("@comp_datacompra", compra.Data);
                cmd.Parameters.AddWithValue("@comp_situacao", compra.Situacao);
                cmd.Parameters.AddWithValue("@comp_statusconsignado", compra.Consignado);
                cmd.Parameters.AddWithValue("@comp_valortotal", compra.ValorTotal);
                cmd.Parameters.AddWithValue("@comp_obs", compra.Obs);
                cmd.Parameters.AddWithValue("@codpessoa", compra.PJ.Codigo);


                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

    }
}
