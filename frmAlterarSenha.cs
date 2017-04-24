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
    public partial class frmAlterarSenha : Form
    {
        Program prog; 

        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }

        private void TxtRepSenha_TextChanged(object sender, EventArgs e)
        {
            txtRepSenha.PasswordChar = '*';
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text == string.Empty
                || txtSenha.Text == string.Empty
                || txtRepSenha.Text == string.Empty
                )
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");
            }
            else if (txtSenha.Text != txtRepSenha.Text)
            {
                MessageBox.Show("A senha deve ser igual nos dois campos!");
            }
            else if (txtSenha.Text == txtMatricula.Text)
            {
                MessageBox.Show("A senha não pode ser igual a sua matricula");
            }
            else
            {
                prog = new Program();
                if (prog.AlterarSenha(txtMatricula.Text, txtSenha.Text))
                    MessageBox.Show("Senha alterada com sucesso");
                else
                    MessageBox.Show("Erro ao Cadastrar a nova senha");
            }
        }
    }
}
