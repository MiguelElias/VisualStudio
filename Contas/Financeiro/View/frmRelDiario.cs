using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financeiro.Model;
using Financeiro.Entidades;
using Financeiro.View;

namespace Financeiro.View
{
    public partial class frmRelDiario : Form
    {
        Lancamento obj = new Lancamento();
        public frmRelDiario()
        {
            InitializeComponent();
            Listar();
            totalizar();
        }
        private void tsSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void msSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsAno_Click(object sender, EventArgs e)
        {
            frmCadAno form = new frmCadAno();
            form.ShowDialog();
        }

        private void tsLancamento_Click(object sender, EventArgs e)
        {

            frmCadLancamento form = new frmCadLancamento();
            form.ShowDialog();
        }
        private void totalizar()
        {
            decimal total = valorTotalEntradas() - valorTotalSaidas();
            lblTotalEnt.Text = valorTotalEntradas().ToString(); lblTotalSaida.Text = valorTotalSaidas().ToString(); lblTotalEnt.Text = Convert.ToString(total);
            if (Convert.ToDecimal(lblTotalEnt.Text) < 0)
            {
                lblTotalEnt.ForeColor = Color.Red;
            }
            else

            {
                lblTotalEnt.ForeColor = Color.Green;
            }
        }
        private void dt_ValueChanged(object sender, EventArgs e)
        {
            buscar();
        }
        private void buscar()
        {
            obj.Data = Convert.ToDateTime(dt.Text);
            List<Lancamento> lista = new List<Lancamento>();
            lista = new LancModel().BuscarDataTipoEntrada(obj);
            dgEntrada.AutoGenerateColumns = false;
            dgEntrada.DataSource = lista;
            List<Lancamento> lista2 = new List<Lancamento>();
            lista2 = new LancModel().BuscarDataTipoSaida(obj);
            dgSaida.AutoGenerateColumns = false;
            dgSaida.DataSource = lista2;
            totalizar();
        }
        private void Listar()
        {
            try
            {
                List<Lancamento> lista = new List<Lancamento>();
                dgEntrada.DataSource = lista;
                dgEntrada.Columns[0].Visible = false;
                dgEntrada.Columns[1].Visible = false;
                dgEntrada.Columns[4].Visible = false;
                dgEntrada.Columns[5].Visible = false;

                dgEntrada.Columns[2].HeaderText = "Descrição";
                dgEntrada.Columns[3].HeaderText = "Valor";
                dgEntrada.Columns[6].HeaderText = "Data";
                dgEntrada.Columns[2].Width = 300;
                dgEntrada.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgEntrada.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                List<Lancamento> lista2 = new List<Lancamento>();
                dgSaida.DataSource = lista2;
                dgSaida.Columns[0].Visible = false;
                dgSaida.Columns[1].Visible = false;
                dgSaida.Columns[4].Visible = false;
                dgSaida.Columns[5].Visible = false;
                dgSaida.Columns[2].HeaderText = "Descrição";
                dgSaida.Columns[3].HeaderText = "Valor";
                dgSaida.Columns[6].HeaderText = "Data";
                dgSaida.Columns[2].Width = 300; dgSaida.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgSaida.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível listar os dados" + ex);
            }
        }
        private void dt_Enter(object sender, EventArgs e)
        {
            dt.Value = DateTime.Now;
        }
        private decimal valorTotalEntradas()
        {
            decimal total = 0;
            int i = 0; for (i = 0; i < dgEntrada.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(dgEntrada.Rows[i].Cells[3].Value);
            }
            return total;
        }
        private decimal valorTotalSaidas()
        {
            decimal total = 0;
            int i = 0; for (i = 0; i < dgSaida.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(dgSaida.Rows[i].Cells[3].Value);
            }
            return total;
        }
        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
