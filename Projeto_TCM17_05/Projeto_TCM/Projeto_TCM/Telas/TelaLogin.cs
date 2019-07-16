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
    public partial class TelaLogin : Form
    {

        Conexao conexao = new Conexao();
        Funcionario funcionario;
        repositorioLog repositorio = new repositorioLog();
         
        //Fim da declaração

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        


        private void btnentrar_Click(object sender, EventArgs e)
        {
            //(!String.IsNullOrEmpty)variavel que verifica se esta nulo o campo
            if (!String.IsNullOrEmpty(txtUsuario.Text) && (!String.IsNullOrEmpty(txtSenha.Text)))
            {

                //Método para realizar o login
                if (login())
                {
                    //Metodo para chamar proxima tela
                    passagemTela();
                }else
                {
                    MessageBox.Show("Não Cadastrado !", "Ops"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               

            }
            else
            {
                verificaCampoVazio();
            }
            
        }

        private void telaLogin_Load(object sender, EventArgs e)
        {

        }

        public void passagemTela()
        {
            this.Hide();
            TelaSplash splash = new TelaSplash();
            splash.ShowDialog();
        }

        public bool login()
        {
            funcionario = new Funcionario();
            funcionario._cpfCnpj = (txtUsuario.Text);
            funcionario._senha = (txtSenha.Text);

            verificaCampoVazio();
            //Chamada dos metódos para salvar serviço
               return repositorio.verificarCadastro(funcionario);
        }

        private void txtsenha_KeyUp(object sender, KeyEventArgs e)
        { 
            if(e.KeyCode == Keys.Enter)
            {
                btnentrar.PerformClick();
            }
        }

        private void verificaCampoVazio()
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Focus();
                txtUsuario.SelectAll();
            }
            else
            {
                txtSenha.Focus();
                txtSenha.SelectAll();
            }
        }

       
    }
}
