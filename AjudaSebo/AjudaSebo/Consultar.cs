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
    public partial class Consultar : Form
    {
        private Cadastrar cadastro = new Cadastrar();       

        public Consultar()
        {
            InitializeComponent();
        }

        private void btnConTela_Click(object sender, EventArgs e)
        {
            List<string> titulos = cadastro.verificarGeral("livros", "titulo");
            List<string> isbns = cadastro.verificarGeral("livros", "isbn");

            List<string> valores;

            bool contemTitulo = titulos.Contains(textTitulo.Text.ToLower());
            bool contemISBN = isbns.Contains(textISBN.Text.ToLower());

            if (contemTitulo && !contemISBN)
            {

                tornarVisivel();
                valores = valoresLinha("titulo", textTitulo.Text);
                textISBN.Text = valores[0];
                textEditora.Text = valores[2];
                textAutor.Text = valores[3];
                textGenero.Text = valores[1];
            }
            else if (!contemTitulo && contemISBN)
            {

                tornarVisivel();
                valores = valoresLinha("isbn", textISBN.Text);
                textTitulo.Text = valores[0];
                textEditora.Text = valores[2];
                textAutor.Text = valores[3];
                textGenero.Text = valores[1];
            }
            else
            {

                MessageBox.Show("Este livro não está registrado.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string idLivro = cadastro.verificarID("livros", "id_livro", "isbn", textISBN.Text);
            string idEditora = retornarValor(idLivro, "id_editora").ToLower();
            string idAutor = retornarValor(idLivro, "id_autor").ToLower();
            string idGeneroNovo = retornarValor(idLivro, "id_genero").ToLower();
            alterarLivro(idLivro, idEditora, idAutor, idGeneroNovo);
        }

        private void bttVender_Click(object sender, EventArgs e)
        {

            List<string> listaISBNs = cadastro.verificarGeral("livros", "isbn");
            List<string> listaQuantidade = cadastro.verificarGeral("livros", "quantidade");
            List<string> listaPreco= cadastro.verificarGeral("livros", "preco");


            int indiceISBN = listaISBNs.IndexOf(textISBN.Text);
            string quantidadeLivroAtual = listaQuantidade[indiceISBN];

            if (Convert.ToInt64(quantidadeLivroAtual) - 1 >= 0)
            {
                DateTime hoje = DateTime.UtcNow.Date;
                string hojeFormatado = hoje.ToString("yyyy-MM-dd");

                cadastro.cadastrarGeral("vendas", hojeFormatado, listaPreco[indiceISBN].Replace(",", "."));

                List<string> listaIdVendas = cadastro.verificarGeral("vendas", "data");

                string idLivro = cadastro.verificarID("livros", "id_livro", "isbn", textISBN.Text);
                string idVenda = cadastro.verificarID("vendas", "id_venda", "data", Convert.ToString(hoje));

                cadastro.cadastrarGeral("livros_vendas", idLivro, idVenda);
                diminuirQuantidade(textISBN.Text);
            }
        }

        private void btnConVoltar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void tornarVisivel()
        {

            lbnAutor.Visible = true;
            lbnEditora.Visible = true;
            lbnGenero.Visible = true;
            textAutor.Visible = true;
            textEditora.Visible = true;
            textGenero.Visible = true;
        }

        private void alterarLivro(string id, string idEditora, string idAutor, string idGenero)
        {

            string url = "Data Source=WINDOWSCOMPUTER\\SQLEXPRESS;Initial Catalog=ajudasebo;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(url);

            string sql = $"UPDATE livros " +
                         $"SET titulo = '{textTitulo.Text}', isbn = '{textISBN.Text}', id_genero = {idGenero}, id_editora = {idEditora}, id_autor = {idAutor} " +
                         $"WHERE id_livro = {id};" +
                         $"UPDATE autor " +
                         $"SET nome =  '{textAutor.Text}' " +
                         $"WHERE id_autor = {idAutor};" +
                         $"UPDATE editora " +
                         $"SET nome = '{textEditora.Text}'" +
                         $"WHERE id_editora = {idEditora};" +
                         $"UPDATE genero " +
                         $"SET descricao = '{textGenero.Text}' " +
                         $"WHERE id_genero = {idGenero};";

            Console.WriteLine(sql);

            SqlCommand command = new SqlCommand(sql, sqlConnection);

            sqlConnection.Open();
            command.ExecuteNonQuery();
        }

        public List<string> valoresLinha(string escolha, string valor)
        {

            string url = "Data Source=WINDOWSCOMPUTER\\SQLEXPRESS;Initial Catalog=ajudasebo;Integrated Security=True";
            String sql = null;
            List<string> resultados = new List<string>();

            SqlConnection sqlConnection = new SqlConnection(url);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            if (escolha.Equals("titulo"))
            {

                sql = "SELECT l.isbn, g.descricao, e.nome, a.nome FROM livros l, genero g, editora e, autor a " +
                      $"WHERE l.id_genero = g.id_genero and l.id_editora = e.id_editora and l.id_autor = a.id_autor and l.titulo = '{valor}'";
            } 
            else if (escolha.Equals("isbn"))
            {

                sql = "SELECT l.titulo, g.descricao, e.nome, a.nome FROM livros l, genero g, editora e, autor a " +
                      $"WHERE l.id_genero = g.id_genero and l.id_editora = e.id_editora and l.id_autor = a.id_autor and l.isbn = '{valor}'";
            }

            SqlCommand command = new SqlCommand(sql, sqlConnection);

            sqlConnection.Open();
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(dataSet);

            foreach (DataTable thisTable in dataSet.Tables)
            {
                foreach (DataRow row in thisTable.Rows)
                {
                    foreach (DataColumn column in thisTable.Columns)
                    {

                        resultados.Add(Convert.ToString(row[column]));
                    }
                }
            }

            return resultados;
        }

        private void diminuirQuantidade(string isbn)
        {

            string url = "Data Source=WINDOWSCOMPUTER\\SQLEXPRESS;Initial Catalog=ajudasebo;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(url);

            string sql = $"update livros set quantidade = quantidade - 1 where isbn = '{isbn}'";

            SqlCommand command = new SqlCommand(sql, sqlConnection);

            sqlConnection.Open();

            command.ExecuteNonQuery();
        }

        private string retornarValor(string id, string coluna)
        {

            string url = "Data Source=WINDOWSCOMPUTER\\SQLEXPRESS;Initial Catalog=ajudasebo;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(url);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            String sql = $"SELECT {coluna} from livros " +
                         $"WHERE id_livro = '{id}'";
            SqlCommand command = new SqlCommand(sql, sqlConnection);


            sqlConnection.Open();
            command.ExecuteNonQuery();
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(dataSet);
            List<int> geral = new List<int>();

            foreach (DataRow data in dataSet.Tables[0].Rows)
            {

                geral.Add(data.Field<int>(coluna));
            }

            return geral[0] + "";
        }
    }
}
