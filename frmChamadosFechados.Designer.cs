namespace prjChamados.View
{
    partial class frmChamadosFechados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtgChamadosFechados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamadosFechadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetChamados = new prjChamados.DataSetChamados();
            this.lblApresentacao = new System.Windows.Forms.Label();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnPesquisaNome = new System.Windows.Forms.Button();
            this.btnPesquisaNroChamado = new System.Windows.Forms.Button();
            this.txtPesquisaNroChamado = new System.Windows.Forms.TextBox();
            this.chamadosFechadosTableAdapter = new prjChamados.DataSetChamadosTableAdapters.ChamadosFechadosTableAdapter();
            this.tableAdapterManager = new prjChamados.DataSetChamadosTableAdapters.TableAdapterManager();
            this.btnGerarDoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChamadosFechados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamadosFechadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetChamados)).BeginInit();
            this.pnlPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgChamadosFechados
            // 
            this.dtgChamadosFechados.AllowUserToAddRows = false;
            this.dtgChamadosFechados.AllowUserToDeleteRows = false;
            this.dtgChamadosFechados.AllowUserToOrderColumns = true;
            this.dtgChamadosFechados.AutoGenerateColumns = false;
            this.dtgChamadosFechados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChamadosFechados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12,
            this.tempoAberto});
            this.dtgChamadosFechados.DataSource = this.chamadosFechadosBindingSource;
            this.dtgChamadosFechados.Location = new System.Drawing.Point(12, 207);
            this.dtgChamadosFechados.Name = "dtgChamadosFechados";
            this.dtgChamadosFechados.ReadOnly = true;
            this.dtgChamadosFechados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgChamadosFechados.Size = new System.Drawing.Size(639, 220);
            this.dtgChamadosFechados.TabIndex = 1;
            this.dtgChamadosFechados.DoubleClick += new System.EventHandler(this.DtgChamadosFechados_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Número do Chamado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "solicitante";
            this.dataGridViewTextBoxColumn2.HeaderText = "Solicitante";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "setor";
            this.dataGridViewTextBoxColumn9.HeaderText = "Setor";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "problemas";
            this.dataGridViewTextBoxColumn3.HeaderText = "Problema";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dataAbert";
            this.dataGridViewTextBoxColumn5.HeaderText = "Abertura";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "dataFechamento";
            this.dataGridViewTextBoxColumn8.HeaderText = "Fechamento";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "solucao";
            this.dataGridViewTextBoxColumn10.HeaderText = "Solucao";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn12.HeaderText = "Atendente";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // tempoAberto
            // 
            this.tempoAberto.DataPropertyName = "tempoAberto";
            this.tempoAberto.HeaderText = "Tempo Aberto";
            this.tempoAberto.Name = "tempoAberto";
            this.tempoAberto.ReadOnly = true;
            // 
            // chamadosFechadosBindingSource
            // 
            this.chamadosFechadosBindingSource.DataMember = "ChamadosFechados";
            this.chamadosFechadosBindingSource.DataSource = this.dataSetChamados;
            // 
            // dataSetChamados
            // 
            this.dataSetChamados.DataSetName = "DataSetChamados";
            this.dataSetChamados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblApresentacao
            // 
            this.lblApresentacao.AutoSize = true;
            this.lblApresentacao.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblApresentacao.Location = new System.Drawing.Point(230, 9);
            this.lblApresentacao.Name = "lblApresentacao";
            this.lblApresentacao.Size = new System.Drawing.Size(204, 23);
            this.lblApresentacao.TabIndex = 2;
            this.lblApresentacao.Text = "Chamados Fechados";
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.Controls.Add(this.btnPesquisa);
            this.pnlPesquisa.Controls.Add(this.txtNome);
            this.pnlPesquisa.Controls.Add(this.btnPesquisaNome);
            this.pnlPesquisa.Controls.Add(this.btnPesquisaNroChamado);
            this.pnlPesquisa.Controls.Add(this.txtPesquisaNroChamado);
            this.pnlPesquisa.Location = new System.Drawing.Point(12, 56);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(639, 125);
            this.pnlPesquisa.TabIndex = 4;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPesquisa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPesquisa.Location = new System.Drawing.Point(18, 89);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(567, 29);
            this.btnPesquisa.TabIndex = 13;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(423, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(162, 20);
            this.txtNome.TabIndex = 12;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // btnPesquisaNome
            // 
            this.btnPesquisaNome.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPesquisaNome.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPesquisaNome.Location = new System.Drawing.Point(423, 3);
            this.btnPesquisaNome.Name = "btnPesquisaNome";
            this.btnPesquisaNome.Size = new System.Drawing.Size(162, 54);
            this.btnPesquisaNome.TabIndex = 9;
            this.btnPesquisaNome.Text = "Habilitar pesquisar pelo Nome";
            this.btnPesquisaNome.UseVisualStyleBackColor = false;
            this.btnPesquisaNome.Click += new System.EventHandler(this.BtnPesquisaNome_Click);
            // 
            // btnPesquisaNroChamado
            // 
            this.btnPesquisaNroChamado.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPesquisaNroChamado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPesquisaNroChamado.Location = new System.Drawing.Point(18, 3);
            this.btnPesquisaNroChamado.Name = "btnPesquisaNroChamado";
            this.btnPesquisaNroChamado.Size = new System.Drawing.Size(171, 54);
            this.btnPesquisaNroChamado.TabIndex = 8;
            this.btnPesquisaNroChamado.Text = "Habilitar pequisa pelo Nro do chamado";
            this.btnPesquisaNroChamado.UseVisualStyleBackColor = false;
            this.btnPesquisaNroChamado.Click += new System.EventHandler(this.BtnPesquisaNroChamado_Click);
            // 
            // txtPesquisaNroChamado
            // 
            this.txtPesquisaNroChamado.Location = new System.Drawing.Point(18, 63);
            this.txtPesquisaNroChamado.Name = "txtPesquisaNroChamado";
            this.txtPesquisaNroChamado.Size = new System.Drawing.Size(171, 20);
            this.txtPesquisaNroChamado.TabIndex = 5;
            this.txtPesquisaNroChamado.TextChanged += new System.EventHandler(this.TxtPesquisaNroChamado_TextChanged);
            // 
            // chamadosFechadosTableAdapter
            // 
            this.chamadosFechadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chamados2TableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.funcionarioAtendenteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjChamados.DataSetChamadosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnGerarDoc
            // 
            this.btnGerarDoc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnGerarDoc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGerarDoc.Location = new System.Drawing.Point(12, 447);
            this.btnGerarDoc.Name = "btnGerarDoc";
            this.btnGerarDoc.Size = new System.Drawing.Size(639, 48);
            this.btnGerarDoc.TabIndex = 5;
            this.btnGerarDoc.Text = "Gerar Documento Word com as Informações do chamado";
            this.btnGerarDoc.UseVisualStyleBackColor = false;
            this.btnGerarDoc.Click += new System.EventHandler(this.BtnGerarDoc_Click);
            // 
            // frmChamadosFechados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(667, 512);
            this.Controls.Add(this.btnGerarDoc);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.lblApresentacao);
            this.Controls.Add(this.dtgChamadosFechados);
            this.Name = "frmChamadosFechados";
            this.Text = "frmChamadosFechados";
            ((System.ComponentModel.ISupportInitialize)(this.dtgChamadosFechados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamadosFechadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetChamados)).EndInit();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSetChamados dataSetChamados;
        private System.Windows.Forms.BindingSource chamadosFechadosBindingSource;
        private DataSetChamadosTableAdapters.ChamadosFechadosTableAdapter chamadosFechadosTableAdapter;
        private DataSetChamadosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dtgChamadosFechados;
        private System.Windows.Forms.Label lblApresentacao;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnPesquisaNome;
        private System.Windows.Forms.Button btnPesquisaNroChamado;
        private System.Windows.Forms.TextBox txtPesquisaNroChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoAberto;
        private System.Windows.Forms.Button btnGerarDoc;
    }
}