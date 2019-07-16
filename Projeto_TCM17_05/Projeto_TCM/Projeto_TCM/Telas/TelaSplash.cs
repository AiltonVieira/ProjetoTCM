using Projeto_TCM.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCM
{
    public partial class TelaSplash : Form
    {
        public TelaSplash()
        {
            InitializeComponent();
           barraProgresso.Maximum = 100;
            timer1.Start();
        }

        private void lblCarregando_Click(object sender, EventArgs e)
        {

        }

        private void barraProgresso_Click(object sender, EventArgs e)
        {

        }

    

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (barraProgresso.Value < 100)
            {
                barraProgresso.Value = barraProgresso.Value + 2;
                lblCarregando.Text = barraProgresso.Value.ToString() + "%";
                
            }
            else
            {
                timer1.Stop();
                this.Hide();
                new TelaPrincipal().ShowDialog();
            }
            
        }

        private void telaSplash_Load(object sender, EventArgs e)
        {

        }
    }
    
}

