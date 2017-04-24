namespace prjChamados.View
{
    partial class frmListaChamado
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
            this.lblApresentacao = new System.Windows.Forms.Label();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnPesquisaTipoProblema = new System.Windows.Forms.Button();
            this.btnPesquisaNome = new System.Windows.Forms.Button();
            this.btnPesquisaNroChamado = new System.Windows.Forms.Button();
            this.cmbPesquisaTipoProblema = new System.Windows.Forms.ComboBox();
            this.txtPesquisaNroChamado = new System.Windows.Forms.TextBox();
            this.dtgChamados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamados2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetChamados = new prjChamados.DataSetChamados();
            this.btnAssumirChamado = new System.Windows.Forms.Button();
            this.chamados2TableAdapter = new prjChamados.DataSetChamadosTableAdapters.chamados2TableAdapter();
            this.tableAdapterManager = new prjChamados.DataSetChamadosTableAdapters.TableAdapterManager();
            this.pnlPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChamados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamados2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetChamados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApresentacao
            // 
            this.lblApresentacao.AutoSize = true;
            this.lblApresentacao.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblApresentacao.Location = new System.Drawing.Point(231, 9);
            this.lblApresentacao.Name = "lblApresentacao";
            this.lblApresentacao.Size = new System.Drawing.Size(214, 23);
            this.lblApresentacao.TabIndex = 1;
            this.lblApresentacao.Text = "Quadro de Chamados";
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.Controls.Add(this.btnPesquisa);
            this.pnlPesquisa.Controls.Add(this.txtNome);
            this.pnlPesquisa.Controls.Add(this.btnPesquisaTipoProblema);
            this.pnlPesquisa.Controls.Add(this.btnPesquisaNome);
            this.pnlPesquisa.Controls.Add(this.btnPesquisaNroChamado);
            this.pnlPesquisa.Controls.Add(this.cmbPesquisaTipoProblema);
            this.pnlPesquisa.Controls.Add(this.txtPesquisaNroChamado);
            this.pnlPesquisa.Location = new System.Drawing.Point(36, 55);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(602, 125);
            this.pnlPesquisa.TabIndex = 3;
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
            this.txtNome.Location = new System.Drawing.Point(235, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(162, 20);
            this.txtNome.TabIndex = 12;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // btnPesquisaTipoProblema
            // 
            this.btnPesquisaTipoProblema.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPesquisaTipoProblema.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPesquisaTipoProblema.Location = new System.Drawing.Point(439, 3);
            this.btnPesquisaTipoProblema.Name = "btnPesquisaTipoProblema";
            this.btnPesquisaTipoProblema.Size = new System.Drawing.Size(146, 54);
            this.btnPesquisaTipoProblema.TabIndex = 10;
            this.btnPesquisaTipoProblema.Text = "Habilitar Pesquisa pelo Tipo de Problema";
            this.btnPesquisaTipoProblema.UseVisualStyleBackColor = false;
            this.btnPesquisaTipoProblema.Click += new System.EventHandler(this.BtnPesquisaTipoProblema_Click);
            // 
            // btnPesquisaNome
            // 
            this.btnPesquisaNome.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPesquisaNome.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPesquisaNome.Location = new System.Drawing.Point(235, 3);
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
            // cmbPesquisaTipoProblema
            // 
            this.cmbPesquisaTipoProblema.FormattingEnabled = true;
            this.cmbPesquisaTipoProblema.Items.AddRange(new object[] {
            "Problemas na conexão com a rede",
            "Problemas de periféricos (mouse, teclado etc.)",
            "Problemas com Login",
            "Outros"});
            this.cmbPesquisaTipoProblema.Location = new System.Drawing.Point(439, 62);
            this.cmbPesquisaTipoProblema.Name = "cmbPesquisaTipoProblema";
            this.cmbPesquisaTipoProblema.Size = new System.Drawing.Size(146, 21);
            this.cmbPesquisaTipoProblema.TabIndex = 7;
            this.cmbPesquisaTipoProblema.SelectedIndexChanged += new System.EventHandler(this.CmbPesquisaTipoProblema_SelectedIndexChanged);
            // 
            // txtPesquisaNroChamado
            // 
            this.txtPesquisaNroChamado.Location = new System.Drawing.Point(18, 63);
            this.txtPesquisaNroChamado.Name = "txtPesquisaNroChamado";
            this.txtPesquisaNroChamado.Size = new System.Drawing.Size(171, 20);
            this.txtPesquisaNroChamado.TabIndex = 5;
            this.txtPesquisaNroChamado.TextChanged += new System.EventHandler(this.TxtPesquisaNroChamado_TextChanged);
            // 
            // dtgChamados
            // 
            this.dtgChamados.AllowUserToAddRows = false;
            this.dtgChamados.AllowUserToDeleteRows = false;
            this.dtgChamados.AllowUserToOrderColumns = true;
            this.dtgChamados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgChamados.AutoGenerateColumns = false;
            this.dtgChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChamados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtgChamados.DataSource = this.chamados2BindingSource;
            this.dtgChamados.Location = new System.Drawing.Point(12, 199);
            this.dtgChamados.Name = "dtgChamados";
            this.dtgChamados.ReadOnly = true;
            this.dtgChamados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgChamados.Size = new System.Drawing.Size(671, 220);
            this.dtgChamados.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nro do Chamado";
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
            this.dataGridViewTextBoxColumn3.HeaderText = "Problema ";
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
            this.dataGridViewTextBoxColumn5.HeaderText = "Data abertura do chamado";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // chamados2BindingSource
            // 
            this.chamados2BindingSource.DataMember = "chamados2";
            this.chamados2BindingSource.DataSource = this.dataSetChamados;
            // 
            // dataSetChamados
            // 
            this.dataSetChamados.DataSetName = "DataSetChamados";
            this.dataSetChamados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAssumirChamado
            // 
            this.btnAssumirChamado.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAssumirChamado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAssumirChamado.Location = new System.Drawing.Point(219, 434);
            this.btnAssumirChamado.Name = "btnAssumirChamado";
            this.btnAssumirChamado.Size = new System.Drawing.Size(213, 50);
            this.btnAssumirChamado.TabIndex = 5;
            this.btnAssumirChamado.Text = "Ver / Assumir Chamado";
            this.btnAssumirChamado.UseVisualStyleBackColor = false;
            this.btnAssumirChamado.Click += new System.EventHandler(this.BtnAssumirChamado_Click);
            // 
            // chamados2TableAdapter
            // 
            this.chamados2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chamados2TableAdapter = this.chamados2TableAdapter;
            this.tableAdapterManager.funcionarioAtendenteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjChamados.DataSetChamadosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmListaChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(696, 509);
            this.Controls.Add(this.btnAssumirChamado);
            this.Controls.Add(this.dtgChamados);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.lblApresentacao);
            this.Name = "frmListaChamado";
            this.Text = "Lista de Chamados";
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChamados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamados2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetChamados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblApresentacao;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.TextBox txtPesquisaNroChamado;
        private System.Windows.Forms.ComboBox cmbPesquisaTipoProblema;
        private System.Windows.Forms.Button btnPesquisaTipoProblema;
        private System.Windows.Forms.Button btnPesquisaNome;
        private System.Windows.Forms.Button btnPesquisaNroChamado;
        private DataSetChamados dataSetChamados;
        private System.Windows.Forms.BindingSource chamados2BindingSource;
        private DataSetChamadosTableAdapters.chamados2TableAdapter chamados2TableAdapter;
        private DataSetChamadosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dtgChamados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnAssumirChamado;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnPesquisa;
    }
}