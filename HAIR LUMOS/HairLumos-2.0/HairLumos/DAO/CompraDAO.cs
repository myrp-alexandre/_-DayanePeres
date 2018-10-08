using HairLumos.Banco;
using HairLumos.Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.DAO
{
    class CompraDAO
    {

        private string _sql;

        public int gravarCompra(Entidades.Compra compra)
        {
            Conexao objConexao = null;
            try
            {
                objConexao = new Conexao();
                if (compra.Codigo == 0)
                {
                    _sql = "INSERT INTO tbcompra "+
                           "(coddespesa, comp_datacompra, comp_situacao, comp_statusconsignado, comp_valortotal, comp_obs, codpessoa)"+
                           " VALUES(@coddespesa, @comp_datacompra, @comp_situacao, @comp_statusconsignado, @comp_valortotal, @comp_obs, @codpessoa); SELECT MAX(codcompra) FROM tbcompra;";

                }
                else
                {
                    _sql = "UPDATE tbmarca" +
                            " SET marc_nome = @marca" +
                        " WHERE codmarca = @cod";
                }

                objConexao.SqlCmd.CommandText = _sql;
                objConexao.SqlCmd.Parameters.AddWithValue("@codcompra", compra.Codigo);
                objConexao.SqlCmd.Parameters.AddWithValue("@coddespesa", compra.Despesa.Codigo);
                objConexao.SqlCmd.Parameters.AddWithValue("@comp_datacompra", compra.Data);
                objConexao.SqlCmd.Parameters.AddWithValue("@comp_situacao", compra.Situacao);
                objConexao.SqlCmd.Parameters.AddWithValue("@comp_statusconsignado", compra.Consignado);
                objConexao.SqlCmd.Parameters.AddWithValue("@comp_valortotal", compra.ValorTotal);
                objConexao.SqlCmd.Parameters.AddWithValue("@comp_obs", compra.Obs);
                objConexao.SqlCmd.Parameters.AddWithValue("@codpessoa", compra.PJ.Codigo);

                objConexao.iniciarTransacao();
                objConexao.AutoConexao = false;
                int cod = (int)objConexao.executarScalar();

                if (cod <= 0)
                {
                    return -1;
                }

                if(compra.Lista!=null)
                {
                    foreach (var item in compra.Lista)
                    {
                        _sql = "INSERT INTO tbcompraproduto(codcompra, codproduto, compprod_qtde, compprod_valor, compprod_qtdedevolvida, codcompra1,codproduto1,compprod_qtdeacertada) ";
                        _sql += "VALUES(@codigo, @produto, @qtde, @valor, @qtdedevolvida, @compra1, @produto1, @qtdeacertada)";

                        objConexao.SqlCmd.Parameters.Clear();
                        objConexao.SqlCmd.CommandText = _sql;

                        objConexao.SqlCmd.Parameters.AddWithValue("@codigo", cod);
                        objConexao.SqlCmd.Parameters.AddWithValue("@produto", item.Produto.CodigoProduto);
                        objConexao.SqlCmd.Parameters.AddWithValue("@qtde", item.Qtde);
                        objConexao.SqlCmd.Parameters.AddWithValue("@valor", item.Valor);
                        objConexao.SqlCmd.Parameters.AddWithValue("@qtdedevolvida", item.QtdeDevolvida);
                        objConexao.SqlCmd.Parameters.AddWithValue("@compra1", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                        objConexao.SqlCmd.Parameters.AddWithValue("@produto1", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                        objConexao.SqlCmd.Parameters.AddWithValue("@qtdeacertada", 0);


                        if (!objConexao.executarComando())
                            return -1;
                    }
                }

                objConexao.commitTransacao();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public DataTable retornaCompra()
        {
            DataTable dt = new DataTable();
            

            _sql = "SELECT codcompra, coddespesa, comp_datacompra, comp_situacao, comp_statusconsignado, comp_valortotal, comp_obs, codpessoa, jur_cnpj FROM tbcompra";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                NpgsqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader para select retorna um DataReader
                dt.Load(dr);//Carrego o DataReader no meu DataTable
                dr.Close();//Fecho o DataReader
            }catch(Exception e)
            {
                throw;
            }
            return dt;
        }

        public DataTable retornaCompra(int codigo)
        {
            DataTable dt = new DataTable();


            _sql = "SELECT codcompra, coddespesa, comp_datacompra, comp_situacao, comp_statusconsignado, comp_valortotal, comp_obs, codpessoa, jur_cnpj FROM tbcompra WHERE codcompra = "+codigo;

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

        public List<Entidades.CompraProduto> retornaLista(int cod)
        {
            DataTable dt = new DataTable();
            List<Entidades.CompraProduto> lista = new List<Entidades.CompraProduto>();

            _sql = "SELECT * FROM tbcompraproduto WHERE codcompra = " + cod;
            

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());
                cmd.CommandText = _sql;
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();

                if(dt!=null && dt.Rows.Count > 0)
                {
                    for(int i =0; i<dt.Rows.Count; i++)
                    {
                        Entidades.CompraProduto ec = new Entidades.CompraProduto();
                        DataRow drE = dt.Rows[i];
                        int codigoP = Convert.ToInt32(drE["codproduto"].ToString());
                        DAO.ProdutoDAO pDAO = new ProdutoDAO();
                        DataTable dtProduto = new DataTable();
                        dtProduto = pDAO.RetornaProduto(codigoP);
                        if(dtProduto!=null && dtProduto.Rows.Count > 0)
                        {
                            DataRow drProduto = dtProduto.Rows[0];
                            Produto p = new Produto();
                            p.CodigoProduto = Convert.ToInt32(drProduto["codproduto"].ToString());
                            p.NomeProduto = drProduto["prod_produto"].ToString();
                            p.Custo = Convert.ToDouble(drProduto["prod_precocusto"].ToString());
                            p.Venda = Convert.ToDouble(drProduto["prod_precovenda"].ToString());
                            p.Quantidade = Convert.ToInt32(drProduto["prod_qtde"].ToString());
                            ec.Produto = p;
                        }
                        ec.Qtde = Convert.ToInt32(drE["compprod_qtde"].ToString());
                        ec.QtdeDevolvida = Convert.ToInt32(drE["compprod_qtdedevolvida"].ToString());
                        ec.Valor = Convert.ToDouble(drE["compprod_valor"].ToString());
                        lista.Add(ec);
                    }
                }

            }
            catch(Exception e)
            {
                throw;
            }

            return lista;

        }

        public int excluirCompra(int codigo)
        {
            _sql = "DELETE FROM tbcompraproduto WHERE codcompra = " + codigo;
            Conexao objConexao = null;
            try
            {
                objConexao = new Conexao();
                objConexao.SqlCmd.CommandText = _sql;

                objConexao.iniciarTransacao();
                objConexao.AutoConexao = false;
                objConexao.executarComando();

                objConexao.SqlCmd.Parameters.Clear();
                
                _sql = "DELETE FROM tbcompra WHERE codcompra = " + codigo;
                objConexao.SqlCmd.CommandText = _sql;
                objConexao.executarComando();
                objConexao.commitTransacao();
                return 1;
            }catch(Exception e)
            {
                throw;
            }
            return 0;
        }

    }
}
