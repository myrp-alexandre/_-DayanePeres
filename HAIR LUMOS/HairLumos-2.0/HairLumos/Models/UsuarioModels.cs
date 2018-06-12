using HairLumos.Entidades;
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

        //public int gravaUsuario(int cod, Pessoa pessoa, string usuario, string senha, int nivel)
        //{
        //    Entidades.Usuario _entUsu = new Entidades.Usuario();
        //    _entUsu.carregaUsuario(cod, pessoa, usuario, senha, nivel);

        //    return _DAOPac.GravarPacote(_entUsu);
        //}

        public DataTable retornaPessoa(string  texto)
        {

            return _DAOUsu.RetornaPessoa(texto);
        }

        //public DataTable retornoObjPacote(int cod)
        //{

        //    return _DAOPac.RetornaObjPacote(cod);
        //}

        //public bool excluirPacote(int intCod)
        //{

        //    return _DAOPac.ExcluirPacote(intCod);
        //}
    }
}
