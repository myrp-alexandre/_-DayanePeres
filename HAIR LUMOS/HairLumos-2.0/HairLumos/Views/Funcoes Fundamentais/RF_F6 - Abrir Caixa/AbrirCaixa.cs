﻿using HairLumos.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F6___Abrir_Caixa
{
    public partial class AbrirCaixa : Form
    {
        public AbrirCaixa()
        {
            InitializeComponent();
            inicializa();
            double trocoinicial = 0;
            CaixaController cc = new CaixaController();
            trocoinicial = cc.retornaMaxCaixa();
            mskTroco.Text = trocoinicial + "";

            if(!string.IsNullOrWhiteSpace(mskTroco.Text))
                mskTroco.Text = Convert.ToDouble(mskTroco.Text).ToString("###,###,##0.00");

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            CaixaController cc = new CaixaController();
            String erro = "";
            int codigo = 0;
            double troco = 0;
            double addValor = 0;

            if (ttbCodigo.Text != null && ttbCodigo.Text!="")
                codigo = Convert.ToInt32(ttbCodigo.Text.ToString());

            if (mskTroco.Text == null || mskTroco.Text=="")
                erro += "Insira o troco";
            else
                troco = Convert.ToDouble(mskTroco.Text.ToString());

            if (!string.IsNullOrWhiteSpace(mskAddValor.Text))
               addValor = Convert.ToDouble(mskAddValor.Text.ToString());

            if (erro == null || erro=="") {
                int result = cc.abrirCaixa(codigo, ttbUsuário.Text, dtpData.Value, dtpHora.Value, troco+addValor);
                if (result > 0)
                {
                    MessageBox.Show("Caixa aberto com sucesso");
                    limpaTela();
                    inicializa();
                }
                else
                {
                    MessageBox.Show("Erro ao abrir caixa");
                }
            }
            else
            {
                MessageBox.Show(erro);
            }

        }

        public void inicializa()
        {
            ttbCodigo.Enabled = false;
            ttbUsuário.Enabled = false;
            mskTroco.Enabled = false;
            UsuarioController uc = new UsuarioController();
            DataTable dt = uc.existeUsuarioLogado();
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                ttbUsuário.Text = dr["usu_usuario"].ToString();
            }
        }

        public void limpaTela()
        {
            ttbCodigo.Text = "";
            ttbUsuário.Text = "";
            dtpData.Text = DateTime.Now.ToString();
            dtpHora.Text = DateTime.Now.ToString();
            mskTroco.Text = "";
            mskAddValor.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mskTroco_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskTroco);
        }

        private void mskTroco_Leave(object sender, EventArgs e)
        {
            mskTroco.Text = Convert.ToDouble(mskTroco.Text).ToString("###,###,##0.00");
        }

        private void mskTroco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskTroco, e);
        }

        private void mskAddValor_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskAddValor);
        }

        private void mskAddValor_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(mskAddValor.Text))
                mskAddValor.Text = Convert.ToDouble(mskAddValor.Text).ToString("###,###,##0.00");
        }

        private void mskAddValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskAddValor, e);
        }
    }
}
