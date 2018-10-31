using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HairLumos.Views.Funcoes_Fundamentais.RF_F2_Agenda
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Views.Funcoes_Fundamentais.RF_F2_Agendamento.Agenda teste = new RF_F2_Agendamento.Agenda();
            teste.ShowDialog();
        }
    }
}
