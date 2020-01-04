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


namespace Financeiro.View
{

    public partial class frmCadLancamento : Form
    {
        Lancamento obj = new Lancamento();
        AnoModel modelA = new AnoModel();
        public frmCadLancamento()
        {
            InitializeComponent();
            PreencherCB();
            dt.Value = DateTime.Now;
            DesabilitarCampos();
            HabilitarCampos();
            Listar();
            totalizar();
        }

        private void totalizar()
        {
            lblTotal.Text = valorTotal().ToString();
            if (Convert.ToDecimal(lblTotal.Text) < 0)
            {
                lblTotal.ForeColor = Color.Red;
            }
            else
            {
                lblTotal.ForeColor = Color.Green;
            }

        }
        private void LimparCampos()
        {
            txtDescricao.Text = "";
            txtValor.Text = "";
            cbBuscarTipo.Text = "";
        }
        private void DesabilitarCampos()
        {
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            cbTipo.Enabled = false;
            cbMes.Enabled = false;
            cbAno.Enabled = false;
            dt.Enabled = false;

        }
        private void HabilitarCampos()
        {
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            cbTipo.Enabled = true;
            cbMes.Enabled = true;
            cbAno.Enabled = true;
            dt.Enabled = true;

        }
        private void PreencherCB()
        {
            cbAno.DataSource = modelA.Listar();
            cbAno.ValueMember = "id_Ano";
            cbAno.DisplayMember = "ano";
        }
        private void Listar()
        {
            try
            {
                List<Lancamento> lista = new List<Lancamento>();
                lista = new LancModel().Listar();
                dgLancamento.DataSource = lista;
                dgLancamento.Columns[0].Visible = false;
                dgLancamento.Columns[4].Visible = false;
                dgLancamento.Columns[5].Visible = false;
                dgLancamento.Columns[1].HeaderText = "Tipo";
                dgLancamento.Columns[2].HeaderText = "Descrição";
                dgLancamento.Columns[3].HeaderText = "Valor";
                dgLancamento.Columns[6].HeaderText = "Data";
                dgLancamento.Columns[2].Width = 300;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel listar od dados " + ex);
            }

        }
        private void salvar()
        {
            try
            {
                obj.Tipo = cbTipo.Text;
                obj.Descricao = txtDescricao.Text;
                obj.Valor = Convert.ToDecimal(txtValor.Text);
                obj.Mes = cbMes.Text;
                obj.Ano = Convert.ToInt32(cbAno.SelectedValue);
                obj.Data = Convert.ToDateTime(dt.Text);
                int x = LancModel.Inserir(obj);
                if (x > 0)
                {
                    MessageBox.Show("Inserido com sucesso!!");

                }
                else
                {
                    MessageBox.Show("Item não inserido !!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Item não foi inserido " + ex);
            }

        }

        
        private void editar()
        {
            try
            {
                obj.Tipo = cbTipo.Text;
                obj.Descricao = txtDescricao.Text;
                obj.Valor = Convert.ToDecimal(txtValor.Text);
                obj.Mes = cbMes.Text;
                obj.Ano = Convert.ToInt32(cbAno.SelectedValue);
                obj.Data = Convert.ToDateTime(dt.Text);
                obj.Id_lancamento = Convert.ToInt32(txtId.Text);

                int x = LancModel.Editar(obj);


                if (x > 0)
                {
                    MessageBox.Show("Editado com sucesso !!");
                }
                else
                {
                    MessageBox.Show("Item não editado !!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Item não editado " + ex);
            }
        }
       
        private void excluir()
        {
            try
            {
                obj.Id_lancamento = Convert.ToInt32(txtId.Text);
                int x = LancModel.Excluir(obj);
                if (x > 0)
                {
                    MessageBox.Show("Excluido com sucesso !!");
                }
                else
                {
                    MessageBox.Show("Item não editado !!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Item não excluido " + ex);
            }

        }
        private decimal valorTotal()
        {
            decimal totalEntrada = 0;
            decimal totalSaida = 0;
            int i = 0;
            for (i = 0; i < dgLancamento.Rows.Count; i++)
            {
                if (Convert.ToString(dgLancamento.Rows[i].Cells[1].Value) == "ENTRADA")
                {
                    totalEntrada = totalEntrada + Convert.ToDecimal(dgLancamento.Rows[i].Cells[3].Value);
                }
                else
                {
                    totalSaida = totalSaida + Convert.ToDecimal(dgLancamento.Rows[i].Cells[3].Value);
                }
            }
            return totalEntrada - totalSaida;
        }

        private void rdBuscarTipo_CheckedChanged(object sender, EventArgs e)
        {
            dtBuscar.Visible = false;
            cbBuscarTipo.Visible = true;
        }

        private void rdBuscar_CheckedChanged(object sender, EventArgs e)
        {
            dtBuscar.Value = DateTime.Now;
            dtBuscar.Visible = true;
            dtBuscar.Enabled = true;
            dtBuscar.Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnSalvar.Enabled = true;
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                MessageBox.Show("Insira um valor !!");
                return;
            }
            salvar();
            LimparCampos();
            btnSalvar.Enabled = false;
            Listar();
            totalizar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                MessageBox.Show("Insira um valor !!");
                return;
            }
            editar();
            LimparCampos();
            btnSalvar.Enabled = false;
            Listar();
            totalizar();
        }

        private void dgLancamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos();
            txtId.Text = dgLancamento.CurrentRow.Cells[0].Value.ToString();
            cbTipo.Text = dgLancamento.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = dgLancamento.CurrentRow.Cells[2].Value.ToString();
            txtValor.Text = dgLancamento.CurrentRow.Cells[3].Value.ToString();
            cbMes.Text = dgLancamento.CurrentRow.Cells[4].Value.ToString();
            cbAno.Text = dgLancamento.CurrentRow.Cells[5].Value.ToString();
            dgLancamento.Text = dgLancamento.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um registro para excluir");
                return;
            }
            else
            {
                excluir();
                DesabilitarCampos();
                LimparCampos();
                Listar();
                totalizar();

            }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj.Tipo = cbBuscarTipo.Text;
            List<Lancamento> lista = new List<Lancamento>();
            lista = new LancModel().BuscarTipo(obj);
            dgLancamento.AutoGenerateColumns = false;
            dgLancamento.DataSource = lista;
            totalizar();
        }

        private void dtBuscar_ValueChanged(object sender, EventArgs e)
        {
            obj.Data = Convert.ToDateTime(dtBuscar.Text);
            List<Lancamento> lista = new List<Lancamento>();
            lista = new LancModel().BuscarTipo(obj);
            dgLancamento.AutoGenerateColumns = false;
            dgLancamento.DataSource = lista;
            totalizar();
        }
    }
}
