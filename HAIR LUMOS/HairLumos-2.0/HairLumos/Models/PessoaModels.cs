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


        public int gravaPessoaFisica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs, bool fiado, string email, List<Entidades.Endereco> Listendereco, List<Entidades.Contato> Listcontato,
            string cpf, string rg, DateTime nascimento)
        {

            Entidades.PessoaFisica _entFis = new Entidades.PessoaFisica(cod, nome, dataCadastro, tipopes, statusPessoa, obs, fiado, email, Listendereco, Listcontato, cpf, rg, nascimento);

            return _DAOPessoa.GravaPessoa(_entFis);

        }

        public int gravaPessoaJuridica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs, bool fiado, string email, List<Entidades.Endereco> Listendereco, List<Entidades.Contato> Listcontato,
            string CNPJ, string razao, string fantasia)
        {
            Entidades.PessoaJuridica _entJur = new Entidades.PessoaJuridica(cod, nome, dataCadastro, tipopes, statusPessoa, obs, fiado, email, Listendereco, Listcontato, CNPJ, razao, fantasia);

            return _DAOPessoa.GravaPessoa(_entJur);
        }

        public int alteraPessoaFisica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs, bool fiado, string email, List<Entidades.Endereco> Listendereco, List<Entidades.Contato> Listcontato,
            string cpf, string rg, DateTime nascimento)
        {

            Entidades.PessoaFisica _entFis = new Entidades.PessoaFisica(cod, nome, dataCadastro, tipopes, statusPessoa, obs, fiado, email, Listendereco, Listcontato, cpf, rg, nascimento);

            return _DAOPessoa.alteraPessoaFisica(_entFis);

        }

        public int alteraPessoaJuridica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs, bool fiado, string email, List<Entidades.Endereco> Listendereco, List<Entidades.Contato> Listcontato,
           string cnpj, string razao, string fantasia)
        {

            Entidades.PessoaJuridica _entJur = new Entidades.PessoaJuridica();

            return _DAOPessoa.alteraPessoaJuridica(_entJur);

        }

        public int excluiPessoa(int cod)
        {

            Entidades.PessoaFisica _entFis = new Entidades.PessoaFisica();

            return _DAOPessoa.deletaPessoaFisica(_entFis);

        }

        public DataTable retornaPessoa(string texto)
        {
            return _DAOPessoa.RetornaPessoa(texto);
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

        public DataTable retornaContato(int cod)
        {
            return _DAOPessoa.RetornaContato(cod);
        }

        public DataTable retornaEndereco(int cod)
        {
            return _DAOPessoa.RetornaEndereco(cod);
        }

    }
}
