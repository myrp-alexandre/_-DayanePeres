using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    class ContasReceberController
    {
        private Models.ContasReceberModels cm = new Models.ContasReceberModels();

        public DataTable retornaContasReceber(DateTime dataI, DateTime dataF, string situacao)
        {
            return cm.retornaContasReceber(dataI, dataF, situacao);
        }
    }
}
