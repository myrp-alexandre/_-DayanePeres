using HairLumos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    class CaixaController
    {
        private Models.CaixaModels _MdlCaixa = new Models.CaixaModels();

        public int abrirCaixa(int codigo, string usuario, DateTime data, DateTime hora, double valor)
        {
            return _MdlCaixa.abrirCaixa(codigo, usuario,data,hora, valor);
        }

        public int fechaCaixa(int codigo, string valor, DateTime data)
        {
            return _MdlCaixa.fecharCaixa(codigo, valor, data);
        }

        public double retornaMaxCaixa()
        {
            try
            {
                DataTable dt = _MdlCaixa.retornaMaxCaixa();

                if(dt !=null && dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    double valor = Convert.ToDouble(dr["caixa_totalsaida"].ToString());
                    return valor;
                }
                else
                {
                    
                    return 0;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public double retornaValCaixaAberto()
        {
            DataTable dt = _MdlCaixa.retornaValCaixaAberto();
            DataRow dr = dt.Rows[0];
            double valor = Convert.ToDouble(dr["caixa_saldoinicial"].ToString());
            return valor;
        }

    }
}
