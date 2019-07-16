using Projeto_TCM;
using Projeto_TCM.repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCM.dominio
{

    class RepositorioCliente : IRepositorio<Cliente>
    {

        //Declarações de constantes para utilização no projeto
        public const String NOME_TABELA = "CLIENTE";
        private const String COMANDO_BASE = " SELECT * From " + NOME_TABELA;
        private const String CONDICIONAL_WHERE = " WHERE ";
        private const String COLUNA_ID = "(Codigo_Serviço)";

        //instancia de conexao com o banco de dados
        Conexao conexão = new Conexao();
        SqlCommand comando = new SqlCommand();

        //Metodo de busca de cliente no banco de dados

        public DataSet buscarPorCodigo(string codigo)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM Cliente WHERE Codigo LIKE '%" + codigo + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }

        public DataSet buscarPorNome(string nome)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM Cliente WHERE NOME LIKE '%" + nome + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }

        public DataSet buscarPorCPFCNPJ(string cpfCnpj)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM Cliente WHERE CPF LIKE '%" + cpfCnpj + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }

        public DataSet buscarPorEndereco(string endereco)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM Cliente WHERE Endereço LIKE '%" + endereco + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }

        public DataSet buscarPorCidade(string cidade)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM Cliente WHERE CIDADE LIKE '%" + cidade + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }

        public DataSet buscarPorUF(string uf)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM Cliente WHERE UF LIKE '%" + uf + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }
        public DataSet buscarPorCEP(string cep)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM Cliente WHERE CEP LIKE '%" + cep + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }
        public DataSet buscarPorEmail(string email)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM Cliente WHERE Email LIKE '%" + email + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }

        public DataSet buscarPorFone(string fone)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM Cliente WHERE Foto LIKE '%" + fone + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }


        public DataSet buscarPorTipoCliente(string tipocliente)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM Cliente WHERE (Tipo Cliente) LIKE '%" + tipocliente + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }

        //Metodo de salvamento de cliente no banco de dados
        public void atualizar(Cliente cliente)
        {
            comando.CommandText = " UPDATE " + NOME_TABELA +
            " set values " + cliente._nome + "','" +
            cliente._cpfCnpj + "','" +
            cliente._endereco + "','" +
            cliente._cidade + "','" +
            cliente._uf + "','" +
            cliente._complemento + "','" +
            cliente._cep + "','" +
            cliente._email + "','" +
            cliente._foneFax + "','" +
            cliente._chnTipoCliente + " WHERE Codigo_Cliente = " + cliente._codigo;

            MessageBox.Show(comando.CommandText);

            //Desconectar para garantir e depois Conectar Novamente
            comando.Connection = conexão.DesconectarBD();
            comando.Connection = conexão.ConectarBD();

            //Controle de  Exceção
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente salvo com sucesso!", "Informação"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception e)
            {
                MessageBox.Show("Falha ao salvar no banco de dados.\nDetalhes do Erro: " + e);
            }
            // fim do controle de execeção

            //Desconectar pela ultima vez
            comando.Connection = conexão.DesconectarBD();


        }


        public void salvar(Cliente cliente)
        {
            comando.CommandText = " INSERT INTO  " + NOME_TABELA +
            " values ('" + cliente._nome + "','" +
            cliente._cpfCnpj + "','" +
            cliente._endereco + "','" +
            cliente._cidade + "','" +
            cliente._uf + "','" +
            cliente._complemento + "','" +
            cliente._cep + "','" +
            cliente._email + "','" +
            cliente._foneFax + "','" +
            cliente._chnTipoCliente + "')";

            MessageBox.Show(comando.CommandText);

            //Desconectar para garantir e depois Conectar Novamente
            comando.Connection = conexão.DesconectarBD();
            comando.Connection = conexão.ConectarBD();

            //Controle de  Exceção
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente salvo com sucesso!", "Informação"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception e)
            {
                MessageBox.Show("Falha ao salvar no banco de dados.\nDetalhes do Erro: " + e);
            }
            // fim do controle de execeção

            //Desconectar pela ultima vez
            comando.Connection = conexão.DesconectarBD();


        }
    }
}

