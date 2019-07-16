using Projeto_TCM.repositorio;
using Projeto_TCM.dominio;
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
    public partial class TelaEquipamento : Form
    {
        Conexao conexao = new Conexao();
        dominio.Equipamento equip;
        Equipamento equipamento = new Equipamento(); // cadastrar novo equipamento
        RepositorioEquipamento repositorio = new RepositorioEquipamento();
        DateTime dt = DateTime.Now;

        String uso;
        String venda;

        //fim da declaração


        public TelaEquipamento()
        {

            InitializeComponent();
            timer1.Start();
            data();
        }
        public void verificaCamposVazios()
        {
            if (txtMaterial.Text == "")
            {
                txtMaterial.Focus();
                MessageBox.Show("O campo Material está incompleto !!!");
            }
            else if (txtMarca.Text == "")
            {
                txtMarca.Focus();
                MessageBox.Show("O campo Marca está incompleto !!!");
            }
            else if (txtEspecificacao.Text == "")
            {
                txtEspecificacao.Focus();
                MessageBox.Show("O campo Especificação está incompleto !!!");
            }
            else if (txtPreco.Text == "")
            {
                txtPreco.Focus();
                MessageBox.Show("O campo Preço está incompleto !!!");
            }
            else if (txtQuantidade.Text == "")
            {
                txtQuantidade.Focus();
                MessageBox.Show("O campo Quantidade está incompleto !!!");

            }
            else if (!radUso.Checked && !radVenda.Checked)
            {
                MessageBox.Show("Selecione o tipo de Finalidade !!!");
            }
        }


        private void btncadastrar_Click(object sender, EventArgs e)
        {
            equipamento._material = (txtMaterial.Text);
            equipamento._marca = (txtMarca.Text);
            equipamento._especificacao = (txtEspecificacao.Text);
            equipamento._preco = (txtPreco.Text);
            equipamento._quantidade = (txtQuantidade.Text);
            equipamento._finalidade = (radUso.Text);

            if (!radUso.Checked && radVenda.Checked)
            {
                equipamento._finalidade = (radVenda.Text);
            } else
            {
                equipamento._finalidade = (radUso.Text);
            }

            //Verifica se algum campo não está preenchido.
            if (txtMaterial.Text == "" || txtMarca.Text == "" || txtEspecificacao.Text == ""
                || txtPreco.Text == "" || txtQuantidade.Text == ""
                || !radUso.Checked && !radVenda.Checked)
            {
                verificaCamposVazios();
            }
            else
            {   //Chamada dos metódos para salvar cliente
                repositorio.salvar(equipamento);
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            clearScreen();
        }
        //Método para limpar campos
        public void clearScreen()
        {
            txtMaterial.Text = "";
            txtMarca.Text = "";
            txtEspecificacao.Text = "";
            txtPreco.Text = "";
            txtQuantidade.Text = "";
            radUso.Checked = true;
            radVenda.Checked = false;
            txtMaterial.Focus();
        }
        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaPrincipal().ShowDialog();
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

        private void btnServiços_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaServico().ShowDialog();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaConsultaTodos().ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaCliente().ShowDialog();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaFuncionario().ShowDialog();
        }

        private void btnEquipamento_Click(object sender, EventArgs e)
        {
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

        public void retornofinalidade(string valor)
        {
            string finalidade = valor;

            if (finalidade.Equals("USO"))
            {
                radUso.Checked = true;
            }else if (finalidade.Equals("VENDA")){
                radVenda.Checked = true;
            }
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            retornofinalidade(textBox1.Text);
        }*/

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            RepositorioEquipamento repositorioe = new RepositorioEquipamento();
            repositorioe.atualizar(equipamento);
        }
    }
 }
