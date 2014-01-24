namespace L4S07
{
    public class Bill
    {
        public double Price { get; set; }
        public double Quantity { get; set; }
        public double Total { get { return Price * Quantity; } }
    }
}