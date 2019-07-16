using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCM.dominio
{
    class Relatorio
    {
        private int codigo;
        private int id;
        private string nome;
        private string tipo;
        private string descricao;
        private int dtinicio;
        private int dttermino;
        private string registro;


        public int _codigo { get; set;}
        public int _id { get; set; }
        public string _nome { get; set; }
        public string _tipo { get; set; }
        public string _descricao { get; set; }
        public int _dtinicio { get; set; }
        public int _dttermino { get; set; }
        public string _relatorio { get; set; }


        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public String Nome
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

        public String Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }

        public String Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                descricao = value;
            }
        }

        public int DtInicio
        {
            get
            {
                return dtinicio;
            }
            set
            {
                dtinicio = value;
            }
        }

        public int DtTermino
        {
            get
            {
                return dttermino;
            }
            set
            {
                dttermino = value;
            }
        }

        public String Registro
        {
            get
            {
                return registro;
            }
            set
            {
                registro = value;
            }
        }

    }
}
