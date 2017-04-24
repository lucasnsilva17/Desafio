using prjChamados.DataSetChamadosTableAdapters;
using prjChamados.Model;
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
    public partial class frmChamadosFechados : Form
    {
        Program prog;

        public frmChamadosFechados()
        {
            InitializeComponent();
            CarregaGrid();
            DesabilitaCampos();
        }

        public void CarregaGrid()
        {
            prog = new Program();            
            dtgChamadosFechados.DataSource= prog.CarregaGridChamadosFechados();
        }

        public void DesabilitaCampos()
        {
            txtNome.Enabled = false;
            txtPesquisaNroChamado.Enabled = false;

            txtNome.Text = "";
            txtPesquisaNroChamado.Text = "";
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

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                dtgChamadosFechados.DataSource = prog.PesquisaGridChamadosFechados(1, txtNome.Text);

                if (dtgChamadosFechados.Rows.Count < 1)
                {
                    DataGridVazio();
                }
            }
            else
            {
                dtgChamadosFechados.DataSource = prog.PesquisaGridChamadosFechados(2, txtPesquisaNroChamado.Text);

                if (dtgChamadosFechados.Rows.Count < 1)
                {
                    DataGridVazio();
                }
            }
        }

        private void DtgChamadosFechados_DoubleClick(object sender, EventArgs e)
        {
            string nroChamado= dtgChamadosFechados.CurrentRow.Cells[0].Value.ToString();
            string solicitante = dtgChamadosFechados.CurrentRow.Cells[1].Value.ToString();
            string setor = dtgChamadosFechados.CurrentRow.Cells[2].Value.ToString();
            string problema = dtgChamadosFechados.CurrentRow.Cells[3].Value.ToString();
            string descricao = dtgChamadosFechados.CurrentRow.Cells[4].Value.ToString();
            string abertura = dtgChamadosFechados.CurrentRow.Cells[5].Value.ToString();
            string fechamento = dtgChamadosFechados.CurrentRow.Cells[6].Value.ToString();
            string solucao = dtgChamadosFechados.CurrentRow.Cells[7].Value.ToString();
            string atendente = dtgChamadosFechados.CurrentRow.Cells[8].Value.ToString();
            string tempoAbert = dtgChamadosFechados.CurrentRow.Cells[9].Value.ToString();

            MessageBox.Show("Número do Chamado: " + nroChamado +
                            "\nSolicitante: " + solicitante +
                            "\nSetor: " + setor + 
                            "\nProblema: " + problema + 
                            "\nDescricao: " + descricao + 
                            "\nData de abertura: " + abertura + 
                            "\nData de fechamento: " + fechamento + 
                            "\nSolução: " + solucao +
                            "\nAtendente: " + atendente +
                            "\nTempo que o chamado permaneceu aberto: " + tempoAbert
                            );
        }

        private void TxtPesquisaNroChamado_TextChanged(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void BtnGerarDoc_Click(object sender, EventArgs e)
        {
            prog = new Program();
            string nroChamado = dtgChamadosFechados.CurrentRow.Cells[0].Value.ToString();

            if (prog.GeraPDF(nroChamado))
            { 
                MessageBox.Show("PDF Criado com sucesso");
                string mensagem;
                string titulo;
                MessageBoxButtons botao;

                botao = MessageBoxButtons.YesNo;
                mensagem = "Deseja abrir o PDF agora?";
                titulo = "Abrir Documento?";

                DialogResult resul = MessageBox.Show(mensagem, titulo, botao, MessageBoxIcon.Exclamation);

                if (resul == DialogResult.Yes)
                {
                    prog.AbrirPDF(Convert.ToInt32(nroChamado));
                }
            }
            else
            {
                MessageBox.Show("Ocorreu um erro na criação do documento");
            }

        }

        public void DataGridVazio()
        {
            MessageBox.Show("Não nenhum registro com este parametro!");
            CarregaGrid();
        }
    }
}

