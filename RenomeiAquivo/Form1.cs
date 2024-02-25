namespace RenomeiAquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();

            // Se o usu�rio selecionar uma pasta, exibe o caminho na caixa de texto
            if (result == DialogResult.OK)
            {
                txtCaminho.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pasta = txtCaminho.Text;

            // Verifica se o diret�rio existe
            if (Directory.Exists(pasta))
            {
                // Obt�m todos os arquivos no diret�rio
                string[] arquivos = Directory.GetFiles(pasta);

                // Itera sobre cada arquivo
                foreach (string arquivo in arquivos)
                {
                    // Obt�m o nome do arquivo sem o caminho completo
                    string nomeArquivo = Path.GetFileName(arquivo);

                    // Verifica se o nome do arquivo tem pelo menos 3 caracteres
                    if (nomeArquivo.Length >= 3)
                    {
                        // Obt�m os primeiros 3 caracteres do nome do arquivo
                        string primeirosTresCaracteres = nomeArquivo.Substring(0, 3);

                        // Define um novo nome para o arquivo com os primeiros 3 caracteres alterados
                        string novoNome = txtPalavra.Text + nomeArquivo.Substring(3); // Altere "NOV" para o que desejar

                        // Caminho completo para o novo nome do arquivo
                        string novoCaminho = Path.Combine(pasta, novoNome);

                        // Renomeia o arquivo
                        File.Move(arquivo, novoCaminho);

                        // Exibe uma mensagem de confirma��o
                        
                    }
                    else
                    {
                        MessageBox.Show($"O arquivo '{nomeArquivo}' n�o foi renomeado, pois n�o tem pelo menos 3 caracteres.", "Renomear Arquivo");
                    }
                   
                }
                MessageBox.Show($"Arquivos renomeados com Sucesso");
            }
            else
            {
                MessageBox.Show("O diret�rio especificado n�o existe.", "Diret�rio Inexistente");
            }
        }
    }
}
