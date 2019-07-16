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
    class RepositorioFuncionario:IRepositorio<Funcionario>
    {
        //Declarações de constantes para utilização no projeto
        public const String NOME_TABELA = "Funcionario";
        private const String COMANDO_BASE = " SELECT * From " + NOME_TABELA;
        private const String CONDICIONAL_WHERE = " WHERE ";
        private const String COLUNA_NOME = "Nome";
        private const String COLUNA_CIDADE = "Cidade";
        private const String COLUNA_UF = "UF";
        private const String COLUNA_CEP = "CEP";
        private const String COLUNA_FONEFAX = "TELEFONE";

        //instancia de conexao com o banco de dados
        Conexao conexão = new Conexao();
        SqlCommand comando = new SqlCommand();
        private object expect;

        public DataSet buscarPorCodigo(string codigo)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM FUNCIONARIO WHERE CODIGO_FUNCIONARIO LIKE '%" + codigo + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }

        public DataSet buscarPorNome(string nome)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM FUNCIONARIO WHERE NOME LIKE '%" + nome + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }
        public DataSet buscarPorCPF(string cpf)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM FUNCIONARIO WHERE CPF LIKE '%" + cpf + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }
        public DataSet buscarPorCidade(string cidade)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM FUNCIONARIO WHERE CIDADE LIKE '%" + cidade + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }
        public DataSet buscarPorUsuario(string usuario)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM FUNCIONARIO WHERE USUARIO LIKE '%" + usuario + "%';", conexão.ConectarBD());
            da.Fill(ds);

            conexão.DesconectarBD();
            return ds;
        }



        //Metodo de salvamento de funcionario no banco de dados 
        public void atualizar(Funcionario funcionario)
        {
            comando.CommandText = " UPDATE " + NOME_TABELA +
           " set values ('" + funcionario._nome + "','" +
           funcionario._senha + "','" +
           funcionario._cpfCnpj + "','" +
           funcionario._endereco + "','" +
           funcionario._cidade + "','" +
           funcionario._cep + "','" +
           funcionario._email + "','" +
           funcionario._foneFax + "','" +
           funcionario._uf + "','" +
           funcionario._imagem + "') WHERE Codigo_Funcionario = " + funcionario._codigo ;

            MessageBox.Show(comando.CommandText);

            //Desconectar para garantir e depois Conectar Novamente
            comando.Connection = conexão.DesconectarBD();
            comando.Connection = conexão.ConectarBD();


            //Controle de  Exceção
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Funcionario salvo com sucesso!", "Informação"
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

        public void salvar(Funcionario funcionario)
        {
            comando.CommandText = " INSERT INTO " + NOME_TABELA +
           " values ('" + funcionario._nome + "','"+
           funcionario._senha + "','"+
           funcionario._cpfCnpj + "','"+
           funcionario._endereco + "','"+
           funcionario._cidade + "','"+
           funcionario._cep + "','" +
           funcionario._email + "','"+
           funcionario._foneFax + "','"+
           funcionario._uf + "','"+
           funcionario._imagem + "')";
           
            MessageBox.Show(comando.CommandText);

            //Desconectar para garantir e depois Conectar Novamente
            comando.Connection = conexão.DesconectarBD();
            comando.Connection = conexão.ConectarBD();


            //Controle de  Exceção
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Funcionario salvo com sucesso!", "Informação"
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

        public string buscarImagem(Funcionario funcionario)
        {

            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select imagem from funcionario where cpf = '" + funcionario._cpfCnpj + "';", conexão.ConectarBD());
            da.Fill(ds);

            //Desconectar para garantir e depois Conectar Novamente
            comando.Connection = conexão.DesconectarBD();
            comando.Connection = conexão.ConectarBD();

          string caminhoimagem = ds.Tables[0].Rows[0]["imagem"].ToString();
            return caminhoimagem;
        }

    }
}
