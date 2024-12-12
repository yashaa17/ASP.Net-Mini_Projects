namespace Green_Basket.Models
{
    public class Vegetable : VegetableBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
        public int Quantity { get; set; }
         public Type VegetableType {  get; set; }

    }
}
