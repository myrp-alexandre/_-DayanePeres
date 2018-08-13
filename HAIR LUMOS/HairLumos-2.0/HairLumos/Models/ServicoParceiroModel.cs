using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class ServicoParceiroModel
    {

        //validar informações para enviar/receber do Banco

        DAO.ServicoParceiroDAO ServicoParceiroDAO = new DAO.ServicoParceiroDAO();
        DAO.PessoaDAO pessoaDAO = new DAO.PessoaDAO();
        DAO.ServicoDAO ServicoDAO = new DAO.ServicoDAO();

        public int gravaServicoParceiro(int codPessoaJur, int codServico, double valor, double percentual, string pagamReceb)
        {
            Entidades.PessoaJuridica _pessoaJuridica = new Entidades.PessoaJuridica();
            Entidades.Servico _servico = new Entidades.Servico();
            Entidades.ServicoParceiro _servicoParceiro = new Entidades.ServicoParceiro();

            DataTable dtPessoaJuridica = pessoaDAO.RetornaPessoaJuridicaCod(codPessoaJur);
            if (dtPessoaJuridica != null && dtPessoaJuridica.Rows.Count > 0)
            {
                DataRow dr = dtPessoaJuridica.Rows[0];

                _pessoaJuridica.Codigo = Convert.ToInt32(dr["codpessoa"].ToString());
                _pessoaJuridica.Nome = dr["pes_nome"].ToString();
            }

            DataTable dtServico = ServicoDAO.RetornaObjServico(codServico);
            if (dtServico != null && dtServico.Rows.Count > 0)
            {
                DataRow dr = dtServico.Rows[0];

                _servico.Codigo = Convert.ToInt32(dr["codtiposervico"].ToString());

            }

            return _servicoParceiro.CarregaServicoParceiro(_pessoaJuridica, _servico, valor, percentual, pagamReceb);
        }
    }
}
