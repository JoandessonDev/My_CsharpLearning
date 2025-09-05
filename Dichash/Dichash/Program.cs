using System;

namespace Mynamespace
{
    class Course
    {
        static void Main(string[] args)
        {
            Dictionary<string, string[]> dict = new Dictionary<string, string[]>();
            string[] arr = new string[3];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            dict.Add("A", arr);

            Console.WriteLine(dict["A"].ToString());
           
        }

    }
}