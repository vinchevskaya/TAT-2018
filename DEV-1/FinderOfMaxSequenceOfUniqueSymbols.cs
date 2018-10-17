using System;
using System.Linq;
using System.Text;

namespace DEV_1
{
    /// <summary>
    /// This class is used to find the maximum number
    /// of unique consecutive characters in a string.
    /// </summary>
    class FinderOfMaxSequenceOfUniqueSymbols
    {
        static void Main(string[] args)
        {
            try
            {
                StringBuilder builderForStartString = new StringBuilder();
                foreach (var a in args)
                {
                    builderForStartString.Append(a).Append(" ");
                }
               
                string startString = builderForStartString.ToString();
                char[] startCharArray = startString.ToCharArray();

                StringBuilder builderForUniqueSequence = new StringBuilder();

                builderForUniqueSequence.Append(startCharArray[0]);
                String sequenceOfUniqueElements = builderForUniqueSequence.ToString();
                int counterOfUniqueElements = sequenceOfUniqueElements.Length;

                String subStringToIndex = "";
                String fullString = "";

                for (int i = 1; i < startCharArray.Length - 1; i++)
                {
                    subStringToIndex = startString.Substring(0, i);
                    if (!sequenceOfUniqueElements.Contains(startCharArray[i]))
                    {
                        builderForUniqueSequence.Append(startCharArray[i]);
                        sequenceOfUniqueElements = builderForUniqueSequence.ToString();
                    }

                    else
                    {
                        sequenceOfUniqueElements = builderForUniqueSequence.ToString();
                        int index = subStringToIndex.LastIndexOf(startCharArray[i]);
                        i = index + 1;

                        if (counterOfUniqueElements < sequenceOfUniqueElements.Length)
                        {
                            counterOfUniqueElements = sequenceOfUniqueElements.Length;
                            fullString = sequenceOfUniqueElements;
                        }

                        sequenceOfUniqueElements = "";
                        builderForUniqueSequence.Clear();
                    }
                }

                Console.WriteLine("Maximum sequence of unique elements: " + fullString +
                "\n Number of unique elements: " + counterOfUniqueElements);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("The location of the error: " + ex.StackTrace);
            }           
        } 
    }
}