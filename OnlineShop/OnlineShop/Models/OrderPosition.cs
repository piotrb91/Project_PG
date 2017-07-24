namespace OnlineShop.Models
{
    public class OrderPosition
    {
        public int OrderPositionID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set;}

        public virtual Shop shop { get; set; }
        public virtual Orders orders { get; set; }

    }
}