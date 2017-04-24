using prjChamados.DataSetChamadosTableAdapters;
using prjChamados.Model;
using System;
using System.Windows.Forms;


namespace prjChamados.Forms
{
    public partial class frmCriarChamado : Form
    {
        Program prog;

        public frmCriarChamado()
        {
            InitializeComponent();
        }

        private void BtnSolicitacao_Click(object sender, EventArgs e)
        {
            try
            {
                prog = new Program();
                int nroChamado;
                nroChamado = prog.CadChamado(txtNome.Text, Convert.ToString(cmbSetor.SelectedItem), Convert.ToString(cmbProblema.SelectedItem), txtDescricao.Text);
                MessageBox.Show("Chamado Criado com sucesso!" + "\nO Numero do seu chamado é:\n" + nroChamado);
                LimpaInfo();
                Solicitacao(1);
                
            } catch (Exception) {
                MessageBox.Show("Por Favor preencha todos os Campos");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            string mensagem = "Deseja realmente Cancelar a abertura deste chamado";
            string titulo = "Fechar Janela?";
            MessageBoxButtons botao = MessageBoxButtons.YesNo;

            DialogResult resul = MessageBox.Show(mensagem, titulo, botao, MessageBoxIcon.Exclamation);

            if (resul == DialogResult.Yes)
            {
                this.Close();
            }



        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Solicitacao(2); 
        }

        private void Solicitacao(int nroSolicitacao)
        {
            string mensagem;
            string titulo;
            MessageBoxButtons botao;

            if (nroSolicitacao == 1)
            {
                botao = MessageBoxButtons.YesNo;
                mensagem = "Deseja fechar a página de abertura de Chamados?";
                titulo = "Fechar Página?";

                DialogResult resul = MessageBox.Show(mensagem, titulo, botao, MessageBoxIcon.Exclamation);

                if (resul == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else if(nroSolicitacao == 2)
            {
                botao = MessageBoxButtons.YesNo;
                mensagem = "Deseja realmente limpar todos os campos?";
                titulo = "Limpar Campos?";

                DialogResult resul = MessageBox.Show(mensagem, titulo, botao, MessageBoxIcon.Exclamation);

                if (resul == DialogResult.Yes)
                {
                    LimpaInfo();
                }
            }
        }

        private void LimpaInfo()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            cmbProblema.SelectedIndex = -1;
            cmbSetor.SelectedIndex = -1;
        }
    }
}
