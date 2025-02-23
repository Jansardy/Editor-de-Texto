namespace EditorTexto
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            colarToolStripMenuItem = new ToolStripMenuItem();
            desfazerToolStripMenuItem = new ToolStripMenuItem();
            refazerToolStripMenuItem = new ToolStripMenuItem();
            formatarToolStripMenuItem = new ToolStripMenuItem();
            estilosDeFontesToolStripMenuItem = new ToolStripMenuItem();
            negritoToolStripMenuItem = new ToolStripMenuItem();
            itálicoToolStripMenuItem = new ToolStripMenuItem();
            sublinhadoToolStripMenuItem = new ToolStripMenuItem();
            alinhamentoToolStripMenuItem = new ToolStripMenuItem();
            centralizadoToolStripMenuItem = new ToolStripMenuItem();
            esquerdaToolStripMenuItem = new ToolStripMenuItem();
            direitaToolStripMenuItem = new ToolStripMenuItem();
            BarFerramentas = new ToolStrip();
            btnNovo = new ToolStripButton();
            btnAbrir = new ToolStripButton();
            btnSalvar = new ToolStripButton();
            btnImprimir = new ToolStripButton();
            toolSeparator1 = new ToolStripSeparator();
            btnCopiar = new ToolStripButton();
            btnColar = new ToolStripButton();
            toolSeparator2 = new ToolStripSeparator();
            btnNegrito = new ToolStripButton();
            btnItalico = new ToolStripButton();
            btnSublinhado = new ToolStripButton();
            btnFonte = new ToolStripButton();
            toolSeparator3 = new ToolStripSeparator();
            btnEsquerda = new ToolStripButton();
            btnCentro = new ToolStripButton();
            btnDireita = new ToolStripButton();
            toolSeparator4 = new ToolStripSeparator();
            btnDesfazer = new ToolStripButton();
            btnRefazer = new ToolStripButton();
            toolSeparator5 = new ToolStripSeparator();
            lblBuscar = new ToolStripLabel();
            TxtBox_Buscador = new ToolStripTextBox();
            fontDialog1 = new FontDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            menuStrip1.SuspendLayout();
            BarFerramentas.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(0, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(697, 358);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonFace;
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem, formatarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(697, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, abrirToolStripMenuItem, imprimirToolStripMenuItem, salvarToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(120, 22);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += Novo_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(120, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += Abrir_Click;
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.Size = new Size(120, 22);
            imprimirToolStripMenuItem.Text = "Imprimir";
            imprimirToolStripMenuItem.Click += Imprimir_Click;
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Size = new Size(120, 22);
            salvarToolStripMenuItem.Text = "Salvar";
            salvarToolStripMenuItem.Click += Salvar_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(120, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += Sair_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copiarToolStripMenuItem, colarToolStripMenuItem, desfazerToolStripMenuItem, refazerToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(118, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += Copiar_Click;
            // 
            // colarToolStripMenuItem
            // 
            colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            colarToolStripMenuItem.Size = new Size(118, 22);
            colarToolStripMenuItem.Text = "Colar";
            colarToolStripMenuItem.Click += Colar_Click;
            // 
            // desfazerToolStripMenuItem
            // 
            desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            desfazerToolStripMenuItem.Size = new Size(118, 22);
            desfazerToolStripMenuItem.Text = "Desfazer";
            desfazerToolStripMenuItem.Click += Desfazer_Click;
            // 
            // refazerToolStripMenuItem
            // 
            refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            refazerToolStripMenuItem.Size = new Size(118, 22);
            refazerToolStripMenuItem.Text = "Refazer";
            refazerToolStripMenuItem.Click += Refazer_Click;
            // 
            // formatarToolStripMenuItem
            // 
            formatarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { estilosDeFontesToolStripMenuItem, alinhamentoToolStripMenuItem });
            formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            formatarToolStripMenuItem.Size = new Size(67, 20);
            formatarToolStripMenuItem.Text = "Formatar";
            // 
            // estilosDeFontesToolStripMenuItem
            // 
            estilosDeFontesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { negritoToolStripMenuItem, itálicoToolStripMenuItem, sublinhadoToolStripMenuItem });
            estilosDeFontesToolStripMenuItem.Name = "estilosDeFontesToolStripMenuItem";
            estilosDeFontesToolStripMenuItem.Size = new Size(161, 22);
            estilosDeFontesToolStripMenuItem.Text = "Estilos de Fontes";
            // 
            // negritoToolStripMenuItem
            // 
            negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            negritoToolStripMenuItem.Size = new Size(134, 22);
            negritoToolStripMenuItem.Text = "Negrito";
            negritoToolStripMenuItem.Click += Negrito_Click;
            // 
            // itálicoToolStripMenuItem
            // 
            itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            itálicoToolStripMenuItem.Size = new Size(134, 22);
            itálicoToolStripMenuItem.Text = "Itálico";
            itálicoToolStripMenuItem.Click += Italico_Click;
            // 
            // sublinhadoToolStripMenuItem
            // 
            sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            sublinhadoToolStripMenuItem.Size = new Size(134, 22);
            sublinhadoToolStripMenuItem.Text = "Sublinhado";
            sublinhadoToolStripMenuItem.Click += Sublinhado_Click;
            // 
            // alinhamentoToolStripMenuItem
            // 
            alinhamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { centralizadoToolStripMenuItem, esquerdaToolStripMenuItem, direitaToolStripMenuItem });
            alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            alinhamentoToolStripMenuItem.Size = new Size(161, 22);
            alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // centralizadoToolStripMenuItem
            // 
            centralizadoToolStripMenuItem.Name = "centralizadoToolStripMenuItem";
            centralizadoToolStripMenuItem.Size = new Size(130, 22);
            centralizadoToolStripMenuItem.Text = "Centralizar";
            centralizadoToolStripMenuItem.Click += Centro_Click;
            // 
            // esquerdaToolStripMenuItem
            // 
            esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            esquerdaToolStripMenuItem.Size = new Size(130, 22);
            esquerdaToolStripMenuItem.Text = "Esquerda";
            esquerdaToolStripMenuItem.Click += Esquerda_Click;
            // 
            // direitaToolStripMenuItem
            // 
            direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            direitaToolStripMenuItem.Size = new Size(130, 22);
            direitaToolStripMenuItem.Text = "Direita";
            direitaToolStripMenuItem.Click += Direita_Click;
            // 
            // BarFerramentas
            // 
            BarFerramentas.BackColor = SystemColors.ButtonFace;
            BarFerramentas.Items.AddRange(new ToolStripItem[] { btnNovo, btnAbrir, btnSalvar, btnImprimir, toolSeparator1, btnCopiar, btnColar, toolSeparator2, btnNegrito, btnItalico, btnSublinhado, btnFonte, toolSeparator3, btnEsquerda, btnCentro, btnDireita, toolSeparator4, btnDesfazer, btnRefazer, toolSeparator5, lblBuscar, TxtBox_Buscador });
            BarFerramentas.Location = new Point(0, 24);
            BarFerramentas.Name = "BarFerramentas";
            BarFerramentas.Size = new Size(697, 25);
            BarFerramentas.TabIndex = 2;
            BarFerramentas.Text = "Ferramentas";
            // 
            // btnNovo
            // 
            btnNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNovo.Image = (Image)resources.GetObject("btnNovo.Image");
            btnNovo.ImageTransparentColor = Color.Magenta;
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(23, 22);
            btnNovo.Text = "Novo";
            btnNovo.Click += Novo_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAbrir.Image = Properties.Resources.Abrir;
            btnAbrir.ImageTransparentColor = Color.Magenta;
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(23, 22);
            btnAbrir.Text = "Abrir";
            btnAbrir.Click += Abrir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSalvar.Image = Properties.Resources.Salvar;
            btnSalvar.ImageTransparentColor = Color.Magenta;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(23, 22);
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += Salvar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnImprimir.Image = (Image)resources.GetObject("btnImprimir.Image");
            btnImprimir.ImageTransparentColor = Color.Magenta;
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(23, 22);
            btnImprimir.Text = "Imprimir";
            btnImprimir.TextDirection = ToolStripTextDirection.Horizontal;
            btnImprimir.Click += Imprimir_Click;
            // 
            // toolSeparator1
            // 
            toolSeparator1.Name = "toolSeparator1";
            toolSeparator1.Size = new Size(6, 25);
            // 
            // btnCopiar
            // 
            btnCopiar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCopiar.Image = Properties.Resources.Copiar;
            btnCopiar.ImageTransparentColor = Color.Magenta;
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(23, 22);
            btnCopiar.Text = "Copiar";
            btnCopiar.ToolTipText = "bt";
            btnCopiar.Click += Copiar_Click;
            // 
            // btnColar
            // 
            btnColar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnColar.Image = Properties.Resources.Colar;
            btnColar.ImageTransparentColor = Color.Magenta;
            btnColar.Name = "btnColar";
            btnColar.Size = new Size(23, 22);
            btnColar.Text = "Colar";
            btnColar.Click += Colar_Click;
            // 
            // toolSeparator2
            // 
            toolSeparator2.Name = "toolSeparator2";
            toolSeparator2.Size = new Size(6, 25);
            // 
            // btnNegrito
            // 
            btnNegrito.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNegrito.Image = Properties.Resources.Negrito;
            btnNegrito.ImageTransparentColor = Color.Magenta;
            btnNegrito.Name = "btnNegrito";
            btnNegrito.Size = new Size(23, 22);
            btnNegrito.Text = "toolStripButton1";
            btnNegrito.ToolTipText = "Negrito";
            btnNegrito.Click += Negrito_Click;
            // 
            // btnItalico
            // 
            btnItalico.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnItalico.Image = Properties.Resources.Itálico;
            btnItalico.ImageTransparentColor = Color.Magenta;
            btnItalico.Name = "btnItalico";
            btnItalico.Size = new Size(23, 22);
            btnItalico.Text = "Itálico";
            btnItalico.Click += Italico_Click;
            // 
            // btnSublinhado
            // 
            btnSublinhado.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSublinhado.Image = Properties.Resources.Sublinhado;
            btnSublinhado.ImageTransparentColor = Color.Magenta;
            btnSublinhado.Name = "btnSublinhado";
            btnSublinhado.Size = new Size(23, 22);
            btnSublinhado.Text = "Sublinhado";
            btnSublinhado.Click += Sublinhado_Click;
            // 
            // btnFonte
            // 
            btnFonte.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFonte.Image = Properties.Resources.Fonte;
            btnFonte.ImageTransparentColor = Color.Magenta;
            btnFonte.Name = "btnFonte";
            btnFonte.Size = new Size(23, 22);
            btnFonte.Text = "Fonte";
            // 
            // toolSeparator3
            // 
            toolSeparator3.Name = "toolSeparator3";
            toolSeparator3.Size = new Size(6, 25);
            // 
            // btnEsquerda
            // 
            btnEsquerda.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEsquerda.Image = Properties.Resources.alnhesquerda;
            btnEsquerda.ImageTransparentColor = Color.Magenta;
            btnEsquerda.Name = "btnEsquerda";
            btnEsquerda.Size = new Size(23, 22);
            btnEsquerda.Text = "Esquerda";
            btnEsquerda.Click += Esquerda_Click;
            // 
            // btnCentro
            // 
            btnCentro.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCentro.Image = Properties.Resources.alnhcentro;
            btnCentro.ImageTransparentColor = Color.Magenta;
            btnCentro.Name = "btnCentro";
            btnCentro.Size = new Size(23, 22);
            btnCentro.Text = "Centro";
            btnCentro.Click += Centro_Click;
            // 
            // btnDireita
            // 
            btnDireita.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDireita.Image = Properties.Resources.alnhDireita;
            btnDireita.ImageTransparentColor = Color.Magenta;
            btnDireita.Name = "btnDireita";
            btnDireita.Size = new Size(23, 22);
            btnDireita.Text = "Direita";
            btnDireita.Click += Direita_Click;
            // 
            // toolSeparator4
            // 
            toolSeparator4.Name = "toolSeparator4";
            toolSeparator4.Size = new Size(6, 25);
            // 
            // btnDesfazer
            // 
            btnDesfazer.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDesfazer.Image = Properties.Resources.Desfazer;
            btnDesfazer.ImageTransparentColor = Color.Magenta;
            btnDesfazer.Name = "btnDesfazer";
            btnDesfazer.Size = new Size(23, 22);
            btnDesfazer.Text = "Desfazer";
            btnDesfazer.Click += Desfazer_Click;
            // 
            // btnRefazer
            // 
            btnRefazer.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRefazer.Image = Properties.Resources.Refazer;
            btnRefazer.ImageTransparentColor = Color.Magenta;
            btnRefazer.Name = "btnRefazer";
            btnRefazer.Size = new Size(23, 22);
            btnRefazer.Text = "Refazer";
            btnRefazer.Click += Refazer_Click;
            // 
            // toolSeparator5
            // 
            toolSeparator5.Name = "toolSeparator5";
            toolSeparator5.Size = new Size(6, 25);
            // 
            // lblBuscar
            // 
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(45, 22);
            lblBuscar.Text = "Buscar:";
            // 
            // TxtBox_Buscador
            // 
            TxtBox_Buscador.BorderStyle = BorderStyle.FixedSingle;
            TxtBox_Buscador.Name = "TxtBox_Buscador";
            TxtBox_Buscador.Size = new Size(100, 25);
            TxtBox_Buscador.TextBoxTextAlign = HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "(*.TXT)|*.TXT";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 410);
            Controls.Add(BarFerramentas);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor de Texto - Comba";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            BarFerramentas.ResumeLayout(false);
            BarFerramentas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStrip BarFerramentas;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem desfazerToolStripMenuItem;
        private ToolStripMenuItem refazerToolStripMenuItem;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripMenuItem estilosDeFontesToolStripMenuItem;
        private ToolStripMenuItem negritoToolStripMenuItem;
        private ToolStripMenuItem itálicoToolStripMenuItem;
        private ToolStripMenuItem sublinhadoToolStripMenuItem;
        private ToolStripMenuItem alinhamentoToolStripMenuItem;
        private ToolStripMenuItem centralizadoToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem esquerdaToolStripMenuItem;
        private ToolStripMenuItem direitaToolStripMenuItem;
        private ToolStripButton btnNovo;
        private ToolStripButton btnAbrir;
        private ToolStripButton btnSalvar;
        private ToolStripSeparator toolSeparator1;
        private ToolStripButton btnCopiar;
        private ToolStripButton btnColar;
        private ToolStripSeparator toolSeparator2;
        private ToolStripButton btnNegrito;
        private ToolStripButton btnSublinhado;
        private ToolStripButton btnFonte;
        private ToolStripButton btnImprimir;
        private ToolStripButton btnItalico;
        private ToolStripSeparator toolSeparator3;
        private ToolStripButton btnEsquerda;
        private ToolStripButton btnCentro;
        private ToolStripButton btnDireita;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ToolStripSeparator toolSeparator4;
        private ToolStripButton btnDesfazer;
        private ToolStripButton btnRefazer;
        private ToolStripSeparator toolSeparator5;
        private ToolStripTextBox TxtBox_Buscador;
        private ToolStripLabel lblBuscar;
    }
}
