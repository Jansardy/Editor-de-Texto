using EditorTexto.Properties;
using System.Text;

namespace EditorTexto
{
    public partial class FrmMain : Form
    {
        StringReader leitura = null;
        private string previousText = "";
        Stack<string> undoStack = new Stack<string>();
        Stack<string> redoStack = new Stack<string>();
        

        public FrmMain()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FrmMain_KeyDown);
            richTextBox1.TextChanged += RichTextBox1_TextChanged;
        }

        #region Eventos
        private void Novo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void Copiar_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                Clipboard.SetText(richTextBox1.SelectedText);
            }
        }

        private void Colar_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                richTextBox1.Paste();
            }
        }

        private void Refazer_Click(object sender, EventArgs e)
        {
            Desfazer_Refazer("Refazer");
        }

        private void Desfazer_Click(object sender, EventArgs e)
        {
            Desfazer_Refazer("Desfazer");
        }

        private void Negrito_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Bold);
        }

        private void Sublinhado_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Underline);
        }

        private void Italico_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Italic);
        }

        private void Esquerda_Click(object sender, EventArgs e)
        {
            Alinhamento("Esquerda");
        }

        private void Centro_Click(object sender, EventArgs e)
        {
            Alinhamento("Centro");
        }

        private void Direita_Click(object sender, EventArgs e)
        {
            Alinhamento("Direita");
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            string texto = this.richTextBox1.Text;
            leitura = new StringReader(texto);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        #endregion

        #region Metodos|Funções

        #region Texto Alterado
        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text != previousText)
            {
                undoStack.Push(previousText);
                previousText = richTextBox1.Text;
                redoStack.Clear();
            }
        }
        #endregion

        #region Salvar pasta
        private void Salvar()
        {
            try
            {
                saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf";
                DialogResult dr = this.saveFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string extensao = Path.GetExtension(saveFileDialog1.FileName).ToLower();
                    if (extensao == ".rtf")
                    {
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8))
                        {
                            sw.Write(richTextBox1.Text);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na gravação: " + ex.Message, "Erro ao Gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Abrir pasta
        private void Abrir()
        {

            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*";

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    string extensao = Path.GetExtension(openFileDialog1.FileName).ToLower();
                    if (extensao == ".rtf")
                    {
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        using (StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.UTF8))
                        {
                            richTextBox1.Text = sr.ReadToEnd();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de leitura: " + ex.Message, "Erro ao ler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Alinhamento
        private void Alinhamento(string tipo)
        {
            switch (tipo)
            {
                case "Esquerda":
                    this.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                    break;
                case "Centro":
                    this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                    break;
                case "Direita":
                    this.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Alterar Estilo Fonte
        private void ToggleFontStyle(FontStyle estilo)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle novoEstilo = richTextBox1.SelectionFont.Style ^ estilo;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, novoEstilo);
            }
        }
        #endregion

        #region Imprimir o Printpage
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPagina = 0;
            float PosY = 0;
            int count = 0;
            float MargemEsquerda = e.MarginBounds.Left - 50;
            float MargemTop = e.MarginBounds.Top - 50;

            if (MargemEsquerda < 5)
            {
                MargemEsquerda = 20;
            }
            if (MargemTop < 5)
            {
                MargemTop = 20;
            }

            string linha = null;
            Font fonte = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            linhasPagina = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);
            linha = leitura.ReadLine();

            while (count < linhasPagina && linha != null)
            {
                PosY = MargemTop + (count * fonte.GetHeight(e.Graphics));
                e.Graphics.DrawString(linha, fonte, pincel
                    , new RectangleF(MargemEsquerda, PosY, e.MarginBounds.Width, fonte.Height)
                    , new StringFormat(StringFormatFlags.LineLimit));
                count += 1;
                linha = leitura.ReadLine();
            }

            if (linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }

            pincel.Dispose();
        }
        #endregion

        #region Desfazer e Refazer
        private void Desfazer_Refazer(string acao)
        {
            if (acao == "Desfazer")
            {
                if (undoStack.Count > 0)
                {
                    redoStack.Push(richTextBox1.Text);
                    richTextBox1.TextChanged -= RichTextBox1_TextChanged;
                    richTextBox1.Text = undoStack.Pop();
                    previousText = richTextBox1.Text;
                    richTextBox1.TextChanged += RichTextBox1_TextChanged;
                }
            }
            else if (acao == "Refazer")
            {
                if (redoStack.Count > 0)
                {
                    undoStack.Push(richTextBox1.Text);
                    richTextBox1.TextChanged -= RichTextBox1_TextChanged;
                    richTextBox1.Text = redoStack.Pop();
                    previousText = richTextBox1.Text;
                    richTextBox1.TextChanged += RichTextBox1_TextChanged;
                }
            }
        }
        #endregion

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) Novo_Click(sender, e);
            if (e.Control && e.KeyCode == Keys.O) Abrir_Click(sender, e);
            if (e.Control && e.KeyCode == Keys.S) Salvar_Click(sender, e);
            if (e.Control && e.KeyCode == Keys.Z) Desfazer_Click(sender, e);
            if (e.Control && e.KeyCode == Keys.Y) Refazer_Click(sender, e);
            if (e.Control && e.KeyCode == Keys.B) Negrito_Click(sender, e);
            if (e.Control && e.KeyCode == Keys.I) Italico_Click(sender, e);
            if (e.Control && e.KeyCode == Keys.U) Sublinhado_Click(sender, e);
        }

        #endregion

    }
}
