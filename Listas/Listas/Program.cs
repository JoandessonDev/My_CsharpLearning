using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Joandesson");
            list.Add("Anna");
            list.Add("Clara");
            list.Add("Iasmim");
            list.Insert(0, "Clarice");
            list.Add("Alyce");
            list.Add("Cassiano");

            foreach (string item in list)
            {
                Console.WriteLine(item);
                
            }

            Console.WriteLine($"\nList Count: {list.Count}");
            string s1 = list.Find(x => x[0] == 'J');
            string lasts1 = list.FindLast(x => x[0] == 'A');

            Console.WriteLine(s1);
            Console.WriteLine($"The Last A: {lasts1}");

            int postion1 = list.FindIndex(x => x[0] == 'C');
            Console.WriteLine($"Find First Index letter C: {postion1}");

            int position2 = list.FindLastIndex(x => x[0] == 'C');
            Console.WriteLine($"Find Last Index Letter C: {position2}");

            Console.WriteLine("-----------------------------");
            List<string> list2 = list.FindAll(x => x.Length == 5);
            list2.Add("Armando");
            list2.Insert(1, "Carlinhos");
            list2.RemoveAll(x => x[0] == 'A');

            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }
        }
    }
}