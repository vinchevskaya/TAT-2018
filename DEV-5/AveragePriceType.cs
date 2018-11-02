using System.Collections.Generic;
using System.Linq;

namespace DEV_5
{
    class AveragePriceType : ICommandStore
    {
        private string type;
        public AveragePriceType(string type)
        {
            this.type = type;
        }
        public void Work(List<CarShop> productList)
        {
            var typeProductList = productList.Where(product => product.Brend == type);
            var priceList = new List<float>();
            foreach(var a in typeProductList)
            {
                priceList.Add(a.CostPerUnit);
            }
        }
    }
}