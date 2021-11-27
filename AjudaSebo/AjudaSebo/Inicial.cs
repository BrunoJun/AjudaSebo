using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjudaSebo
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void bttConsultarVendas_Click(object sender, EventArgs e)
        {

            ConsultarVendas consultarVendas = new ConsultarVendas();
            consultarVendas.Show();
        }

        private void cadInicial_Click(object sender, EventArgs e)
        {

            Cadastrar cadastrar = new Cadastrar();
            cadastrar.Show();
        }

        private void conInicial_Click(object sender, EventArgs e)
        {

            Consultar consultar = new Consultar();
            consultar.Show();
        }
    }
}
