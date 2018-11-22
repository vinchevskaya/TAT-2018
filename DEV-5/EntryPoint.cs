using System;
using System.Collections.Generic;

namespace DEV_5
{
    /// <summary>
    /// It's an entry point in the program.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo continueInput = new ConsoleKeyInfo();

            List<CarShop> productList = new List<CarShop>();
            try
            {
                do
                {
                    var product = new ProductBuilder();

                    Console.WriteLine("Input brend of product:");
                    product.SetBrend(Console.ReadLine());

                    Console.WriteLine("\nInput the model of product:");
                    product.SetModel(Console.ReadLine());

                    Console.WriteLine("\nInput the quantity of product");
                    product.SetQuantity(Console.ReadLine());

                    Console.WriteLine("\nInput the cost of one product");
                    product.SetCostPerUnit(Console.ReadLine());

                    productList.Add(product.Build());

                    continueInputProducts:

                    Console.WriteLine("\nDo you want to continue to input products?");
                    Console.WriteLine("No [LeftArrow] | Yes [RightArrow]");
                    continueInput = Console.ReadKey();

                    if (continueInput.Key != ConsoleKey.RightArrow && continueInput.Key != ConsoleKey.LeftArrow) goto continueInputProducts;
                }
                while (continueInput.Key == ConsoleKey.LeftArrow);

                string number;

                do
                {
                    chooseCommand:

                    Console.WriteLine("\nChoose command:" +
                    "\n1) count types\n" +
                    "2) count all\n" +
                    "3) average price (all types)\n" +
                    "4) average price (type)\n" +
                    "5) exit\n" +
                    "Input number: ");

                    number = Console.ReadLine();

                    Storage storage = new Storage();

                    switch (number)
                    {
                        case "1":
                            storage.SetCommand(new CountTypes());
                            storage.WorkCommand(productList);
                            break;
                        case "2":
                            storage.SetCommand(new CountAll());
                            storage.WorkCommand(productList);
                            break;
                        case "3":
                            storage.SetCommand(new AveragePrice());
                            storage.WorkCommand(productList);
                            break;
                        case "4":
                            Console.WriteLine("Input type: ");
                            string type = Console.ReadLine();
                            storage.SetCommand(new AveragePriceType(type));
                            storage.WorkCommand(productList);
                            break;
                        case "5":
                            return;
                        default:
                            goto chooseCommand;
                    }
                }
                while (true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}