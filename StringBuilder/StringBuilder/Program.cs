using System;
using Stringbuilder.Entites;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow thats awaesome!");

            Post p1 = new Post(
                DateTime.Parse("22/06/2024"),
                "Travel to New Zeland",
                "Im goin to visit thi wondergul country", 12
                );
            p1.AddComent(c1);
            p1.AddComent(c2);

            Comment c3 = new Comment("Oh my God, a new Emotion!");
            Comment c4 = new Comment("Im love this movie:-)");

            Post p2 = new Post(
                DateTime.Now,
                "Are you watch this movie?",
                "This week has a new, the movie named Divertidamente",
                500
                ) ;
            p2.AddComent(c3);
            p2.AddComent(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}