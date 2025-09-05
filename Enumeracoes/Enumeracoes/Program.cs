using System;
using Enumeracoes.Entites;
using Enumeracoes.Entites.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 12747,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered

            };
            Console.WriteLine(order);
        }
    }
}