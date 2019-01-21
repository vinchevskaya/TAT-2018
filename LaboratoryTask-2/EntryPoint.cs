using System;

namespace LaboratoryTask_2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            MyList <Car> myList= new MyList<Car>();
            myList.Add(new Car("Q", "Audi", "wite"));
            myList.Add(new Car("X5", "BMV", "black"));
            myList.Add(new Car("T8", "Lada", "red"));
            myList.Add(new Car("OP", "Mercedes", "red"));
            foreach(Car car in myList)
            {
                Console.WriteLine(car);
            }
            Searcher searcher = new Searcher();
            var cars = searcher.ColorSearch("red", myList);
            foreach(var car in cars)
            {
                Console.WriteLine("Available cars of selected colour: " + car);
            }
        }
    }
}