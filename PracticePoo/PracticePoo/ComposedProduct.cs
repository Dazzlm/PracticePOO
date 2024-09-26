namespace PracticePOO
{
    public class ComposedProduct : Product

    {

        public float Discount { get; set; }
        public ICollection<Product> Products { get; set; }

        public override decimal GetValueToPay()
        {
            decimal valueT = 0;
            foreach (Product p in Products)
            {
                valueT += p.GetValueToPay();
            }

            return valueT - valueT * (decimal)Discount;
        }

        public override string ToString()

        {
            String CadenaProducts = "";
            foreach (Product p in Products)
            {

                CadenaProducts = CadenaProducts + p.Description + ", ";
            }
            CadenaProducts = CadenaProducts.TrimEnd(',', ' ');

            return base.ToString() +
                $"\n\tProducts...: {$"{CadenaProducts:C2}",14}" +
                $"\n\tDiscount...:{$"{Discount:P2}",16}" +
                $"\n\tValue:.....:{$"{GetValueToPay():C2}",14}"; ;
        }
    }
}
