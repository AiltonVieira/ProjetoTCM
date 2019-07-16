using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win
{
    public partial class Exemplo : Form
    {
        public Exemplo()
        {
            InitializeComponent();
        }

        private void Exemplo_Load(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now;
            //TssDATA
            tss.Text = dt.ToLongDateString();
            ExibirHora();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssHora.Text = DateTime.Now.ToLongTimeString();
        }


        private void ExibirHora()
        {
            DateTime dt = DateTime.Now;
            tssHora.Text = dt.ToLongTimeString();
        }
    }
}
