namespace PracticePOO
{
    public abstract class Product
    {
        public String Description { get; set; }
        public int Id { get; set; }

        public decimal Price { get; set; }
        public float Tax { get; set; }



        public override string ToString()
        {

            return $"   {Id} {Description}" ;
        }

        public abstract decimal GetValueToPay();

    }
}
