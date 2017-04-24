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
    public partial class FrmCadUsuario : Form
    {
        public FrmCadUsuario()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text == string.Empty)
            {
                MessageBox.Show("Preecha o campo Matricula!");
            }
            else if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Preecha o campo Nome!");
            }
            else
            {
                Program prog = new Program();
                if (prog.CadUsuario(txtMatricula.Text, txtNome.Text))
                {
                    MessageBox.Show("Usuário cadastrado com sucesso." +
                        "\nPara o primeiro acesso é necessário alteração da senha");
                }
            }
        }
    }
}
