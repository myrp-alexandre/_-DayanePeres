﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class Servico
    {
        
        private int _cod;
        private string _servico;
        private double _valor;
        private string _tempo;
        private string _obs;


        public string _erro;

        public Servico(int cod, string servico, string obs, double valor, string tempo )
        {
            this.carregaServico(cod, servico, obs, valor, tempo);
        }

        public Servico()
        {
            this.carregaServico(0, string.Empty, string.Empty,  0, string.Empty );
        }

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }

        public int Codigo
        {
            get { return _cod; }
            set { _cod = value; }
        }

        public string ServicoNome
        {
            get { return _servico; }
            set { _servico = value; }
        }

        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public string Tempo
        {
            get { return _tempo; }
            set { _tempo = value; }
        }

        public string Observacao
        {
            get { return _obs; }
            set { _obs = value; }
        }

        public void carregaServico(int cod, string servico, string obs, double valor, string tempo)
        {
            this.Codigo = cod;
            this.ServicoNome = servico;
            this.Valor = valor;
            this.Tempo = tempo;
            this.Observacao = obs;
        }

        public override string ToString()
        {
            return ServicoNome;
        }
    }
}

