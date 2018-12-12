using HairLumos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    public class PessoaModels
    {
        DAO.PessoaDAO _DAOPessoa = new DAO.PessoaDAO();


        public int gravaPessoaFisica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs, bool fiado, string email, Endereco endereco, string telefone, string celular,
            string cpf, string rg, DateTime nascimento)
        {

            Entidades.PessoaFisica _entFis = new Entidades.PessoaFisica(cod, nome, dataCadastro, tipopes, statusPessoa, obs, fiado, email, endereco, telefone, celular, cpf, rg, nascimento);

            return _DAOPessoa.GravaPessoa(_entFis);

        }

        public int gravaPessoaJuridica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs, bool fiado, string email, Endereco endereco, string telefone, string celular,
            string CNPJ, string razao)
        {
            Entidades.PessoaJuridica _entJur = new Entidades.PessoaJuridica(cod, nome, dataCadastro, tipopes, statusPessoa, obs, fiado, email, endereco, telefone, celular, CNPJ, razao);

            return _DAOPessoa.GravaPessoa(_entJur);
        }

        public int alteraPessoaFisica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs, bool fiado, string email, Endereco endereco, string telefone, string celular,
            string cpf, string rg, DateTime nascimento)
        {

            Entidades.PessoaFisica _entFis = new Entidades.PessoaFisica(cod, nome, dataCadastro, tipopes, statusPessoa, obs, fiado, email, endereco, telefone, celular,  cpf, rg, nascimento);

            return _DAOPessoa.alteraPessoaFisica(_entFis);

        }

        public int alteraPessoaJuridica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs, bool fiado, string email, Endereco endereco, string telefone, string celular,
           string cnpj, string razao)
        {

            Entidades.PessoaJuridica _entJur = new Entidades.PessoaJuridica();

            return _DAOPessoa.alteraPessoaJuridica(_entJur);

        }

        public int excluiPessoa(int cod)
        {

            Entidades.PessoaFisica _entFis = new Entidades.PessoaFisica();
            _entFis.Codigo = cod;
            return _DAOPessoa.deletaPessoaFisica(_entFis);

        }

        public DataTable retornaPessoa(string texto)
        {
            return _DAOPessoa.RetornaPessoa(texto);
        }

        public DataTable retornaPessoaCompra(string texto)
        {
            return _DAOPessoa.RetornaPessoaCompra(texto);
        }

        public DataTable retornaCpf(string cpf)
        {
            return _DAOPessoa.RetornaCPF(cpf);
        }

        public DataTable retornaPessoaCod(string cod)
        {
            return _DAOPessoa.RetornaPessoaCod(cod);
        }

        public DataTable retornaPessoaFisica(int cod)
        {
            return _DAOPessoa.RetornaPessoaFisicaCod(cod);
        }

        public DataTable retornaPessoaFisica()
        {
            return _DAOPessoa.RetornaPessoaFisica();
        }

        public DataTable retornaPessoaJuridica(int cod)
        {
            return _DAOPessoa.RetornaPessoaJuridicaCod(cod);
        }

        public DataTable retornaPessoaJuridicaCnpj(string cnpj)
        {
            return _DAOPessoa.RetornaPessoaJuridicaCnpj(cnpj);
        }

        public DataTable retornaPessoaJuridica()
        {
            return _DAOPessoa.RetornaPessoaJuridicaCod();
        }

        public DataTable retornaPessoaJuridica(string texto)
        {
            return _DAOPessoa.RetornaPessoaJuridicaCod(texto);
        }

        public DataTable retornaEstado()
        {

            return _DAOPessoa.RetornaEstado();
        }

        public DataTable retornaCidade(int codigo)
        {

            return _DAOPessoa.RetornaCidades(codigo);
        }

        public DataTable retornaEndereco(int cod)
        {
            return _DAOPessoa.RetornaEndereco(cod);
        }

        public DataTable retornaCidCodigo(int cod)
        {
            return _DAOPessoa.RetornaCidCodigo(cod);
        }

    }
}
