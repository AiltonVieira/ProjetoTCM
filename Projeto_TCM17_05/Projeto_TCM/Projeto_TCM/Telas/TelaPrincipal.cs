using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCM.Telas
{
    
    public partial class TelaPrincipal : Form
    {
        Conexao con = new Conexao();
        
        public TelaPrincipal()
        {

            InitializeComponent();
            timer1.Start();
            data();
        }

        private void telaPrincipal_Load(object sender, EventArgs e)
        {
                   
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Telas.TelaCliente().ShowDialog();

        }

        private void btnServiços_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Telas.TelaServico().ShowDialog();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Telas.TelaFuncionario().ShowDialog();
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            con.ConectarBD();
            con.ChecarConexao();
            con.DesconectarBD();

        }

        private void tipConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Telas.TelaConsultaTodos().ShowDialog();
        }
        
        private void tipSair_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new TelaLogin().ShowDialog();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaConsultaTodos().ShowDialog();
        }

        private void picConsulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaConsultaTodos().ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Telas.TelaRelatorio().ShowDialog();
        }

        private void btnInformacoes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Telas.TelaInformacoes().ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trocarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaLogin().ShowDialog();
        }

        private void menStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnEquipamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaEquipamento().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }
        private void data()
        {
            DateTime dt = DateTime.Now;
            lblData.Text = dt.ToShortDateString();
        }

    }
}
