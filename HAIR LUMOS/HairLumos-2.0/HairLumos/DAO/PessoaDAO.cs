using HairLumos.Banco;
using HairLumos.Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.DAO
{
    public class PessoaDAO
    {
        public int GravarPessoa(Pessoa objPessoa)
        {
            int intRetorno = 0;

            string strSQL = "";
            Conexao objConexao = null;
            try
            {
                if(objPessoa.Codigo == 0)
                {
                    objConexao = new Conexao();

                    int cod = (int)objConexao.executarScalar();
                    if (cod <= 0)
                    {
                        return -1;
                    }
                    //Fazer o Insert da pessoa
                    strSQL = "INSERT INTO tbPessoa(pes_nomepessoa, pes_datacadastro, pes_tipopessoa, pes_statuspessoa, pes_obspessoa, pes_fiado)";
                    strSQL += " VALUES(@nomePessoa, @dataCadastro, @tipoPessoa, @statusPessoa, @obsPessoa, @fiado); RETURNING codPessoa";
                    objConexao.SqlCmd = new NpgsqlCommand(strSQL);
       
                    objConexao.SqlCmd.Parameters.AddWithValue("@nomePessoa", objPessoa.PessoaFisica.Nome);
                    objConexao.SqlCmd.Parameters.AddWithValue("@dataCadastro", objPessoa.PessoaFisica.DataCadastro);
                    objConexao.SqlCmd.Parameters.AddWithValue("@tipoPessoa", objPessoa.PessoaFisica.TipoPessoa);
                    objConexao.SqlCmd.Parameters.AddWithValue("@statusPessoa", true);
                    objConexao.SqlCmd.Parameters.AddWithValue("@obsPessoa", objPessoa.PessoaFisica.Observacao);
                    objConexao.SqlCmd.Parameters.AddWithValue("@fiado", objPessoa.PessoaFisica.Fiado);

                    

                    objConexao.iniciarTransacao();
                    //Fazer o insert da Fisica ou Juridica
                    if (objPessoa.PessoaFisica.TipoPessoa.Equals("F"))
                    {
                        strSQL = "INSERT INTO tbFisica(codpessoa, fis_cpf, fis_rg, fis_datanascimento) ";
                        strSQL += "VALUES(@codPessoa, @cpf, @rg, @dataNascimento)";

                        objConexao.SqlCmd = new NpgsqlCommand(strSQL);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codPessoa", cod);
                        objConexao.SqlCmd.Parameters.AddWithValue("@cpf", objPessoa.PessoaFisica.CPF);
                        objConexao.SqlCmd.Parameters.AddWithValue("@rg", objPessoa.PessoaFisica.RG);
                        objConexao.SqlCmd.Parameters.AddWithValue("@dataNascimento", objPessoa.PessoaFisica.Nascimento);

                        objConexao.executarComando();

                    }
                    else
                    {
                        strSQL = "INSERT INTO tbjuridica(codpessoa, jur_razaosocial, jur_fantasia, jur_inscricaoestadual) ";
                        strSQL += "VALUES(@codpessoa, @jur_razaosocial, @jur_fantasia)";

                        objConexao.SqlCmd = new NpgsqlCommand(strSQL);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codpessoa", cod);
                        objConexao.SqlCmd.Parameters.AddWithValue("@jur_razaosocial", objPessoa.PessoaJuridica.RazaoSocial);
                        objConexao.SqlCmd.Parameters.AddWithValue("@jur_fantasia", objPessoa.PessoaJuridica.NomeFantasia);
                        

                        objConexao.executarComando();

                    }

                    //Fazer o insert dos Endereços
                    foreach (var item in objPessoa.ListaEndereco)
                    {
                        //COLOCAR CO CODPESSOA
                        strSQL = "INSERT INTO tbEndereco(end_cep, end_logradouro, end_numero, end_bairro, end_complemento, codcidade, coduf, codPessoa) ";
                        strSQL += "VALUES(@codPessoa, @cep, @logradouro, @numero, @bairro, @complemento, @codcidade, @coduf)";

                        objConexao.SqlCmd = new NpgsqlCommand(strSQL);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codPessoa", cod);
                        objConexao.SqlCmd.Parameters.AddWithValue("@cep", item._cep);
                        objConexao.SqlCmd.Parameters.AddWithValue("@logradouro", item._logradouro);
                        objConexao.SqlCmd.Parameters.AddWithValue("@numero", item._numero);
                        objConexao.SqlCmd.Parameters.AddWithValue("@bairro", item._bairro);
                        objConexao.SqlCmd.Parameters.AddWithValue("@complemento", item._complemento);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codcidade", item._codCidade);
                        objConexao.SqlCmd.Parameters.AddWithValue("@coduf", item._codUf);


                        objConexao.executarComando();
                    }
                    //Fazer insert dos Contatos
                    foreach (var item in objPessoa.ListaContato)
                    {
                        //COLOCAR CO CODPESSOA
                        strSQL = "INSERT INTO tbEndereco(cont_telefone, cont_celular, cont_email, codpessoa)";
                        strSQL += "VALUES(@cont_telefone, @cont_celular, @cont_email, @codpessoa)";

                        objConexao.SqlCmd = new NpgsqlCommand(strSQL);
                        objConexao.SqlCmd.Parameters.AddWithValue("@cont_telefone", item._telefone);
                        objConexao.SqlCmd.Parameters.AddWithValue("@cont_celular", item._celular);
                        objConexao.SqlCmd.Parameters.AddWithValue("@cont_email", item._email);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codpessoa", cod);



                        objConexao.executarComando();
                    }

                    objConexao.commitTransacao();
                    return 1;
                }
                else // Alteração
                {

                }

               
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
