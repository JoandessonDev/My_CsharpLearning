using HerancaMultipla.Interfaces;


namespace HerancaMultipla.Entites
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public void Scan()
        {
            Console.WriteLine("Scaneando Documento: {document}");
        }
        public void Print()
        {
            Console.WriteLine("Imprimindo documento");
        }
    }
}
