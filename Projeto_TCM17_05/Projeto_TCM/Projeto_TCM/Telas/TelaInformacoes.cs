using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCM.Telas
{
    public partial class TelaInformacoes : Form
    {

        public TelaInformacoes()
        {
            InitializeComponent();
            timer1.Start();
            data();
        }


        ProcessStartInfo sInfo = new ProcessStartInfo("http://www.google.com");



        private void lblhora_Click(object sender, EventArgs e)
        {
            
        }

        private void lblTexto3_Click(object sender, EventArgs e)
        {

        }

        private void linkLblSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(sInfo);
        }

        private void lblTexto5_Click(object sender, EventArgs e)
        {

        }

        private void TelaInformacoes_Load(object sender, EventArgs e)
        {

        }

        private void lblTexto_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaPrincipal().ShowDialog();
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

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new TelaCliente().ShowDialog();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaConsultaTodos().ShowDialog();
        }

        private void btnFuncionarios_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new TelaFuncionario().ShowDialog();
        }

        private void btnInformacoes_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaRelatorio().ShowDialog();
        }

        private void btnServiços_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new TelaServico().ShowDialog();
        }

        private void tsmTrocaUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaLogin().ShowDialog();
        }

        private void tsmSairSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
