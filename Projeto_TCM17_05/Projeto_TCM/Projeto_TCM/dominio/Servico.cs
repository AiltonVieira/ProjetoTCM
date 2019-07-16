using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCM.dominio
{
    class Servico
    {
        //Declaração dos atributos.
        public int codigo;
        private string empresa;
        private string cpfCnpj;
        private string endereco;
        private string cidade;
        private string uf;
        private string cep;
        private string dataInicio;
        private string dataTermino;
        private float valor;
        private string finalidade;
        private string descricaoDoServico;
        private string situacaoDoServico;
        private string relatorio;

        //Declaraçãpo dos getters e setters
        public int _codigo { get; set; }
        public string _empresa { get; set; }
        public string _cpfCnpj { get; set; }
        public string _endereco { get; set; }
        public string _cidade { get; set; }
        public string _uf { get; set; }
        public string _cep { get; set; }
        public string _dataInicio { get; set; }
        public string _dataTermino { get; set; }
        public float _valor { get; set; }
        public string _finalidade { get; set; }
        public string _descricaoDoServico { get; set; }
        public string _situacaoDoServico { get; set; }
        public string _relatorio { get; set; }



    }
}

