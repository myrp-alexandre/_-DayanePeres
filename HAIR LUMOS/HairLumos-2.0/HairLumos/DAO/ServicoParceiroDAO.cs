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
                        "(codpessoa, codtiposervico, prestserv_valor, prestserv_percentual, prestser_pagrec, jur_cnpj, estado)" +
                        " VALUES (@codPessoa, @codtipoServico, @valor, @percentual, @recebido, @cnpj, @estado)";

                }

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codPessoa", _servicoParceiro._pessoaJuridica.Codigo);
                cmd.Parameters.AddWithValue("@codtipoServico", _servicoParceiro.Servico.Codigo);
                cmd.Parameters.AddWithValue("@valor", _servicoParceiro.Valor);
                cmd.Parameters.AddWithValue("@percentual", _servicoParceiro.Percentual);
                cmd.Parameters.AddWithValue("@recebido", _servicoParceiro.PagamentoRecebido);
                cmd.Parameters.AddWithValue("@cnpj", _servicoParceiro.PessoaJuridica.CNPJ);
                cmd.Parameters.AddWithValue("@estado", _servicoParceiro.Estado);

                
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

        public int AlteraServicoParceiro(Entidades.ServicoParceiro _servicoParceiro)
        {

            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

            //int _controle = 0;
            try
            {
                
                
                _sql = "UPDATE tbprestadorservico" +
                        " SET codpessoa = @codPessoa, codtiposervico = @codtipoServico, prestserv_valor = @valor, prestserv_percentual = @percentual, prestser_pagrec = @recebido, jur_cnpj = @cnpj, estado = @estado " +
                    " WHERE codpessoa = @codPessoa AND codtiposervico = @codtipoServico";
                

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codPessoa", _servicoParceiro._pessoaJuridica.Codigo);
                cmd.Parameters.AddWithValue("@codtipoServico", _servicoParceiro.Servico.Codigo);
                cmd.Parameters.AddWithValue("@valor", _servicoParceiro.Valor);
                cmd.Parameters.AddWithValue("@percentual", _servicoParceiro.Percentual);
                cmd.Parameters.AddWithValue("@recebido", _servicoParceiro.PagamentoRecebido);
                cmd.Parameters.AddWithValue("@cnpj", _servicoParceiro.PessoaJuridica.CNPJ);
                cmd.Parameters.AddWithValue("@estado", _servicoParceiro.Estado);


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

            _sql = "SELECT codpessoa, codtiposervico, prestserv_valor, prestserv_percentual, prestser_pagrec, estado" +
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
                cmd.Parameters.AddWithValue("@estado");
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

            _sql = "SELECT codpessoa, codtiposervico, prestserv_valor, prestserv_percentual, prestser_pagrec, estado" +
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
                cmd.Parameters.AddWithValue("@estado");
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

        public DataTable RetornaPrestador()
        {
            DataTable dt = new DataTable();

            _sql = "select ps.codpessoa, p.pes_nome from tbprestadorservico ps inner join tbpessoa p on p.codpessoa = ps.codpessoa group by ps.codpessoa, p.pes_nome ";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
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

        public DataTable RetornaServicos(int codigo)
        {
            DataTable dt = new DataTable();

            _sql = "select * from tbprestadorservico where codpessoa = " + codigo;

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
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

        public bool VerificaAgenda(int codServico, string cnpj)
        {
            DataTable dt = new DataTable();

            _sql = "select * from tbagenda where codtiposervico = @cod and jur_cnpj = '@cnpj'";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@cod", codServico);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
                if (dt != null && dt.Rows.Count > 0)
                {
                    return false; //ja realizou serviço
                }
                else
                    return true; //não existe cadastrado
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool VerificaServico(int codServico, int cosPessoa)
        {
            DataTable dt = new DataTable();

            _sql = "select * from tbprestadorservico where codtiposervico = @cod and codpessoa = @codPessoa and estado <> 'FALSE'";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@cod", codServico);
                cmd.Parameters.AddWithValue("@codPessoa", cosPessoa);
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
                if (dt != null && dt.Rows.Count > 0)
                {
                    return true; //ja existe serviço cadastrado pra esse prestador
                }
                else
                    return false; //não existe vinculo entre este servico e estre prestador
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool VerificaServicoDois(int codServico, int cosPessoa)
        {
            DataTable dt = new DataTable();

            _sql = "select * from tbprestadorservico where codtiposervico = @cod and codpessoa = @codPessoa";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@cod", codServico);
                cmd.Parameters.AddWithValue("@codPessoa", cosPessoa);
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
                if (dt != null && dt.Rows.Count > 0)
                {
                    return true; //ja existe serviço cadastrado pra esse prestador
                }
                else
                    return false; //não existe vinculo entre este servico e estre prestador
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
