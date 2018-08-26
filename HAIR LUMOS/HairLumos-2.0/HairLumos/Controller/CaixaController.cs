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


    }
}
