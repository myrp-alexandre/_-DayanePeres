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

        public DataTable retornaContasReceber(DateTime dataI , DateTime dataF, String situacao) 
        {

            dataI = dataI.Date;
            dataF = dataF.Date;
            DataTable dt = new DataTable();
            DateTime dataA = DateTime.Now.Date;

            string dataIni = Convert.ToString(dataI);
            string DataFim = Convert.ToString(dataF);

            dataIni.Split('/');
            DataFim.Split('/');

            string dia, mes, ano;

            dia = mes = ano = "";
            ano = dataIni.Substring(6, 4);
            mes = dataIni.Substring(3, 2);
            dia = dataIni.Substring(0,2);

            dataIni = ano;
            dataIni += "-";
            dataIni += mes;
            dataIni += "-";
            dataIni += dia;

            ano = DataFim.Substring(6, 4);
            mes = DataFim.Substring(3, 2);
            dia = DataFim.Substring(0, 2);

            DataFim = ano;
            DataFim += "-";
            DataFim += mes;
            DataFim += "-";
            DataFim += dia;


            dataI = Convert.ToDateTime(dataIni);
            dataF = Convert.ToDateTime(DataFim);

            //dataI = Convert.ToDateTime(dataIni);
            // dataF = Convert.ToDateTime(DataFim);

            _sql = "SELECT p.codcontareceber, p.codparc, p.parc_valorpago, p.parc_datapagamento, " +
                   "p.codformapag, p.codcaixa, p.parc_valor, p.parc_datavencimento, c.contrec_obs " +
                   "FROM tbcontasreceber_parc p " +
                   "inner join tbcontasreceber c on c.codcontareceber = p.codcontareceber " +
                   "WHERE p.parc_datavencimento between "+ dataI + " and "+ dataF + " "; //'2017-12-31' and '2018-12-02'";//

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
                    _sql += " and p.parc_datavencimento < " + dataA;
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
    }
}
