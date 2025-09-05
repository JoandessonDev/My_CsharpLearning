namespace FirstProject
{
    public partial class Form1 : Form
    {
        private object lblhelloworld;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World";

        }

        private void label1_Click(object sender, EventArgs e)
        {

            btnClickThis.Text = "Click Again";
        }

        private void btnClickThis2_Click(object sender, EventArgs e)
        {
            label1.Text = "Jesus é o caminho";
        }
    }
}
