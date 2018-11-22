namespace DEV_5
{
    public class CarShop
    {
        public string Brend { get; set; }
        public string Model { get; set; }
        public uint Quantity { get; set; }
        public float CostPerUnit { get; set; }

        public static ProductBuilder CreateBuilder()
        {
            return new ProductBuilder();
        }
    }
}