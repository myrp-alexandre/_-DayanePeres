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
                        //COLOCAR CO CODPESSOA
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

            _sql = "SELECT codformapag, formpag_descricao" +
                        " FROM tbformapagamento; ";

            // int intCodigo = 0;


            //_sql += $"OR codcategoria = @cod";
            //_sql += $"OR cat_categoria = @categoria";
            //_sql += $"OR cat_obscategoria = @obs";

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, Conexao.getIntancia().openConn());

                cmd.CommandText = _sql;
                cmd.Parameters.AddWithValue("@codformapag");
                cmd.Parameters.AddWithValue("@formpag_descricao");
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

    }
}
