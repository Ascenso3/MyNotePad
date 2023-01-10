namespace MyNotePad
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFicheiro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicheiroNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicheiroAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarColar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarSelecionar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarProcurar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarLetra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarCores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarCoresLetra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarCoresFundo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarAlinhamento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarAlinhamentoEsquerda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarAlinhamentoCentro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarAlinhamentoDireito = new System.Windows.Forms.ToolStripMenuItem();
            this.rbTexto = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFicheiro,
            this.menuEditar,
            this.menuFormatar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFicheiro
            // 
            this.menuFicheiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFicheiroNovo,
            this.menuFicheiroAbrir,
            this.guardarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuFicheiro.Image = global::MyNotePad.Properties.Resources.ficheiros;
            this.menuFicheiro.Name = "menuFicheiro";
            this.menuFicheiro.Size = new System.Drawing.Size(96, 34);
            this.menuFicheiro.Text = "Ficheiros";
            // 
            // menuFicheiroNovo
            // 
            this.menuFicheiroNovo.Image = global::MyNotePad.Properties.Resources.novo;
            this.menuFicheiroNovo.Name = "menuFicheiroNovo";
            this.menuFicheiroNovo.Size = new System.Drawing.Size(194, 36);
            this.menuFicheiroNovo.Text = "Novo";
            this.menuFicheiroNovo.Click += new System.EventHandler(this.menuFicheiroNovo_Click);
            // 
            // menuFicheiroAbrir
            // 
            this.menuFicheiroAbrir.Image = global::MyNotePad.Properties.Resources.abrir;
            this.menuFicheiroAbrir.Name = "menuFicheiroAbrir";
            this.menuFicheiroAbrir.Size = new System.Drawing.Size(194, 36);
            this.menuFicheiroAbrir.Text = "Abrir";
            this.menuFicheiroAbrir.Click += new System.EventHandler(this.menuFicheiroAbrir_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = global::MyNotePad.Properties.Resources.guardarr;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::MyNotePad.Properties.Resources.sair;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // menuEditar
            // 
            this.menuEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditarCortar,
            this.menuEditarCopiar,
            this.menuEditarColar,
            this.menuEditarSelecionar,
            this.menuEditarProcurar});
            this.menuEditar.Image = global::MyNotePad.Properties.Resources.editar;
            this.menuEditar.Name = "menuEditar";
            this.menuEditar.Size = new System.Drawing.Size(79, 34);
            this.menuEditar.Text = "Editar";
            // 
            // menuEditarCortar
            // 
            this.menuEditarCortar.Image = global::MyNotePad.Properties.Resources.cortar;
            this.menuEditarCortar.Name = "menuEditarCortar";
            this.menuEditarCortar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarCortar.Text = "Cortar";
            this.menuEditarCortar.Click += new System.EventHandler(this.menuEditarCortar_Click);
            // 
            // menuEditarCopiar
            // 
            this.menuEditarCopiar.Image = global::MyNotePad.Properties.Resources.copiar;
            this.menuEditarCopiar.Name = "menuEditarCopiar";
            this.menuEditarCopiar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarCopiar.Text = "Copiar";
            this.menuEditarCopiar.Click += new System.EventHandler(this.menuEditarCopiar_Click);
            // 
            // menuEditarColar
            // 
            this.menuEditarColar.Image = global::MyNotePad.Properties.Resources.colar;
            this.menuEditarColar.Name = "menuEditarColar";
            this.menuEditarColar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarColar.Text = "Colar";
            this.menuEditarColar.Click += new System.EventHandler(this.menuEditarColar_Click);
            // 
            // menuEditarSelecionar
            // 
            this.menuEditarSelecionar.Image = global::MyNotePad.Properties.Resources.selecionar_tudo;
            this.menuEditarSelecionar.Name = "menuEditarSelecionar";
            this.menuEditarSelecionar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarSelecionar.Text = "Selecionar tudo";
            this.menuEditarSelecionar.Click += new System.EventHandler(this.menuEditarSelecionar_Click);
            // 
            // menuEditarProcurar
            // 
            this.menuEditarProcurar.Image = global::MyNotePad.Properties.Resources.procurar;
            this.menuEditarProcurar.Name = "menuEditarProcurar";
            this.menuEditarProcurar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarProcurar.Text = "Procurar";
            // 
            // menuFormatar
            // 
            this.menuFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatarLetra,
            this.menuFormatarCores,
            this.menuFormatarAlinhamento});
            this.menuFormatar.Image = global::MyNotePad.Properties.Resources.formatae;
            this.menuFormatar.Name = "menuFormatar";
            this.menuFormatar.Size = new System.Drawing.Size(97, 34);
            this.menuFormatar.Text = "Formatar";
            // 
            // menuFormatarLetra
            // 
            this.menuFormatarLetra.Image = global::MyNotePad.Properties.Resources.letra;
            this.menuFormatarLetra.Name = "menuFormatarLetra";
            this.menuFormatarLetra.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarLetra.Text = "Letra";
            this.menuFormatarLetra.Click += new System.EventHandler(this.menuFormatarLetra_Click);
            // 
            // menuFormatarCores
            // 
            this.menuFormatarCores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatarCoresLetra,
            this.menuFormatarCoresFundo});
            this.menuFormatarCores.Image = global::MyNotePad.Properties.Resources.cor;
            this.menuFormatarCores.Name = "menuFormatarCores";
            this.menuFormatarCores.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarCores.Text = "Cores ";
            // 
            // menuFormatarCoresLetra
            // 
            this.menuFormatarCoresLetra.Image = global::MyNotePad.Properties.Resources.letraaa;
            this.menuFormatarCoresLetra.Name = "menuFormatarCoresLetra";
            this.menuFormatarCoresLetra.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarCoresLetra.Text = "Letra";
            this.menuFormatarCoresLetra.Click += new System.EventHandler(this.menuFormatarCoresLetra_Click);
            // 
            // menuFormatarCoresFundo
            // 
            this.menuFormatarCoresFundo.Image = global::MyNotePad.Properties.Resources.tinta;
            this.menuFormatarCoresFundo.Name = "menuFormatarCoresFundo";
            this.menuFormatarCoresFundo.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarCoresFundo.Text = "Fundo";
            this.menuFormatarCoresFundo.Click += new System.EventHandler(this.menuFormatarCoresFundo_Click);
            // 
            // menuFormatarAlinhamento
            // 
            this.menuFormatarAlinhamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatarAlinhamentoEsquerda,
            this.menuFormatarAlinhamentoCentro,
            this.menuFormatarAlinhamentoDireito});
            this.menuFormatarAlinhamento.Image = global::MyNotePad.Properties.Resources.alinhamento_normal;
            this.menuFormatarAlinhamento.Name = "menuFormatarAlinhamento";
            this.menuFormatarAlinhamento.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarAlinhamento.Text = "Alinhamento";
            // 
            // menuFormatarAlinhamentoEsquerda
            // 
            this.menuFormatarAlinhamentoEsquerda.Image = global::MyNotePad.Properties.Resources.alinhamento_esquerda;
            this.menuFormatarAlinhamentoEsquerda.Name = "menuFormatarAlinhamentoEsquerda";
            this.menuFormatarAlinhamentoEsquerda.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarAlinhamentoEsquerda.Text = "Esquerda ";
            this.menuFormatarAlinhamentoEsquerda.Click += new System.EventHandler(this.menuFormatarAlinhamentoEsquerda_Click);
            // 
            // menuFormatarAlinhamentoCentro
            // 
            this.menuFormatarAlinhamentoCentro.Image = global::MyNotePad.Properties.Resources.alinhamento_centro;
            this.menuFormatarAlinhamentoCentro.Name = "menuFormatarAlinhamentoCentro";
            this.menuFormatarAlinhamentoCentro.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarAlinhamentoCentro.Text = "Centro";
            this.menuFormatarAlinhamentoCentro.Click += new System.EventHandler(this.menuFormatarAlinhamentoCentro_Click);
            // 
            // menuFormatarAlinhamentoDireito
            // 
            this.menuFormatarAlinhamentoDireito.Image = global::MyNotePad.Properties.Resources.alinhamento_direito;
            this.menuFormatarAlinhamentoDireito.Name = "menuFormatarAlinhamentoDireito";
            this.menuFormatarAlinhamentoDireito.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarAlinhamentoDireito.Text = "Direito";
            this.menuFormatarAlinhamentoDireito.Click += new System.EventHandler(this.menuFormatarAlinhamentoDireito_Click);
            // 
            // rbTexto
            // 
            this.rbTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbTexto.Location = new System.Drawing.Point(0, 38);
            this.rbTexto.Name = "rbTexto";
            this.rbTexto.Size = new System.Drawing.Size(784, 703);
            this.rbTexto.TabIndex = 2;
            this.rbTexto.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 741);
            this.Controls.Add(this.rbTexto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MyNotePad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFicheiro;
        private System.Windows.Forms.ToolStripMenuItem menuEditar;
        private System.Windows.Forms.ToolStripMenuItem menuFormatar;
        private System.Windows.Forms.ToolStripMenuItem menuFicheiroNovo;
        private System.Windows.Forms.ToolStripMenuItem menuFicheiroAbrir;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEditarCortar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarCopiar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarColar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarSelecionar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarProcurar;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarLetra;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarCores;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarCoresLetra;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarCoresFundo;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarAlinhamento;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarAlinhamentoEsquerda;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarAlinhamentoCentro;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarAlinhamentoDireito;
        private System.Windows.Forms.RichTextBox rbTexto;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

