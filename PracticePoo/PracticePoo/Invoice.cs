using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePOO
{
    public class Invoice : IPay

    {

        private ICollection<Product> _Products =  new List<Product>(); 

        public decimal GetValueToPay()
        {
            decimal Value = 0;
            foreach (Product p in _Products)
            {
                Value += p.GetValueToPay();
            }
            return  Value;
        }

        public void AddProduct(Product P) { 
            _Products.Add(P);
        }

        public override string ToString()
        {
            String CadenaP = "";
            foreach (Product p in _Products) { 
            CadenaP += p.ToString()+"\n";
            }
            return CadenaP +"" +
                "                    ==============" +
                $"\nTotal:       {$"{GetValueToPay():C2}",21}";
        }
    }
}
