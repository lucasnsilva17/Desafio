using prjChamados.DataSetChamadosTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjChamados.View
{
    public partial class frmListaChamado : Form
    {

        Program prog;
        private string matricula;


        public frmListaChamado(string nroMatricula)
        {
            InitializeComponent();
            this.matricula = nroMatricula;
            CarregaGrid(); // carrega todas as informações
            DesabilitaCampos();
        }

        private void DesabilitaCampos()
        {
            txtNome.Enabled = false;
            txtPesquisaNroChamado.Enabled = false;
            cmbPesquisaTipoProblema.Enabled = false;

            txtNome.Text = "";
            txtPesquisaNroChamado.Text = "";
            cmbPesquisaTipoProblema.SelectedIndex = -1;
        }

        private void BtnPesquisaNroChamado_Click(object sender, EventArgs e)
        {
            DesabilitaCampos();
            txtPesquisaNroChamado.Enabled = true;
        }

        private void BtnPesquisaNome_Click(object sender, EventArgs e)
        {
            DesabilitaCampos();
            txtNome.Enabled = true;
        }

        private void BtnPesquisaTipoProblema_Click(object sender, EventArgs e)
        {
            DesabilitaCampos();
            cmbPesquisaTipoProblema.Enabled = true;
        }

        private void BtnAssumirChamado_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgChamados.CurrentRow.Cells[0].Value);
            prog.IniciaChamado(id, matricula);
            this.Close();
        }

        public void CarregaGrid()
        {
            prog = new Program();
            dtgChamados.DataSource = prog.CarregaGridChamadosAbertos();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CmbPesquisaTipoProblema_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void TxtPesquisaNroChamado_TextChanged(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "") // pesquisa por solicitante 1
            {
                dtgChamados.DataSource = prog.PesquisaGridChamadosAbertos(1, txtNome.Text);

                if (dtgChamados.Rows.Count < 1)
                {
                    DataGridVazio();
                }
            }
            else if (txtPesquisaNroChamado.Text != "") // pesquisa pelo numero do chamado 2
            {
                dtgChamados.DataSource = prog.PesquisaGridChamadosAbertos(2, txtPesquisaNroChamado.Text);

                if (dtgChamados.Rows.Count < 1)
                {
                    DataGridVazio();
                }
            }
            else // pesquisa pelo problema ocorrido 3
            {
                dtgChamados.DataSource = prog.PesquisaGridChamadosAbertos(3, cmbPesquisaTipoProblema.SelectedItem.ToString());

                if (dtgChamados.Rows.Count < 1)
                {
                    DataGridVazio();
                }
            }

        }

        public void DataGridVazio()
        {
            MessageBox.Show("Não nenhum registro com este parametro!");
            CarregaGrid();
        }
    }
}
