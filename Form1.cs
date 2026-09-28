namespace RipassoInterGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Somma_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(textNum1.Text);
            int n2 = Convert.ToInt16(textNum2.Text);
            int somma = n1 + n2;

            Risultato.Text = somma.ToString();
        }
    }
}
