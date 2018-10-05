using HairLumos.Banco;
using HairLumos.Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.DAO
{
    public class PessoaDAO
    {
        private string _sql;

        public PessoaDAO()
        {
            this._sql = string.Empty;
        }


        //    //public int GravarPessoa(Pessoa objPessoa)
        //    //{
        //    //    int intRetorno = 0;

        //    //    string strSQL = "";
        //    //    Conexao objConexao = null;
        //    //    try
        //    //    {
        //    //        if(objPessoa.Codigo == 0)
        //    //        {
        //    //            objConexao = new Conexao();


        //    //            //Fazer o Insert da pessoa
        //    //            strSQL = "INSERT INTO tbPessoa(pes_nomepessoa, pes_datacadastro, pes_tipopessoa, pes_statuspessoa, pes_obspessoa, pes_fiado)";
        //    //            strSQL += " VALUES(@nomePessoa, @dataCadastro, @tipoPessoa, @statusPessoa, @obsPessoa, @fiado); RETURNING codpessoa";
        //    //            objConexao.SqlCmd = new NpgsqlCommand(strSQL);

        //    //            objConexao.SqlCmd.Parameters.AddWithValue("@nomePessoa", objPessoa.PessoaFisica.Nome);
        //    //            objConexao.SqlCmd.Parameters.AddWithValue("@dataCadastro", objPessoa.PessoaFisica.DataCadastro);
        //    //            objConexao.SqlCmd.Parameters.AddWithValue("@tipoPessoa", objPessoa.PessoaFisica.TipoPessoa);
        //    //            objConexao.SqlCmd.Parameters.AddWithValue("@statusPessoa", true);
        //    //            objConexao.SqlCmd.Parameters.AddWithValue("@obsPessoa", objPessoa.PessoaFisica.Observacao);
        //    //            objConexao.SqlCmd.Parameters.AddWithValue("@fiado", objPessoa.PessoaFisica.Fiado);


        //    //            int cod = (int)objConexao.SqlCmd.ExecuteScalar();
        //    //            if (cod <= 0)
        //    //            {
        //    //                return -1;
        //    //            }

        //    //            objConexao.iniciarTransacao();
        //    //            //Fazer o insert da Fisica ou Juridica
        //    //            if (objPessoa.PessoaFisica.TipoPessoa.Equals("F"))
        //    //            {
        //    //                strSQL = "INSERT INTO tbFisica(codpessoa, fis_cpf, fis_rg, fis_datanascimento) ";
        //    //                strSQL += "VALUES(@codPessoa, @cpf, @rg, @dataNascimento)";

        //    //                objConexao.SqlCmd = new NpgsqlCommand(strSQL);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@codPessoa", cod);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@cpf", objPessoa.PessoaFisica.CPF);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@rg", objPessoa.PessoaFisica.RG);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@dataNascimento", objPessoa.PessoaFisica.Nascimento);

        //    //                objConexao.executarComando();

        //    //            }
        //    //            else
        //    //            {
        //    //                strSQL = "INSERT INTO tbjuridica(codpessoa, jur_razaosocial, jur_fantasia, jur_inscricaoestadual) ";
        //    //                strSQL += "VALUES(@codpessoa, @jur_razaosocial, @jur_fantasia)";

        //    //                objConexao.SqlCmd = new NpgsqlCommand(strSQL);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@codpessoa", cod);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@jur_razaosocial", objPessoa.PessoaJuridica.RazaoSocial);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@jur_fantasia", objPessoa.PessoaJuridica.NomeFantasia);


        //    //                objConexao.executarComando();

        //    //            }

        //    //            //Fazer o insert dos Endereços
        //    //            foreach (var item in objPessoa.ListaEndereco)
        //    //            {
        //    //                //COLOCAR CO CODPESSOA
        //    //                strSQL = "INSERT INTO tbEndereco(end_cep, end_logradouro, end_numero, end_bairro, end_complemento, codcidade, coduf, codPessoa) ";
        //    //                strSQL += "VALUES(@codPessoa, @cep, @logradouro, @numero, @bairro, @complemento, @codcidade, @coduf)";

        //    //                objConexao.SqlCmd = new NpgsqlCommand(strSQL);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@codPessoa", cod);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@cep", item._cep);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@logradouro", item._logradouro);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@numero", item._numero);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@bairro", item._bairro);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@complemento", item._complemento);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@codcidade", item._codCidade);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@coduf", item._codUf);


        //    //                objConexao.executarComando();
        //    //            }
        //    //            //Fazer insert dos Contatos
        //    //            foreach (var item in objPessoa.ListaContato)
        //    //            {
        //    //                //COLOCAR CO CODPESSOA
        //    //                strSQL = "INSERT INTO tbEndereco(cont_telefone, cont_celular, cont_email, codpessoa)";
        //    //                strSQL += "VALUES(@cont_telefone, @cont_celular, @cont_email, @codpessoa)";

        //    //                objConexao.SqlCmd = new NpgsqlCommand(strSQL);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@cont_telefone", item._telefone);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@cont_celular", item._celular);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@cont_email", item._email);
        //    //                objConexao.SqlCmd.Parameters.AddWithValue("@codpessoa", cod);



        //    //                objConexao.executarComando();
        //    //            }

        //    //            objConexao.commitTransacao();
        //    //            return 1;
        //    //        }
        //    //        else // Alteração
        //    //        {

        //    //        }


        //    //    }
        //    //    catch (Exception e)
        //    //    {
        //    //        objConexao?.rollbackTransacao();
        //    //    }
        //    //    finally
        //    //    {
        //    //        objConexao?.fecharConexao();
        //    //    }

        //    //    return intRetorno;
        //    //}
        //}


        public int GravaPessoa(PessoaFisica objPessoa)
        {
            int intRetorno = 0;

            string strSQL = "";
            Conexao objConexao = null;
            try
            {

                objConexao = new Conexao();


                //Fazer o Insert da pessoa
                strSQL = "INSERT INTO tbPessoa(pes_nome, pes_datacadastro, pes_tipopessoa, pes_statuspessoa, pes_obs, pes_fiado, pes_email)";
                strSQL += " VALUES(@nomePessoa, @dataCadastro, @tipoPessoa, @statusPessoa, @obsPessoa, @fiado, @email); SELECT MAX(codpessoa) FROM tbpessoa;";
                //objConexao.SqlCmd = new NpgsqlCommand(strSQL);

                objConexao.SqlCmd.CommandText = strSQL;
                objConexao.SqlCmd.Parameters.AddWithValue("@nomePessoa", objPessoa.Nome);
                objConexao.SqlCmd.Parameters.AddWithValue("@dataCadastro", objPessoa.DataCadastro);
                objConexao.SqlCmd.Parameters.AddWithValue("@tipoPessoa", objPessoa.TipoPessoa);
                objConexao.SqlCmd.Parameters.AddWithValue("@statusPessoa", objPessoa.StatusPessoa);
                objConexao.SqlCmd.Parameters.AddWithValue("@obsPessoa", objPessoa.Observacao);
                objConexao.SqlCmd.Parameters.AddWithValue("@fiado", objPessoa.Fiado);
                objConexao.SqlCmd.Parameters.AddWithValue("@email", objPessoa.Email);



                objConexao.iniciarTransacao();
                objConexao.AutoConexao = false;

                int cod = (int)objConexao.executarScalar();
                //int cod = 0;
                //objConexao.executarComando();
                if (cod <= 0)
                {
                    return -1;
                }

                //Fazer o insert da Fisica ou Juridica

                strSQL = "INSERT INTO tbFisica(codpessoa, fis_cpf, fis_rg, fis_datanascimento) ";
                strSQL += "VALUES(@codPessoa, @cpf, @rg, @dataNascimento)";

                objConexao.SqlCmd.Parameters.Clear();
                objConexao.SqlCmd.CommandText = strSQL;

                objConexao.SqlCmd.Parameters.AddWithValue("@codPessoa", cod);
                objConexao.SqlCmd.Parameters.AddWithValue("@cpf", objPessoa.CPF);
                objConexao.SqlCmd.Parameters.AddWithValue("@rg", objPessoa.RG);
                objConexao.SqlCmd.Parameters.AddWithValue("@dataNascimento", objPessoa.Nascimento);

                if (!objConexao.executarComando())
                    return -1;


                if (objPessoa.ListaEndereco != null)
                {
                    //Fazer o insert dos Endereços
                    foreach (var item in objPessoa.ListaEndereco)
                    {
                        //COLOCAR CO CODPESSOA
                        strSQL = "INSERT INTO tbendereco(end_cep, end_logradouro, end_numero, end_bairro, edn_complemento, codcidade, coduf, codPessoa) ";
                        strSQL += "VALUES(@cep, @logradouro, @numero, @bairro, @complemento, @codcidade, @coduf, @codPessoa)";

                        objConexao.SqlCmd.Parameters.Clear();
                        objConexao.SqlCmd.CommandText = strSQL;

                        objConexao.SqlCmd.Parameters.AddWithValue("@cep", item._cep);
                        objConexao.SqlCmd.Parameters.AddWithValue("@logradouro", item._logradouro);
                        objConexao.SqlCmd.Parameters.AddWithValue("@numero", item._numero);
                        objConexao.SqlCmd.Parameters.AddWithValue("@bairro", item._bairro);
                        objConexao.SqlCmd.Parameters.AddWithValue("@complemento", item._complemento);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codcidade", NpgsqlTypes.NpgsqlDbType.Integer, item._codCidade);
                        objConexao.SqlCmd.Parameters.AddWithValue("@coduf", NpgsqlTypes.NpgsqlDbType.Integer, item._codUf);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codPessoa", cod);


                        if (!objConexao.executarComando())
                            return -1;
                    }
                }

                if (objPessoa.ListaContato != null)
                {
                    //Fazer insert dos Contatos
                    foreach (var item in objPessoa.ListaContato)
                    {
                        //COLOCAR CO CODPESSOA
                        strSQL = "INSERT INTO tbcontato(cont_telefone, cont_tipofone,codpessoa) ";
                        strSQL += " VALUES(@cont_telefone, @tipofone, @codpessoa)";

                        objConexao.SqlCmd.Parameters.Clear();
                        objConexao.SqlCmd.CommandText = strSQL;

                        objConexao.SqlCmd.Parameters.AddWithValue("@cont_telefone", item._telefone);
                        objConexao.SqlCmd.Parameters.AddWithValue("@tipofone", item._tipo);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codPessoa", cod);

                        if (!objConexao.executarComando())
                            return -1;
                    }
                }


                objConexao.commitTransacao();
                return 1;


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


        public int GravaPessoa(PessoaJuridica objPessoa)
        {
            int intRetorno = 0;

            string strSQL = "";
            Conexao objConexao = null;
            try
            {

                objConexao = new Conexao();


                //Fazer o Insert da pessoa
                strSQL = "INSERT INTO tbPessoa(pes_nome, pes_datacadastro, pes_tipopessoa, pes_statuspessoa, pes_obs, pes_fiado, pes_email)";
                strSQL += " VALUES(@nomePessoa, @dataCadastro, @tipoPessoa, @statusPessoa, @obsPessoa, @fiado, @email); SELECT MAX(codpessoa) FROM tbpessoa;";
                //objConexao.SqlCmd = new NpgsqlCommand(strSQL);

                objConexao.SqlCmd.CommandText = strSQL;
                objConexao.SqlCmd.Parameters.AddWithValue("@nomePessoa", objPessoa.Nome);
                objConexao.SqlCmd.Parameters.AddWithValue("@dataCadastro", objPessoa.DataCadastro);
                objConexao.SqlCmd.Parameters.AddWithValue("@tipoPessoa", objPessoa.TipoPessoa);
                objConexao.SqlCmd.Parameters.AddWithValue("@statusPessoa", objPessoa.StatusPessoa);
                objConexao.SqlCmd.Parameters.AddWithValue("@obsPessoa", objPessoa.Observacao);
                objConexao.SqlCmd.Parameters.AddWithValue("@fiado", objPessoa.Fiado);
                objConexao.SqlCmd.Parameters.AddWithValue("@email", objPessoa.Email);



                objConexao.iniciarTransacao();
                objConexao.AutoConexao = false;

                int cod = (int)objConexao.executarScalar();
                //int cod = 0;
                //objConexao.executarComando();
                if (cod <= 0)
                {
                    return -1;
                }

                //Fazer o insert da Fisica ou Juridica

                strSQL = "INSERT INTO tbjuridica(codpessoa, jur_cnpj, jur_razaosocial, jur_fantasia) ";
                strSQL += "VALUES(@codPessoa, @cnpj, @razao, @fantasia)";

                objConexao.SqlCmd.Parameters.Clear();
                objConexao.SqlCmd.CommandText = strSQL;

                objConexao.SqlCmd.Parameters.AddWithValue("@codPessoa", cod);
                objConexao.SqlCmd.Parameters.AddWithValue("@cnpj", objPessoa.CNPJ);
                objConexao.SqlCmd.Parameters.AddWithValue("@razao", objPessoa.RazaoSocial);
                objConexao.SqlCmd.Parameters.AddWithValue("@fantasia", objPessoa.NomeFantasia);

                if (!objConexao.executarComando())
                    return -1;




                if (objPessoa.ListaEndereco != null)
                {
                    //Fazer o insert dos Endereços
                    foreach (var item in objPessoa.ListaEndereco)
                    {
                        //COLOCAR CO CODPESSOA
                        strSQL = "INSERT INTO tbendereco(end_cep, end_logradouro, end_numero, end_bairro, edn_complemento, codcidade, coduf, codPessoa) ";
                        strSQL += "VALUES(@cep, @logradouro, @numero, @bairro, @complemento, @codcidade, @coduf, @codPessoa)";

                        objConexao.SqlCmd.Parameters.Clear();
                        objConexao.SqlCmd.CommandText = strSQL;


                        objConexao.SqlCmd.Parameters.AddWithValue("@cep", item._cep);
                        objConexao.SqlCmd.Parameters.AddWithValue("@logradouro", item._logradouro);
                        objConexao.SqlCmd.Parameters.AddWithValue("@numero", item._numero);
                        objConexao.SqlCmd.Parameters.AddWithValue("@bairro", item._bairro);
                        objConexao.SqlCmd.Parameters.AddWithValue("@complemento", item._complemento);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codcidade", NpgsqlTypes.NpgsqlDbType.Integer, item._codCidade);
                        objConexao.SqlCmd.Parameters.AddWithValue("@coduf", NpgsqlTypes.NpgsqlDbType.Integer, item._codUf);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codPessoa", cod);


                        if (!objConexao.executarComando())
                            return -1;
                    }
                }

                if (objPessoa.ListaContato != null)
                {
                    //Fazer insert dos Contatos
                    foreach (var item in objPessoa.ListaContato)
                    {
                        //COLOCAR CO CODPESSOA
                        strSQL = "INSERT INTO tbcontato(cont_telefone, cont_tipofone,codpessoa) ";
                        strSQL += "VALUES(@cont_telefone, @tipofone, @codpessoa)";

                        objConexao.SqlCmd.Parameters.Clear();
                        objConexao.SqlCmd.CommandText = strSQL;

                        objConexao.SqlCmd.Parameters.AddWithValue("@cont_telefone", item._telefone);
                        objConexao.SqlCmd.Parameters.AddWithValue("@tipofone", item._tipo);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codpessoa", cod);



                        if (!objConexao.executarComando())
                            return -1;
                    }
                }


                objConexao.commitTransacao();
                return 1;


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

        public int alteraPessoaFisica(PessoaFisica obj)
        {
            int intRetorno = 0;

            string strSQL = "";
            Conexao objConexao = null;
            try
            {

                objConexao = new Conexao();


                //Fazer o Insert da pessoa
                strSQL = "UPDATE tbPessoa SET pes_nome = @nomePessoa, pes_datacadastro =  @dataCadastro, pes_tipopessoa = @tipoPessoa, pes_statuspessoa = @statusPessoa, pes_obs = @obsPessoa, pes_fiado = @fiado, pes_email = @email WHERE codpessoa = @codigo;";
                //objConexao.SqlCmd = new NpgsqlCommand(strSQL);

                objConexao.SqlCmd.CommandText = strSQL;
                objConexao.SqlCmd.Parameters.AddWithValue("@nomePessoa", obj.Nome);
                objConexao.SqlCmd.Parameters.AddWithValue("@dataCadastro", obj.DataCadastro);
                objConexao.SqlCmd.Parameters.AddWithValue("@tipoPessoa", obj.TipoPessoa);
                objConexao.SqlCmd.Parameters.AddWithValue("@statusPessoa", obj.StatusPessoa);
                objConexao.SqlCmd.Parameters.AddWithValue("@obsPessoa", obj.Observacao);
                objConexao.SqlCmd.Parameters.AddWithValue("@fiado", obj.Fiado);
                objConexao.SqlCmd.Parameters.AddWithValue("@email", obj.Email);
                objConexao.SqlCmd.Parameters.AddWithValue("@codigo", obj.Codigo);


                objConexao.iniciarTransacao();
                objConexao.AutoConexao = false;

                if (!objConexao.executarComando())
                    return -1;

                //Fazer o insert da Fisica ou Juridica

                strSQL = "UPDATE tbFisica SET fis_cpf = @cpf, fis_rg = @rg, fis_datanascimento = @dataNascimento where codpessoa = @codPessoa;";

                objConexao.SqlCmd.Parameters.Clear();
                objConexao.SqlCmd.CommandText = strSQL;


                objConexao.SqlCmd.Parameters.AddWithValue("@cpf", obj.CPF);
                objConexao.SqlCmd.Parameters.AddWithValue("@rg", obj.RG);
                objConexao.SqlCmd.Parameters.AddWithValue("@dataNascimento", obj.Nascimento);
                objConexao.SqlCmd.Parameters.AddWithValue("@codPessoa", obj.Codigo);

                if (!objConexao.executarComando())
                    return -1;




                if (obj.ListaEndereco != null)
                {
                    //Fazer o insert dos Endereços
                    foreach (var item in obj.ListaEndereco)
                    {
                        //COLOCAR CO CODPESSOA
                        strSQL = "UPDATE tbendereco SET end_cep = @cep, end_logradouro = @logradouro, end_numero = @numero, end_bairro = @bairro, edn_complemento = @complemento, codcidade = @codcidade, coduf = @coduf WHERE codpessoa = @codPessoa;";


                        objConexao.SqlCmd.Parameters.Clear();
                        objConexao.SqlCmd.CommandText = strSQL;


                        objConexao.SqlCmd.Parameters.AddWithValue("@cep", item._cep);
                        objConexao.SqlCmd.Parameters.AddWithValue("@logradouro", item._logradouro);
                        objConexao.SqlCmd.Parameters.AddWithValue("@numero", item._numero);
                        objConexao.SqlCmd.Parameters.AddWithValue("@bairro", item._bairro);
                        objConexao.SqlCmd.Parameters.AddWithValue("@complemento", item._complemento);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codcidade", NpgsqlTypes.NpgsqlDbType.Integer, item._codCidade);
                        objConexao.SqlCmd.Parameters.AddWithValue("@coduf", NpgsqlTypes.NpgsqlDbType.Integer, item._codUf);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codPessoa", obj.Codigo);


                        if (!objConexao.executarComando())
                            return -1;
                    }
                }

                if (obj.ListaContato != null)
                {
                    //Fazer insert dos Contatos
                    foreach (var item in obj.ListaContato)
                    {
                        //COLOCAR CO CODPESSOA
                        strSQL = "UPDATE tbcontato SET cont_telefone = @cont_telefone, cont_tipofone = @tipofone WHERE codpessoa = @codpessoa;";


                        objConexao.SqlCmd.Parameters.Clear();
                        objConexao.SqlCmd.CommandText = strSQL;

                        objConexao.SqlCmd.Parameters.AddWithValue("@cont_telefone", item._telefone);
                        objConexao.SqlCmd.Parameters.AddWithValue("@tipofone", item._tipo);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codpessoa", obj.Codigo);

                        if (!objConexao.executarComando())
                            return -1;
                    }
                }


                objConexao.commitTransacao();
                return 1;


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

        public int alteraPessoaJuridica(PessoaJuridica obj)
        {
            int intRetorno = 0;

            string strSQL = "";
            Conexao objConexao = null;
            try
            {

                objConexao = new Conexao();


                //Fazer o Insert da pessoa
                strSQL = "UPDATE tbPessoa SET pes_nome = @nomePessoa, pes_datacadastro =  @dataCadastro, pes_tipopessoa = @tipoPessoa, pes_statuspessoa = @statusPessoa, pes_obs = @obsPessoa, pes_fiado = @fiado, pes_email = @email WHERE codpessoa = @codigo;";
                //objConexao.SqlCmd = new NpgsqlCommand(strSQL);

                objConexao.SqlCmd.CommandText = strSQL;
                objConexao.SqlCmd.Parameters.AddWithValue("@nomePessoa", obj.Nome);
                objConexao.SqlCmd.Parameters.AddWithValue("@dataCadastro", obj.DataCadastro);
                objConexao.SqlCmd.Parameters.AddWithValue("@tipoPessoa", obj.TipoPessoa);
                objConexao.SqlCmd.Parameters.AddWithValue("@statusPessoa", obj.StatusPessoa);
                objConexao.SqlCmd.Parameters.AddWithValue("@obsPessoa", obj.Observacao);
                objConexao.SqlCmd.Parameters.AddWithValue("@fiado", obj.Fiado);
                objConexao.SqlCmd.Parameters.AddWithValue("@email", obj.Email);
                objConexao.SqlCmd.Parameters.AddWithValue("@codigo", obj.Codigo);


                objConexao.iniciarTransacao();
                objConexao.AutoConexao = false;

                //Fazer o insert da Fisica ou Juridica

                strSQL = "UPDATE tbjuridica SET jur_cnpj = @cnpj, jur_razaosocial = @razao, jur_fantasia = @fantasia  where codpessoa = @codPessoa;";

                objConexao.SqlCmd.Parameters.Clear();
                objConexao.SqlCmd.CommandText = strSQL;

                objConexao.SqlCmd.Parameters.AddWithValue("@codPessoa", obj.Codigo);
                objConexao.SqlCmd.Parameters.AddWithValue("@cnpj", obj.CNPJ);
                objConexao.SqlCmd.Parameters.AddWithValue("@razao", obj.RazaoSocial);
                objConexao.SqlCmd.Parameters.AddWithValue("@fantasia", obj.NomeFantasia);

                if (!objConexao.executarComando())
                    return -1;




                if (obj.ListaEndereco != null)
                {
                    //Fazer o insert dos Endereços
                    foreach (var item in obj.ListaEndereco)
                    {
                        //COLOCAR CO CODPESSOA
                        strSQL = "UPDATE tbendereco SET end_cep = @cep, end_logradouro = @logradouro, end_numero = @numero, end_bairro = @bairro, edn_complemento = @complemento, codcidade = @codcidade, coduf = @coduf WHERE codpessoa = @codPessoa;";


                        objConexao.SqlCmd.Parameters.Clear();
                        objConexao.SqlCmd.CommandText = strSQL;


                        objConexao.SqlCmd.Parameters.AddWithValue("@cep", item._cep);
                        objConexao.SqlCmd.Parameters.AddWithValue("@logradouro", item._logradouro);
                        objConexao.SqlCmd.Parameters.AddWithValue("@numero", item._numero);
                        objConexao.SqlCmd.Parameters.AddWithValue("@bairro", item._bairro);
                        objConexao.SqlCmd.Parameters.AddWithValue("@complemento", item._complemento);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codcidade", NpgsqlTypes.NpgsqlDbType.Integer, item._codCidade);
                        objConexao.SqlCmd.Parameters.AddWithValue("@coduf", NpgsqlTypes.NpgsqlDbType.Integer, item._codUf);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codPessoa", obj.Codigo);


                        if (!objConexao.executarComando())
                            return -1;
                    }
                }

                if (obj.ListaContato != null)
                {
                    //Fazer insert dos Contatos
                    foreach (var item in obj.ListaContato)
                    {
                        //COLOCAR CO CODPESSOA
                        strSQL = "UPDATE tbcontato SET cont_telefone = @cont_telefone, cont_tipofone = @tipofone WHERE codpessoa = @codpessoa;";


                        objConexao.SqlCmd.Parameters.Clear();
                        objConexao.SqlCmd.CommandText = strSQL;

                        objConexao.SqlCmd.Parameters.AddWithValue("@cont_telefone", item._telefone);
                        objConexao.SqlCmd.Parameters.AddWithValue("@tipofone", item._tipo);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codpessoa", obj.Codigo);

                        if (!objConexao.executarComando())
                            return -1;
                    }
                }


                objConexao.commitTransacao();
                return 1;


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

        public int deletaPessoaFisica(PessoaFisica obj)
        {
            int intRetorno = 0;
            //int intRetorno = 0 x

            //     ,2+*--------------------------------------;

            string strSQL = "";
            Conexao objConexao = null;
            try
            {
                objConexao = new Conexao();
                
                //Fazer o delete da Fisica ou Juridica

                strSQL = "DELETE FROM tbFisica WHERE codpessoa = @codPessoa;";
                objConexao.SqlCmd.CommandText = strSQL;
                objConexao.SqlCmd.Parameters.AddWithValue("@codPessoa", obj.Codigo);

                objConexao.iniciarTransacao();
                objConexao.AutoConexao = false;

                if (!objConexao.executarComando())
                    return -1;

                if (obj.ListaEndereco != null)
                {
                    //Fazer o insert dos Endereços
                    foreach (var item in obj.ListaEndereco)
                    {
                        //COLOCAR CO CODPESSOA
                        strSQL = "DELETE FROM tbendereco WHERE codpessoa = @codPessoa;";


                        objConexao.SqlCmd.Parameters.Clear();
                        objConexao.SqlCmd.CommandText = strSQL;

                        objConexao.SqlCmd.Parameters.AddWithValue("@codPessoa", obj.Codigo);


                        if (!objConexao.executarComando())
                            return -1;
                    }
                }

                if (obj.ListaContato != null)
                {
                    //Fazer insert dos Contatos
                    foreach (var item in obj.ListaContato)
                    {
                        //COLOCAR CO CODPESSOA
                        strSQL = "DELETE FROM tbcontato WHERE codpessoa = @codpessoa;";


                        objConexao.SqlCmd.Parameters.Clear();
                        objConexao.SqlCmd.CommandText = strSQL;
                        objConexao.SqlCmd.Parameters.AddWithValue("@codpessoa", obj.Codigo);

                        if (!objConexao.executarComando())
                            return -1;
                    }
                }

                //Fazer o Insert da pessoa
                strSQL = "DELETE FROM tbPessoa WHERE codpessoa = @codigo;";
                //objConexao.SqlCmd = new NpgsqlCommand(strSQL);
                objConexao.SqlCmd.Parameters.Clear();
                objConexao.SqlCmd.CommandText = strSQL;
                objConexao.SqlCmd.Parameters.AddWithValue("@codigo", obj.Codigo);

                if (!objConexao.executarComando())
                    return -1;


                objConexao.commitTransacao();
                return 1;
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

        public DataTable RetornaPessoa(string texto)
        {
            DataTable dt = new DataTable();


            _sql = "SELECT codpessoa, pes_nome, pes_datacadastro, pes_tipopessoa, pes_statuspessoa," +
                        "pes_obs, pes_fiado, pes_email" +
                      " FROM tbpessoa";

            if (texto != null && texto != "")
                _sql += $" WHERE UPPER(pes_nome) LIKE @pes_nome";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                if (texto != null && texto != "")
                    cmd.Parameters.AddWithValue("@pes_nome", texto.ToUpper());

                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw;
            }
            return dt;
        }

        public DataTable RetornaPessoaCod(string cod) //string Texto
        {
            DataTable dt = new DataTable();


            _sql = "SELECT codpessoa, pes_nome, pes_datacadastro, pes_tipopessoa, pes_statuspessoa," +
                        "pes_obs, pes_fiado, pes_email" +
                      " FROM tbpessoa WHERE codpessoa =" + cod;


            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@cod", cod);

                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw;
            }
            return dt;
        }

        public DataTable RetornaCPF(string cpf) //string Texto
        {
            DataTable dt = new DataTable();


            _sql = "SELECT codpessoa, fis_cpf  " +
                    "FROM tbfisica" +
                      " WHERE  fis_cpf = '"+cpf+"'";


            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;

                cmd.Parameters.AddWithValue("@codpessoa");
                cmd.Parameters.AddWithValue("@fis_cpf");
                

                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw;
            }
            return dt;
        }

        public DataTable RetornaPessoaFisicaCod(int cod) //string Texto
        {
            DataTable dt = new DataTable();


            _sql = "SELECT codpessoa, fis_cpf, fis_rg, fis_datanascimento" +
                            " FROM tbfisica WHERE codpessoa =" + cod;


            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@cod", cod);

                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw;
            }
            return dt;
        }

        public DataTable RetornaPessoaFisica()
        {
            DataTable dt = new DataTable();


            _sql = "SELECT codpessoa, pes_nome, pes_datacadastro, pes_tipopessoa, pes_statuspessoa," +
                    "pes_obs, pes_fiado, pes_email  FROM tbpessoa WHERE pes_tipopessoa = 'FISICA' ";


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

                throw;
            }
            return dt;
        }


        public DataTable RetornaPessoaJuridicaCod(int cod) //string Texto
        {
            DataTable dt = new DataTable();


            _sql = "SELECT codpessoa, jur_cnpj, jur_razaosocial, jur_fantasia" +
                      " FROM tbjuridica WHERE @cod =" + cod;


            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@cod", cod);

                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw;
            }
            return dt;
        }

        public DataTable RetornaPessoaJuridicaCod(string texto) //string Texto
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codpessoa, jur_cnpj, jur_razaosocial, jur_fantasia" +
                      " FROM tbjuridica";

            if (texto != null && texto != "")
                _sql += $" WHERE UPPER(jur_fantasia) LIKE @jur_fantasia";


            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                if (texto != null && texto != "")
                    cmd.Parameters.AddWithValue("@jur_fantasia", texto.ToUpper());

                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw;
            }
            return dt;
        }

        public DataTable RetornaCidades(int estado)
        {
            DataTable dt = new DataTable();


            _sql = "SELECT * FROM tbcidade WHERE coduf =" + estado;


            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("coduf", estado);

                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader



            }
            catch (Exception e)
            {

                throw;
            }
            return dt;
        }

        public DataTable RetornaEstado()
        {

            DataTable dt = new DataTable();


            _sql = "SELECT * FROM tbestado";


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

                throw;
            }
            return dt;
        }

        public DataTable RetornaContato(int codigo)
        {
            DataTable dt = new DataTable();


            _sql = "SELECT cont_telefone FROM tbcontato WHERE codpessoa = "+codigo;

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@cont_telefone");

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

        public DataTable RetornaEndereco(int codigo)
        {
            DataTable dt = new DataTable();


            _sql = "SELECT * FROM tbendereco WHERE codpessoa =" + codigo;


            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("codpessoa", codigo);

                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader



            }
            catch (Exception e)
            {

                throw;
            }
            return dt;
        }


    }
}


