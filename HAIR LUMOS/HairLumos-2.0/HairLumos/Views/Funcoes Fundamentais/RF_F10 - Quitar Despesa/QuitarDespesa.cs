﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais
{

    public partial class QuitarDespesa : Form
    {
        private Controller.ContasPagarController contcon = new Controller.ContasPagarController();

        public QuitarDespesa()
        {
            InitializeComponent();
            dgvContas.AutoGenerateColumns = false;
            String datal = DateTime.Now.ToString("dd/MM/yyyy");
            selecionaContas(Convert.ToDateTime(datal), Convert.ToDateTime(datal));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            if(dtpInicio.Value > dtpFim.Value)
            {
                MessageBox.Show("A data inicial deve ser menor que a final!");
            }
            else
            {
                selecionaContas(dtpInicio.Value, dtpFim.Value);
            }
        }

        private void dtpFim_ValueChanged(object sender, EventArgs e)
        {
            if (dtpInicio.Value > dtpFim.Value)
            {
                MessageBox.Show("A data final deve ser maior que a inicial!");
            }
            else
            {
                selecionaContas(dtpInicio.Value, dtpFim.Value);
            }
        }

        private void selecionaContas(DateTime datai, DateTime dataf)
        {
            DataTable dtContas = contcon.retornaPeriodo(datai, dataf);
            if(dtContas!=null && dtContas.Rows.Count > 0)
            {
                carregaDGV(dtContas);
                ttbTotalPagar.Text = somavalorTotal(dtContas) + "";
                ttbTotalPago.Text = somavalorPago(dtContas) + "";
                ttbTotalVencido.Text = somavalorVencido(dtContas) + "";
            }

        }

        private void carregaDGV(DataTable dt)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = dt;
            dgvContas.DataSource = bd;
            dgvContas.Refresh();
        }

        private double somavalorTotal(DataTable dt)
        {
            double total = 0;
            for(int i =0; i<dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                total += Convert.ToDouble(dr["contPag_valorParcela"].ToString());
            }
            return total;
        }

        private double somavalorPago(DataTable dt)
        {
            double total = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if(Convert.ToDouble(dr["contpag_valorpago"].ToString())>0)
                    total += Convert.ToDouble(dr["contpag_valorpago"].ToString());
            }
            return total;
        }

        private double somavalorVencido(DataTable dt)
        {
            double total = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (Convert.ToDateTime(dr["contpag_datavencimento"].ToString()) < Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")))
                {
                    total+= Convert.ToDouble(dr["contPag_valorParcela"].ToString())- Convert.ToDouble(dr["contpag_valorpago"].ToString());
                }
            }
            return total;
        }
    }
}
