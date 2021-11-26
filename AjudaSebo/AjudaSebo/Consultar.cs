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

            
        }

        private void btnConVoltar_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
