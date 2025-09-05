using System;
using HerancaMultipla.Entites;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer() { Id = 234, Name = "Impressora" };
            printer.ProcessDocument("joandesson.pdf");
            printer.Print();

            Scanner scanner = new Scanner() { Id = 235, Name = "Scanner" };
            scanner.ProcessDocument("Clarice.Pdf");
            scanner.Scan();

            ComboDevice device = new ComboDevice() { Id = 233, Name = "Combo Device" };
            device.ProcessDocument("Curriculo.pdf");
            device.Scan();
            device.Print();
           
        }
    }
}