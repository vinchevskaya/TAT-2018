using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_5
{
    class CountAll : ICommandStore
    {
        /// <summary>
        /// Method for counting the total number of cars.
        /// </summary>
        public void Work(List<CarShop> productList)
        {
            Console.WriteLine("\nCountAll: " + productList.Distinct().Count());
        }
    }
}