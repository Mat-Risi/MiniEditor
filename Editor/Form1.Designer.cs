namespace Editor
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoEscuroClaroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPaginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sombreadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamanhoDaLetraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeLetraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarCtrlcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarCtrlvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corDoFundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tamanhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.centroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeLetraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renomearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.funçõesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.carregarToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.novaPaginaToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Image = global::Editor.Properties.Resources.Salvar;
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Image = global::Editor.Properties.Resources.Salvar1;
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // carregarToolStripMenuItem
            // 
            this.carregarToolStripMenuItem.Image = global::Editor.Properties.Resources.icone_abrir;
            this.carregarToolStripMenuItem.Name = "carregarToolStripMenuItem";
            this.carregarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.carregarToolStripMenuItem.Text = "Carregar";
            this.carregarToolStripMenuItem.Click += new System.EventHandler(this.carregarToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoEscuroClaroToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Image = global::Editor.Properties.Resources.setting;
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // modoEscuroClaroToolStripMenuItem
            // 
            this.modoEscuroClaroToolStripMenuItem.Image = global::Editor.Properties.Resources.copia_de1;
            this.modoEscuroClaroToolStripMenuItem.Name = "modoEscuroClaroToolStripMenuItem";
            this.modoEscuroClaroToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.modoEscuroClaroToolStripMenuItem.Text = "Modo Escuro/Claro";
            this.modoEscuroClaroToolStripMenuItem.Click += new System.EventHandler(this.modoEscuroClaroToolStripMenuItem_Click);
            // 
            // novaPaginaToolStripMenuItem
            // 
            this.novaPaginaToolStripMenuItem.Image = global::Editor.Properties.Resources.copia_de;
            this.novaPaginaToolStripMenuItem.Name = "novaPaginaToolStripMenuItem";
            this.novaPaginaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.novaPaginaToolStripMenuItem.Text = "Nova pagina";
            this.novaPaginaToolStripMenuItem.Click += new System.EventHandler(this.novaPaginaToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.corToolStripMenuItem,
            this.sombreadoToolStripMenuItem,
            this.inserirImagemToolStripMenuItem,
            this.tamanhoDaLetraToolStripMenuItem,
            this.alinhamentoToolStripMenuItem,
            this.tipoDeLetraToolStripMenuItem,
            this.copiarCtrlcToolStripMenuItem,
            this.colarCtrlvToolStripMenuItem,
            this.corDoFundoToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // corToolStripMenuItem
            // 
            this.corToolStripMenuItem.Image = global::Editor.Properties.Resources.pick;
            this.corToolStripMenuItem.Name = "corToolStripMenuItem";
            this.corToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.corToolStripMenuItem.Text = "Cor";
            this.corToolStripMenuItem.Click += new System.EventHandler(this.corToolStripMenuItem_Click);
            // 
            // sombreadoToolStripMenuItem
            // 
            this.sombreadoToolStripMenuItem.Name = "sombreadoToolStripMenuItem";
            this.sombreadoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.sombreadoToolStripMenuItem.Text = "Sombreado";
            this.sombreadoToolStripMenuItem.Click += new System.EventHandler(this.sombreadoToolStripMenuItem_Click_1);
            // 
            // inserirImagemToolStripMenuItem
            // 
            this.inserirImagemToolStripMenuItem.Image = global::Editor.Properties.Resources.rec;
            this.inserirImagemToolStripMenuItem.Name = "inserirImagemToolStripMenuItem";
            this.inserirImagemToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.inserirImagemToolStripMenuItem.Text = "Inserir imagem";
            this.inserirImagemToolStripMenuItem.Click += new System.EventHandler(this.inserirImagemToolStripMenuItem_Click);
            // 
            // tamanhoDaLetraToolStripMenuItem
            // 
            this.tamanhoDaLetraToolStripMenuItem.Image = global::Editor.Properties.Resources.t;
            this.tamanhoDaLetraToolStripMenuItem.Name = "tamanhoDaLetraToolStripMenuItem";
            this.tamanhoDaLetraToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.tamanhoDaLetraToolStripMenuItem.Text = "Tamanho da letra";
            this.tamanhoDaLetraToolStripMenuItem.Click += new System.EventHandler(this.tamanhoDaLetraToolStripMenuItem_Click);
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centroToolStripMenuItem,
            this.esquerdaToolStripMenuItem,
            this.direitaToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Image = global::Editor.Properties.Resources.tr1;
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // centroToolStripMenuItem
            // 
            this.centroToolStripMenuItem.Image = global::Editor.Properties.Resources.centro;
            this.centroToolStripMenuItem.Name = "centroToolStripMenuItem";
            this.centroToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.centroToolStripMenuItem.Text = "Centro";
            this.centroToolStripMenuItem.Click += new System.EventHandler(this.centroToolStripMenuItem_Click);
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Image = global::Editor.Properties.Resources.esquerda;
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            this.esquerdaToolStripMenuItem.Click += new System.EventHandler(this.esquerdaToolStripMenuItem_Click);
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Image = global::Editor.Properties.Resources.direita;
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.direitaToolStripMenuItem.Text = "Direita";
            this.direitaToolStripMenuItem.Click += new System.EventHandler(this.direitaToolStripMenuItem_Click);
            // 
            // tipoDeLetraToolStripMenuItem
            // 
            this.tipoDeLetraToolStripMenuItem.Image = global::Editor.Properties.Resources.ajuste_de_fonte;
            this.tipoDeLetraToolStripMenuItem.Name = "tipoDeLetraToolStripMenuItem";
            this.tipoDeLetraToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.tipoDeLetraToolStripMenuItem.Text = "Tipo de letra";
            this.tipoDeLetraToolStripMenuItem.Click += new System.EventHandler(this.tipoDeLetraToolStripMenuItem_Click_1);
            // 
            // copiarCtrlcToolStripMenuItem
            // 
            this.copiarCtrlcToolStripMenuItem.Image = global::Editor.Properties.Resources.copia_de;
            this.copiarCtrlcToolStripMenuItem.Name = "copiarCtrlcToolStripMenuItem";
            this.copiarCtrlcToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.copiarCtrlcToolStripMenuItem.Text = "Copiar (Ctrl+c)";
            this.copiarCtrlcToolStripMenuItem.Click += new System.EventHandler(this.copiarCtrlcToolStripMenuItem_Click);
            // 
            // colarCtrlvToolStripMenuItem
            // 
            this.colarCtrlvToolStripMenuItem.Image = global::Editor.Properties.Resources.colar;
            this.colarCtrlvToolStripMenuItem.Name = "colarCtrlvToolStripMenuItem";
            this.colarCtrlvToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.colarCtrlvToolStripMenuItem.Text = "Colar (Ctrl+v)";
            this.colarCtrlvToolStripMenuItem.Click += new System.EventHandler(this.colarCtrlvToolStripMenuItem_Click);
            // 
            // corDoFundoToolStripMenuItem
            // 
            this.corDoFundoToolStripMenuItem.Name = "corDoFundoToolStripMenuItem";
            this.corDoFundoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.corDoFundoToolStripMenuItem.Text = "Cor do fundo";
            this.corDoFundoToolStripMenuItem.Click += new System.EventHandler(this.corDoFundoToolStripMenuItem_Click);
            // 
            // funçõesToolStripMenuItem
            // 
            this.funçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paintToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.outrosToolStripMenuItem});
            this.funçõesToolStripMenuItem.Name = "funçõesToolStripMenuItem";
            this.funçõesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.funçõesToolStripMenuItem.Text = "Funções";
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paintToolStripMenuItem.Text = "Paint";
            this.paintToolStripMenuItem.Click += new System.EventHandler(this.paintToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tamanhoToolStripMenuItem,
            this.alinhamentoToolStripMenuItem1,
            this.tipoDeLetraToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 70);
            // 
            // tamanhoToolStripMenuItem
            // 
            this.tamanhoToolStripMenuItem.Image = global::Editor.Properties.Resources.t;
            this.tamanhoToolStripMenuItem.Name = "tamanhoToolStripMenuItem";
            this.tamanhoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.tamanhoToolStripMenuItem.Text = "Tamanho";
            this.tamanhoToolStripMenuItem.Click += new System.EventHandler(this.tamanhoToolStripMenuItem_Click);
            // 
            // alinhamentoToolStripMenuItem1
            // 
            this.alinhamentoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centroToolStripMenuItem1,
            this.esquerdaToolStripMenuItem1,
            this.direitaToolStripMenuItem1});
            this.alinhamentoToolStripMenuItem1.Image = global::Editor.Properties.Resources.tr1;
            this.alinhamentoToolStripMenuItem1.Name = "alinhamentoToolStripMenuItem1";
            this.alinhamentoToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.alinhamentoToolStripMenuItem1.Text = "Alinhamento";
            // 
            // centroToolStripMenuItem1
            // 
            this.centroToolStripMenuItem1.Image = global::Editor.Properties.Resources.centro;
            this.centroToolStripMenuItem1.Name = "centroToolStripMenuItem1";
            this.centroToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.centroToolStripMenuItem1.Text = "Centro";
            this.centroToolStripMenuItem1.Click += new System.EventHandler(this.centroToolStripMenuItem1_Click);
            // 
            // esquerdaToolStripMenuItem1
            // 
            this.esquerdaToolStripMenuItem1.Image = global::Editor.Properties.Resources.esquerda;
            this.esquerdaToolStripMenuItem1.Name = "esquerdaToolStripMenuItem1";
            this.esquerdaToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.esquerdaToolStripMenuItem1.Text = "Esquerda";
            this.esquerdaToolStripMenuItem1.Click += new System.EventHandler(this.esquerdaToolStripMenuItem1_Click);
            // 
            // direitaToolStripMenuItem1
            // 
            this.direitaToolStripMenuItem1.Image = global::Editor.Properties.Resources.direita;
            this.direitaToolStripMenuItem1.Name = "direitaToolStripMenuItem1";
            this.direitaToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.direitaToolStripMenuItem1.Text = "Direita";
            this.direitaToolStripMenuItem1.Click += new System.EventHandler(this.direitaToolStripMenuItem1_Click);
            // 
            // tipoDeLetraToolStripMenuItem1
            // 
            this.tipoDeLetraToolStripMenuItem1.Image = global::Editor.Properties.Resources.ajuste_de_fonte1;
            this.tipoDeLetraToolStripMenuItem1.Name = "tipoDeLetraToolStripMenuItem1";
            this.tipoDeLetraToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.tipoDeLetraToolStripMenuItem1.Text = "Tipo de letra";
            this.tipoDeLetraToolStripMenuItem1.Click += new System.EventHandler(this.tipoDeLetraToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(785, 398);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.ContextMenuStrip = this.contextMenuStrip2;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 430);
            this.tabControl1.TabIndex = 4;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renomearToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(129, 26);
            // 
            // renomearToolStripMenuItem
            // 
            this.renomearToolStripMenuItem.Name = "renomearToolStripMenuItem";
            this.renomearToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.renomearToolStripMenuItem.Text = "Renomear";
            this.renomearToolStripMenuItem.Click += new System.EventHandler(this.renomearToolStripMenuItem_Click);
            // 
            // outrosToolStripMenuItem
            // 
            this.outrosToolStripMenuItem.Name = "outrosToolStripMenuItem";
            this.outrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.outrosToolStripMenuItem.Text = "Outros";
            this.outrosToolStripMenuItem.Click += new System.EventHandler(this.outrosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Editor de texto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamanhoDaLetraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tamanhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem centroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tipoDeLetraToolStripMenuItem1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem tipoDeLetraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarCtrlcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarCtrlvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoEscuroClaroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPaginaToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem renomearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corDoFundoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sombreadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

