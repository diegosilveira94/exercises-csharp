namespace Calculadora_Simples
{
    using System;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txbNum1.Text);
            double num2 = double.Parse(txbNum2.Text);
            double result = num1 + num2;
            txbResult.Text = result.ToString();
        }

        private void txbNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txbNum1.Text);
            double num2 = double.Parse(txbNum2.Text);
            double result = num1 - num2;
            txbResult.Text = result.ToString();
        }

        private void txbClean_Click(object sender, EventArgs e)
        {
            txbNum1.Clear();
            txbNum2.Clear();
            txbResult.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txbNum1.Text);
            double num2 = double.Parse(txbNum2.Text);
            double result = num1 * num2;
            txbResult.Text = result.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double num1 = double.Parse(txbNum1.Text);
            double num2 = double.Parse(txbNum2.Text);
            double result = double.Math.Pow(txbNum1, txbNum2));
            txbResult.Text = result.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txbNum1.Text);
            double num2 = double.Parse(txbNum2.Text);
            double result = num1 / num2;
            txbResult.Text = result.ToString();
        }
    }
}
