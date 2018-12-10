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
    class VendaDAO
    {
        private string _sql;

        public VendaDAO()
        {
            this._sql = string.Empty;
        }

        public int GravaVenda(Entidades.Venda venda)
        {
            int intRetorno = 0;

            string strSQL = "";
            Conexao objConexao = null;
            try
            {

                objConexao = new Conexao();


                //Fazer o Insert da pessoa
                strSQL = "INSERT INTO tbvenda(vend_datavenda, vend_situacao, vend_valortotal, vend_obs, codpessoa)";
                strSQL += " VALUES (@vend_datavenda, @vend_situacao, @vend_valortotal, @vend_obs, @codpessoa); SELECT MAX(codvenda) FROM tbvenda;";
                //objConexao.SqlCmd = new NpgsqlCommand(strSQL);

                objConexao.SqlCmd.CommandText = strSQL;
                objConexao.SqlCmd.Parameters.AddWithValue("@vend_datavenda", venda.Data);
                objConexao.SqlCmd.Parameters.AddWithValue("@vend_situacao", venda.Situacao);
                objConexao.SqlCmd.Parameters.AddWithValue("@vend_valortotal", venda.ValorTotal);
                objConexao.SqlCmd.Parameters.AddWithValue("@vend_obs", venda.Observacao);
                objConexao.SqlCmd.Parameters.AddWithValue("@codpessoa", venda.Pessoa.Codigo);


                objConexao.iniciarTransacao();
                objConexao.AutoConexao = false;

                int cod = (int)objConexao.executarScalar();
                //int cod = 0;
                //objConexao.executarComando();
                if (cod <= 0)
                {
                    return -1;
                }
                
                if (venda.ListavendaProdutos != null)
                {

                    for (int i = 0; i < venda.ListavendaProdutos.Count; i++)
                    {
                        strSQL = "INSERT INTO tbvendaproduto(codvenda, codproduto, vendprod_qtde, vendprod_valor) ";
                        strSQL += "VALUES (@codvenda, @codproduto, @vendprod_qtde, @vendprod_valor);";

                        objConexao.SqlCmd.Parameters.Clear();
                        objConexao.SqlCmd.CommandText = strSQL;

                        objConexao.SqlCmd.Parameters.AddWithValue("@codvenda", cod);
                        objConexao.SqlCmd.Parameters.AddWithValue("@codproduto", venda.ListavendaProdutos.ElementAt(i).Produto.CodigoProduto);
                        objConexao.SqlCmd.Parameters.AddWithValue("@vendprod_qtde", venda.ListavendaProdutos.ElementAt(i).Quantidade);
                        objConexao.SqlCmd.Parameters.AddWithValue("@vendprod_valor", venda.ListavendaProdutos.ElementAt(i).Valor);

                        if (!objConexao.executarComando())
                            return -1;
                    }

                    

                }

                objConexao.commitTransacao();
                return cod;


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

        public int retornaUltimaVenda()
        {
            DataTable dt = new DataTable();
            int cont = 0;

            _sql = "SELECT MAX (codvenda)"+
                   " FROM tbvenda";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
                DataRow dtr = dt.Rows[0];
                cont = Convert.ToInt32(dtr[0].ToString());
            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao retronar Contas");
            }
            return cont;
        }

        public DataTable retornaVenda(int cod)
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codvenda, vend_datavenda, vend_situacao, vend_valortotal, vend_obs, codpessoa "+
                    "FROM tbvenda " +
                    "WHERE codvenda = "+ cod;


            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codvenda");
                cmd.Parameters.AddWithValue("@vend_datavenda");
                cmd.Parameters.AddWithValue("@vend_situacao");
                cmd.Parameters.AddWithValue("@vend_valortotal");
                cmd.Parameters.AddWithValue("@vend_obs");
                cmd.Parameters.AddWithValue("@codpessoa");


                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao retornar Venda");
            }
            return dt;
        }

        public DataTable retornaVendaProdutoCod(int cod)
        {
            DataTable dt = new DataTable();

            _sql = "SELECT Venda.vend_valortotal, Prod.prod_produto, VenProd.vendProd_qtde,VenProd.vendProd_valor "+
                   "FROM tbvenda as Venda "+
                   "INNER JOIN tbvendaproduto as VenProd on Venda.codVenda = VenProd.codvenda "+
                   "INNER JOIN tbProduto as Prod on VenProd.codproduto = Prod.codproduto " +
                   "WHERE Venda.codVenda = " + cod;

            //Venda.codvenda, Prod.codProduto, 

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                //cmd.Parameters.AddWithValue("@Venda.codvenda");
                cmd.Parameters.AddWithValue("@Venda.vend_valortotal");
                //cmd.Parameters.AddWithValue("@Prod.codProduto");
                cmd.Parameters.AddWithValue("@Prod.prod_produto");
                cmd.Parameters.AddWithValue("@VenProd.vendProd_qtde");
                cmd.Parameters.AddWithValue("@VenProd.vendProd_valor");


                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao retornar Vendas de Produto");
            }
            return dt;
        }

        public DataTable retornaProdutos(int cod)
        {
            DataTable dt = new DataTable();

            _sql = "SELECT v.codvenda, v.codproduto, v.vendprod_qtde, v.vendprod_valor, p.prod_produto " +
                      "FROM tbvendaproduto v inner join tbproduto p on p.codproduto = v.codproduto "+
                      "where v.codvenda = " + cod;

            //Venda.codvenda, Prod.codProduto, 

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

                throw new SystemException(e + "Erro ao retornar Vendas de Produto");
            }
            return dt;
        }

        public int atualizaStatus(int cod, string status)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
            try
            {

                _sql = "update tbvenda set vend_situacao = @status where codvenda = @codigo";

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@codigo", cod);


                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public DataTable retornaVendaPessoa(int cod)
        {
            DataTable dt = new DataTable();

            _sql = "SELECT codvenda, vend_datavenda, vend_situacao, vend_valortotal, vend_obs, codpessoa " +
                    "FROM tbvenda " +
                    "WHERE vend_situacao = 'aberta' and codpessoa = "+cod +" and codvenda not in (select codvenda from tbcontasreceber)";


            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codvenda");
                cmd.Parameters.AddWithValue("@vend_datavenda");
                cmd.Parameters.AddWithValue("@vend_situacao");
                cmd.Parameters.AddWithValue("@vend_valortotal");
                cmd.Parameters.AddWithValue("@vend_obs");
                cmd.Parameters.AddWithValue("@codpessoa");


                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }
            catch (Exception e)
            {

                throw new SystemException(e + "Erro ao retornar Venda");
            }
            return dt;
        }
    }
}
