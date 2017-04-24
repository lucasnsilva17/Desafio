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
    public partial class frmAssumirChamado : Form
    {
        Program prog;
        DataTable dt = new DataTable();
        chamados2TableAdapter chamadosTA = new chamados2TableAdapter();
        private string matricula;
        private int nroChamado;


        public frmAssumirChamado(int nroChamado, string matricula)
        {
            InitializeComponent();
            this.matricula = matricula;
            this.nroChamado = nroChamado;
            CarregaCampos();
        }

        private void CarregaCampos()
        {
            prog = new Program();

            dt = prog.PesquisaGridChamadosAbertos(2, Convert.ToString(nroChamado));

            txtNroChamado.Text = dt.Rows[0]["id"].ToString();
            txtNome.Text = dt.Rows[0]["solicitante"].ToString();

            cmbSetor.Items.Insert(0, dt.Rows[0]["setor"].ToString());
            cmbSetor.SelectedIndex = 0;

            cmbProblema.Items.Insert(0, dt.Rows[0]["problemas"].ToString());
            cmbProblema.SelectedIndex = 0;

            txtDescricao.Text = dt.Rows[0]["descricao"].ToString();

            DesabilitaCampos();
        }

        private void DesabilitaCampos()
        {
            prog = new Program();

            txtNroChamado.Enabled = false;
            txtNome.Enabled = false;
            cmbSetor.Enabled = false;
            cmbProblema.Enabled = false;
            txtDescricao.Enabled = false;
            txtSolução.Enabled = false;
            btnFecharChamado.Enabled = false;

            dt = prog.PesquisaGridChamadosAbertos(2, nroChamado.ToString());

            if (dt.Rows[0]["id_func"].ToString() != "")// caso o chamado ja tenha sido assumido mas ainda não foi atendido
            {
                txtSolução.Enabled = true;
                btnAssumirChamado.Enabled = false;
                btnFecharChamado.Enabled = true;
            }


        }

        private void BtnAssumirChamado_Click(object sender, EventArgs e)
        {
            Program prog = new Program();
            
            if (prog.AssumirChamado(nroChamado, matricula))
            {
                MessageBox.Show("Chamado assumido com sucesso");
                CarregaCampos();
            }
            else
                MessageBox.Show("Aconteceu um erro na operação");
        }

        private void BtnFecharChamado_Click(object sender, EventArgs e)
        {
            if (txtSolução.Text == "")
            {
                MessageBox.Show("Para Fechar o chamado é necessário Informar o serviço executado no campo solução");
            }
            else
            {
                prog = new Program();

                string FuncFechaChamado = prog.OwnerChamado(nroChamado);
                string matriculaTentAssumir = matricula;

                if (FuncFechaChamado != matriculaTentAssumir)
                {
                    MessageBox.Show("Você não possui as permissões necessárias para fechar este chamado.\nApenas quem o assumiu que pode facha-lo!");
                }
                else
                {
                    try
                    {
                        prog.FecharChamado(nroChamado, txtSolução.Text, matricula);
                        MessageBox.Show("Chamado fechado.\n Para visualizar as informações deste chamado, vá a página de chamados Fechados.");
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Desculpa, estamos com problemas tecnicos no momento");
                    }
                }


            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            prog = new Program();
            prog.VoltarListaChamados(matricula);
            this.Close();
         }
    }
}

