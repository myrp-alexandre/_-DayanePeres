using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    public class PessoaController
    {
        private Models.PessoaModels _MdlPes = new Models.PessoaModels();

        public int gravarPessoa(int cod, string nome, DateTime dataCadastro, string razao, string rg, string cpf, string cnpj,
            DateTime nascimento, bool fiado, List<Entidades.Endereco> Listendereco, List<Entidades.Contato> Listcontato, string obs, string tipoPes)
        {
            return _MdlPes.gravaPessoa(cod, nome, dataCadastro, razao, rg, cpf, cnpj, nascimento, fiado, Listendereco, Listcontato, obs, tipoPes);
        }
    }
}
