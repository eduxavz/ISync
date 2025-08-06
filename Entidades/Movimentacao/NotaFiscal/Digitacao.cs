using ISync.Servicos.NotaFiscal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISync.Forms.NotaFiscal
{
    public partial class Digitacao : Form
    {
        public Digitacao()
        {
            InitializeComponent();
        }

        private void btnTransmitir_Click(object sender, EventArgs e)
        {
            NFeService servico = new();
            _ = servico.ObterNfeValidada(DFe.Classes.Flags.VersaoServico.Versao400, DFe.Classes.Flags.ModeloDocumento.NFe, 0);
        }
    }
}
