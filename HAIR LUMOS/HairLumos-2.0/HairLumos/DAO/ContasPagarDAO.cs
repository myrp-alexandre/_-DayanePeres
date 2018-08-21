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
                objConexao.SqlCmd.Parameters.AddWithValue("@dtVencimento", objContasPagar.DataVencimento);
                objConexao.SqlCmd.Parameters.AddWithValue("@dtPagamento", objContasPagar.DataPagamento);
                objConexao.SqlCmd.Parameters.AddWithValue("@valorTotal", objContasPagar.ValorTotal);
                objConexao.SqlCmd.Parameters.AddWithValue("@valorPago", objContasPagar.ValorPago);
                objConexao.SqlCmd.Parameters.AddWithValue("@obs", objContasPagar.Observacao);
                objConexao.SqlCmd.Parameters.AddWithValue("@status", objContasPagar.Status);
                objConexao.SqlCmd.Parameters.AddWithValue("@numParcela", objContasPagar.Parcela);

                if(objContasPagar.Compra!=null && objContasPagar.Compra.Codigo!=0)
                    objConexao.SqlCmd.Parameters.AddWithValue("@codCompra", objContasPagar.Compra.Codigo);
                else
                    objConexao.SqlCmd.Parameters.AddWithValue("@codCompra", 1);

                if(objContasPagar.Despesa!=null && objContasPagar.Despesa.Codigo!=0)
                    objConexao.SqlCmd.Parameters.AddWithValue("@codDespesa", objContasPagar.Despesa.Codigo);
                else
                    objConexao.SqlCmd.Parameters.AddWithValue("@codDespesa", 0);

                if (objContasPagar.Caixa!=null && objContasPagar.Caixa.CodCaixa!=0)
                    objConexao.SqlCmd.Parameters.AddWithValue("@codCaixa", objContasPagar.Caixa.CodCaixa);
                else
                    objConexao.SqlCmd.Parameters.AddWithValue("@codCaixa", 1);

                if(objContasPagar.FormaPagamento!=null && objContasPagar.FormaPagamento.Codigo!=0)
                    objConexao.SqlCmd.Parameters.AddWithValue("@codFormaPag", objContasPagar.FormaPagamento.Codigo);
                else
                    objConexao.SqlCmd.Parameters.AddWithValue("@codFormaPag", 1);

                if(objContasPagar.Comissao!=null && objContasPagar.Comissao.CodigoComissao!=0)
                    objConexao.SqlCmd.Parameters.AddWithValue("@codComissao", objContasPagar.Comissao.CodigoComissao);
                else
                    objConexao.SqlCmd.Parameters.AddWithValue("@codComissao", 1);
                



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
