using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Outras_Fundamentais
{
    class EnterPropriedades
    {
        public void _enterPropriedade(MaskedTextBox mskCampo)
        {
            String x = "";
            for (int i = 0; i <= mskCampo.Text.Length - 1; i++)
            {
                if ((mskCampo.Text[i] >= '0' &&
                    mskCampo.Text[i] <= '9') ||
                    mskCampo.Text[i] == ',')
                {
                    x += mskCampo.Text[i];
                }
            }
            mskCampo.Text = x;
            mskCampo.SelectAll();
        }

        public void _keyPessPropriedade(MaskedTextBox mskCampo, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!mskCampo.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }


    }
}
