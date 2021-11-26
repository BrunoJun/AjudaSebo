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
            string idEditora = cadastro.verificarID("editora", "id_editora", "nome", textEditora.Text.ToLower());
            string idAutor = cadastro.verificarID("autor", "id_autor", "nome", textAutor.Text.ToLower());
            string idGeneroNovo = cadastro.verificarID("genero", "id_genero", "descricao", textGenero.Text.ToLower());
            alterarLivro(idLivro, idEditora, idAutor, idGeneroNovo);
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
                         $"WHERE id_livro = {id}";

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
    }
}
