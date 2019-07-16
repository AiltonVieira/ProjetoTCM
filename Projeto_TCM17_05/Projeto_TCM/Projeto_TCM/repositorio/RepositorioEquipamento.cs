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
    class RepositorioEquipamento : IRepositorio<Equipamento>
    {

    //Declarações de constantes para utilização no projeto
    public const String NOME_TABELA = "EQUIPAMENTO";
    private const String COMANDO_BASE = " SELECT * From " + NOME_TABELA;
    private const String CONDICIONAL_WHERE = " WHERE ";
    private const String COLUNA_CODIGO = "Codigo_Equipamento";
    private const String COLUNA_MATERIAL = "(Material)";
    private const String COLUNA_MARCA = "(Marca)";
    private const String COLUNA_FINALIDADE = "(Finalidade)";
    private const String COLUNA_ESPECIFICACAO = "(Especificacao)";
    private const String COLUNA_PRECO = "(Preco)";
    private const String COLUNA_QUANTIDADE = "(Quantidade)";

        //instancia de conexao com o banco de dados
        Conexao conexão = new Conexao();
        SqlCommand comando = new SqlCommand();
        private object expect;

    //Metodo de busca de equipamento no banco de dados

    public DataSet buscarPorEquipamento(string material)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        da = new SqlDataAdapter("SELECT * FROM Equipamento WHERE Material LIKE '%" + material + "%';", conexão.ConectarBD());
        da.Fill(ds);
        conexão.DesconectarBD();
        return ds;
    }

    public DataSet buscarPorMarca(string marca)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        da = new SqlDataAdapter("SELECT * FROM Equipamento WHERE Marca LIKE '%" + marca + "%';", conexão.ConectarBD());
        da.Fill(ds);
        conexão.DesconectarBD();
        return ds;
    }

    public DataSet buscarPorFinalidade(string finalidade)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        da = new SqlDataAdapter("SELECT * FROM Equipamento WHERE Finalidade LIKE '%" + finalidade + "%';", conexão.ConectarBD());
        da.Fill(ds);
        conexão.DesconectarBD();
        return ds;
    }

        public DataSet buscarPorEspecificacao(string especificacao)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM Equipamento WHERE Especificacao LIKE '%" + especificacao + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }

        public DataSet buscarPorPreco(string preco)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM Equipamento WHERE Preco LIKE '%" + preco + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }

        public DataSet buscarPorID(string id)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT * FROM Equipamento WHERE ID LIKE '%" + id + "%';", conexão.ConectarBD());
            da.Fill(ds);
            conexão.DesconectarBD();
            return ds;
        }

        //Metodo de salvamento de equipamento no banco de dados

        public void atualizar(Equipamento equipamento)
        {
            comando.CommandText = " UPDATE " + NOME_TABELA +
            " set Material ='" + equipamento._material +
            "', Marca ='" + equipamento._marca +
            "', Finalidade ='" + equipamento._finalidade +
            "', Especificacao ='" + equipamento._especificacao +
            "', Preco ='" + equipamento._preco +
            "', Quantidade ='" +  equipamento._quantidade + "' WHERE Codigo_Equipamento = 1";
            //"', Quantidade ='" +  equipamento._quantidade + "' WHERE Codigo_Equipamento = " + equipamento._codigo;

            MessageBox.Show(comando.CommandText);

            //Desconectar para garantir e depois Conectar Novamente
            comando.Connection = conexão.DesconectarBD();
            comando.Connection = conexão.ConectarBD();

            //Controle de  Exceção
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Equipamento salvo com sucesso!", "Informação"
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

        public void salvar(Equipamento equipamento)
    {
            comando.CommandText = " INSERT INTO  " + NOME_TABELA +
            " values ('" + equipamento._material + "','" +
            equipamento._marca + "','" +
            equipamento._finalidade + "','" +
            equipamento._especificacao + "','" +
            equipamento._preco + "','" +
            equipamento._quantidade + "')";
        
        MessageBox.Show(comando.CommandText);

        //Desconectar para garantir e depois Conectar Novamente
        comando.Connection = conexão.DesconectarBD();
        comando.Connection = conexão.ConectarBD();

        //Controle de  Exceção
        try
        {
            comando.ExecuteNonQuery();
            MessageBox.Show("Equipamento salvo com sucesso!", "Informação"
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