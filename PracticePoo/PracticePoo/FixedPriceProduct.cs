namespace PracticePOO
{
    public class FixedPriceProduct : Product
    {
        public override decimal GetValueToPay()
        {
            return Price + (Price * (decimal)Tax);
        }

        public override string ToString()
        {

            return base.ToString() +
                   $"\n\tPrice:.....:{$"{Price:C2}",14}"+
                   $"\n\tTax:.......:{$"{Tax:P2}",16}"+
                   $"\n\tValue:.....:{$"{GetValueToPay():C2}",14}";
        }
    }
}
