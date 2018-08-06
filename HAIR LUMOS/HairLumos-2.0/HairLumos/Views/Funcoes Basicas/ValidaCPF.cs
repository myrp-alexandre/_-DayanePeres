using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Views.Funcoes_Basicas
{
    class ValidaCPF
    {
        #region Construtor
        public ValidaCPF()
        {
        }
        #endregion

        #region Função
        public Boolean CPFValido(String cpf)
        {
            int i, mult, num, soma, dig1, dig2;
            cpf = cpf.Replace("-", "").Replace(".", "").Replace(" ", "");

            // Calculando digito 1
            mult = 10;
            soma = 0;
            for (i = 0; i < cpf.Length - 2; i++)
            {
                num = Convert.ToInt32(cpf[i].ToString());
                soma += num * mult;
                mult--;
            }

            dig1 = 11 - Convert.ToInt32(soma % 11);
            if (dig1 == 10 || dig1 == 11)
                dig1 = 0;

            // Calculando digito 2
            mult = 11;
            soma = 0;
            for (i = 0; i < cpf.Length - 1; i++)
            {
                num = Convert.ToInt32(cpf[i].ToString());
                soma += num * mult;
                mult--;
            }

            dig2 = 11 - Convert.ToInt32(soma % 11);
            if (dig2 == 10 || dig2 == 11)
                dig2 = 0;

            if (dig1 == Convert.ToInt32(cpf[cpf.Length - 2].ToString()) && dig2 == Convert.ToInt32(cpf[cpf.Length - 1].ToString()))
                return true;
            else
                return false;
        }
        #endregion
    }
}
