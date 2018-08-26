using HairLumos.Controller;
using HairLumos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class CaixaModels
    {
        DAO.CaixaDAO _DAOCaixa = new DAO.CaixaDAO();

        public int abrirCaixa(int codigo, string usuario, DateTime data, DateTime hora, double valor)
        {
            Caixa c = new Caixa();
            Usuario u = new Usuario();
            UsuarioController uc = new UsuarioController();
            if (codigo != 0)
                c.CodCaixa = codigo;
            if (usuario != null && usuario != "")
            {
                DataTable dt = uc.existeUsuarioLogado();
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    u.UsuarioCodigo = Convert.ToInt32(dr["codusuario"].ToString());
                    u.PessoaCod = Convert.ToInt32(dr["codpessoa"].ToString());
                    u.Login = dr["usu_usuario"].ToString();
                    u.Senha = dr["usu_senha"].ToString();
                    u.Nivel = Convert.ToInt32(dr["usu_nivel"].ToString());
                }
                c.Usuario = u;
            }
            if (data != null)
                c.DataAbertura = data;
            c.DataFechamento = DateTime.MinValue;
            c.SaldoInicial = valor;

            return _DAOCaixa.abrirCaixa(c);

        }

        public int fecharCaixa(int caixa, string valor, DateTime data)
        {
            Caixa c = new Caixa();
            c.CodCaixa = caixa;
            c.DataFechamento = data;
            c.TotalSaida = Convert.ToDouble(valor);

            return _DAOCaixa.fecharCaixa(c);
        }

        public double retornaMaxCaixa()
        {
            return _DAOCaixa.retornaMaxCaixa();
        }

        public double retornaValCaixaAberto()
        {
            return _DAOCaixa.retornaValCaixaAberto();
        }
    }
}
