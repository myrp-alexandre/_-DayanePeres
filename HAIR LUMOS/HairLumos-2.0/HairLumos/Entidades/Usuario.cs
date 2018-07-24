using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    public class Usuario
    {
        private int _codUsu;
        //private Pessoa _pessoa;
        private int _pessoa;
        private string _login;
        private string _senha;
        private int _nivel;

        private string _erro;

        public Usuario(int codUsu, int pessoa, string login, string senha, int nivel)
        {
            carregaUsuario(codUsu, pessoa, login, senha, nivel);
        }

        public Usuario()
        {
            carregaUsuario(0, 0, string.Empty, string.Empty, 0);
        }

        public int UsuarioCodigo
        {
            get { return _codUsu; }
            set { _codUsu = value; }
        }

        public int PessoaCod
        {
            get { return _pessoa; }
            set { _pessoa = value; }
        }

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        public int Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }

        public void carregaUsuario(int codUsu, int pessoa, string login, string senha, int nivel)
        {
            this.UsuarioCodigo = codUsu;
            this.PessoaCod = pessoa;
            this.Login = login;
            this.Senha = senha;
            this.Nivel = nivel;

        }
    }
}
