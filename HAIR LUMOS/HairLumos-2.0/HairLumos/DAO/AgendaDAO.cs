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
    class AgendaDAO
    {
        private string _sql = "";

        public int gravarAgenda(Entidades.Agenda obj)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
            try
            {

                _sql = "INSERT INTO tbagenda(codpessoa, agen_dataagendamento, agen_horaagendamento, agen_status, agen_valor, codcomissao, codtiposervico, jur_cnpj, codfechamento)"+
                      " VALUES (@codpessoa, @dtagendamento, @horario, @status, @valor, @comissao, @servico, @func, @fechamento)";

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codpessoa", obj.Pes.Codigo);
                cmd.Parameters.AddWithValue("@dtagendamento", obj.DtAgendamento);
                cmd.Parameters.AddWithValue("@horario", obj.Hora);
                cmd.Parameters.AddWithValue("@status", obj.Status);
                cmd.Parameters.AddWithValue("@valor", obj.Valor);
                cmd.Parameters.AddWithValue("@comissao", obj.Comissao.CodigoComissao);
                cmd.Parameters.AddWithValue("@servico", obj.ServicoParceiro.Servico.Codigo);
                cmd.Parameters.AddWithValue("@func", obj.ServicoParceiro.PessoaJuridica.CNPJ);
                cmd.Parameters.AddWithValue("@fechamento", NpgsqlTypes.NpgsqlDbType.Integer, obj.Fechamento.Codigo);


                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public DataTable retornaAgenda(string cnpj, string data)
        {
            DataTable dt = new DataTable();
            _sql = "select * from tbagenda where jur_cnpj = '" + cnpj + "' and agen_dataagendamento = '" + data+"'";

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

                throw new SystemException(e + "Erro ao retronar Despesa");
            }
            return dt;
        }

        public int atualizaStatus(Entidades.Agenda obj)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
            try
            {

                _sql = "update tbagenda set agen_status = @status where codagenda = @codigo";

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@status", obj.Status);
                cmd.Parameters.AddWithValue("@codigo", obj.Codigo);


                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int retornaComissao(Entidades.Agenda obj)
        {
            DataTable dt = new DataTable();
            _sql = "select codcomissao from tbagenda where codagenda = @cod";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@cod", obj.Codigo);
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader

                DataRow drTeste = dt.Rows[0];
                return Convert.ToInt32(drTeste["codcomissao"].ToString());

            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao retronar Despesa");
            }
            return -1;
        }

        public DataTable retornaServicosCliente(int codigo)
        {
            _sql = "select a.codpessoa, a.agen_valor, a.agen_dataagendamento, ts.tiposerv_descricao, a.agen_status, a.codagenda " +
                   " from tbagenda a inner join tbtiposervico ts on ts.codtiposervico = a.codtiposervico" +
                   " where a.codpessoa = " + codigo+ " and a.agen_status = 'Confirmado' and a.codfechamento = 0";
            DataTable dt = new DataTable();

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

                throw new SystemException(e + "Erro ao retronar Despesa");
            }
            return dt;
        }

        public int atualizaFiado(Entidades.Agenda obj)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
            try
            {

                _sql = "update tbagenda set codfechamento = @cod where codagenda = @codigo";

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@cod", obj.Fechamento.Codigo);
                cmd.Parameters.AddWithValue("@codigo", obj.Codigo);


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
