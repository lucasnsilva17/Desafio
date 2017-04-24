namespace prjChamados
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chamadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirNovoChamadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chamadosFechadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaLogadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeChamadosAbertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuárioAlterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chamadosToolStripMenuItem,
            this.areaLogadaToolStripMenuItem,
            this.sobreOSistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(471, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chamadosToolStripMenuItem
            // 
            this.chamadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirNovoChamadoToolStripMenuItem,
            this.chamadosFechadosToolStripMenuItem});
            this.chamadosToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.chamadosToolStripMenuItem.Name = "chamadosToolStripMenuItem";
            this.chamadosToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.chamadosToolStripMenuItem.Text = "Chamados";
            // 
            // abrirNovoChamadoToolStripMenuItem
            // 
            this.abrirNovoChamadoToolStripMenuItem.Name = "abrirNovoChamadoToolStripMenuItem";
            this.abrirNovoChamadoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.abrirNovoChamadoToolStripMenuItem.Text = "Abrir Novo Chamado";
            this.abrirNovoChamadoToolStripMenuItem.Click += new System.EventHandler(this.AbrirNovoChamadoToolStripMenuItem_Click);
            // 
            // chamadosFechadosToolStripMenuItem
            // 
            this.chamadosFechadosToolStripMenuItem.Name = "chamadosFechadosToolStripMenuItem";
            this.chamadosFechadosToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.chamadosFechadosToolStripMenuItem.Text = "Chamados Fechados";
            this.chamadosFechadosToolStripMenuItem.Click += new System.EventHandler(this.ChamadosFechadosToolStripMenuItem_Click);
            // 
            // areaLogadaToolStripMenuItem
            // 
            this.areaLogadaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeChamadosAbertosToolStripMenuItem,
            this.cadastrarNovoUsuárioToolStripMenuItem,
            this.novoUsuárioAlterarSenhaToolStripMenuItem});
            this.areaLogadaToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.areaLogadaToolStripMenuItem.Name = "areaLogadaToolStripMenuItem";
            this.areaLogadaToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.areaLogadaToolStripMenuItem.Text = "Area Logada";
            // 
            // listaDeChamadosAbertosToolStripMenuItem
            // 
            this.listaDeChamadosAbertosToolStripMenuItem.Name = "listaDeChamadosAbertosToolStripMenuItem";
            this.listaDeChamadosAbertosToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.listaDeChamadosAbertosToolStripMenuItem.Text = "Lista de chamados Abertos";
            this.listaDeChamadosAbertosToolStripMenuItem.Click += new System.EventHandler(this.ListaDeChamadosAbertosToolStripMenuItem_Click);
            // 
            // cadastrarNovoUsuárioToolStripMenuItem
            // 
            this.cadastrarNovoUsuárioToolStripMenuItem.Name = "cadastrarNovoUsuárioToolStripMenuItem";
            this.cadastrarNovoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.cadastrarNovoUsuárioToolStripMenuItem.Text = "Cadastrar Novo Usuário";
            this.cadastrarNovoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.CadastrarNovoUsuárioToolStripMenuItem_Click);
            // 
            // novoUsuárioAlterarSenhaToolStripMenuItem
            // 
            this.novoUsuárioAlterarSenhaToolStripMenuItem.Name = "novoUsuárioAlterarSenhaToolStripMenuItem";
            this.novoUsuárioAlterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.novoUsuárioAlterarSenhaToolStripMenuItem.Text = "Novo Usuário - Alterar senha ";
            this.novoUsuárioAlterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.NovoUsuárioAlterarSenhaToolStripMenuItem_Click);
            // 
            // sobreOSistemaToolStripMenuItem
            // 
            this.sobreOSistemaToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.sobreOSistemaToolStripMenuItem.Name = "sobreOSistemaToolStripMenuItem";
            this.sobreOSistemaToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.sobreOSistemaToolStripMenuItem.Text = "Sobre o sistema";
            this.sobreOSistemaToolStripMenuItem.Click += new System.EventHandler(this.SobreOSistemaToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(471, 317);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chamadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirNovoChamadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chamadosFechadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaLogadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeChamadosAbertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsuárioAlterarSenhaToolStripMenuItem;
    }
}

