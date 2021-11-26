using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjudaSebo
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btnCadTela_Click(object sender, EventArgs e)
        {
            string[] listaLivros = verificarGeral("livros", "isbn");
            string[] listaGeneros = verificarGeral("genero", "descricao");
            string[] listaEditora = verificarGeral("editora", "nome");
            string[] listaAutores = verificarGeral("autor", "nome");

            if (listaLivros.Contains(textISBN.Text.ToLower()))
            {

                aumentarQuantidade(textISBN.Text);
            }
            else if (!listaGeneros.Contains(textGenero.Text.ToLower()) && listaEditora.Contains(textEditora.Text.ToLower()) && listaAutores.Contains(textAutor.Text.ToLower()))
            {

                cadastrarGeral("genero", textGenero.Text);
                cadastrarGeral("livros");
                // Terminar implementação
            }
        }

        public string[] verificarGeral(string tabela, string coluna)
        {

            string url = "Data Source=WINDOWSCOMPUTER\\SQLEXPRESS;Initial Catalog=ajudasebo;Integrated Security=True";
            int contador = 0;

            SqlConnection sqlConnection = new SqlConnection(url);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            String sql = $"SELECT * FROM {tabela}";
            SqlCommand command = new SqlCommand(sql, sqlConnection);

            sqlConnection.Open();
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(dataSet);
            string[] geral = new string[dataSet.Tables[0].Rows.Count];

            foreach (DataRow data in dataSet.Tables[0].Rows)
            {

                geral[contador] = data.Field<String>(coluna).ToLower();
                contador++;
            }

            return geral;
        }

        public void cadastrarGeral(string tabela, params string[] valores)
        {
            string[] colunas = listaColunas(tabela);
            string url = "Data Source=WINDOWSCOMPUTER\\SQLEXPRESS;Initial Catalog=ajudasebo;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(url);

            string sql = $"INSERT INTO {tabela} (";

            for (int i = 1; i < colunas.Length; i++)
            {

                sql += colunas[i];

                if (i < colunas.Length - 1)
                {

                    sql += ", ";
                }
            }
            sql += ")";
            sql += " VALUES (";

            for(int i = 0; i < valores.Length; i++)
            {

                sql += valores[i];

                if (i < valores.Length - 1)
                {

                    sql += ", ";
                }
            }
            sql += ")";

            Console.WriteLine(sql);

            SqlCommand command = new SqlCommand(sql, sqlConnection);

            sqlConnection.Open();
            //command.ExecuteNonQuery();
        }

        private string[] listaColunas(string tabela)
        {

            int contador = 0;
            string url = "Data Source=WINDOWSCOMPUTER\\SQLEXPRESS;Initial Catalog=ajudasebo;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(url);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            String sql = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS " +
                        $"WHERE TABLE_NAME = '{tabela}' ";
            SqlCommand command = new SqlCommand(sql, sqlConnection);


            sqlConnection.Open();
            command.ExecuteNonQuery();
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(dataSet);
            string[] geral = new string[dataSet.Tables[0].Rows.Count];

            foreach (DataRow data in dataSet.Tables[0].Rows)
            {

                geral[contador] = data.Field<String>("COLUMN_NAME");
                contador++;
            }

            return geral;
        }

        private void aumentarQuantidade(string isbn)
        {

            string url = "Data Source=WINDOWSCOMPUTER\\SQLEXPRESS;Initial Catalog=ajudasebo;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(url);

            string sql = $"update livros set quantidade = quantidade + 1 where isbn = {isbn}";

            SqlCommand command = new SqlCommand(sql, sqlConnection);

            sqlConnection.Open();

            command.ExecuteNonQuery();
        }
    }
}
