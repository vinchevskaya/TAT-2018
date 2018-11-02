using System;

namespace DEV_5
{
    public class ProductBuilder
    {
        private CarShop product;

        public ProductBuilder()
        {
            product = new CarShop();
        }
        public ProductBuilder SetBrend(string brend)
        {
            if (brend.Equals(string.Empty))
            {
                throw new ArgumentException();
            }

            product.Brend = brend;
            return this;
        }
        public ProductBuilder SetModel(string model)
        {
            if (model.Equals(string.Empty))
            {
                throw new ArgumentException();
            }

            product.Model = model;
            return this;
        }
        public ProductBuilder SetQuantity(string quantity)
        {
            product.Quantity = UInt32.Parse(quantity);
            return this;
        }
        public ProductBuilder SetQuantity(uint quantity)
        {
            product.Quantity = quantity;
            return this;
        }
        public ProductBuilder SetCostPerUnit(string costPerUnit)
        {
            float cost = Single.Parse(costPerUnit);

            if (cost < 0)
            {
                throw new ArgumentException();
            }

            product.CostPerUnit = cost;
            return this;
        }
        public ProductBuilder SetCostPerUnit(float costPerUnit)
        {
            if (costPerUnit < 0)
            {
                throw new ArgumentException();
            }

            product.CostPerUnit = costPerUnit;
            return this;
        }
        public CarShop Build()
        {
            return product;
        }
    }
}