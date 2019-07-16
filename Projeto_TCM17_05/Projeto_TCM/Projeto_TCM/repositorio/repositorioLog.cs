using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCM.dominio
{
    class repositorioLog
    {
        //Declarações de constantes para utilização no projeto
        public const String NOME_TABELA = "funcionario";
        private const String COMANDO_BASE = " SELECT * From " + NOME_TABELA;
        private const String CONDICIONAL_WHERE = " WHERE ";
        private const String COLUNA_Usuario = "cpfCnpj";
        private const String COLUNA_Senha = "senha";

        //instancia de conexao com o banco de dados
        Conexao conexão = new Conexao();
        SqlCommand comando = new SqlCommand();
        private object expect;

        //Metodo de salvamento de contato no banco de dados

        public void Cadastrar(Funcionario funcionario)
        {
            comando.CommandText = " insert into  " + NOME_TABELA +
                " values ('" + funcionario._cpfCnpj + "','" +
            funcionario._senha + "')";
            MessageBox.Show(comando.CommandText);

            //Desconectar para garantir e depois Conectar Novamente
            comando.Connection = conexão.DesconectarBD();
            comando.Connection = conexão.ConectarBD();


            //Controle de  Exceção
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastrado com sucesso!", "Notificação"
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

        public bool verificarCadastro(Funcionario funcionario)
        {
            comando.CommandText = "select * from " + NOME_TABELA +
                " where CPF = '" + funcionario._cpfCnpj + "' and senha = '" 
                + funcionario._senha + "'";
            //MessageBox.Show(comando.CommandText);

            //Desconectar para garantir e depois Conectar Novamente
            comando.Connection = conexão.DesconectarBD();
            comando.Connection = conexão.ConectarBD();

            SqlDataReader dr;

            //Controle de  Exceção
            try
            {//ExecuteReader usado para obter os resultados da consulta como um objeto DataReader.
                dr =comando.ExecuteReader();

                if (dr.HasRows)//Use o HasRows propriedade para evitar a necessidade de telefonar o Read método para o DataTableReader Se não houver nenhuma linha dentro do conjunto de resultados corrente.
                {
                    return true;
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Falha .\nDetalhes do Erro: " + e);
            }
            return false;
        }
    }
}



