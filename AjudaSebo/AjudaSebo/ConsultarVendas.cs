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
    public partial class ConsultarVendas : Form
    {

        Cadastrar cadastro = new Cadastrar();
        public ConsultarVendas()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            string date = Convert.ToString(Convert.ToDateTime(data.Text));

            List<string> listaDatas = cadastro.verificarGeral("vendas", "data");

            if (listaDatas.Contains(date))
            {

                string idData = cadastro.verificarID("vendas", "id_venda", "data", date);
                List<string> resultados = demostrarLivrosVendas(date);
                
                foreach(string livro in resultados)
                {

                    textLivros.AppendText(livro + Environment.NewLine);
                }
                textValor.Text = valorTotal(date);
            }
        }

        private List<string> demostrarLivrosVendas(string data)
        {

            string url = "Data Source=WINDOWSCOMPUTER\\SQLEXPRESS;Initial Catalog=ajudasebo;Integrated Security=True";
            string sql = $"SELECT l.titulo FROM livros l, vendas v, livros_vendas lv " +
                         $"WHERE l.id_livro = lv.id_livro and v.id_venda = lv.id_venda and v.data = '{data}'";
            List<string> resultados = new List<string>();

            SqlConnection sqlConnection = new SqlConnection(url);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            SqlCommand command = new SqlCommand(sql, sqlConnection);

            sqlConnection.Open();
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(dataSet);

            foreach (DataRow dataR in dataSet.Tables[0].Rows)
            {

                resultados.Add(Convert.ToString(dataR.Field<Object>("titulo")));
            }

            return resultados;
        }

        private string valorTotal(string data)
        {

            string url = "Data Source=WINDOWSCOMPUTER\\SQLEXPRESS;Initial Catalog=ajudasebo;Integrated Security=True";

            string sql = "SELECT sum(valor_venda) as valor FROM vendas " +
                         $"WHERE data = '{data}'";

            SqlConnection sqlConnection = new SqlConnection(url);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            SqlCommand command = new SqlCommand(sql, sqlConnection);

            sqlConnection.Open();
            command.ExecuteNonQuery();

            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(dataSet);

            List<string> resultado = new List<string>();

            foreach(DataTable table in dataSet.Tables)
            {
                foreach(DataRow row in table.Rows)
                {
                    foreach (DataColumn column in table.Columns)
                    {

                        resultado.Add(Convert.ToString(row[column]));
                    }
                }
            }
            return resultado[0];
        }
    }
}
