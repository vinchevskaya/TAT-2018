using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_5
{
    class CountTypes : ICommandStore
    {
        /// <summary>
        /// Method for counting the number of brands of cars.
        /// </summary>
        public void Work(List<CarShop> productList)
        {
            List<string> uniqueProductList = new List<string>();
            foreach(var a in productList)
            {
                uniqueProductList.Add(a.Brend);
            }

            Console.WriteLine("\nCountTypes: " + uniqueProductList.Distinct().Count());
        }
    }
}