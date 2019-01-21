namespace LaboratoryTask_2
{
    /// <summary>
    /// Selection of cars by the chosen color.
    /// </summary>
    public class Searcher
    {
        public MyList<Car> ColorSearch(string color, MyList<Car> cars)
        {
            var sekondList = new MyList<Car>();
            foreach(Car car in cars)
            {
                if (car.Color.Equals(color)) sekondList.Add(car);
            }
            return sekondList;       
        }       
    }
}