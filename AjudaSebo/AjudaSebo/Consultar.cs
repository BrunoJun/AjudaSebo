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
            List<string> editoras = cadastro.verificarGeral("editora", "nome");
            List<string> autores = cadastro.verificarGeral("autor", "nome");
            List<string> generos = cadastro.verificarGeral("genero", "descricao");

            bool contemTitulo = titulos.Contains(textTitulo.Text.ToLower());
            bool contemISBN = isbns.Contains(textISBN.Text.ToLower());

            if (contemTitulo && !contemISBN)
            {

                int idLivro = titulos.IndexOf(textTitulo.Text.ToLower());
                tornarVisivel();
                textISBN.Text = isbns[idLivro];
                textEditora.Text = editoras[idLivro];
                textAutor.Text = autores[idLivro];
                textGenero.Text = generos[idLivro];
            }
            else if (!contemTitulo && contemISBN)
            {

                int idLivro = isbns.IndexOf(textISBN.Text.ToLower());
                tornarVisivel();
                textTitulo.Text = titulos[idLivro];
                textEditora.Text = editoras[idLivro];
                textAutor.Text = autores[idLivro];
                textGenero.Text = generos[idLivro];
            }
            else
            {

                MessageBox.Show("Este livro não está registrado.");
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
    }
}
