﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F16_Gerenciar_Pacotes
{
    public partial class Pesquisa_GerenciarPacotes : Form
    {
        public int intCodPacote { get; set; }

        public Pesquisa_GerenciarPacotes()
        {
            InitializeComponent();
            dgvPacote.AutoGenerateColumns = false;
        }

        private void DGVMoeda()
        {
            this.dgvPacote.Columns["pac_valor"].DefaultCellStyle.Format = "c";
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Controller.PacoteController pacoteController = new Controller.PacoteController();
            DataTable dtRetorno = pacoteController.retornaPacoteText(ttbDescricao.Text.Trim());

            if (dtRetorno != null)
            {
                dgvPacote.DataSource = dtRetorno;
                dgvPacote.ClearSelection();
                //DGVMoeda();
            }
            else
                dgvPacote.Rows.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.selecionaPacote();
        }

        private void selecionaPacote()
        {
            if (dgvPacote.Rows.Count > 0)
            {
                int intCod = 0;
                int.TryParse(dgvPacote.CurrentRow.Cells[0].FormattedValue.ToString(), out intCod);

                if (intCod > 0)
                {
                    this.intCodPacote = intCod;
                    this.Close();
                }
            }
        }

        private void dgvPacote_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selecionaPacote();
        }

        private void Pesquisa_GerenciarPacotes_Load(object sender, EventArgs e)
        {

        }
    }
}
