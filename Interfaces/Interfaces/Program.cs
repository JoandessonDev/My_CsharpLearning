namespace Interfaces
{
    using Interfaces.Entites;
    using Interfaces.Services;
    using System.Globalization;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car Model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yyyy hh::mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return (dd/MM/yyyy hh::mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per Hour: ");
            double hour = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter price per Day: ");
            double day = double.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrasilTaxService());
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine($"Invoice: {carRental.Invoice}");
        }
    }
}
 