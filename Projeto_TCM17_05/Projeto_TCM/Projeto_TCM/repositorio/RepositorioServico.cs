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
    class RepositorioServico:IRepositorio<Servico>
    {
        //Declarações de constantes para utilização no projeto
        public const String NOME_TABELA = "SERVICCO";
        private const String COMANDO_BASE = " SELECT * From " + NOME_TABELA;
        private const String CONDICIONAL_WHERE = " WHERE ";


        //instancia de conexao com o banco de dados
        Conexao conexão = new Conexao();
        SqlCommand comando = new SqlCommand();
        private object expect;

        public DataSet buscarPorCodigo(string Codigo)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM SERVICCO WHERE Codigo_Serviço LIKE '%" + Codigo + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }

        public DataSet buscarPorEmpresa(string Empresa)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM SERVICCO WHERE Empresa LIKE '%" + Empresa + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }

        //Metodo de salvamento de contato no banco de dados
        public DataSet buscarPorDataInicio(string DataInicio)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM SERVICCO WHERE DataInicio LIKE '%" + DataInicio + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }

        public DataSet buscarPorSituacao(string situacao)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM SERVICCO WHERE SituacaoDoServico LIKE '%" + situacao + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }

        public void atualizar(Servico Servi)
        {
            comando.CommandText = " UPDATE " + NOME_TABELA +
            " SET values ('" + Servi._empresa + "','" +
            Servi._cpfCnpj + "','" +
            Servi._endereco + "','" +
            Servi._cidade + "','" +
            Servi._uf + "','" +
            Servi._cep + "','" +
            Servi._dataInicio + "','" +
            Servi._dataTermino + "','" +
            Servi._valor + "','" +
            Servi._descricaoDoServico + "','" +
            Servi._situacaoDoServico + "','" +
            Servi._relatorio + "') WHERE CODIGO_SERVIÇO =" + Servi._codigo  ;
            MessageBox.Show(comando.CommandText);

            //Desconectar para garantir e depois Conectar Novamente
            comando.Connection = conexão.DesconectarBD();
            comando.Connection = conexão.ConectarBD();


            //Controle de  Exceção
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Serviço salvo com sucesso!", "Informação"
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
        public void salvar(Servico Servi)
        {
            comando.CommandText = " INSERT INTO " + NOME_TABELA +
            " values ('" + Servi._empresa + "','"+
            Servi._cpfCnpj + "','"+
            Servi._endereco + "','"+
            Servi._cidade + "','"+
            Servi._uf + "','"+
            Servi._cep + "','"+
            Servi._dataInicio + "','"+
            Servi._dataTermino + "','"+
            Servi._valor + "','"+
            Servi._descricaoDoServico + "','"+
            Servi._situacaoDoServico + "','" +
            Servi._relatorio + "')";
            MessageBox.Show(comando.CommandText);

            //Desconectar para garantir e depois Conectar Novamente
            comando.Connection = conexão.DesconectarBD();
            comando.Connection = conexão.ConectarBD();


            //Controle de  Exceção
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Serviço salvo com sucesso!", "Informação"
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
