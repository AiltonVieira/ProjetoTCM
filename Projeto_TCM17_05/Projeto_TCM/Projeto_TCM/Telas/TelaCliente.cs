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
    public partial class TelaCliente : Form
    {
        Conexao conexao = new Conexao();
        dominio.Cliente contato;
        Cliente cliente = new Cliente(); // Cadastrar novo Cliente
        RepositorioCliente repositorio = new RepositorioCliente();
        DateTime dt = DateTime.Now;

        //Fim da declaração

        public TelaCliente()
        {

            InitializeComponent();
            data();
            timer1.Start();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            chkFisica.Checked = true;
        }

        private void retPrincipal_Click(object sender, EventArgs e)
        {
            //this.ShowDialog(); Voltar para anterior
            this.Hide();
            new Telas.TelaPrincipal().ShowDialog();
        }


        private void btnlimpar_Click(object sender, EventArgs e)
        {
            clearScreen();
        }

        //Método para limpar campos
        public void clearScreen()
        {
            txtNome.Text = "";
            txtcpfCnpj.Text = "";
            txtCid.Text = "";
            cboUf.Text = "";
            txtCep.Text = "";
            txtEmail.Text = "";
            txtFoneFax.Text = "";
            txtComplemento.Text = "";
            txtEnd.Text = "";
            cboUf.Text = "";
            chkFisica.Checked = false;
            chkJuridica.Checked = false;
            txtNome.Focus();
        }

        //CheckedListeBox ativa
        public void checkedListeBoxAtiva()
        {
            
            if (chkJuridica.Checked)
            {
                chkFisica.Checked = !chkJuridica.Checked;
              
               
            }
            if (chkFisica.Checked)
            {
                chkJuridica.Checked = !chkFisica.Checked;
            }
        }

        
        private void chnFisica_CheckedChanged(object sender, EventArgs e)
        {
            
            checkedListeBoxAtiva();
        }

        private void chnJuridica_CheckedChanged(object sender, EventArgs e)
        {

            checkedListeBoxAtiva();
        }
        private void data()
        {
            DateTime dt = DateTime.Now;
            lblData.Text = dt.ToShortDateString();
        }


        private void btncadastrar_Click(object sender, EventArgs e)
        {
            cliente._nome = (txtNome.Text);
            cliente._cpfCnpj = (txtcpfCnpj.Text);
            cliente._endereco = (txtEnd.Text);
            cliente._cidade = (txtCid.Text);
            cliente._uf = (cboUf.Text);
            cliente._complemento = (txtComplemento.Text);
            cliente._cep = (txtCep.Text);
            cliente._email = (txtEmail.Text);
            cliente._foneFax = (txtFoneFax.Text);

            if (chkFisica.Checked)
            {
                cliente._chnTipoCliente = (chkFisica.Text);
                chkJuridica.Checked = false;
            }
            else if (chkJuridica.Checked)
            {
                cliente._chnTipoCliente = (chkJuridica.Text);
                chkFisica.Checked = false;
            }
            else if(!chkFisica.Checked && !chkJuridica.Checked)
            {
                chkFisica.Checked = false;
                chkJuridica.Checked = false;
                
            }

            //Verifica se algum campo não está preenchido.
            if (txtNome.Text == "" || txtcpfCnpj.Text == "" || txtEnd.Text == ""
                || txtCid.Text == "" || txtComplemento.Text == "" || txtCep.Text == ""
                || txtEmail.Text == "" || txtFoneFax.Text == "" || cboUf.Text == ""
                || !chkFisica.Checked && !chkJuridica.Checked)
            {
                verificaCamposVazios();
            }
            else
            {   //Chamada dos metódos para salvar cliente
                repositorio.salvar(cliente);
            }
        }

            public void verificaCamposVazios()
        {
            if (txtNome.Text == "")
            {
                txtNome.Focus();
                MessageBox.Show("O campo Nome está incompleto !!!");
            }
            else if (txtcpfCnpj.Text == "")
            {
                txtcpfCnpj.Focus();
                MessageBox.Show("O campo CPF está incompleto !!!");
            }
            else if (txtEnd.Text == "")
            {
                txtEnd.Focus();
                MessageBox.Show("O campo Endereço está incompleto !!!");
            }
            else if (txtCid.Text == "")
            {
                txtCid.Focus();
                MessageBox.Show("O campo Cidade está incompleto !!!");
            }
            else if (cboUf.Text == "")
            {
                cboUf.Focus();
                MessageBox.Show("O campo UF está incompleto !!!");
            }
            else if (txtComplemento.Text == "")
            {
                txtCep.Focus();
                MessageBox.Show("O campo Complemento está incompleto !!!");
            }
            else if (txtCep.Text == "")
            {
                txtCep.Focus();
                MessageBox.Show("O campo CEP está incompleto !!!");
            }
            else if (txtEmail.Text == "")
            {
                txtEmail.Focus();
                MessageBox.Show("O campo E-MAIL está incompleto !!!");
            }
            else if (txtFoneFax.Text == "")
            {
                txtFoneFax.Focus();
                MessageBox.Show("O campo Fone/Fax está incompleto !!!");
            }
            else if (!chkFisica.Checked && chkJuridica.Checked)
            {
                chkJuridica.Checked = true;
            }
            else if (!chkJuridica.Checked && chkFisica.Checked)
            {
                chkFisica.Checked = true;
            }
            else if (!chkFisica.Checked && !chkJuridica.Checked)
            {
                MessageBox.Show("Selecione o tipo de cliente");
            }
             
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            //new Telas.TelaCliente().Hide();
            this.Hide();
            new Telas.TelaFuncionario().ShowDialog();
        }

        private void btnServiços_Click(object sender, EventArgs e)
        {
            //new Telas.TelaCliente().Hide();
            this.Hide();
            new Telas.TelaServico().ShowDialog();
        }
        
        
        private void lblhora_Click(object sender, EventArgs e)
        {
           
        }

        private void timerDataHora_Tick(object sender, EventArgs e)
        {
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

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void cboUF_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void srFulanoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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
    }
 }




