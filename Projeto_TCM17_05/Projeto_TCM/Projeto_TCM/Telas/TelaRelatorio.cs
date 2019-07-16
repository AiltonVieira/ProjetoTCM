using Projeto_TCM.dominio;
using Projeto_TCM.repositorio;
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
    public partial class TelaRelatorio : Form
    {
        DateTime dt = DateTime.Now;
        RepositorioServico repositorios = new RepositorioServico();
        RepositorioRelatorio repositorior = new RepositorioRelatorio();
        public TelaRelatorio()
        {
            InitializeComponent();
            timerDataHora.Start();
            data();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaPrincipal().ShowDialog();

        }

        private void lbldata_Click(object sender, EventArgs e)
        {

        }

        private void relatório_Load(object sender, EventArgs e)
        {

        }


        private void btnenviar_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {

        }

        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
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
            this.Hide();
            new TelaInformacoes().ShowDialog();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSituacaodoServico_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  cmbSituacaoServico.Items.Add("Disponível");
        }

        private void trocarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaLogin().ShowDialog();
        }

        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
           if (cmbPesquisa.SelectedItem.Equals("Disponível"))
                {
                    string situacao = (cmbPesquisa.Text);
                    DataSet ds = new DataSet();
                    ds = repositorios.buscarPorSituacao(situacao);
                    dgvServico.DataSource = ds.Tables[0];
                    dgvServico.Refresh();
                }
            if (cmbPesquisa.SelectedItem.Equals("Em Andamento"))
            {
                string situacao = (cmbPesquisa.Text);
                DataSet ds = new DataSet();
                ds = repositorior.buscarPorSituacao(situacao);
                dgvServico.DataSource = ds.Tables[0];
                dgvServico.Refresh();
            }
            if (cmbPesquisa.SelectedItem.Equals("Encerrado"))
            {
                string situacao = (cmbPesquisa.Text);
                DataSet ds = new DataSet();
                ds = repositorior.buscarPorSituacao(situacao);
                dgvServico.DataSource = ds.Tables[0];
                dgvServico.Refresh();
            }
        }

        private void txtServico_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEquipamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaEquipamento().ShowDialog();
        }

        private void dgvServico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RepositorioServico repositorios = new RepositorioServico();
            TelaRelatorio servico = new TelaRelatorio();
            if (e.RowIndex >= 0)
            {
                servico.txtCodigo.Text = dgvServico.Rows[e.RowIndex].Cells[0].Value.ToString();
                servico.txtEmpresa.Text = dgvServico.Rows[e.RowIndex].Cells[1].Value.ToString();
                servico.txtDtInicio.Text = dgvServico.Rows[e.RowIndex].Cells[7].Value.ToString();
                servico.txtDtTermino.Text = dgvServico.Rows[e.RowIndex].Cells[8].Value.ToString();
                servico.txtValor.Text = dgvServico.Rows[e.RowIndex].Cells[9].Value.ToString();
                servico.txtDescricao.Text = dgvServico.Rows[e.RowIndex].Cells[10].Value.ToString();
                servico.cmbSituacao.Text = dgvServico.Rows[e.RowIndex].Cells[11].Value.ToString();
                servico.txtRelatorio.Text = dgvServico.Rows[e.RowIndex].Cells[12].Value.ToString();
                servico.ShowDialog();
            }
            
        }

        private void data()
        {
            DateTime dt = DateTime.Now;
            lblData.Text = dt.ToShortDateString();
        }

    }
   }
