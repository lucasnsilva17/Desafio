using prjChamados.DataSetChamadosTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace prjChamados.Model
{
    class Chamados
    {
        public string Nome { get; set; }
        public string Setor { get; set; }
        public string Problema { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAbert { get; set; }

        chamados2TableAdapter ta;

        public Chamados(String nome, String setor, String problema, String descricao) {
            Nome = nome;
            Setor = setor;
            Problema = problema;
            Descricao = descricao;
            
            DataAbert = DateTime.Now;
        } // construtor

        public Chamados()
        {

        } //construtor

        public int InsertBD() {
            ta = new chamados2TableAdapter();

            ta.Insert(Nome, Problema, Descricao, Convert.ToString(DataAbert), "ABERTO", null, null, Setor, null, null);
           
            int max = Convert.ToInt32(ta.maxId());
            return max;
        } //metodo cria um chamado

        public Boolean AtribuirChamado(int nroChamado, string matricula)
        {
            try
            {
                ta = new chamados2TableAdapter();
                ta.AssumirChamado(matricula, nroChamado);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } // metodo atribui um chamado

        public Boolean EncerrarChamado(int chamado, string solucao)
        {
            DataTable dt = new DataTable();
            ta = new chamados2TableAdapter();

            try
            {

                DateTime dataNow, dataAbertura;
                string dataResul;

               
                dt = ta.GetDataById(chamado);

                dataAbertura = Convert.ToDateTime(dt.Rows[0]["dataAbert"].ToString());
                dataNow = DateTime.Now;
                
                dataResul = dataNow.Subtract(dataAbertura).ToString().Substring(0,8);
                
                //ta = new chamados2TableAdapter();
                ta.FecharChamado(Convert.ToString(dataNow), solucao, Convert.ToString(dataResul), chamado);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } //metodo encerra um chamado

        public string OwnerChamado(int nroChamado)
        {
            IdTableAdapter ta = new IdTableAdapter(); // fazer um datatable
            DataTable dt = new DataTable();
            dt = ta.OwnerChamado(nroChamado);

            string matricula = null;

            matricula = dt.Rows[0]["id_func"].ToString();


            return matricula;
        }

        public void GerarDocumentoChamado(int nroChamado)
        {
            ChamadosFechadosTableAdapter ta = new ChamadosFechadosTableAdapter();
            DataTable dt = new DataTable();
            ta.GetDataById(nroChamado);
            
           // StreamWriter gravar = new StreamWriter("C:\\Contratos" + RetNome() + ".doc", false, Encoding.UTF8);
        }

        public DataTable CarregaGridChamadosFechados()
        {
            DataTable chamados;

            ChamadosFechadosTableAdapter ta = new ChamadosFechadosTableAdapter();

            chamados = ta.GetData();

            return chamados;
        }

        public DataTable PesquisaGridChamadosFechados(int opcao, string condicao)
        {
            DataTable chamados = null;
            ChamadosFechadosTableAdapter ta = new ChamadosFechadosTableAdapter();

            if (opcao == 1)
            {
                chamados = ta.GetDataBySolicitante(condicao);
            }
            else if (opcao == 2)
            {
                chamados = ta.GetDataById(Convert.ToInt32(condicao));
            }

            return chamados;
        }

        public DataTable CarregaGridChamadosAbertos()
        {
            DataTable chamados;

            ta = new chamados2TableAdapter();

            chamados = ta.GetData();

            return chamados;
        }

        public DataTable PesquisaGridChamadosAbertos(int opcao, string condicao)
        {
            DataTable chamados = null;
            ta = new chamados2TableAdapter();

            if (opcao == 1)
            {
                chamados = ta.GetDataBySolicitante(condicao);
            }
            else if (opcao == 2)
            {
                chamados = ta.GetDataById(Convert.ToInt32(condicao));
            }
            else if (opcao == 3)
            {
                chamados = ta.GetDataByProblema(condicao);
            }

            return chamados;
        }
        
        
        public Boolean GeraPDF(string nroChamado)
        {
            try
            {

                DataTable dt = new DataTable();

                dt = PesquisaGridChamadosFechados(2, nroChamado);


                Document doc = new Document(PageSize.A4);
                doc.SetMargins(40, 40, 40, 80);
                doc.AddCreationDate();

                string caminho = @"C:\Users\Lucas\Desktop\PDF's\chamadoNumero- " + nroChamado + ".pdf"; // Nome do documento é o Numero do chamado
                
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
                
                doc.Open();
                string dados = "";
                
                Paragraph paragrafo = new Paragraph(dados, new Font(Font.NORMAL, 14)); // Alinhamento e fonte
                
                paragrafo.Alignment = Element.ALIGN_JUSTIFIED; // Texto justificado
                
                
                //adicioando texto
                paragrafo.Add("                     Dados do chamado");
                paragrafo.Add("\n\nChamado Número: " + dt.Rows[0]["id"].ToString());
                paragrafo.Add("\nSolicitante: " + dt.Rows[0]["solicitante"].ToString());
                paragrafo.Add("\nSetor: " + dt.Rows[0]["setor"].ToString());
                paragrafo.Add("\nProblema: " + dt.Rows[0]["problemas"].ToString());
                paragrafo.Add("\nDescrição do Problema: " + dt.Rows[0]["descricao"].ToString());
                paragrafo.Add("\nData de abertura do chamado: " + dt.Rows[0]["dataAbert"].ToString());
                paragrafo.Add("\nData de fechamento do chamado: " + dt.Rows[0]["dataFechamento"].ToString());
                paragrafo.Add("\nSolução para o Problema: " + dt.Rows[0]["solucao"].ToString());
                paragrafo.Add("\nResponsável pelo Atendimento do chamado: " + dt.Rows[0]["nome"].ToString());
                paragrafo.Add("\nTempo que o chamado permaneceu aberto: " + dt.Rows[0]["tempoAberto"].ToString());
                paragrafo.Add("\n\n\nMuito Obrigado por utilizar nosso serviços.\nQualquer duvida crie um novo chamado e entraremos em contato");
                
                doc.Add(paragrafo);

                doc.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void AbrirPDF(int nroChamado)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Lucas\Desktop\PDF's\chamadoNumero- " + nroChamado + ".pdf");
        }

    }
}
