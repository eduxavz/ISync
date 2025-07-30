using ISync.Forms.Cadastros;
using ISync.Forms.NotaFiscal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISync.Forms
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void novaNotaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Digitacao nfe = new Digitacao();
            nfe.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos prod = new Produtos();
            prod.ShowDialog();
        }

        private void naturezaDeOperaçãoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NaturezaOperacao natureza = new NaturezaOperacao();
            natureza.ShowDialog();
        }
    }
}