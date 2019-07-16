using Projeto_TCM.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCM.repositorio
{
    class RepositorioRelatorio: IRepositorio<Relatorio>
    {
        //Declarações de constantes para utilização no projeto
        public const String NOME_TABELA = "SERVICCO";
        private const String COMANDO_BASE = " SELECT * From " + NOME_TABELA;
        private const String CONDICIONAL_WHERE = " WHERE ";
        private const String COLUNA_ID = "(Codigo do Serviço)";
        private const String COLUNA_NOME = "Nome";
        private const String COLUNA_TIPO = "Tipo";
        private const String COLUNA_DESCRICAO = "(Descrição do Serviço)";
        private const String COLUNA_DTINICIO = "(Data Inicio)";
        private const String COLUNA_DTTERMINO = "(Data Termino)";
        private const String COLUNA_RELATORIO = "Relatorio";

        //instancia de conexao com o banco de dados
        Conexao conexão = new Conexao();
        SqlCommand comando = new SqlCommand();
        private object expect;

        //Metodo de salvamento de cliente no banco de dados


        public void atualizar(Relatorio relatorio)
        {
            comando.CommandText = "UPDATE " + NOME_TABELA +
            " SET values ('" + relatorio._nome + "','" +
            relatorio._tipo + "','" +
            relatorio._descricao + "','" +
            relatorio._dtinicio + "','" +
            relatorio._dttermino + "','" +
            relatorio._relatorio + "') WHERE CODIGO_SERVICO =" + relatorio._codigo ;
            MessageBox.Show(comando.CommandText);

            //Desconectar para garantir e depois Conectar Novamente
            comando.Connection = conexão.DesconectarBD();
            comando.Connection = conexão.ConectarBD();


            //Controle de  Exceção
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Relatório salvo com sucesso!", "Informação"
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
        public void salvar(Relatorio relatorio)
        {
            comando.CommandText = "INSERT INTO  " + NOME_TABELA +
            " values ('" + relatorio._nome + "','" +
            relatorio._tipo + "','" +
            relatorio._descricao + "','" +
            relatorio._dtinicio + "','" +
            relatorio._dttermino + "','" +
            relatorio._relatorio + "')";
            MessageBox.Show(comando.CommandText);

            //Desconectar para garantir e depois Conectar Novamente
            comando.Connection = conexão.DesconectarBD();
            comando.Connection = conexão.ConectarBD();


            //Controle de  Exceção
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Relatório salvo com sucesso!", "Informação"
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

        public DataSet buscarPorSituacao(string situacao)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM SERVICCO WHERE SituacaoDoServico LIKE '%" + situacao + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }
    }
}

