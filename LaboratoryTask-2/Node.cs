namespace LaboratoryTask_2
{
    /// <summary>
    /// This class defines a list item
    /// </summary>
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> PrevCar { get; set; }
        public Node<T> NextCar { get; set; }
    }
}