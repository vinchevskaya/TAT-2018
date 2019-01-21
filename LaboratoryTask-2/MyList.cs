using System.Collections.Generic;
using System.Collections;

namespace LaboratoryTask_2
{
    /// <summary>
    /// The class definition of list of cars.
    /// </summary>
    public class MyList<T> : IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        int count;
        /// <summary>
        /// This method adds an item to the list.
        /// </summary>
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
                head = node;
            else
            {
                tail.NextCar = node;
                node.PrevCar = tail;
            }
            tail = node;
            count++;
        }
        /// <summary>
        /// This method adds an item to the top of the list.
        /// </summary>
        public void AddFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> temp = head;
            node.NextCar = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.PrevCar = node;
            count++;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.NextCar;
            }
        }
        public IEnumerable<T> BackEnumerator()
        {
            Node<T> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.PrevCar;
            }
        }
    }
}