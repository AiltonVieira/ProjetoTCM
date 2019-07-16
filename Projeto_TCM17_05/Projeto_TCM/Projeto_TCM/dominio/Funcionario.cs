using Projeto_TCM.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCM.dominio
{
    class Funcionario:Pessoa
    {
        //Declarações dos atributos
        private int codigo;
        private string nome;
        private string cpfCnpj;
        private string endereco;
        private string cidade;
        private string uf;
        private string cep;
        private string email;
        private string foneFax;
        private string senha;
        private string imagem;

        public Funcionario()
        {
        }
                
        //Declarações dos getters e setters
        public int _codigo { get; set; }
        public string _nome { get ; set; }
        public string _senha { get; set; }
        public string _cpfCnpj { get ; set; }
        public string _endereco { get ; set; }
        public string _cidade { get ; set; }
        public string _cep { get; set; }
        public string _email { get; set; }
        public string _foneFax { get; set; }
        public string _uf { get ; set; }
        public string _imagem { get; set; }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
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

        public string Endereco
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

        public string Cidade
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
        
        public String Email
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

        public int Imagem
        {
            get
            {
                return Imagem;
            }

            set
            {
                Imagem = value;
            }
        }


    }
}



