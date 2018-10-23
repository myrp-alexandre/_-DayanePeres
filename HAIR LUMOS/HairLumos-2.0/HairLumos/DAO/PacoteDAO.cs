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
    /*
     * Inset into tb () values() RETURNING codServico INTO: codRetorno";
     * */

    class PacoteDAO
    {
        private string _sql;

        public PacoteDAO()
        {
            this._sql = string.Empty;
        }


        public int GravarPacote(Entidades.Pacote _pacote)
        {

            //NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

            int intRetorno = 0;

            string strSQL = "";
            Conexao objConexao = null;
            //int _controle = 0;
            try
            {
                objConexao = new Conexao();

                if (_pacote.Codigo == 0)
                {
                    _sql = "INSERT INTO tbpacote" +
                        "(pac_pacote, pac_valor, pac_obs, pac_periodicidade, pac_datainicio, pac_datafim)" +
                        " VALUES(@pacote, @valor, @obs, @periodo, @dtIni, @dtFim); SELECT MAX(codpacote) FROM tbpacote;";

                }
                else
                {
                    _sql = "UPDATE tbpacote" +
                            " SET pac_pacote = @pacote, pac_valor = @valor, pac_obs = @obs, pac_periodicidade = @periodo, pac_datainicio = @dtIni, pac_datafim = @dtFim" +
                        " WHERE codpacote = @codigo";
                }

                objConexao.SqlCmd.CommandText = _sql;
                objConexao.SqlCmd.Parameters.AddWithValue("@codigo", _pacote.Codigo);
                objConexao.SqlCmd.Parameters.AddWithValue("@pacote", _pacote.PaccoteNome);
                objConexao.SqlCmd.Parameters.AddWithValue("@valor", _pacote.Valor);
                objConexao.SqlCmd.Parameters.AddWithValue("@obs", _pacote.Observacao);
                objConexao.SqlCmd.Parameters.AddWithValue("@periodo", _pacote.Periodo);
                objConexao.SqlCmd.Parameters.AddWithValue("@dtIni", _pacote.DataInicio);
                objConexao.SqlCmd.Parameters.AddWithValue("@dtFim", _pacote.DataFim);


                objConexao.iniciarTransacao();
                objConexao.AutoConexao = false;

                int cod = (int)objConexao.executarScalar();
                if (cod <= 0)
                {
                    return -1;
                }

                if (_pacote.ListaServico != null)
                {
                    //Fazer o insert dos Endereços
                    foreach (var item in _pacote.ListaServico)
                    {
                        
                        strSQL = "INSERT INTO tbpacoteservico(codpacote,codtiposervico,pacserv_qtde, pacServ_periodicidade, pacserv_valor) ";
                        strSQL += "VALUES(@codpacote, @codServico, @qtde, @periodicidade, @valorP)";

                        objConexao.SqlCmd.Parameters.Clear();
                        objConexao.SqlCmd.CommandText = strSQL;

                        objConexao.SqlCmd.Parameters.AddWithValue("@qtde", item.Quantidade);
                        objConexao.SqlCmd.Parameters.AddWithValue("@periodicidade", item.Periodicidade);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codServico", NpgsqlTypes.NpgsqlDbType.Integer, item.Servico.Codigo);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codPacote", cod);
                        objConexao.SqlCmd.Parameters.AddWithValue("@valorP", item.Valor);
                        


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

        public int contratarPacote(Entidades.Contrato contrato)
        {
            int intRetorno = 0;

            string strSQL = "";
            Conexao objConexao = null;
            //int _controle = 0;
            try
            {
                objConexao = new Conexao();

                if (contrato.Codigo == 0)
                {
                    _sql = "INSERT INTO tbcontrato" +
                        "(contra_data, contra_ob, codpacote, fis_cpf)" +
                        " VALUES(@data, @ob, @pacote, @pessoa); SELECT MAX(codcontrato) FROM tbcontrato;";

                }
                else
                {
                    _sql = "UPDATE tbcontrato" +
                            " SET contra_data = @data, contra_ob = @ob, codpacote = @pacote, fis_cpf = @pessoa" +
                        " WHERE codcontrato = @codigo";
                }

                objConexao.SqlCmd.CommandText = _sql;
                objConexao.SqlCmd.Parameters.AddWithValue("@codigo", contrato.Codigo);
                objConexao.SqlCmd.Parameters.AddWithValue("@pacote", contrato.Pacote.Codigo);
                objConexao.SqlCmd.Parameters.AddWithValue("@ob", contrato.Observacao);
                objConexao.SqlCmd.Parameters.AddWithValue("@pessoa", contrato.CodigoPessoa.CPF);
                objConexao.SqlCmd.Parameters.AddWithValue("@data", contrato.DataContrato);


                objConexao.iniciarTransacao();
                objConexao.AutoConexao = false;

                int cod = (int)objConexao.executarScalar();
                if (cod <= 0)
                {
                    return -1;
                }

                if (contrato.Lista != null)
                {
                    //Fazer o insert dos Endereços
                    foreach (var item in contrato.Lista)
                    {

                        strSQL = "INSERT INTO tbpacotesadicionais(codcontrato,codtiposervico,pacadc_qtde, fis_cpf, pacadc_valor, pacadc_obs, pacadc_realizado) ";
                        strSQL += "VALUES(@contrato, @codservico, @qtde, @pessoa, @valor, @obs, @realizado)";

                        objConexao.SqlCmd.Parameters.Clear();
                        objConexao.SqlCmd.CommandText = strSQL;

                        objConexao.SqlCmd.Parameters.AddWithValue("@qtde", item.QtdeServico);
                        objConexao.SqlCmd.Parameters.AddWithValue("@contrato", cod);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codServico", item.Servico.Codigo);
                        objConexao.SqlCmd.Parameters.AddWithValue("@pessoa", contrato.CodigoPessoa.CPF);
                        objConexao.SqlCmd.Parameters.AddWithValue("@valor", contrato.Valor);
                        objConexao.SqlCmd.Parameters.AddWithValue("@obs", contrato.Observacao);
                        objConexao.SqlCmd.Parameters.AddWithValue("@realizado",false);

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

        public DataTable RetornaPacoteCod(int cod)
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codpacote, pac_pacote, pac_valor, pac_obs, pac_periodicidade, pac_datainicio, pac_datafim" +
                        " FROM tbpacote" +
                        " WHERE codpacote = "+cod;


            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codpacote");
                cmd.Parameters.AddWithValue("@pac_pacote");
                cmd.Parameters.AddWithValue("@pac_valor");
                cmd.Parameters.AddWithValue("@pac_obspacote");
                cmd.Parameters.AddWithValue("@pac_periodicidade");
                cmd.Parameters.AddWithValue("@pac_datainicio");
                cmd.Parameters.AddWithValue("@pac_datafim");

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

        public DataTable RetornaPacote()
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codpacote, pac_pacote, pac_valor, pac_obs, pac_periodicidade, pac_datainicio, pac_datafim" +
                        " FROM tbpacote; ";

            
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codpacote");
                cmd.Parameters.AddWithValue("@pac_pacote");
                cmd.Parameters.AddWithValue("@pac_valor");
                cmd.Parameters.AddWithValue("@pac_obspacote");
                cmd.Parameters.AddWithValue("@pac_periodicidade");
                cmd.Parameters.AddWithValue("@pac_datainicio");
                cmd.Parameters.AddWithValue("@pac_datafim"); 

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

        public DataTable RetornaObjPacote(int cod)
        {

            DataTable dt = new DataTable();

            _sql = "SELECT codpacote, pac_pacote, pac_valor, pac_obs, pac_periodicidade, pac_datainicio, pac_datafim " +
                "FROM tbpacote " +
                "WHERE codpacote = " + cod;

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                //cmd.Parameters.AddWithValue("@codpacote");
                //cmd.Parameters.AddWithValue("@pac_pacote");
                //cmd.Parameters.AddWithValue("@pac_valor");
                //cmd.Parameters.AddWithValue("@pac_obspacote");
                //cmd.Parameters.AddWithValue("@pac_periodicidade");
                //cmd.Parameters.AddWithValue("@pac_datainicio");
                //cmd.Parameters.AddWithValue("@pac_datafim");
                //cmd.Parameters.AddWithValue("@cod", cod);

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

        public bool ExcluirPacote(int intCod)
        {
            _sql = "DELETE FROM tbpacote WHERE codpacote = @cod";
            string _sql1 = "DELETE FROM tbpacoteservico WHERE codpacote = @cod";

            int _controle = 0;
            try
            {
                NpgsqlCommand cmd1 = new NpgsqlCommand(_sql1, Conexao.getIntancia().openConn());
                cmd1.Parameters.AddWithValue("@cod", intCod);
                _controle = cmd1.ExecuteNonQuery();
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
                cmd.Parameters.AddWithValue("@cod", intCod);
                _controle = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            return (_controle > 0);
        }

        public DataTable RetornaPacote(string texto)
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codpacote, pac_pacote, pac_valor, pac_obs, pac_periodicidade,  pac_datainicio, pac_datafim " +
                    "FROM tbpacote ";
             if(!string.IsNullOrEmpty(texto))
                    _sql += "WHERE pac_pacote LIKE %" + texto + "%";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codpacote");
                cmd.Parameters.AddWithValue("@pac_pacote");
                cmd.Parameters.AddWithValue("@pac_valor");
                cmd.Parameters.AddWithValue("@pac_obs");
                cmd.Parameters.AddWithValue("@pac_periodicidade");
                cmd.Parameters.AddWithValue("@pac_datainicio");
                cmd.Parameters.AddWithValue("@pac_datafim");


                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao retornar Pacote");
            }
            return dt;
        }

        public DataTable RetornaPacoteServicos(int cod)
        {
            DataTable dt = new DataTable();

            _sql = "SELECT Pacote.codPacote, Pacote.pac_pacote, PacServ.pacServ_qtde, PacServ.pacServ_periodicidade, TipoServ.tipoServ_descricao"+
                        " FROM TbPacote Pacote " +
                        " INNER JOIN TbPacoteServico PacServ on Pacote.codPacote = PacServ.codPacote" +
                        " INNER JOIN TbTipoServico TipoServ on PacServ.codTipoServico = TipoServ.codTipoServico" +
                        " WHERE Pacote.codPacote = " +cod;

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@Pacote.codPacote");
                cmd.Parameters.AddWithValue("@Pacote.pac_pacote");
                cmd.Parameters.AddWithValue("@PacServ.pacServ_qtde");
                cmd.Parameters.AddWithValue("@PacServ.pacServ_periodicidade");
                cmd.Parameters.AddWithValue("@TipoServ.tipoServ_descricao");


                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao retornar Pacote Serviços");
            }
            return dt;
        }


        public DataTable RetornaContrato(string texto)
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codcontrato, contra_data, contra_ob, codpacote, fis_cpf, contra_valor "+
                    "FROM tbcontrato; " +
                    "WHERE pac_pacote LIKE %" + texto + "%";

            int intCodigo = 0;

            int.TryParse(texto, out intCodigo);

            if (intCodigo > 0)
                _sql += $"OR codpacote = @codpacote ";

            // _sql += $"OR UPPER (usu_usuario) LIKE @usu_usuario";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codpacote");
                cmd.Parameters.AddWithValue("@pac_pacote");
                cmd.Parameters.AddWithValue("@pac_valor");
                cmd.Parameters.AddWithValue("@pac_obs");
                cmd.Parameters.AddWithValue("@pac_periodicidade");
                cmd.Parameters.AddWithValue("@pac_datainicio");
                cmd.Parameters.AddWithValue("@pac_datafim");


                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao retornar Pacote");
            }
            return dt;
        }

        public DataTable RetornaContratoServicos()
        {
            DataTable dt = new DataTable();

            _sql = "SELECT c.codContrato, p.codPacote, p.pac_pacote, sum(ps.pacServ_qtde), p.pac_valor, c.fis_cpf"+
                    " FROM tbpacoteservico ps inner join tbpacote p on p.codPacote = ps.codPacote"+
                    " INNER JOIN tbcontrato c on c.codPacote = p.codPacote"+
                    " GROUP BY p.codPacote, ps.codPacote, p.pac_valor, c.codContrato" +
                    " ORDER BY c.codContrato ";


            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@c.codContrato");
                cmd.Parameters.AddWithValue("@p.codPacote");
                cmd.Parameters.AddWithValue("@p.pac_pacote");
                cmd.Parameters.AddWithValue("@sum");
                cmd.Parameters.AddWithValue("@p.pac_valor");
                cmd.Parameters.AddWithValue("@c.fis_cpf");



                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao retornar Contrato.");
            }
            return dt;
        }

        public DataTable RetornaContrato()
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codcontrato, contra_data, contra_ob, codpacote, fis_cpf, contra_valor " +
                       "FROM tbcontrato ";
                    

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codcontrato");
                cmd.Parameters.AddWithValue("@contra_data");
                cmd.Parameters.AddWithValue("@contra_ob");
                cmd.Parameters.AddWithValue("@codpacote");
                cmd.Parameters.AddWithValue("@fis_cpf");
                cmd.Parameters.AddWithValue("@contra_valor");


                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao retornar Contrato");
            }
            return dt;
        }

        public Boolean RetornaContrato(int Cod)
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codcontrato, contra_data, contra_ob, codpacote, fis_cpf, contra_valor " +
                       "FROM tbcontrato "+
                       " WHERE codPacote = "+Cod;


            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader

                if(dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao retornar Contrato");
            }
            return false;
        }

        public DataTable retornaListaPacote(int codigo)
        {
            DataTable dt = new DataTable();
            _sql = "SELECT * FROM tbpacoteservico WHERE codpacote = " + codigo;
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
                cmd.CommandText = _sql;

                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
                return dt;
            }catch(Exception e)
            {
                throw;
            }
        }
    }
}
