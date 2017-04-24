using prjChamados.Forms;
using prjChamados.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjChamados
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

       
        private void AbrirNovoChamadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCriarChamado cr = new frmCriarChamado();
            cr.Show();
        }

        private void ChamadosFechadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChamadosFechados frm = new frmChamadosFechados();
            frm.Visible = true;
        }

        private void ListaDeChamadosAbertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin(0);
            log.Show();
        }

        private void CadastrarNovoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin(1);
            log.Show();
        }

        private void SobreOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de gerenciamento de chamados.\nPara acessar algumas funcionalidades é necessário fazer login");
        }

        private void NovoUsuárioAlterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlterarSenha frm = new frmAlterarSenha();
            frm.Visible = true;
        }
    }
}
