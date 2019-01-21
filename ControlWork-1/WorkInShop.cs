using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork_1
{
    public class WorkInShop
    {       
        List <Shop> list = new List<Shop>();

        public void Store()
        {
            foreach(Shop products in list)
            {
                Console.WriteLine(products.type + "-" + products.name + "-" + products.cost + "-" + products.shelfLife + "-");
            }
        }
        public string finishShelfLife = "30.06.2019";

        public void StoreList()
        {
            foreach (Shop products in list)
            {
                string shelfLife = products.shelfLife;              
            }
        }
        public void Action()
        {
            List<String> shelfLife = new List<String>();
            foreach (Shop products in list)
            {
                shelfLife.Add(products.shelfLife);
            }

            string shelfLifeForGoods = products.shelfLife.ToString();
            if (shelfLifeForGoods.Equals(finishShelfLife))
            {
                Console.WriteLine("Good merchandise");
            }
            else
            {
                Console.WriteLine("Not good");
            }
        }
    }
}