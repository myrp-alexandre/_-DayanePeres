using HairLumos.Banco;
using Npgsql;
using System;
using System.Collections.Generic;
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
                if (_servicoParceiro.PessoaJuridica.Codigo == 0 && _servicoParceiro._servico.Codigo == 0)
                {
                    _sql = "INSERT INTO tbprestadorservico" +
                        "(codpessoa, codtiposervico, prestserv_valor, prestserv_percentual, prestser_pagrec)" +
                        " VALUES (@codPessoa, @codtipoServico, @valor, @percentual, @recebido)";

                }
                else
                {
                    _sql = "UPDATE tbprestadorservico" +
                            " SET codpessoa = @codPessoa, codtiposervico = @codtipoServico, prestserv_valor = @valor, prestserv_percentual = @percentual, prestser_pagrec = @recebido " +
                        " WHERE codpessoa = @codPessoa AND WHERE codtiposervico = @codtipoServico";
                }

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codPessoa", _servicoParceiro._pessoaJuridica.Codigo);
                cmd.Parameters.AddWithValue("@codtipoServico", _servicoParceiro.Servico.Codigo);
                cmd.Parameters.AddWithValue("@valor", _servicoParceiro.Valor);
                cmd.Parameters.AddWithValue("@percentual", _servicoParceiro.Percentual);
                cmd.Parameters.AddWithValue("@recebido", _servicoParceiro.PagamentoRecebido);
                
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
    }
}
