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
    class ServicoParceiroDAO
    {
        private string _sql;

        public ServicoParceiroDAO()
        {
            this._sql = string.Empty;
        }


        public int GravarServicoParceiro(Entidades.ServicoParceiro _servicoParceiro)
        {

            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

            //int _controle = 0;
            try
            {
                if (_servicoParceiro.PessoaJuridica.Codigo != 0 && _servicoParceiro._servico.Codigo != 0)
                {
                    _sql = "INSERT INTO tbprestadorservico" +
                        "(codpessoa, codtiposervico, prestserv_valor, prestserv_percentual, prestser_pagrec, jur_cnpj)" +
                        " VALUES (@codPessoa, @codtipoServico, @valor, @percentual, @recebido, @cnpj)";

                }
                else
                {
                    _sql = "UPDATE tbprestadorservico" +
                            " SET codpessoa = @codPessoa, codtiposervico = @codtipoServico, prestserv_valor = @valor, prestserv_percentual = @percentual, prestser_pagrec = @recebido, jur_cnpj = @cnpj " +
                        " WHERE codpessoa = @codPessoa AND WHERE codtiposervico = @codtipoServico";
                }

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codPessoa", _servicoParceiro._pessoaJuridica.Codigo);
                cmd.Parameters.AddWithValue("@codtipoServico", _servicoParceiro.Servico.Codigo);
                cmd.Parameters.AddWithValue("@valor", _servicoParceiro.Valor);
                cmd.Parameters.AddWithValue("@percentual", _servicoParceiro.Percentual);
                cmd.Parameters.AddWithValue("@recebido", _servicoParceiro.PagamentoRecebido);
                cmd.Parameters.AddWithValue("@cnpj", _servicoParceiro.PessoaJuridica.CNPJ);
                
                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception E)
            {
                return 0;
            }
            //if (_controle > 0)
            //return 1;
            //return 0;
        }

        public DataTable RetornaServicoParceiro()
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codpessoa, codtiposervico, prestserv_valor, prestserv_percentual, prestser_pagrec" +
                        " FROM tbprestadorservico; ";

            // int intCodigo = 0;
            //_sql += $"OR codcategoria = @cod";
            //_sql += $"OR cat_categoria = @categoria";
            //_sql += $"OR cat_obscategoria = @obs";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codpessoa");
                cmd.Parameters.AddWithValue("@codtiposervico");
                cmd.Parameters.AddWithValue("@prestserv_valor");
                cmd.Parameters.AddWithValue("@prestserv_percentual");
                cmd.Parameters.AddWithValue("@prestser_pagrec");
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        public DataTable RetornaParceiroServico(int intCodPessoa, int intCodServico)
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codpessoa, codtiposervico, prestserv_valor, prestserv_percentual, prestser_pagrec" +
                        " FROM tbprestadorservico WHERE codpessoa = "+ intCodPessoa +" AND codtiposervico = " + intCodServico +"; ";

            

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codpessoa");
                cmd.Parameters.AddWithValue("@codtiposervico");
                cmd.Parameters.AddWithValue("@prestserv_valor");
                cmd.Parameters.AddWithValue("@prestserv_percentual");
                cmd.Parameters.AddWithValue("@prestser_pagrec");
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        public bool ExcluirServicoParceiro(int intCodPessoa, int intCodServico)
        {
            _sql = "DELETE FROM tbprestadorservico WHERE codpessoa = " + intCodPessoa + " AND codtiposervico = " + intCodServico + "; ";

            int _controle = 0;
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
                cmd.Parameters.AddWithValue("@codPessoa", intCodPessoa);
                cmd.Parameters.AddWithValue("@codtiposervico", intCodServico);
                _controle = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            return (_controle > 0);
        }
    }
}
