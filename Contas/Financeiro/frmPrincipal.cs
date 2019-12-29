using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financeiro.View; 

namespace Financeiro
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lançamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadLancamento form = new frmCadLancamento();
            form.Show();
        }

        private void anoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadAno form = new frmCadAno();
            form.Show();
        }
    }
}
