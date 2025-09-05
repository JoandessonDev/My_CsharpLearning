namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = 0;
            double n2 = 0;
            double resultado = 0;

            n1 = double.Parse(text1.Text);
            n2 = double.Parse(text2.Text);

            switch (cboTypeCal.SelectedItem.ToString())
            {

                case "Somar":
                    resultado = n1 + n2;
                    break;

                case "Subtrair":
                    resultado = n1 - n2;
                    break;

                case "Multiplicar":
                    resultado = n1 * n2;
                    break;
                case "Dividir":
                    resultado = n1 / n2;
                    break;

                case "":
                    MessageBox.Show("Selecione uma operação valida");
                    break;

            }

            lblResultado.Text = resultado.ToString();

        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "0";
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Sair;
            Sair = MessageBox.Show("Voê realmente deseja fechar esta aplicação?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Sair.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void cboTypeCal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

