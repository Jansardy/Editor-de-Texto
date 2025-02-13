namespace EditorTexto
{
    public partial class FrmMain : Form
    {
        StreamReader leitura = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void Salvar()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter cfb_streamWriter = new StreamWriter(arquivo);
                    cfb_streamWriter.Flush();
                    cfb_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    cfb_streamWriter.Write(this.richTextBox1.Text);
                    cfb_streamWriter.Flush();
                    cfb_streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na gravação: " + ex.Message, "Erro ao Gravar",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
