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
    }
}
