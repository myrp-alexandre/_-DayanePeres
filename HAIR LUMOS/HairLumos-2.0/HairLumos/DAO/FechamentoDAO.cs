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
    class FechamentoDAO
    {

        private string _sql = "";

        public int gravarFechamento(Entidades.Fechamento obj)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
            try
            {
                _sql = @"INSERT INTO tbfechamento(codpessoa, codfechamento, fia_dataabertura, fia_datafechamento,fia_valortotal, fia_status)
                            VALUES(@codpessoa, @codfechamento, @dataabertura, @datafechamento, @valortotal, @status)";

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codpessoa", obj.Pes.Codigo);
                cmd.Parameters.AddWithValue("@codfechamento", obj.Codigo);
                cmd.Parameters.AddWithValue("@dataabertura", obj.DtAbertura);
                cmd.Parameters.AddWithValue("@datafechamento", obj.DtPagamento);
                cmd.Parameters.AddWithValue("@valortotal", obj.Valor);
                cmd.Parameters.AddWithValue("@status", obj.Status);

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
            _sql = "select max(codfechamento) from tbfechamento";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader

                if(dt!=null && dt.Rows.Count > 0)
                {
                    int cod = 0;
                    DataRow drTeste = dt.Rows[0];
                    int.TryParse(drTeste[0].ToString(), out cod);
                    return cod;
                }
                return -1;
            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao retronar Despesa");
            }
        }
    }
}
