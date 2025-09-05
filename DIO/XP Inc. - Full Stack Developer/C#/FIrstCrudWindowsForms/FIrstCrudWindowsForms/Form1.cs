using System.Data.SQLite;

namespace FIrstCrudWindowsForms
{
    public partial class Form1 : Form
    {
        private SQLiteConnection sqliteConnection;
        public Form1()
        {
            InitializeComponent();
            ConnectToDatabase();
            FetchData();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConnectToDatabase()
        {
            string connectionString = @"Data Source=C:\\Users\\JOANDESSON\\Desktop\\C#\\DIO\\XP Inc. - Full Stack Developer\\C#\\FIrstCrudWindowsForms\\FIrstCrudWindowsForms\\bin\\Debug\\database.db;Version=3;";
            sqliteConnection = new SQLiteConnection(connectionString);

            try
            {
                sqliteConnection.Open();
                MessageBox.Show("Conexão estabelecida com Sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Base de Dados " + ex.Message);
            }
        }
        private void FetchData()
        {
            string query = $"SELECT * FROM produtos";

            SQLiteCommand command = new SQLiteCommand(query, sqliteConnection);

            try
            {
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.ToString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados: " + ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO produtos (Nome, Marca, Categoria, Quantidade) " +
                "VALUES (@nome, @marca, @categoria, @quantidade)";

            SQLiteCommand command = new SQLiteCommand(query, sqliteConnection);

            int quantidade = int.Parse(quantidadeTexBox.Text);

            command.Parameters.AddWithValue("@nome", nomeTexBox.Text);
            command.Parameters.AddWithValue("@marca", marcaTexBox.Text);
            command.Parameters.AddWithValue("@categoria", categoriaTexBox.Text);
            command.Parameters.AddWithValue("@quantidade", quantidade);

            try
            {
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Dados inseridos com sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha ao inserir dados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir dados: " + ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
