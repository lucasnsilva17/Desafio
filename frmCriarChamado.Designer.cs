namespace prjChamados.Forms
{
    partial class frmCriarChamado
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
            this.lblApresentacao = new System.Windows.Forms.Label();
            this.lblSetor = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblProblema = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.cmbProblema = new System.Windows.Forms.ComboBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnSolicitacao = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApresentacao
            // 
            this.lblApresentacao.AutoSize = true;
            this.lblApresentacao.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApresentacao.Location = new System.Drawing.Point(159, 9);
            this.lblApresentacao.Name = "lblApresentacao";
            this.lblApresentacao.Size = new System.Drawing.Size(151, 23);
            this.lblApresentacao.TabIndex = 0;
            this.lblApresentacao.Text = "Criar Chamado";
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSetor.Location = new System.Drawing.Point(52, 114);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(44, 16);
            this.lblSetor.TabIndex = 2;
            this.lblSetor.Text = "Setor";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNome.Location = new System.Drawing.Point(52, 72);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 16);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblProblema
            // 
            this.lblProblema.AutoSize = true;
            this.lblProblema.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblProblema.Location = new System.Drawing.Point(52, 156);
            this.lblProblema.Name = "lblProblema";
            this.lblProblema.Size = new System.Drawing.Size(68, 16);
            this.lblProblema.TabIndex = 4;
            this.lblProblema.Text = "Problema";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(163, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(189, 20);
            this.txtNome.TabIndex = 6;
            // 
            // cmbSetor
            // 
            this.cmbSetor.FormattingEnabled = true;
            this.cmbSetor.Items.AddRange(new object[] {
            "Comercial",
            "Financeiro",
            "Informática",
            "Produção",
            "P&D",
            "Recursos Humanos"});
            this.cmbSetor.Location = new System.Drawing.Point(163, 109);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(189, 21);
            this.cmbSetor.TabIndex = 7;
            // 
            // cmbProblema
            // 
            this.cmbProblema.FormattingEnabled = true;
            this.cmbProblema.Items.AddRange(new object[] {
            "Problemas na conexão com a rede",
            "Problemas de periféricos (mouse, teclado etc.)",
            "Problemas com Login",
            "Outros"});
            this.cmbProblema.Location = new System.Drawing.Point(163, 155);
            this.cmbProblema.Name = "cmbProblema";
            this.cmbProblema.Size = new System.Drawing.Size(189, 21);
            this.cmbProblema.TabIndex = 8;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDescricao.Location = new System.Drawing.Point(52, 200);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(71, 16);
            this.lblDescricao.TabIndex = 9;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(163, 196);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(189, 20);
            this.txtDescricao.TabIndex = 10;
            // 
            // btnSolicitacao
            // 
            this.btnSolicitacao.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSolicitacao.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSolicitacao.Location = new System.Drawing.Point(55, 295);
            this.btnSolicitacao.Name = "btnSolicitacao";
            this.btnSolicitacao.Size = new System.Drawing.Size(297, 44);
            this.btnSolicitacao.TabIndex = 11;
            this.btnSolicitacao.Text = "Criar Solicitação";
            this.btnSolicitacao.UseVisualStyleBackColor = false;
            this.btnSolicitacao.Click += new System.EventHandler(this.BtnSolicitacao_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Location = new System.Drawing.Point(55, 249);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(131, 40);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(221, 249);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 40);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // frmCriarChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(462, 388);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSolicitacao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.cmbProblema);
            this.Controls.Add(this.cmbSetor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblProblema);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.lblApresentacao);
            this.Name = "frmCriarChamado";
            this.Text = "frmCriarChamado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApresentacao;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblProblema;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbSetor;
        private System.Windows.Forms.ComboBox cmbProblema;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnSolicitacao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
    }
}