namespace EditorTexto
{
    public partial class FrmMain : Form
    {
        StringReader leitura = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        #region Eventos
        private void Novo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
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

        private void Salvar()
        {
            try
            {
                DialogResult dr = this.saveFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter arq_streamWriter = new StreamWriter(arquivo);
                    arq_streamWriter.Flush();
                    arq_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    arq_streamWriter.Write(this.richTextBox1.Text);
                    arq_streamWriter.Flush();
                    arq_streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na gravação: " + ex.Message, "Erro ao Gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Abrir()
        {
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"C:\Users\jansen\Documentos";
            openFileDialog1.Filter = "(*.TXT)|*.TXT";

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader arq_streamReader = new StreamReader(arquivo);
                    arq_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";

                    string linha = arq_streamReader.ReadLine();
                    while (linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = arq_streamReader.ReadLine();
                    }
                    arq_streamReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de leitura: " + ex.Message, "Erro ao ler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

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

        private void ToggleFontStyle(FontStyle estilo)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle novoEstilo = richTextBox1.SelectionFont.Style ^ estilo;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, novoEstilo);
            }
        }

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
                e.Graphics.DrawString(linha, fonte, pincel, MargemEsquerda, PosY, new StringFormat());
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
    }
}
