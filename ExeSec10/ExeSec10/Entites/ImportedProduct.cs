using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeSec10.Entites
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(double customsFee, string name, double price) : base(name, price) 
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return CustomsFee * Price;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice()} (CustomsFee: $ {CustomsFee})";
        }
    }
}
