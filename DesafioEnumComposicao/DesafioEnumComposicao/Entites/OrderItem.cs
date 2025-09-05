using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEnumComposicao.Entites
{
    internal class OrderItem
    {
        public int Quantity { get; set; }

        public List<Product> Product { get; set; } = new List<Product>();

        public OrderItem() { }
        public OrderItem( int quantity)
        {
            Quantity = quantity;
        }
        public void AddProduct(Product product)
        {
            Product.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            Product.Remove(product);
        }

        public double SubTotal()
        {
            double subtotal = 0;
            foreach (Product product in Product)
            {
                subtotal += product.Price;
            }
            return subtotal;
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Product product in Product)
            {
                sb.Append(product.ToString());
            }
            sb.Append(Quantity);
            sb.AppendLine("Subtotal: ");
            sb.Append(SubTotal());

            return sb.ToString();



        }
    }
}
