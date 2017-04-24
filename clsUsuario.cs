using prjChamados.DataSetChamadosTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjChamados.Model
{
    class clsUsuario
    {
        public string nome { get; set; }
        public string matricula { get; set; }
        public string senha { get; set; }

        public Boolean ValidaAcesso()
        {
            string matriculaBanco;
            string senhaBanco;

            funcionarioAtendenteTableAdapter ta = new funcionarioAtendenteTableAdapter();
            DataTable dt = new DataTable();
            try
            {
                dt = ta.Logar(matricula, senha);
                matriculaBanco = dt.Rows[0]["matricula"].ToString();
                senhaBanco = dt.Rows[0]["senha"].ToString();

                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public Boolean CadastrarUsuario()
        {
            try
            {
                funcionarioAtendenteTableAdapter ta = new funcionarioAtendenteTableAdapter();
                ta.CriarUsuario(matricula, nome, matricula);
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }

        public Boolean AlteraSenha()
        {
            funcionarioAtendenteTableAdapter ta = new funcionarioAtendenteTableAdapter();
            try
            {
                ta.AlteraSenha(senha, matricula);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



    }
}
