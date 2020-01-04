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
using Financeiro.Entidades ;
//excluir e editar não esta pegando 
namespace Financeiro.View
{
    public partial class frmCadAno : Form
    {
        Anos obj = new Anos();      
        public frmCadAno()
        {
            InitializeComponent();
            Listar();
        }
        private void Listar()
        {
            try
            {
                List<Anos> lista = new List<Anos>();
                lista = new AnoModel().Listar();

                dgAno.DataSource = lista;
                dgAno.Columns[0].HeaderText = "Código";
                dgAno.Columns[1].HeaderText = "Ano";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel listar os dados!!" + ex);

            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            txtAno.Enabled = true;
            txtAno.Focus();
            Listar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtAno.Text == "")
            {
                MessageBox.Show("Digite um ano!! ");
                return;

            }
            salvar();
            btnSalvar.Enabled = false;
            txtAno.Enabled = false;
            txtAno.Text = "";
            Listar();
        }
        private void salvar()
        {
            try
            {
                obj.Ano = Convert.ToInt32(txtAno.Text);
                int x = AnoModel.Inserir(obj);
                if (x > 0)
                {
                    MessageBox.Show("Inserido com sucesso !!!");
                }
                else
                {
                    MessageBox.Show("Cadastro não inserido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cadastro não foi inserido !! " + ex);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Id_ano = Convert.ToInt32(txtId.Text);
                int x = AnoModel.Deletar(obj);
                if (x > 0)
                {
                    MessageBox.Show("Excluido com sucesso !!");
                }
                else
                {
                    MessageBox.Show("Cadastro não foi excluido");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cadastro não foi exclido !! " + ex);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                Listar();
                return;
            }
            obj.Ano = Convert.ToInt32(txtBuscar.Text);
            List<Anos> lista = new List<Anos>();
            lista = new AnoModel().Buscar(obj);
            dgAno.AutoGenerateColumns = false;
            dgAno.DataSource = lista;
        }
        private void dgAno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgAno.CurrentRow.Cells[0].Value.ToString();
            txtAno.Text = dgAno.CurrentRow.Cells[1].Value.ToString();
            txtAno.Enabled = true;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtAno.Text == "")
            {
                MessageBox.Show("Digite um ano!!");
            }
            return;
            editar();
            btnSalvar.Enabled = false;
            txtAno.Enabled = false;
            txtAno.Text = "";
            Listar();
        }

        public void editar()
        {
            try
            {
                obj.Id_ano = Convert.ToInt32(txtAno.Text);
                obj.Ano = Convert.ToInt32(txtAno.Text);
                int x = AnoModel.Editar(obj);
                if (x > 0)
                {
                    MessageBox.Show("Editado com sucesso !!");
                }
                else
                {
                    MessageBox.Show("Cadastro não foi editado!!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Cadastro não foi editado!!" + ex);
            }
        }

        
    }
}
