namespace Terceiro_projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Tem certeza que seja sair?", "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close(); // fecha o formulário
            } // se não continua
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = e.Start.ToShortDateString();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            CarregarImagemNoPictureBox(pictureBox1);
        }

        private void CarregarImagemNoPictureBox(PictureBox pb)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Selecione uma imagem";
                openFileDialog.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image img = Image.FromFile(openFileDialog.FileName);
                        pb.Image = img;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.SendToBack();
        }
    }
}
