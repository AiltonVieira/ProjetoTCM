using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCM.dominio
{
    class Equipamento
    {
        public int codigo;
        private string material;
        private string marca;
        private string finalidade;
        private string especificacao;
        private string preco;
        private string quantidade;

        public int _codigo { get; set; }
        public string _material { get; set; }
        public string _marca { get; set; }
        public string _finalidade { get; set; }
        public string _especificacao { get; set; }
        public string _preco { get; set; }
        public string _quantidade { get; set; }
    }
}
