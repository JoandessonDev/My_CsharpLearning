namespace TelaTest
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

        private void btnAction_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Seu Nome Completo é {textBox1.Text} {textBox2.Text}");
        }
    }
}
