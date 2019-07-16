using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCM
{
    class Conexao
    {
        //String de conexão
        //SqlConnection con = new SqlConnection(@"User ID=sa;Initial Catalog=bancoT;Data Source=MESQUITA_\SQLEXPRESS;Password=1234567");
        SqlConnection con = new SqlConnection("User ID=sa;Initial Catalog=bancoT;Data Source=(local);Password=1234567");


        //Metodo de conexão com banco de dados

        public SqlConnection ConectarBD()
        {

            try ////FormatException= Error de Formato, OverflowException= Error de estouro, Exception = Error gerais;
            {
                con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao conectar.\nDetalhes do erro: " + e);
            }
            return con;
        }
        
        //Metodo de Desconectar o banco de dados

         public SqlConnection DesconectarBD()
        {
            try
            {
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao desconectar.\nDetalhes do erro: " + e);
            }
            return con;
        }

       //Método de checarconexão com banco de dados

          public void ChecarConexao()
        {
            if(con != null && con.State != ConnectionState.Closed)
            {
                MessageBox.Show("Conectado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao conectar Banco de Dados");
            }
        }
   }
}

