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


        public int gravarPessoaFisica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs,
            bool fiado, string email, List<Entidades.Endereco> Listendereco, List<Entidades.Contato> Listcontato,
            string cpf, string rg, DateTime nascimento)
        {
            return _MdlPes.gravaPessoaFisica(cod, nome, dataCadastro, tipopes, statusPessoa, obs,
                fiado, email, Listendereco, Listcontato, cpf, rg, nascimento);

        }

        //public int gravarPessoaJuridica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs,
        //    bool fiado, string email, List<Entidades.Endereco> Listendereco, List<Entidades.Contato> Listcontato,
        //    string cnpj, string razao, string fantasia)
        //{
        //    return _MdlPes.gravaPessoaJuridica(cod, nome, dataCadastro, tipopes, statusPessoa, obs,
        //        fiado, email, Listendereco, Listcontato,cnpj, razao, fantasia);

        //}

        public int alteraPessoaFisica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs,
            bool fiado, string email, List<Entidades.Endereco> Listendereco, List<Entidades.Contato> Listcontato,
            string cpf, string rg, DateTime nascimento)
        {
            return _MdlPes.alteraPessoaFisica(cod, nome, dataCadastro, tipopes, statusPessoa, obs,
                fiado, email, Listendereco, Listcontato, cpf, rg, nascimento);

        }

        public DataTable retornaPessoa(string strTexto)
        {
            return _MdlPes.retornaPessoa(strTexto);
        }

        public int excluiPessoaFisica(int cod)
        {
            return _MdlPes.excluiPessoa(cod);

        }

    }
}
