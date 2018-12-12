using HairLumos.Entidades;
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


        public int gravarPessoaFisica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs, bool fiado, string email, Endereco endereco, string telefone, string celular,
            string cpf, string rg, DateTime nascimento)
        {
            return _MdlPes.gravaPessoaFisica(cod, nome, dataCadastro, tipopes, statusPessoa, obs,
                fiado, email, endereco, telefone, celular, cpf, rg, nascimento);

        }

        public int gravarPessoaJuridica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs, bool fiado, string email, Endereco endereco, string telefone, string celular,
            string cnpj, string razao)
        {
            return _MdlPes.gravaPessoaJuridica(cod, nome, dataCadastro, tipopes, statusPessoa, obs,
                fiado, email, endereco, telefone, celular, cnpj, razao);

        }

        public int alteraPessoaFisica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs, bool fiado, string email, Endereco endereco, string telefone, string celular,
            string cpf, string rg, DateTime nascimento)
        {
            return _MdlPes.alteraPessoaFisica(cod, nome, dataCadastro, tipopes, statusPessoa, obs,
                fiado, email, endereco, telefone, celular, cpf, rg, nascimento);

        }

        public int alteraPessoaJuridica(int cod, string nome, DateTime dataCadastro, string tipopes, bool statusPessoa, string obs, bool fiado, string email, Endereco endereco, string telefone, string celular,
            string cnpj, string razao)
        {
            return _MdlPes.alteraPessoaJuridica(cod, nome, dataCadastro, tipopes, statusPessoa, obs,
                fiado, email, endereco, telefone, celular, cnpj, razao);

        }

        public DataTable retornaPessoa(string strTexto)
        {
            return _MdlPes.retornaPessoa(strTexto);
        }

        public DataTable retornaPessoaCompra(string strTexto)
        {
            return _MdlPes.retornaPessoaCompra(strTexto);
        }

        public DataTable retornaPessoaCod(string strCod)
        {
            return _MdlPes.retornaPessoaCod(strCod);
        }

        public DataTable retornaPessoaFisicaCod(int strCod)
        {
            return _MdlPes.retornaPessoaFisica(strCod);
        }

        public DataTable retornaCpf(string strCpf)
        {
            return _MdlPes.retornaCpf(strCpf);
        }
            

        public DataTable retornaPessoaFisica()
        {
            return _MdlPes.retornaPessoaFisica();
        }

        public DataTable retornaPessoaJuridicaCod(int strCod)
        {
            return _MdlPes.retornaPessoaJuridica(strCod);
        }

        public DataTable retornaPessoaJuridicaCnpj(string cnpj)
        {
            return _MdlPes.retornaPessoaJuridicaCnpj(cnpj);
        }

        public DataTable retornaPessoaJuridica(string texto)
        {
            return _MdlPes.retornaPessoaJuridica(texto);
        }

        public DataTable retornaPessoaJuridica()
        {
            return _MdlPes.retornaPessoaJuridica();
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

        public DataTable retornaEndereco(int cod)
        {
            return _MdlPes.retornaEndereco(cod);
        }

        public DataTable retornaCidCodigo(int codcid)
        {
            return _MdlPes.retornaCidCodigo(codcid);
        }
    }
}
