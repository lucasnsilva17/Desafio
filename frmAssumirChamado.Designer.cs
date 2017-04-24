namespace prjChamados.View
{
    partial class frmAssumirChamado
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
            this.btnFecharChamado = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.cmbProblema = new System.Windows.Forms.ComboBox();
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblProblema = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSetor = new System.Windows.Forms.Label();
            this.btnAssumirChamado = new System.Windows.Forms.Button();
            this.txtSolução = new System.Windows.Forms.TextBox();
            this.lblSolução = new System.Windows.Forms.Label();
            this.txtNroChamado = new System.Windows.Forms.TextBox();
            this.lblNroChamado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFecharChamado
            // 
            this.btnFecharChamado.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnFecharChamado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFecharChamado.Location = new System.Drawing.Point(43, 415);
            this.btnFecharChamado.Name = "btnFecharChamado";
            this.btnFecharChamado.Size = new System.Drawing.Size(369, 44);
            this.btnFecharChamado.TabIndex = 22;
            this.btnFecharChamado.Text = "Fechar Chamado";
            this.btnFecharChamado.UseVisualStyleBackColor = false;
            this.btnFecharChamado.Click += new System.EventHandler(this.BtnFecharChamado_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(151, 239);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(261, 20);
            this.txtDescricao.TabIndex = 21;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDescricao.Location = new System.Drawing.Point(40, 243);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(71, 16);
            this.lblDescricao.TabIndex = 20;
            this.lblDescricao.Text = "Descrição";
            // 
            // cmbProblema
            // 
            this.cmbProblema.FormattingEnabled = true;
            this.cmbProblema.Items.AddRange(new object[] {
            "Problemas na conexão com a rede",
            "Problemas de periféricos (mouse, teclado etc.)",
            "Problemas com Login",
            "Outros"});
            this.cmbProblema.Location = new System.Drawing.Point(151, 198);
            this.cmbProblema.Name = "cmbProblema";
            this.cmbProblema.Size = new System.Drawing.Size(261, 21);
            this.cmbProblema.TabIndex = 19;
            // 
            // cmbSetor
            // 
            this.cmbSetor.FormattingEnabled = true;
            this.cmbSetor.Location = new System.Drawing.Point(151, 152);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(261, 21);
            this.cmbSetor.TabIndex = 18;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(151, 111);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(261, 20);
            this.txtNome.TabIndex = 17;
            // 
            // lblProblema
            // 
            this.lblProblema.AutoSize = true;
            this.lblProblema.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblProblema.Location = new System.Drawing.Point(40, 199);
            this.lblProblema.Name = "lblProblema";
            this.lblProblema.Size = new System.Drawing.Size(68, 16);
            this.lblProblema.TabIndex = 16;
            this.lblProblema.Text = "Problema";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNome.Location = new System.Drawing.Point(40, 115);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 16);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome";
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSetor.Location = new System.Drawing.Point(40, 157);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(44, 16);
            this.lblSetor.TabIndex = 14;
            this.lblSetor.Text = "Setor";
            // 
            // btnAssumirChamado
            // 
            this.btnAssumirChamado.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAssumirChamado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAssumirChamado.Location = new System.Drawing.Point(43, 365);
            this.btnAssumirChamado.Name = "btnAssumirChamado";
            this.btnAssumirChamado.Size = new System.Drawing.Size(369, 44);
            this.btnAssumirChamado.TabIndex = 23;
            this.btnAssumirChamado.Text = "Assumir Chamado";
            this.btnAssumirChamado.UseVisualStyleBackColor = false;
            this.btnAssumirChamado.Click += new System.EventHandler(this.BtnAssumirChamado_Click);
            // 
            // txtSolução
            // 
            this.txtSolução.Location = new System.Drawing.Point(151, 277);
            this.txtSolução.Name = "txtSolução";
            this.txtSolução.Size = new System.Drawing.Size(261, 20);
            this.txtSolução.TabIndex = 25;
            // 
            // lblSolução
            // 
            this.lblSolução.AutoSize = true;
            this.lblSolução.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSolução.Location = new System.Drawing.Point(40, 281);
            this.lblSolução.Name = "lblSolução";
            this.lblSolução.Size = new System.Drawing.Size(58, 16);
            this.lblSolução.TabIndex = 24;
            this.lblSolução.Text = "Solução";
            // 
            // txtNroChamado
            // 
            this.txtNroChamado.Location = new System.Drawing.Point(151, 74);
            this.txtNroChamado.Name = "txtNroChamado";
            this.txtNroChamado.Size = new System.Drawing.Size(261, 20);
            this.txtNroChamado.TabIndex = 27;
            // 
            // lblNroChamado
            // 
            this.lblNroChamado.AutoSize = true;
            this.lblNroChamado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNroChamado.Location = new System.Drawing.Point(40, 78);
            this.lblNroChamado.Name = "lblNroChamado";
            this.lblNroChamado.Size = new System.Drawing.Size(93, 16);
            this.lblNroChamado.TabIndex = 26;
            this.lblNroChamado.Text = "Nro Chamado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Assumir Chamado";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnVoltar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.Location = new System.Drawing.Point(43, 315);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(369, 44);
            this.btnVoltar.TabIndex = 29;
            this.btnVoltar.Text = "Voltar a lista de Chamados";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmAssumirChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(446, 465);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNroChamado);
            this.Controls.Add(this.lblNroChamado);
            this.Controls.Add(this.txtSolução);
            this.Controls.Add(this.lblSolução);
            this.Controls.Add(this.btnAssumirChamado);
            this.Controls.Add(this.btnFecharChamado);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.cmbProblema);
            this.Controls.Add(this.cmbSetor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblProblema);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblSetor);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmAssumirChamado";
            this.Text = "frmAssumirChamado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFecharChamado;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ComboBox cmbProblema;
        private System.Windows.Forms.ComboBox cmbSetor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblProblema;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Button btnAssumirChamado;
        private System.Windows.Forms.TextBox txtSolução;
        private System.Windows.Forms.Label lblSolução;
        private System.Windows.Forms.TextBox txtNroChamado;
        private System.Windows.Forms.Label lblNroChamado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
    }
}