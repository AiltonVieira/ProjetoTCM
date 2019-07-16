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
    public partial class TelaFuncionario : Form
    {
        Conexao conexao = new Conexao();
        Funcionario funcionario;
        RepositorioFuncionario repositorio = new RepositorioFuncionario();
        Boolean isImageCaptuerd = false;
        string diretorio;

        public TelaFuncionario()
        {
            InitializeComponent();
            timer1.Start();
            data();

        }
        private void funcionarios_Load(object sender, EventArgs e)
        {
            


        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFone_TextChanged(object sender, EventArgs e)
        {

        }

    //Método para limpar campos
        public void clearScreen()
        {           
            txtCid.Text = "";
            txtNome.Text = "";
            txtcpfCnpj.Text = "";
            txtEnd.Text = "";
            txtCep.Text = "";
            txtEmail.Text = "";
            txtFone.Text = "";
            txtSenha.Text = "";
            txtSenhaNovamente.Text = "";
            cboUf.Text = "";
            txtNome.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Telas.TelaPrincipal().ShowDialog();
        }

        private void btnServiços_Click(object sender, EventArgs e)
        {
            //new Telas.TelaFuncionario().Hide();
            this.Hide();
            new Telas.TelaServico().ShowDialog();
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            //new Telas.TelaFuncionario().Hide();
            this.Hide();
            new Telas.TelaCliente().ShowDialog();
            this.btnClientes.BackColor = Color.Blue;
        }
        private void btnClientes_MouseHouver(object sender, EventArgs e)
        {
            this.btnClientes.BackColor = Color.Blue;
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
        //    btnClientes.Font = Color(555,555,555);
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            //new Telas.TelaConsultaTodos().Hide();
            this.Hide();
            new Telas.TelaConsultaTodos().ShowDialog();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnServiços_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Telas.TelaServico().ShowDialog();
        }

        private void btnlimpar_Click_1(object sender, EventArgs e)
        {
            clearScreen();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {// pega imagem em uma pasta
                isImageCaptuerd = false;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                ofd.Title = "Please Upload Image";


                if (ofd.ShowDialog() == DialogResult.OK)
                {//exibe imagem na pcb

                    isImageCaptuerd = true;
                    picUsuario.Image = Image.FromFile(ofd.FileName);
                    diretorio = ofd.FileName;

                }
            }
            catch (Exception ex)
            {
            }
        }

        private void pegarDiretorio()
        {
            using (FolderBrowserDialog dirDialog = new FolderBrowserDialog())
            {
                // Mostra a janela de escolha do directorio
                DialogResult res = dirDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    // Como o utilizador carregou no OK, o directorio escolhido pode ser acedido da seguinte forma:
                    string directorio = dirDialog.SelectedPath;
                    MessageBox.Show(directorio);
                }
                else
                {
                    // Caso o utilizador tenha cancelado
                    // ...
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            funcionario = new Funcionario();
           
            funcionario._nome = (txtNome.Text);
            funcionario._senha = (txtSenha.Text);
            funcionario._cpfCnpj = (txtcpfCnpj.Text);
            funcionario._endereco = (txtEnd.Text);
            funcionario._cidade = (txtCid.Text);
            funcionario._cep = (txtCep.Text);
            funcionario._email = (txtEmail.Text);
            funcionario._foneFax = (txtFone.Text);
            funcionario._uf = (cboUf.Text);
            funcionario._imagem = diretorio;

            // Verifica se algum campo não está preenchido.
            if (txtNome.Text == "" || txtcpfCnpj.Text == "" || txtEnd.Text == ""
                || txtCid.Text == "" || txtCep.Text == "" || txtEmail.Text == "" 
                || txtFone.Text == "" || cboUf.Text == "" 
                || txtSenha.Text == "" || txtSenhaNovamente.Text == "")
            {   
                verificaCamposVazios();
            }
            //método para preenchimento correto dos campos senha.
            else if (txtSenha.Text != txtSenhaNovamente.Text)
            {
                MessageBox.Show("Senha Incorreta !!!");
            }
            else
            {   //Chamada dos metódos para salvar contato
                repositorio.salvar(funcionario);
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
            else if (txtFone.Text == "")
            {
                txtFone.Focus();
                MessageBox.Show("O campo Fone/Fax está incompleto !!!");
            }
            else if (cboUf.Text == "")
            {
                cboUf.Focus();
                MessageBox.Show("O campo UF está incompleto !!!");
            }
            else if (txtSenha.Text == "")
            {
                txtSenha.Focus();
                MessageBox.Show("O campo Senha está incompleto");
            }
            else if (txtSenhaNovamente.Text == "")
            {
                txtSenhaNovamente.Focus();
                MessageBox.Show("O campo de confirmação está incompleto");
            }
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btnCadastrar.PerformClick();
            }
        }

        private void picFuncionario_Click(object sender, EventArgs e)
        {
           
            verificaFuncionario();
        }

        public void verificaFuncionario()
        {

            funcionario = new Funcionario();
            //MessageBox.Show(repositorios.buscarImagem(funcionario));
            //   repositorios.verificar(funcionario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void lblEscolhaNovamente_Click(object sender, EventArgs e)
        {

        }

        private void txtSenhaNovamente_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcep_Click(object sender, EventArgs e)
        {


        }
        private void data()
        {
            DateTime dt = DateTime.Now;
            lblData.Text = dt.ToShortDateString();
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

