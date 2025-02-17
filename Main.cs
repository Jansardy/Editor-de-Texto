namespace EditorTexto
{
    public partial class FrmMain : Form
    {
        StreamReader leitura = null;

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
                MessageBox.Show("Erro na gravação: " + ex.Message, "Erro ao Gravar",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Abrir()
        {
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"C:\Users\jansen\Documentos";
            openFileDialog1.Filter = "(*.TXT)|*.TXT";

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader arq_streamReader = new StreamReader(arquivo);
                    arq_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";

                    string linha = arq_streamReader.ReadLine();
                    while(linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = arq_streamReader.ReadLine();
                    }
                    arq_streamReader.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro de leitura: " + ex.Message, "Erro ao ler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        #endregion
    }
}
