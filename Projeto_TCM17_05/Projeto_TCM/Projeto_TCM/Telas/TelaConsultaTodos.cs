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
    public partial class TelaConsultaTodos : Form
    {
        RepositorioCliente repositorioc = new RepositorioCliente();
        RepositorioFuncionario repositoriof = new RepositorioFuncionario();
        RepositorioServico repositorios = new RepositorioServico();
        RepositorioEquipamento repositorioEquip = new RepositorioEquipamento();
        DateTime dt = DateTime.Now;

        public TelaConsultaTodos()
        {
            InitializeComponent();
            timer1.Start();
            data();
        }


        private void consultaTodos_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            //new Telas.TelaConsultaTodos().Hide();
            this.Hide();
            new Telas.TelaCliente().ShowDialog();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            //new Telas.TelaConsultaTodos().Hide();
            this.Hide();
            new Telas.TelaFuncionario().ShowDialog();
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            //new Telas.TelaConsultaTodos().Hide();
            this.Hide();
            new Telas.TelaServico().ShowDialog();
        }

        private void btnInformacoess_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Telas.TelaInformacoes().ShowDialog();
        }

        private void btnRelatorioo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Telas.TelaRelatorio().ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Telas.TelaPrincipal().ShowDialog();
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbPorTipo.SelectedItem.Equals("Cliente"))
            {
                if (cmbPorCampo.SelectedItem.Equals("Código"))
                {
                    String codigo = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositorioc.buscarPorCodigo(codigo);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
                if (cmbPorCampo.SelectedItem.Equals("Nome"))
                {
                    String nome = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositorioc.buscarPorNome(nome);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
                if (cmbPorCampo.SelectedItem.Equals("CPF"))
                {
                    String cpfcnpj = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositorioc.buscarPorCPFCNPJ(cpfcnpj);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
                /*if (cmbPorCampo.SelectedItem.Equals("Endereço"))
                {
                    String endereco = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositorioc.buscarPorEndereco(endereco);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
                if (cmbPorCampo.SelectedItem.Equals("Cidade"))
                {
                    String cidade = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositorioc.buscarPorCidade(cidade);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
                if (cmbPorCampo.SelectedItem.Equals("UF"))
                {
                    String uf = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositorioc.buscarPorUF(uf);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }*/
                if (cmbPorCampo.SelectedItem.Equals("CEP"))
                {
                    String cep = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositorioc.buscarPorCEP(cep);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
                /* if (cmbPorCampo.SelectedItem.Equals("Email"))
                 {
                     String email = (txtConsulta.Text);
                     DataSet ds = new DataSet();
                     ds = repositorioc.buscarPorEmail(email);
                     dgvConsulta.DataSource = ds.Tables[0];
                     dgvConsulta.Refresh();
                 }
                 if (cmbPorCampo.SelectedItem.Equals("Fone"))
                 {
                     String fone = (txtConsulta.Text);
                     DataSet ds = new DataSet();
                     ds = repositorioc.buscarPorFone(fone);
                     dgvConsulta.DataSource = ds.Tables[0];
                     dgvConsulta.Refresh();
                 }
                 if (cmbPorCampo.SelectedItem.Equals("Tipo"))
                 {
                     String tipo = (txtConsulta.Text);
                     DataSet ds = new DataSet();
                     ds = repositorioc.buscarPorTipoCliente(tipo);
                     dgvConsulta.DataSource = ds.Tables[0];
                     dgvConsulta.Refresh();
                 }*/
            }

            if (cmbPorTipo.SelectedItem.Equals("Funcionário"))
            {
                if (cmbPorCampo.SelectedItem.Equals("Código"))
                {
                    String codigo = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositoriof.buscarPorCodigo(codigo);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
                if (cmbPorCampo.SelectedItem.Equals("Nome"))
                {
                    String nome = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositoriof.buscarPorNome(nome);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
                if (cmbPorCampo.SelectedItem.Equals("CPF/CNPJ"))
                {
                    String cpf = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositoriof.buscarPorCPF(cpf);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
                /*if (cmbPorCampo.SelectedItem.Equals("Cidade"))
                {
                    String cidade = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositoriof.buscarPorCidade(cidade);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
                if (cmbPorCampo.SelectedItem.Equals("Usuario"))
                {
                    String usuario = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositoriof.buscarPorUsuario(usuario);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }*/
            }

            if (cmbPorTipo.SelectedItem.Equals("Serviço"))
            {
                if (cmbPorCampo.SelectedItem.Equals("Código"))
                {
                    String codigo = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositorios.buscarPorCodigo(codigo);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
                if (cmbPorCampo.SelectedItem.Equals("Empresa"))
                {
                    String empresa = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositorios.buscarPorEmpresa(empresa);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
                if (cmbPorCampo.SelectedItem.Equals("Data de Inicio"))
                {
                    String DataInicio = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositorios.buscarPorDataInicio(DataInicio);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
            }

            if (cmbPorTipo.SelectedItem.Equals("Equipamento"))
            {

                if (cmbPorCampo.SelectedItem.Equals("Material"))
                {
                    String Material = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositorioEquip.buscarPorEquipamento(Material);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
                if (cmbPorCampo.SelectedItem.Equals("Marca"))
                {
                    String Marca = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositorioEquip.buscarPorMarca(Marca);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
                if (cmbPorCampo.SelectedItem.Equals("Finalidade"))
                {
                    String finalidade = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositorioEquip.buscarPorFinalidade(finalidade);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
                if (cmbPorCampo.SelectedItem.Equals("Especificacao"))
                {
                    String especificacao = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositorioEquip.buscarPorEspecificacao(especificacao);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
                if (cmbPorCampo.SelectedItem.Equals("Preço"))
                {
                    String preco = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositorioEquip.buscarPorPreco(preco);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
                if (cmbPorCampo.SelectedItem.Equals("Id"))
                {
                    String Id = (txtConsulta.Text);
                    DataSet ds = new DataSet();
                    ds = repositorioEquip.buscarPorID(Id);
                    dgvConsulta.DataSource = ds.Tables[0];
                    dgvConsulta.Refresh();
                }
            }
        }

        private void cmbPorCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPorTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPorTipo.Text == "Cliente")
            {
                cmbPorCampo.Items.Clear();
                cmbPorCampo.Items.Add("Código");
                //cmbPorCampo.Items.Add("Tipo");
                cmbPorCampo.Items.Add("Nome");
                cmbPorCampo.Items.Add("CPF");
                //cmbPorCampo.Items.Add("Endereço");
                //cmbPorCampo.Items.Add("Cidade");
                //cmbPorCampo.Items.Add("UF");
                cmbPorCampo.Items.Add("CEP");
                //cmbPorCampo.Items.Add("Email");
                //cmbPorCampo.Items.Add("Fone/Fax");
            }

            if (cmbPorTipo.Text == "Funcionário")
            {
                cmbPorCampo.Items.Clear();
                cmbPorCampo.Items.Add("Código");
                cmbPorCampo.Items.Add("Nome");
                cmbPorCampo.Items.Add("CPF");
                //cmbPorCampo.Items.Add("Endereço");
                //cmbPorCampo.Items.Add("Cidade");
                //cmbPorCampo.Items.Add("UF");
                cmbPorCampo.Items.Add("CEP");
                //cmbPorCampo.Items.Add("Email");
                //cmbPorCampo.Items.Add("Fone/Fax");
            }

            if (cmbPorTipo.Text == "Serviço")
            {
                cmbPorCampo.Items.Clear();
                cmbPorCampo.Items.Add("Código");
                //cmbPorCampo.Items.Add("Empresa");
                cmbPorCampo.Items.Add("CPF");
                //cmbPorCampo.Items.Add("Endereço");
                //cmbPorCampo.Items.Add("Cidade");
                cmbPorCampo.Items.Add("CEP");
                //cmbPorCampo.Items.Add("Data Início");
                //cmbPorCampo.Items.Add("Data Término");
                //cmbPorCampo.Items.Add("Valor de Equipamentos");
                //cmbPorCampo.Items.Add("Valor do Serviço");
                //cmbPorCampo.Items.Add("Valor Total");
                cmbPorCampo.Items.Add("Finalidade");
                //cmbPorCampo.Items.Add("Descrição");
                cmbPorCampo.Items.Add("Situação");
            }

            if (cmbPorTipo.Text == "Equipamento")
            {
                cmbPorCampo.Items.Clear();
                cmbPorCampo.Items.Add("Código");
                cmbPorCampo.Items.Add("Material");
                //cmbPorCampo.Items.Add("Marca");
                cmbPorCampo.Items.Add("Finalidade");
                //cmbPorCampo.Items.Add("Especificação");
                //cmbPorCampo.Items.Add("Preço");
            }
        }

        private void btnEquipamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaEquipamento().ShowDialog();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        public void selecionar(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbPorTipo.Text == "Cliente")
            {
                RepositorioCliente repositorioc = new RepositorioCliente();
                TelaCliente cliente = new TelaCliente();
                if (e.RowIndex >= 0)
                {
                    cliente.txtNome.Text = dgvConsulta.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cliente.txtcpfCnpj.Text = dgvConsulta.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cliente.txtEnd.Text = dgvConsulta.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cliente.txtCid.Text = dgvConsulta.Rows[e.RowIndex].Cells[4].Value.ToString();
                    cliente.cboUf.Text = dgvConsulta.Rows[e.RowIndex].Cells[5].Value.ToString();
                    cliente.txtComplemento.Text = dgvConsulta.Rows[e.RowIndex].Cells[6].Value.ToString();
                    cliente.txtCep.Text = dgvConsulta.Rows[e.RowIndex].Cells[7].Value.ToString();
                    cliente.txtEmail.Text = dgvConsulta.Rows[e.RowIndex].Cells[8].Value.ToString();
                    cliente.txtFoneFax.Text = dgvConsulta.Rows[e.RowIndex].Cells[9].Value.ToString();
                    cliente.ShowDialog();
                }
            }

            if (cmbPorTipo.Text == "Funcionário")
            {
                RepositorioFuncionario repositoriof = new RepositorioFuncionario();
                TelaFuncionario funcionario = new TelaFuncionario();
                if (e.RowIndex >= 0)
                {
                    funcionario.txtNome.Text = dgvConsulta.Rows[e.RowIndex].Cells[1].Value.ToString();
                    funcionario.txtSenha.Text = dgvConsulta.Rows[e.RowIndex].Cells[2].Value.ToString();
                    funcionario.txtcpfCnpj.Text = dgvConsulta.Rows[e.RowIndex].Cells[3].Value.ToString();
                    funcionario.txtEnd.Text = dgvConsulta.Rows[e.RowIndex].Cells[4].Value.ToString();
                    funcionario.txtCid.Text = dgvConsulta.Rows[e.RowIndex].Cells[5].Value.ToString();
                    funcionario.txtCep.Text = dgvConsulta.Rows[e.RowIndex].Cells[6].Value.ToString();
                    funcionario.txtEmail.Text = dgvConsulta.Rows[e.RowIndex].Cells[7].Value.ToString();
                    funcionario.txtFone.Text = dgvConsulta.Rows[e.RowIndex].Cells[8].Value.ToString();
                    funcionario.cboUf.Text = dgvConsulta.Rows[e.RowIndex].Cells[9].Value.ToString();
                    funcionario.picUsuario.ImageLocation = dgvConsulta.Rows[e.RowIndex].Cells[10].Value.ToString();
                    funcionario.ShowDialog();
                }
            }

            if (cmbPorTipo.Text == "Serviço")
            {
                RepositorioServico repositorios = new RepositorioServico();
                TelaServico servico = new TelaServico();
                if (e.RowIndex >= 0)
                {
                    servico.txtempresa.Text = dgvConsulta.Rows[e.RowIndex].Cells[1].Value.ToString();
                    servico.txtcpfCnpj.Text = dgvConsulta.Rows[e.RowIndex].Cells[2].Value.ToString();
                    servico.txtEndereco.Text = dgvConsulta.Rows[e.RowIndex].Cells[3].Value.ToString();
                    servico.txtCidade.Text = dgvConsulta.Rows[e.RowIndex].Cells[4].Value.ToString();
                    servico.cmbUf.Text = dgvConsulta.Rows[e.RowIndex].Cells[5].Value.ToString();
                    servico.txtCep.Text = dgvConsulta.Rows[e.RowIndex].Cells[6].Value.ToString();
                    servico.txtdataInicio.Text = dgvConsulta.Rows[e.RowIndex].Cells[7].Value.ToString();
                    servico.txtdataTermino.Text = dgvConsulta.Rows[e.RowIndex].Cells[8].Value.ToString();
                    servico.txtValor.Text = dgvConsulta.Rows[e.RowIndex].Cells[9].Value.ToString();
                    servico.txtdescricaoDoServico.Text = dgvConsulta.Rows[e.RowIndex].Cells[11].Value.ToString();
                    servico.cmbSituacao.Text = dgvConsulta.Rows[e.RowIndex].Cells[12].Value.ToString();
                    servico.ShowDialog();
                }
            }

            if (cmbPorTipo.Text == "Equipamento")
            {
                RepositorioEquipamento repositorioe = new RepositorioEquipamento();
                TelaEquipamento equipamento = new TelaEquipamento();
                if (e.RowIndex >= 0)
                {
                    equipamento.txtMaterial.Text = dgvConsulta.Rows[e.RowIndex].Cells[1].Value.ToString();
                    equipamento.txtMarca.Text = dgvConsulta.Rows[e.RowIndex].Cells[2].Value.ToString();
                    equipamento.txtEspecificacao.Text = dgvConsulta.Rows[e.RowIndex].Cells[4].Value.ToString();
                    equipamento.txtPreco.Text = dgvConsulta.Rows[e.RowIndex].Cells[5].Value.ToString();
                    equipamento.txtQuantidade.Text = dgvConsulta.Rows[e.RowIndex].Cells[6].Value.ToString();
                    equipamento.ShowDialog();
                }
            }
        }
        private void data()
        {
            DateTime dt = DateTime.Now;
            lblData.Text = dt.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }
        //
        // private void dgvConsulta_Paint(object sender, PaintEventArgs e)
        //{
        //   selecionar(sender, e);
        //}
    }
}


