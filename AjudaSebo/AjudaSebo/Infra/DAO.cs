using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AjudaSebo.Infra
{
    class DAO
    {

        private const string url = "Data Source=WINDOWSCOMPUTER'\'SQLEXPRESS;Initial Catalog=ajudasebo;Integrated Security=True";

        private SqlConnection fabricarConexao()
        {
            SqlConnection sqlConnection = new SqlConnection(url);

            return sqlConnection;
        }

        // Entidade Livro

        public void cadastrarLivro()
        {
            String sql = "INSERT INTO dbo.livros (titulo, isbn, edicao, preco, quantidade)" +
                         "VALUES ()";

            SqlCommand command = new SqlCommand("", fabricarConexao());

            //TODO
        }

        // Fim entidade Livro

        // Entidade Genero

        private void cadastrarGenero(String descricaoGenero)
        {

            SqlConnection conexao = fabricarConexao();

            String sql = "INSERT INTO dbo.genero (descricao)" +
                      $"VALUES ({descricaoGenero})";

            SqlCommand command = new SqlCommand("sql", conexao);

            conexao.Open();
            command.ExecuteNonQuery();
            //Precisa terminar
        }

        private void verificarGenero()
        {

            SqlConnection conexao = fabricarConexao();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();
            //string[] generos = 

            String sql = "SELECT * FROM dbo.genero";

            SqlCommand command = new SqlCommand("sql", conexao);

            conexao.Open();
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(dataSet);

            foreach (DataRow data in dataSet.Tables[0].Rows)
            {
                
            }
        }


    }
}
