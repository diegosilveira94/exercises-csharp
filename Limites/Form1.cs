namespace Limites
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtInicial.Text = "";
            txtLimite.Text = "";
            ltbLista.Items.Clear();
        }

        private void btnLimites_Click(object sender, EventArgs e)
        {
            int inicio, fim, i;
            inicio = Convert.ToInt32(txtInicial.Text);
            fim = Convert.ToInt32(txtLimite.Text);
            if (inicio < fim)
            {
                for (i = inicio; i <= fim; i++)
                {
                    ltbLista.Items.Add(i);
                }
            }
            else
            {
                MessageBox.Show("Cabeça de guidão. O valor inicial deve ser menor que o valor limite.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLimite.Text = "";
                txtInicial.Text = "";
            }
        }

        private void ltbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
