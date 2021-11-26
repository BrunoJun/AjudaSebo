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

            string idGenero = verificarID("genero", "id_genero", "descricao", textGenero.Text.ToLower());
            string idEditora = verificarID("editora", "id_editora", "nome", textEditora.Text.ToLower());
            string idAutor = verificarID("autor", "id_autor", "nome", textAutor.Text.ToLower());

            List<string> listaLivros = verificarGeral("livros", "isbn");
            List<string> listaGeneros = verificarGeral("genero", "descricao");
            List<string> listaEditora = verificarGeral("editora", "nome");
            List<string> listaAutores = verificarGeral("autor", "nome");
            

            bool contemLivro = listaLivros.Contains(textISBN.Text.ToLower());
            bool contemGenero = listaGeneros.Contains(textGenero.Text.ToLower());
            bool contemEditora = listaEditora.Contains(textEditora.Text.ToLower());
            bool contemAutor = listaAutores.Contains(textAutor.Text.ToLower());

            string titulo = textTitulo.Text;
            string isbn = textISBN.Text;
            string edicao = textEdicao.Text;
            string preco = textPreco.Text;

            if (contemLivro)
            {

                aumentarQuantidade(textISBN.Text);
            }
            else if (!contemGenero && contemEditora && contemAutor)
            {
                cadastrarGeral("genero", textGenero.Text);
                listaGeneros = verificarGeral("genero", "descricao");
                idGenero = verificarID("genero", "id_genero", "descricao", textGenero.Text.ToLower());
                cadastrarGeral("livros", titulo, isbn, edicao, preco, "1", idGenero, idEditora, idAutor);
            }
            else if (!contemGenero && !contemEditora && contemAutor)
            {

                cadastrarGeral("genero", textGenero.Text);
                cadastrarGeral("editora", textEditora.Text);
                listaGeneros = verificarGeral("genero", "descricao");
                listaEditora = verificarGeral("editora", "nome");
                idGenero = verificarID("genero", "id_genero", "descricao", textGenero.Text.ToLower());
                idEditora = verificarID("editora", "id_editora", "nome", textEditora.Text.ToLower());
                cadastrarGeral("livros", titulo, isbn, edicao, preco, "1", idGenero, idEditora, idAutor);
            }
            else if (!contemGenero && contemEditora && !contemAutor)
            {

                cadastrarGeral("genero", textGenero.Text);
                cadastrarGeral("autor", textAutor.Text);
                listaGeneros = verificarGeral("genero", "descricao");
                listaAutores= verificarGeral("autor", "nome");
                idGenero = verificarID("genero", "id_genero", "descricao", textGenero.Text.ToLower());
                idAutor= verificarID("autor", "id_autor", "nome", textAutor.Text.ToLower());
                cadastrarGeral("livros", titulo, isbn, edicao, preco, "1", idGenero, idEditora, idAutor);
            }
            else if (contemGenero && !contemEditora && !contemAutor)
            {

                cadastrarGeral("autor", textAutor.Text);
                cadastrarGeral("editora", textEditora.Text);
                listaAutores = verificarGeral("autor", "nome");
                listaEditora = verificarGeral("editora", "nome");
                idAutor = verificarID("autor", "id_autor", "nome", textAutor.Text.ToLower());
                idEditora = verificarID("editora", "id_editora", "nome", textEditora.Text.ToLower());
                cadastrarGeral("livros", titulo, isbn, edicao, preco, "1", idGenero, idEditora, idAutor);
            }
            else if (!contemGenero && !contemEditora && !contemAutor)
            {

                cadastrarGeral("autor", textAutor.Text);
                cadastrarGeral("editora", textEditora.Text);
                cadastrarGeral("genero", textGenero.Text);
                idGenero = verificarID("genero", "id_genero", "descricao", textGenero.Text.ToLower());
                idEditora = verificarID("editora", "id_editora", "nome", textEditora.Text.ToLower());
                idAutor = verificarID("autor", "id_autor", "nome", textAutor.Text.ToLower());
                cadastrarGeral("livros", titulo, isbn, edicao, preco, "1", idGenero, idEditora, idAutor);
            }
        }

        private void btnVoltarTela_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        public List<string> verificarGeral(string tabela, string coluna)
        {

            string url = "Data Source=WINDOWSCOMPUTER\\SQLEXPRESS;Initial Catalog=ajudasebo;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(url);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            String sql = $"SELECT * FROM {tabela}";
            SqlCommand command = new SqlCommand(sql, sqlConnection);

            sqlConnection.Open();
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(dataSet);
            List<string> geral = new List<string>();

            foreach (DataRow data in dataSet.Tables[0].Rows)
            {

                geral.Add(Convert.ToString(data.Field<Object>(coluna)).ToLower());
            }

            return geral;
        }

        public void cadastrarGeral(string tabela, params string[] valores)
        {
            int j = 1;

            List<string> colunas = listaColunas(tabela);

            string url = "Data Source=WINDOWSCOMPUTER\\SQLEXPRESS;Initial Catalog=ajudasebo;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(url);

            string sql = $"INSERT INTO {tabela} (";

            if (tabela.Equals("livros_vendas")) j = 0;

            for (int i = j; i < colunas.Count; i++)
            {

                sql += colunas[i];

                if (i < colunas.Count - 1)
                {

                    sql += ", ";
                }
            }
            sql += ")";
            sql += " VALUES (";

            for(int i = 0; i < valores.Length; i++)
            {
                sql += "'";
                sql += valores[i];
                sql += "'";

                if (i < valores.Length - 1)
                {

                    sql += ", ";
                }
            }
            sql += ")";

            Console.WriteLine(sql);

            SqlCommand command = new SqlCommand(sql, sqlConnection);

            sqlConnection.Open();
            command.ExecuteNonQuery();
        }

        private List<string> listaColunas(string tabela)
        {

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
            List<string> geral = new List<string>();

            foreach (DataRow data in dataSet.Tables[0].Rows)
            {

                geral.Add(data.Field<String>("COLUMN_NAME"));
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

        public string verificarID(string tabela, string colunaID, string colunaElemento, string elemento)
        {

            List<string> valoresID = verificarGeral(tabela, colunaID);
            List<string> valoresElemento = verificarGeral(tabela, colunaElemento);

            int indiceElemento = valoresElemento.IndexOf(elemento);

            if (indiceElemento == -1)
            {

                return "0";
            }

            return valoresID[indiceElemento];
        }
    }
}
