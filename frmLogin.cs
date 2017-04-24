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
    public partial class frmLogin : Form
    {
        private int abrirTela;
        Program prog;
        FrmCadUsuario cad;

        public frmLogin(int nroTela)
        {
            InitializeComponent();
            txtMatricula.Focus();
            abrirTela = nroTela;
        }        

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            FazerLogin();
        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Resposta()
        {
            MessageBox.Show("Usuário e/ou senha invalidos");
        }

        public void FazerLogin()
        {
            prog = new Program();

            if (txtMatricula.Text == string.Empty)                                              //validações de acesso
            {                                                                                   //validações de acesso
                MessageBox.Show("Preecha o campo Matricula!");                                  //validações de acesso
            }                                                                                   //validações de acesso
            else if (txtSenha.Text == string.Empty)                                             //validações de acesso
            {                                                                                   //validações de acesso
                MessageBox.Show("Preecha o campo Senha!");                                      //validações de acesso
            }                                                                                   //validações de acesso
            else if (txtMatricula.Text == txtSenha.Text)                                        //validações de acesso
            {                                                                                   //validações de acesso
                MessageBox.Show("Para o primeiro acesso é necessário alterar a senha!");        //validações de acesso
            }
            else                                                                                //acesso validado
            {
                bool loginOk = prog.FazerLogin(txtMatricula.Text, Convert.ToString(txtSenha.Text));

                if (loginOk)
                {
                    if (abrirTela == 0)                                                         //acesso a lista de chamados
                    {
                        frmListaChamado list = new frmListaChamado(txtMatricula.Text);
                        list.Visible = true;
                        this.Close();
                    }
                    else if (abrirTela == 1)                                                    //acesso ao cadastro de novos usuários
                    {
                        cad = new FrmCadUsuario();
                        cad.Visible = true;
                        this.Close();
                    }
                }
                else
                    Resposta();
            }

        }

    }
}
