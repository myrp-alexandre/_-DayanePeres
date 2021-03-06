﻿using HairLumos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class UsuarioModels
    {
        DAO.usuarioDAO _DAOUsu = new DAO.usuarioDAO();

        public int gravaUsuario(int cod, int pessoa, string usuario, string senha, int nivel)
        {
            Entidades.Usuario _entUsu = new Entidades.Usuario();
            _entUsu.carregaUsuario(cod, pessoa, usuario, senha, nivel);

            return _DAOUsu.GravaUsuario(_entUsu);
        }

        public DataTable retornaPessoa(string texto)
        {

            return _DAOUsu.RetornaPessoa(texto);
        }

        public DataTable retornoObjUsuario(int cod)
        {

            return _DAOUsu.RetornaPessoaCod(cod);
        }

        public DataTable verificaCadastroUser(int cod)
        {

            return _DAOUsu.VerificaUsuarioCadastro(cod);
        }

        public bool excluirUsuario(int intCod)
        {

            return _DAOUsu.ExcluirUsuario(intCod);
        }

        public DataTable realizaLogin(string login, string senha)
        {

            return _DAOUsu.RealizaLogin(login,senha);
        }

        public DataTable verificaLogin(string login)
        {

            return _DAOUsu.VerificaLogin(login);
        }

        public DataTable existeUsuario()
        {

            return _DAOUsu.ExisteUsuario();
        }

        public int usuarioLogado(int cod, int codU)
        {
            return _DAOUsu.usuarioLogado(cod, codU);
        }

        public DataTable existeUsuarioLogado()
        {

            return _DAOUsu.ExisteUsuarioLogado();
        }
    }
}
