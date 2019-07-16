using Projeto_TCM.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCM.dominio
{
    class Cliente
      {
        private int codigo;
        private string nome;
        private string cpfCnpj;
        private string endereco;
        private string cidade;
        private string uf;
        private string cep;
        private string email;
        private string chnTipoCliente;
        private string fone_fax;

        public int _codigo { get; set; }
        public string _nome { get; set; }
        public string _cpfCnpj { get; set; }
        public string _endereco { get; set; }
        public string _cidade { get; set; }
        public string _uf { get; set; }
        public string _cep { get; set; }
        public string _complemento { get; set; }
        public string _email { get; set; }
        public string _foneFax { get; set; }
        public string _chnTipoCliente { get; set; }

        public String Nome
        {
            get
            {
                return Nome;
            }

            set
            {
                Nome = value;
            }
        }

       

        public string CpfCnpj
        {
            get
            {
                return CpfCnpj;
            }
            set
            {
                CpfCnpj = value;
            }
        }
        
        public String Endereco
        {
            get
            {
                return Endereco;
            }
            set
            {
                Endereco = value;
            }
        }
        
        public String Cidade
        {
            get
            {
                return Cidade;
            }
            set
            {
                Cidade = value;
            }
        }
        
        public string Uf
        {
            get
            {
                return Uf;

            }
            set
            {
                Uf = value;
            }
        }

        public string Cep
        {
            get
            {
                return Cep;
            }
            set
            {
                Cep = value;
            }
        }

        public string Email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }

        public string FoneFax
        {
            get
            {
                return FoneFax;
            }
            set
            {
                FoneFax = value;
            }
        }

    }
}




