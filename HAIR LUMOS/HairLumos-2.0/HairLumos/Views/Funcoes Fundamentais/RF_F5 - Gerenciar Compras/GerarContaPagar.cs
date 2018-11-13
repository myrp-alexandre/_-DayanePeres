using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F5
{
    public partial class GerarContaPagar : Form
    {
        private int codCompra { get; set; }
        private double valorTotal { get; set; }

        private List<Entidades.ContasPagar> listacontasPagars = new List<Entidades.ContasPagar>();
        private Controller.CompraController CompraController = new Controller.CompraController();
        private Entidades.ContasPagar ContasPagar = new Entidades.ContasPagar();

        public GerarContaPagar()
        {
            InitializeComponent();
            mskValorTotal.Enabled = false;
            mskValorParcela.Enabled = false;

            dgvContas.AutoGenerateColumns = false;

            _inicializa();

            DataTable dt = CompraController.retornaCompraMAX();

            if(dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                codCompra = Convert.ToInt32(dr["codcompra"].ToString());
                mskValorTotal.Text = Convert.ToDouble(dr["comp_valortotal"]).ToString();
                valorTotal = Convert.ToDouble(mskValorTotal.Text);
            }
            
        }

        private void _inicializa()
        {
            dtpDataVencimento.Value = DateTime.Now;
            ttbQtdeParcela.Text = "";
            mskValorTotal.Text = "";
            mskValorParcela.Text = "";
            dgvContas.Rows.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _inicializa();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Controller.ContasPagarController contasPagarController = new Controller.ContasPagarController();

            try
            {
                int res = contasPagarController.insereLancamento(0, codCompra, dtpDataVencimento.Value, valorTotal, ttbObservacao.Text);

                if(res == 1)
                {
                    MessageBox.Show("Compra Finalizada. Já é possível verificar no Contas a Pagar!");
                }
                else
                {
                    MessageBox.Show("Erro");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Controller.ContasPagarController contasPagarController = new Controller.ContasPagarController();

            try
            {
                if (string.IsNullOrWhiteSpace(ttbQtdeParcela.Text))
                    MessageBox.Show("Informe uma valor para a parcela ou 0");

                if (dtpDataVencimento.Value >= DateTime.Now)
                    MessageBox.Show("Data inválida.");

                double valorParc = Convert.ToDouble(mskValorTotal.Text) / Convert.ToInt32(ttbQtdeParcela.Text);
               
                for (int i = 0; i < Convert.ToInt32(ttbQtdeParcela.Text); i++)
                {
                    ContasPagar = new Entidades.ContasPagar();
                    ContasPagar.Parcela = i + 1;
                    ContasPagar.ValorTotal = valorParc;
                    ContasPagar.DataVencimento = dtpDataVencimento.Value.AddDays(i*30);
                    listacontasPagars.Add(ContasPagar);
                    
                }
                carregaDGV(listacontasPagars);

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void carregaDGV(List<Entidades.ContasPagar> list)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = list;
            dgvContas.DataSource = bd;
            dgvContas.Refresh();

        }

        private void ttbQtdeParcela_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double valor= 0;
                int qtdPar = 0;

                if (!string.IsNullOrWhiteSpace(mskValorTotal.Text))
                    valor = Convert.ToDouble(mskValorTotal.Text);

                if (!string.IsNullOrWhiteSpace(ttbQtdeParcela.Text))
                    qtdPar = Convert.ToInt32(ttbQtdeParcela.Text);

                mskValorParcela.Text = Convert.ToString(valor / qtdPar); ;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
