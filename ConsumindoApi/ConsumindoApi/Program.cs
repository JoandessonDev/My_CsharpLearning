using System.Text.Json;
using System.Text.Json.Nodes;

namespace ConsumindoApi
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (HttpClient client = new HttpClient())
                try
            {
                string url = "https://jsonplaceholder.typicode.com/posts";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                List<Post> posts = JsonSerializer.Deserialize<List<Post>>(responseBody);
                foreach (var post in posts)
                    {
                        Console.WriteLine($"Título: {post.title}");
                        Console.WriteLine($"Conteúdo: {post.body}");
                        Console.WriteLine(new string('-', 50));

                    }
               
            }
            catch (HttpRequestException erro)
            {
                Console.WriteLine($"Deu erro: {erro.Message}");
            }
        }
    }
    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
