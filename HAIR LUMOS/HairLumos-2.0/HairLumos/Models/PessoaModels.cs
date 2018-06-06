using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    public class PessoaModels
    {
        DAO.PessoaDAO _DAOPessoa = new DAO.PessoaDAO();
        

        public int gravaPessoa(int cod, string nome, DateTime dataCadastro, string razao, string rg, string cpf, string cnpj,
            DateTime nascimento, bool fiado, List<Entidades.Endereco> Listendereco, List<Entidades.Contato> Listcontato, string obs, string tipopes)
        {
            Entidades.Pessoa _entPessoa = new Entidades.Pessoa();
            //Entidades.PessoaFisica _entPessoaF = new Entidades.PessoaFisica();
            //Entidades.PessoaJuridica _entPessoaJ = new Entidades.PessoaJuridica();

            //_entPessoa.carregaPessoa(cod, nome, dataCadastro, tipopes, obs, fiado);

            if(tipopes == "F")
            {
                _entPessoa.PessoaFisica = new Entidades.PessoaFisica(cpf, rg, nascimento, cod, nome, dataCadastro, tipopes, true, obs, fiado); 
                
            }
            if (tipopes == "J")
            {
                _entPessoa.PessoaJuridica = new Entidades.PessoaJuridica(razao, nome);
                //_entPessoaJ.carregaPessoaJuridica(razao, nome);
            }
            return _DAOPessoa.GravarPessoa(_entPessoa);
        }
    }
}
