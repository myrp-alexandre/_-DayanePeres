using HairLumos.Banco;
using System;
using System.Collections.Generic;
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


                //Fazer o Insert da pessoa
                strSQL = "INSERT INTO tbcontaspagar (contpag_datavencimento, contpag_datapagamento, contpag_valortotal, contpag_valorpago, contpag_obs, contpag_status, contpag_numparc, codcompra, coddespesa, codcaixa, codformapag, codcomissao)";
                strSQL += " VALUES(@dtVencimento, @dtPagamento, @valorTotal, @valorPago, @obs, @status, @numParcela, @codCompra, @codDespesa, @codCaixa, @codFormaPag, @codComissao);"; //SELECT MAX(codpessoa) FROM tbpessoa;";
                //objConexao.SqlCmd = new NpgsqlCommand(strSQL);

                objConexao.SqlCmd.CommandText = strSQL;
                objConexao.SqlCmd.Parameters.AddWithValue("@contpag_datavencimento", objContasPagar.DataVencimento);
                objConexao.SqlCmd.Parameters.AddWithValue("@contpag_datapagamento", objContasPagar.DataPagamento);
                objConexao.SqlCmd.Parameters.AddWithValue("@contpag_valortotal", objContasPagar.ValorTotal);
                objConexao.SqlCmd.Parameters.AddWithValue("@contpag_valorpago", objContasPagar.ValorPago);
                objConexao.SqlCmd.Parameters.AddWithValue("@contpag_obs", objContasPagar.Observacao);
                objConexao.SqlCmd.Parameters.AddWithValue("@contpag_status", objContasPagar.Status);
                objConexao.SqlCmd.Parameters.AddWithValue("@contpag_numparc", objContasPagar.Parcela);
                objConexao.SqlCmd.Parameters.AddWithValue("@codcompra", objContasPagar.Compra);
                objConexao.SqlCmd.Parameters.AddWithValue("@coddespesa", objContasPagar.Despesa);
                objConexao.SqlCmd.Parameters.AddWithValue("@codcaixa", objContasPagar.Caixa);
                objConexao.SqlCmd.Parameters.AddWithValue("@codformapag", objContasPagar.FormaPagamento);
                objConexao.SqlCmd.Parameters.AddWithValue("@codcomissao", objContasPagar.Comissao);



                objConexao.iniciarTransacao();
                objConexao.AutoConexao = false;

                //int cod = (int)objConexao.executarScalar();
                ////int cod = 0;
                ////objConexao.executarComando();
                //if (cod <= 0)
                //{
                //    return -1;
                //}
                
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
    }

}
