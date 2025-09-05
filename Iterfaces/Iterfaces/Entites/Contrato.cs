using Iterfaces.Services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterfaces.Entites
{
    internal class Contrato
    {
        public int Number { get; private set; }
        public DateTime Date { get;  private set; }

        public int NParcelas { get; set; }
        public List<Parcela> Parcelas = new List<Parcela>();

        public double ValueContract { get; set; }
        public double TotalValue { get; set; }

        public Contrato(int number, int nParcelas, double valueContract)
        {
            Number = number;
            NParcelas = nParcelas;
            ValueContract = valueContract;
            Date = DateTime.Now;
        }

        public void CalcularContrato()
        {
            double amount = ValueContract / NParcelas;
            
            Parcela parcela = new Parcela(amount, Date, new TaxPaypal());

            for (int i = 0; i < NParcelas; i++)
            {
                parcela.DueDate.AddMonths(i);
                Parcelas.Add(parcela);
            }
            double total = 0;

            foreach (Parcela parcela1 in Parcelas)
            {
                total += parcela1.TotalPayment;
            1}
            TotalValue = total;
        }
        public void ImprimirParcelas()
        {
            foreach(Parcela parcela in Parcelas)
            {
                Console.WriteLine(parcela);
            }
        }


        
    }
}
