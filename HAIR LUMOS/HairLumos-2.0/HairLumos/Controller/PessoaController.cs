using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    public class PessoaController
    {
        private Models.PessoaModels _MdlPes = new Models.PessoaModels();


        public int gravarPessoaFisica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs, bool fiado, string email, List<Entidades.Endereco> Listendereco, List<Entidades.Contato> Listcontato,
            string cpf, string rg, DateTime nascimento)
        {
            return _MdlPes.gravaPessoaFisica(cod, nome, dataCadastro, tipopes, statusPessoa, obs,
                fiado, email, Listendereco, Listcontato, cpf, rg, nascimento);

        }

        public int gravarPessoaJuridica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs, bool fiado, string email, List<Entidades.Endereco> Listendereco, List<Entidades.Contato> Listcontato,
            string cnpj, string razao, string fantasia)
        {
            return _MdlPes.gravaPessoaJuridica(cod, nome, dataCadastro, tipopes, statusPessoa, obs,
                fiado, email, Listendereco, Listcontato, cnpj, razao, fantasia);

        }

        public int alteraPessoaFisica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs, bool fiado, string email, List<Entidades.Endereco> Listendereco, List<Entidades.Contato> Listcontato,
            string cpf, string rg, DateTime nascimento)
        {
            return _MdlPes.alteraPessoaFisica(cod, nome, dataCadastro, tipopes, statusPessoa, obs,
                fiado, email, Listendereco, Listcontato, cpf, rg, nascimento);

        }

        public int alteraPessoaJuridica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs, bool fiado, string email, List<Entidades.Endereco> Listendereco, List<Entidades.Contato> Listcontato,
            string cnpj, string razao, string fantasia)
        {
            return _MdlPes.alteraPessoaJuridica(cod, nome, dataCadastro, tipopes, statusPessoa, obs,
                fiado, email, Listendereco, Listcontato, cnpj, razao, fantasia);

        }

        public DataTable retornaPessoa(string strTexto)
        {
            return _MdlPes.retornaPessoa(strTexto);
        }

        public DataTable retornaPessoaCod(string strCod)
        {
            return _MdlPes.retornaPessoaCod(strCod);
        }

        public DataTable retornaPessoaFisicaCod(int strCod)
        {
            return _MdlPes.retornaPessoaFisica(strCod);
        }

        public DataTable retornaPessoaJuridicaCod(int strCod)
        {
            return _MdlPes.retornaPessoaFisica(strCod);
        }

        public DataTable retornaEstado()
        {
            return _MdlPes.retornaEstado();
        }

        public DataTable retornaCidade(int cod)
        {
            return _MdlPes.retornaCidade(cod);
        }

        public int excluiPessoaFisica(int cod)
        {
            return _MdlPes.excluiPessoa(cod);

        }

        public int excluiPessoaJuridica(int cod)
        {
            return _MdlPes.excluiPessoa(cod);

        }

    }
}
