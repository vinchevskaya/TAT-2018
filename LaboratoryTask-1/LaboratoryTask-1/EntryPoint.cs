using System;

namespace LaboratoryTask_1
{
    /// <summary>
    /// This class is used to enter the program.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Stack stack = new Stack();
                stack.Push(5);
                stack.Push(13);
                stack.Push(40);
                stack.Pop();
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}