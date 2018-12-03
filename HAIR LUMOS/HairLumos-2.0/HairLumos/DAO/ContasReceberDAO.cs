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

        public DataTable retornaContasReceber(string dataI , string dataF, String situacao) 
        {

            
            DataTable dt = new DataTable();
            string dataA = DateTime.Now.ToString("yyyy-MM-dd");

            _sql = "SELECT p.codcontareceber, p.codparc, p.parc_valorpago, p.parc_datapagamento, " +
                   "p.codformapag, p.codcaixa, p.parc_valor, p.parc_datavencimento, c.contrec_obs " +
                   "FROM tbcontasreceber_parc p " +
                   "inner join tbcontasreceber c on c.codcontareceber = p.codcontareceber " +
                   "WHERE p.parc_datavencimento between '"+ dataI + "' and '"+ dataF + "' "; //'2017-12-31' and '2018-12-02'";//

            if (!situacao.Equals("")) { 
                if (situacao.Equals("Em aberto"))
                {
                    _sql += " and c.contrec_obs = 'aberta'";
                }
                if (situacao.Equals("Pago"))
                {
                    _sql += " and c.contrec_obs = 'fechada'";
                }
                if (situacao.Equals("Vencido"))
                {
                    _sql += " and p.parc_datavencimento < '" + dataA+"'";
                }
            }
            else
            {
                dt = null;
            }

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
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

        public int gravarContasReceber(Entidades.ContasReceber obj)
        {
            int intRetorno = 0;

            string strSQL = "";
            Conexao objConexao = null;
            try
            {

                objConexao = new Conexao();


                //Fazer o Insert da pessoa
                strSQL = "INSERT INTO tbcontasreceber(contrec_datavencimento, contrec_valortotal, contrec_obs, codcontrato, codvenda, codcomissao, codpessoa, codfiado)";
                strSQL += " VALUES (@contrec_datavencimento, @contrec_valortotal, @contrec_obs, @codcontrato, @codvenda, @codcomissao, @codpessoa, @codfiado); SELECT MAX(codcontareceber) FROM tbcontasreceber;";
                //objConexao.SqlCmd = new NpgsqlCommand(strSQL);

                objConexao.SqlCmd.CommandText = strSQL;
                objConexao.SqlCmd.Parameters.AddWithValue("@contrec_datavencimento", obj.DtVencimento);
                objConexao.SqlCmd.Parameters.AddWithValue("@contrec_valortotal", obj.ValorTotal);
                objConexao.SqlCmd.Parameters.AddWithValue("@contrec_obs", obj.Obs);
                if(obj.Contrato!=null && obj.Contrato.Codigo>0)
                    objConexao.SqlCmd.Parameters.AddWithValue("@codcontrato", obj.Contrato.Codigo > 0);
                else
                    objConexao.SqlCmd.Parameters.AddWithValue("@codcontrato", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                if(obj.Venda != null && obj.Venda.Codigo>0)
                    objConexao.SqlCmd.Parameters.AddWithValue("@codvenda", obj.Venda.Codigo);
                else
                    objConexao.SqlCmd.Parameters.AddWithValue("@codvenda", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                if(obj.Comissao!=null && obj.Comissao.CodigoComissao>0)
                    objConexao.SqlCmd.Parameters.AddWithValue("@codcomissao", obj.Comissao.CodigoComissao);
                else
                    objConexao.SqlCmd.Parameters.AddWithValue("@codcomissao", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                if (obj.Pessoaf != null && obj.Pessoaf.Codigo > 0)
                    objConexao.SqlCmd.Parameters.AddWithValue("@codpessoa", obj.Pessoaf.Codigo);
                else
                    objConexao.SqlCmd.Parameters.AddWithValue("@codpessoa", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                objConexao.SqlCmd.Parameters.AddWithValue("@codfiado", NpgsqlTypes.NpgsqlDbType.Integer, 0);


                objConexao.iniciarTransacao();
                objConexao.AutoConexao = false;

                int cod = (int)objConexao.executarScalar();
                //int cod = 0;
                //objConexao.executarComando();
                if (cod <= 0)
                {
                    return -1;
                }

                if (obj.Lista != null)
                {

                    for (int i = 0; i < obj.Lista.Count; i++)
                    {
                        strSQL = "INSERT INTO tbcontasreceber_parc(codcontareceber, codparc, parc_valorpago, parc_datapagamento, codformapag, codcaixa, parc_valor, parc_datavencimento) ";
                        strSQL += "VALUES (@codcontareceber, @codparc, @parc_valorpago, @parc_datapagamento, @codformapag, @codcaixa, @parc_valor, @parc_datavencimento);";

                        objConexao.SqlCmd.Parameters.Clear();
                        objConexao.SqlCmd.CommandText = strSQL;

                        objConexao.SqlCmd.Parameters.AddWithValue("@codcontareceber", cod);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codparc", obj.Lista.ElementAt(i).Codigo);
                        objConexao.SqlCmd.Parameters.AddWithValue("@parc_valorpago", obj.Lista.ElementAt(i).ValorPago);
                        objConexao.SqlCmd.Parameters.AddWithValue("@parc_datapagamento", obj.Lista.ElementAt(i).DataPagamento);
                        if(obj.Lista.ElementAt(i).Forma!=null && obj.Lista.ElementAt(i).Forma.Codigo!=0)
                            objConexao.SqlCmd.Parameters.AddWithValue("@codformapag", obj.Lista.ElementAt(i).Forma.Codigo);
                        else
                            objConexao.SqlCmd.Parameters.AddWithValue("@codformapag", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codcaixa", obj.Lista.ElementAt(i).Caixa.CodCaixa);
                        objConexao.SqlCmd.Parameters.AddWithValue("@parc_valor", obj.Lista.ElementAt(i).ValorReceber);
                        objConexao.SqlCmd.Parameters.AddWithValue("@parc_datavencimento", obj.Lista.ElementAt(i).DataVencimento);

                        if (!objConexao.executarComando())
                            return -1;
                    }



                }

                objConexao.commitTransacao();
                return cod;


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

        public int realizarRecebimento(Entidades.Parcela obj, int codigo)
        {
            _sql = "update tbcontasreceber_parc set parc_valorpago = @pago, parc_datapagamento = @data, codformapag = @forma, codcaixa = @caixa where codcontareceber = @cod and codparc = @parc ";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@pago", obj.ValorPago);
                cmd.Parameters.AddWithValue("@data", obj.DataPagamento);
                cmd.Parameters.AddWithValue("@forma", obj.Forma.Codigo);
                cmd.Parameters.AddWithValue("@caixa", obj.Caixa.CodCaixa);
                cmd.Parameters.AddWithValue("@cod", codigo);
                cmd.Parameters.AddWithValue("@parc", obj.Codigo);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao realizar recebimento");
            }
        }

        public int atualizaStatus(int codigo, string status) 
        {
            _sql = "update tbcontasreceber set contrec_obs = @obs where codcontareceber = @cod";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@obs", status);
                cmd.Parameters.AddWithValue("@cod", codigo);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao retronar Despesas");
            }
        }

        public DataTable retornaContasCod(int codigo)
        {
            DataTable dt = new DataTable();

            _sql = "SELECT * FROM tbcontasreceber where codcontareceber = "+ codigo;

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
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

        public DataTable retornaParcelaContaReceber(int codRe, int codP)
        {
            DataTable dt = new DataTable();

            _sql = "SELECT * FROM tbcontasreceber_parc where codcontareceber = " + codRe + " and codparc = " + codP ;

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
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
