using System;

namespace ControlWork_1
{
    public class Shop
    {
        public string type { get; set; }
        public double cost { get; set; }
        public string name { get; set; }
        public string shelfLife { get; set; }

        public Shop(String type, String name, string shelfLife, double cost)
        {
            this.type = type;
            this.name = name;
            this.shelfLife = shelfLife;
            this.cost = cost;
        }
    }
}
