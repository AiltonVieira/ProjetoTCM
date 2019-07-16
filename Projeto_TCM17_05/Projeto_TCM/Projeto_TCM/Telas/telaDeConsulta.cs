using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCM.Telas.telasPrincipais
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
            timerHora.Start();
            lbldata.Text = DateTime.Now.ToLongDateString();
    }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new telaPrincipal().ShowDialog();
        }

        private void consultarClientes_Load(object sender, EventArgs e)
        {

        }

        private void lbldata_Click(object sender, EventArgs e)
        {

        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToShortTimeString();
        }

        private void lblhora_Click(object sender, EventArgs e)
        {

        }
    }
}
