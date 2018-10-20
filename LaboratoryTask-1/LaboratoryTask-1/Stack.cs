using System;

namespace LaboratoryTask_1
{
    /// <summary>
    /// Based on the Node class, we implement the stack structure.
    /// </summary>
    public class Stack : Node
    {
        public int StackContents { get; private set; }
        public void Push(int value)
        {
            Node node = new Node { Size = value };
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                head = node.Next;
                tail = node;
            }
            StackContents++;
        }
        public int Pop()
        {
            if (StackContents < 1)
            {
                throw new Exception("Stack is empty");
            }
            if (StackContents == 1)
            {
                StackContents = 0;
                int count = head.Size;
                head = tail = null;
                return count;
            }
            Node index = head;
            while (index.Next != tail)
            {
                index = index.Next;
            }
            int top = index.Next.Size;
            tail = index;
            StackContents--;
            return top;
        }
    }
}