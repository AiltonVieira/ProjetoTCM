using Projeto_TCM.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new TelaSplash());

            //Application.Run(new TelaLogin());
            //Application.Run(new TelaConsultaTodos());
            //Application.Run(new Telas.TelaPrincipal());
            //Application.Run(new Telas.TelaFuncionario());
            //Application.Run(new Telas.TelaInformacoes());
            //Application.Run(new Telas.TelaServico());
            //Application.Run(new Telas.TelaRelatorio());
            //Application.Run(new Telas.TelaRelatorio());
            //Application.Run(new Telas.TelaInformacoes());
            //Application.Run(new TelaCliente());
            //Application.Run(new TelaServico());
            Application.Run(new TelaEquipamento());

        }
    }
}
