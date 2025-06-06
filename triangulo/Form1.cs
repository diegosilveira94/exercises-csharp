using System.Diagnostics.Eventing.Reader;

namespace triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbResult.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                double l1, l2, l3; // lados do triângulo
                l1 = Convert.ToDouble(txbLado1.Text);
                l2 = Convert.ToDouble(txbLado2.Text);
                l3 = Convert.ToDouble(txbLado3.Text);

                if ((l1 + l2 >= l3) && (l1 + l3 >= l2) && (l2 + l3 >= l1)) // verifica se é triângulo
                {
                    lbResult.Enabled = true; // habilita o label de resultado
                    if (l1 == l2 && l2 == l3 && l3 == l1)
                    {  // todos os lados iguais
                        lbResult.Text = "Triângulo Equilátero";
                    }
                    else if (l1 == l2 || l2 == l3 || l3 == l1)
                    {
                        lbResult.Text = "Triângulo Isósceles"; // dois lados iguais
                    }
                    else if (l1 != l2 && l2 != l3 && l3 != l1)
                    {
                        lbResult.Text = "Triângulo Escaleno"; // todos os lados diferentes
                    }
                }
                else
                {
                    lbResult.Text = "Não é um triângulo";
                }
            }
            catch
            {
                lbResult.Text = "Error!";
                MessageBox.Show("Insira valores numéricos válidos!", "Erro");
            }
        }

        private void lbResult_Click(object sender, EventArgs e)
        {

        }
    }
}
