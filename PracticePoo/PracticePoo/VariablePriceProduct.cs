namespace PracticePOO
{
    public class VariablePriceProduct : Product
    {

        public String Measurement { get; set; }
        public float Quantity { get; set; }

        public override string ToString()
        {
            return base.ToString() +
                   $"\n\tMeasurement: {Measurement}" +
                   $"\n\tQuantity...:{$"{Quantity:C2}",14}" +
                   $"\n\tPrice:.....:{$"{Price:C2}",14}" +
                   $"\n\tTax:.......:{$"{Tax:P2}",16}" +
                   $"\n\tValue:.....:{$"{GetValueToPay():C2}",14}";
        }
        public override decimal GetValueToPay()
        {

            return Price * (decimal)Quantity + (Price * (decimal)Quantity * (decimal)Tax);
        }
    }
}
