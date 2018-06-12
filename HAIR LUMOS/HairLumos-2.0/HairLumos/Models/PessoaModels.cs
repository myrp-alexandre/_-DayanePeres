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
        

        public int gravaPessoaFisica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs,
            bool fiado, string email, List<Entidades.Endereco> Listendereco, List<Entidades.Contato> Listcontato,
            string cpf, string rg, DateTime nascimento)
        {
            //Entidades.Pessoa _entPessoa = new Entidades.Pessoa();
            Entidades.PessoaFisica _entFis = new Entidades.PessoaFisica();

            //_entPessoa.PessoaFisica.carregaPessoaFisica(cpf, rg, nascimento);


            //_entPessoa.carregaPessoa(cod, nome, dataCadastro, tipopes, statusPessoa, obs, fiado, email,
            //    _entPessoa.PessoaFisica, _entPessoa.PessoaJuridica);

            _entFis.carregaPessoaFisica(cpf, rg, nascimento, cod, nome, dataCadastro, tipopes, statusPessoa, obs, fiado);
            return _DAOPessoa.GravaPessoa(_entFis);

                
            //return _DAOPessoa.GravaPessoa(_entPessoa);
        }

        //public int gravaPessoaJuridica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs,
        //    bool fiado, string email, List<Entidades.Endereco> Listendereco, List<Entidades.Contato> Listcontato,
        //    string cnpj, string razao, string fantasia)
        //{
        //    Entidades.Pessoa _entPessoa = new Entidades.Pessoa();            
        //    Entidades.PessoaJuridica _entJur = new Entidades.PessoaJuridica();


        //    _entPessoa.PessoaJuridica.carregaPessoaJuridica(cnpj, razao, fantasia);

        //    _entPessoa.carregaPessoa(cod, nome, dataCadastro, tipopes, statusPessoa, obs, fiado, email,
        //        _entPessoa.PessoaFisica, _entPessoa.PessoaJuridica);

        //}

        public int alteraPessoaFisica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs,
            bool fiado, string email, List<Entidades.Endereco> Listendereco, List<Entidades.Contato> Listcontato,
            string cpf, string rg, DateTime nascimento)
        {
            //Entidades.Pessoa _entPessoa = new Entidades.Pessoa();
            Entidades.PessoaFisica _entFis = new Entidades.PessoaFisica();

            //_entPessoa.PessoaFisica.carregaPessoaFisica(cpf, rg, nascimento);


            //_entPessoa.carregaPessoa(cod, nome, dataCadastro, tipopes, statusPessoa, obs, fiado, email,
            //    _entPessoa.PessoaFisica, _entPessoa.PessoaJuridica);

            _entFis.carregaPessoaFisica(cpf, rg, nascimento, cod, nome, dataCadastro, tipopes, statusPessoa, obs, fiado);
            return _DAOPessoa.alteraPessoaFisica(_entFis);


            //return _DAOPessoa.GravaPessoa(_entPessoa);
        }

        public int excluiPessoa(int cod)
        {
            //Entidades.Pessoa _entPessoa = new Entidades.Pessoa();
            Entidades.PessoaFisica _entFis = new Entidades.PessoaFisica();

            //_entPessoa.PessoaFisica.carregaPessoaFisica(cpf, rg, nascimento);


            //_entPessoa.carregaPessoa(cod, nome, dataCadastro, tipopes, statusPessoa, obs, fiado, email,
            //    _entPessoa.PessoaFisica, _entPessoa.PessoaJuridica);

            _entFis.carregaPessoaFisica(null, null, DateTime.Now, cod, null, DateTime.Now, null, true, null, false);
            return _DAOPessoa.deletaPessoaFisica(_entFis);


            //return _DAOPessoa.GravaPessoa(_entPessoa);
        }

        public DataTable retornaPessoa(string texto)
        {

            return _DAOPessoa.RetornaPessoa(texto);
        }


    }
}
