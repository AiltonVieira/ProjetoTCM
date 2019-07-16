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
    public partial class TelaServico : Form
    {
        Conexao conexao = new Conexao();
        dominio.Servico Servi;
        RepositorioServico repositorio = new RepositorioServico();
        DateTime dt = DateTime.Now;
        //Fim da declaração

        public TelaServico()
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

        private void Serviços_Load(object sender, EventArgs e)
        {
            //Adicionar argumentos na combobox
            //cmbUf.Items.Add("");
            
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            clearScreen();
        }

        //Método para limpar todos os campos.
        public void clearScreen()
        {
            txtempresa.Text = "";
            txtcpfCnpj.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            cmbUf.Text = "";
            txtCep.Text = "";
            txtdataInicio.Text = "";
            txtdataTermino.Text = "";
            txtValor.Text = "";
            txtdescricaoDoServico.Text = "";
            cmbSituacao.Text = "";            
            txtempresa.Focus();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == null)
            {
                MessageBox.Show("Não é possivel cadastrar um serviço sem um valor");
            }
            else
            {

                Servi = new Servico();
                Servi._empresa = (txtempresa.Text);
                Servi._cpfCnpj = (txtcpfCnpj.Text);
                Servi._endereco = (txtEndereco.Text);
                Servi._cidade = (txtCidade.Text);
                Servi._uf = (cmbUf.Text);
                Servi._cep = (txtCep.Text);
                Servi._dataInicio = (txtdataInicio.Text);
                Servi._dataTermino = (txtdataTermino.Text);
                Servi._valor = float.Parse(txtValor.Text);
                Servi._descricaoDoServico = (txtdescricaoDoServico.Text);
                Servi._situacaoDoServico = (cmbSituacao.Text);
                Servi._relatorio = ("");
                
                // Verifica se algum campo não está preenchido.
                if (txtempresa.Text == "" || txtcpfCnpj.Text == "" || txtEndereco.Text == ""
                    || txtCidade.Text == "" || cmbUf.Text == "" || txtCep.Text == ""
                    || txtdataInicio.Text == "" || txtdataTermino.Text == ""
                    || txtValor.Text == "" || txtdescricaoDoServico.Text == ""
                    || cmbSituacao.Text == "" && txtValor.Text == null)
                {
                    verificaCamposVazios();
                }

                else
                {
                    //Chamada dos metódos para salvar contato
                    repositorio.salvar(Servi);
                }
            }
            
        }
        public void verificaCamposVazios()
        {
            if (txtempresa.Text == "")
            {
                txtempresa.Focus();
                MessageBox.Show("O campo Nome está incompleto !!!");
            }
            else if (txtcpfCnpj.Text == "")
            {
                txtcpfCnpj.Focus();
                MessageBox.Show("O campo CPF está incompleto !!!");
            }
            else if (txtEndereco.Text == "")
            {
                txtEndereco.Focus();
                MessageBox.Show("O campo Endereço está incompleto !!!");
            }
            else if (txtCidade.Text == "")
            {
                txtCidade.Focus();
                MessageBox.Show("O campo Cidade está incompleto !!!");
            }
            else if (cmbUf.Text == "")
            {
                txtCep.Focus();
                MessageBox.Show("O campo UF está incompleto !!!");
            }
            else if (txtCep.Text == "")
            {
                txtCep.Focus();
                MessageBox.Show("O campo CEP está incompleto !!!");
            }
            else if (txtdataInicio.Text == "")
            {
                txtdataInicio.Focus();
                MessageBox.Show("O campo data de inicio está incompleto !!!");
            }
            else if (txtdataTermino.Text == "")
            {
                txtdataTermino.Focus();
                MessageBox.Show("O campo data de término está incompleto !!!");
            }
            else if (txtValor.Text == "")
            {
                txtValor.Focus();
                MessageBox.Show("O campo valor está incompleto !!!");
            }
            
            else if (txtdescricaoDoServico.Text == "")
            {
                txtdescricaoDoServico.Focus();
                MessageBox.Show("O campo descrição do serviço está incompleto !!!");
            }
            else if (cmbSituacao.Text == "")
            {
                cmbSituacao.Focus();
                MessageBox.Show("O campo situação do serviço está incompleto !!!");
            }
             
        }

        public void comboBoxUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //new Telas.TelaServico().Hide();
            this.Hide();
            new Telas.TelaCliente().ShowDialog();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Telas.TelaConsultaTodos().ShowDialog();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Telas.TelaFuncionario().ShowDialog();
        }

        private void btnInformacoes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Telas.TelaInformacoes().ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Telas.TelaRelatorio().ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsmSairSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmTrocaUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaLogin().ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFuncionarios_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new TelaFuncionario().ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Telas.TelaCliente().ShowDialog();
        }

        private void btnConsulta_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new TelaConsultaTodos().ShowDialog();
        }

        private void btnRelatorio_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new TelaRelatorio().ShowDialog();
        }

        private void btnInformacoes_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new TelaInformacoes().ShowDialog();
        }

        private void lblempresa_Click(object sender, EventArgs e)
        {

        }

        private void btnEquipamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaEquipamento().ShowDialog();
        }

        private void timerDataHora_Tick(object sender, EventArgs e)
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
