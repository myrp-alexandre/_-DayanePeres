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
    class ContasPagarDAO
    {
        private string _sql;

        public ContasPagarDAO()
        {
            this._sql = string.Empty;
        }

        public int GravaLancamentoDespesa(Entidades.ContasPagar objContasPagar)
        {
            int intRetorno = 0;

            string strSQL = "";
            Conexao objConexao = null;
            try
            {

                objConexao = new Conexao();

                
                
                strSQL = "INSERT INTO tbcontaspagar (contpag_datavencimento, contpag_datapagamento, contpag_valortotal, contpag_valorpago, contpag_obs, contpag_status, contpag_numparc, codcompra, coddespesa, codcaixa, codformapag, codcomissao, \"contPag_valorParcela\", \"contPag_Parcela\", \"codContasPagar\")";
                strSQL += " VALUES(@dtVencimento, @dtPagamento, @valorTotal, @valorPago, @obs, @status, @numParcela, @codCompra, @codDespesa, @codCaixa, @codFormaPag, @codComissao, @contPag_valorParcela, @contPag_Parcela,@codContasPagar);";
                //objConexao.SqlCmd = new NpgsqlCommand(strSQL);

                objConexao.SqlCmd.CommandText = strSQL;
                objConexao.SqlCmd.Parameters.AddWithValue("@dtVencimento", objContasPagar.DataVencimento);
                objConexao.SqlCmd.Parameters.AddWithValue("@dtPagamento", objContasPagar.DataPagamento);
                objConexao.SqlCmd.Parameters.AddWithValue("@valorTotal", objContasPagar.ValorTotal);
                objConexao.SqlCmd.Parameters.AddWithValue("@valorPago", objContasPagar.ValorPago);
                objConexao.SqlCmd.Parameters.AddWithValue("@obs", objContasPagar.Observacao);
                objConexao.SqlCmd.Parameters.AddWithValue("@status", objContasPagar.Status);
                objConexao.SqlCmd.Parameters.AddWithValue("@numParcela", objContasPagar.Parcela);
                objConexao.SqlCmd.Parameters.AddWithValue("@codCompra", objContasPagar.Compra.Codigo);
                objConexao.SqlCmd.Parameters.AddWithValue("@codDespesa", objContasPagar.Despesa.Codigo);
                objConexao.SqlCmd.Parameters.AddWithValue("@codCaixa", objContasPagar.Caixa.CodCaixa);
                if(objContasPagar.FormaPagamento!=null && objContasPagar.FormaPagamento.Codigo!=0)
                    objConexao.SqlCmd.Parameters.AddWithValue("@codFormaPag", objContasPagar.FormaPagamento.Codigo);
                else 
                    objConexao.SqlCmd.Parameters.AddWithValue("@codFormaPag", NpgsqlTypes.NpgsqlDbType.Integer, objContasPagar.FormaPagamento.Codigo);
                if (objContasPagar.Comissao != null && objContasPagar.Comissao.CodigoComissao != 0)
                    objConexao.SqlCmd.Parameters.AddWithValue("@codComissao", objContasPagar.Comissao.CodigoComissao);
                else
                    objConexao.SqlCmd.Parameters.AddWithValue("@codComissao", NpgsqlTypes.NpgsqlDbType.Integer, objContasPagar.Comissao.CodigoComissao);
                objConexao.SqlCmd.Parameters.AddWithValue("@contPag_valorParcela", objContasPagar.ValorParcela);
                objConexao.SqlCmd.Parameters.AddWithValue("@contPag_Parcela", objContasPagar.CodParcela);
                objConexao.SqlCmd.Parameters.AddWithValue("@codContasPagar", objContasPagar.CodigoContasaPagar);



                objConexao.iniciarTransacao();
                objConexao.AutoConexao = false;

                

                if (!objConexao.executarComando())
                    return -1;

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

        public DataTable retornaContasPeriodo(DateTime data)
        {
            DataTable dt = new DataTable();

            _sql = "SELECT * FROM tbcontaspagar where contpag_datapagamento BETWEEN @datai AND @dataa; ";

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

        public DataTable retornaContasPeriodo(DateTime datai, DateTime dataf)
        {
            DataTable dt = new DataTable();

            _sql = "SELECT t.contpag_datavencimento, t.contpag_datapagamento, t.contpag_valortotal, t.contpag_valorpago, t.contpag_obs, t.contpag_status, t.contpag_numparc, t.codcompra, t.coddespesa, t.codcaixa, t.codformapag, t.codcomissao,"
                 + " \"contPag_valorParcela\", \"contPag_Parcela\", \"codContasPagar\" desp_descricao FROM tbcontaspagar t inner join tbdespesa p on p.coddespesa = t.coddespesa where t.contpag_datavencimento BETWEEN @datai AND @dataa;";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@datai", datai);
                cmd.Parameters.AddWithValue("@dataa", dataf);
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

        public int GravarContasPagar(Entidades.ContasPagar contasPagar)
        {
            Conexao objConexao = null;
            try
            {
                objConexao = new Conexao();
                if (contasPagar.CodigoContasaPagar == 0)
                {
                    _sql = "INSERT INTO tbcontaspagar" +
                           " (contpag_datavencimento, contpag_datapagamento, contpag_valortotal, contpag_valorpago, contpag_obs, contpag_status, contpag_numparc, codcompra, coddespesa, codcaixa, codformapag,codcomissao)" +
                           " VALUES (@dtVencimento, @dtPagamento, @valorTotal, @valorPago, @obs, @status, @numParcela, @codCompra, @codDespesa, @codCaixa, @codFormaPag, @CodComissao);" +
                           " SELECT MAX(codcompra),  max(codCaixa)"+
                           " FROM tbcompra;";

                }
               

                objConexao.SqlCmd.CommandText = _sql;
                objConexao.SqlCmd.Parameters.AddWithValue("@dtVencimento", contasPagar.DataVencimento);
                objConexao.SqlCmd.Parameters.AddWithValue("@dtPagamento", contasPagar.DataPagamento);
                objConexao.SqlCmd.Parameters.AddWithValue("@valorTotal", contasPagar.ValorTotal);
                objConexao.SqlCmd.Parameters.AddWithValue("@valorPago", contasPagar.ValorPago);
                objConexao.SqlCmd.Parameters.AddWithValue("@obs", contasPagar.Observacao);
                objConexao.SqlCmd.Parameters.AddWithValue("@numParcela", contasPagar.Parcela);
                objConexao.SqlCmd.Parameters.AddWithValue("@codCompra", contasPagar.Compra.Codigo);
                objConexao.SqlCmd.Parameters.AddWithValue("@codDespesa", contasPagar.Despesa.Codigo);
                objConexao.SqlCmd.Parameters.AddWithValue("@codCaixa", contasPagar.Caixa.CodCaixa);
                objConexao.SqlCmd.Parameters.AddWithValue("@codFormaPag", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                objConexao.SqlCmd.Parameters.AddWithValue("@CodComissao", NpgsqlTypes.NpgsqlDbType.Integer, 0);



                objConexao.iniciarTransacao();
                objConexao.AutoConexao = false;
                
                if (!objConexao.executarComando())
                    return -1;
                
                

                objConexao.commitTransacao();
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int max()
        {
            DataTable dt = new DataTable();
            int cont = 0;

            _sql = "SELECT max(\"codContasPagar\") FROM tbcontaspagar";

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

    }

}
