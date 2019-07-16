using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCM.repositorio
{
    interface IRepositorio<T>
    {
        void salvar(T t);

    }
}
