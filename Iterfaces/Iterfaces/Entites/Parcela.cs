using Iterfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterfaces.Entites
{
    internal class Parcela
    {
        public double Amount { get; set; }
        public DateTime DueDate { get; set; }

        public ITaxContrato _taxContrato { get; set; }

        public Parcela(double amount, DateTime dueDate, ITaxContrato taxContrato)
        {
            Amount = amount;
            DueDate = dueDate;
            _taxContrato = taxContrato;
        }

        public double TotalPayment
        {
            get { return Amount + (Amount * 0.01) + (_taxContrato.Tax(Amount)); }
        }

        public override string ToString()
        {
            return $"{DueDate.ToString("dd/mm/yyyy")} - {TotalPayment}";
            
        }
    }
}
