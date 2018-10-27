namespace LaboratoryTask_2
{
    /// <summary>
    /// Class constructor.
    /// </summary>
    public class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public Car(string model, string brand, string color)
        {
            this.Model = model;
            this.Brand = brand;
            this.Color = color;
        }
        public override string ToString()
        {
            return "Model: " + Model + " Brand: " + Brand + " Color: " + Color;
        }
    }
}