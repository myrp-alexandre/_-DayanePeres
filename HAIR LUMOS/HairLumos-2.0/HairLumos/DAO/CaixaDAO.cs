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
    class CaixaDAO
    {
        private string _sql;

        public int abrirCaixa(Entidades.Caixa obj)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
            try
            {
                if (obj.CodCaixa == 0)
                {
                    _sql = "INSERT INTO tbcaixa(caixa_periodo, caixa_datahoraabertura, caixa_datahorafecha,caixa_saldoinicial, caixa_troco, caixa_totalentra, caixa_totalsaida,codusuario, codpessoa)"+
                            " VALUES(@caixaperiodo, @caixaabertura, @caixadatafecha, @caixasaldoinicial, @caixatroco, @caixatotalen, @caixatotalsa, @codusu, @codpessoa)";

                }

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@caixaperiodo", obj.Periodo);
                cmd.Parameters.AddWithValue("@caixaabertura", obj.DataAbertura);
                cmd.Parameters.AddWithValue("@caixadatafecha", obj.DataFechamento);
                cmd.Parameters.AddWithValue("@caixasaldoinicial", obj.SaldoInicial);
                cmd.Parameters.AddWithValue("@caixatroco", obj.Troco);
                cmd.Parameters.AddWithValue("@caixatotalen", obj.TotalEntrada);
                cmd.Parameters.AddWithValue("@caixatotalsa", obj.TotalSaida);
                cmd.Parameters.AddWithValue("@codusu", obj.Usuario.UsuarioCodigo);
                cmd.Parameters.AddWithValue("@codpessoa", obj.Usuario.PessoaCod);


                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public DataTable caixaAberto()
        {
            DataTable dt = new DataTable();
            string data = "0001-01-01";
            DateTime datad = Convert.ToDateTime(data);
            _sql = "SELECT * FROM tbcaixa where caixa_datahorafecha = @data ";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@data", datad);
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao retronar Despesa");
            }
            return dt;
        }

        public int fecharCaixa(Entidades.Caixa obj)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
            try
            {
                _sql = "UPDATE tbcaixa SET caixa_datahorafecha = @data, caixa_totalsaida = @total WHERE codcaixa = @codigo;";

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@data", obj.DataFechamento);
                cmd.Parameters.AddWithValue("@total", obj.TotalSaida);
                cmd.Parameters.AddWithValue("@codigo", obj.CodCaixa);


                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public DataTable retornaMaxCaixa()
        {
            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
            try
            {
                DataTable dt = new DataTable();
                _sql = "select * from tbcaixa where codcaixa = ((select max(codcaixa) from tbcaixa)-1)";
                cmd.CommandText = _sql;
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataTable retornaValCaixaAberto()
        {
            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
            try
            {
                DataTable dt = new DataTable();
                _sql = "select * from tbcaixa where codcaixa = (select max(codcaixa) from tbcaixa)";
                cmd.CommandText = _sql;
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
}
