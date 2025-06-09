namespace tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num, cont, tab;
            num = Convert.ToInt32(txtNumero.Text);
            for (cont = 0; cont <= 10; cont++)
            {
                tab = num * cont;
                lstTabuada.Items.Add(num.ToString() + " x " + cont.ToString() + " = " + tab.ToString());
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            lstTabuada.Items.Clear();
        }
    }
}
