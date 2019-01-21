using System;
using System.Linq;
using System.Text;

namespace ControlWork_1
{
    /// <summary>
    /// This class is used to find the number
    /// of same characters in a string.
    /// </summary>
    public class CounterOfTheSameChars
    {
        public void SearchesForSameChars(string[] args)
        {
            StringBuilder builderForStartString = new StringBuilder();

            foreach (var a in args)
            {
                builderForStartString.Append(a).Append(" ");
            }

            string startString = builderForStartString.ToString();
            char[] startCharArray = startString.ToCharArray();

            StringBuilder builderForSameSequence = new StringBuilder();
            builderForSameSequence.Append(startCharArray[0]);
            String sequenceOfSameElements = builderForSameSequence.ToString();
            int counterOfSameElements = sequenceOfSameElements.Length;

            String subStringToIndex = "";
            String fullString = "";

            for (int i = 1; i < startCharArray.Length - 1; i++)
            {
                subStringToIndex = startString.Substring(0, i);
                if (!sequenceOfSameElements.Contains(startCharArray[i]))
                {
                    builderForSameSequence.Append(startCharArray[i]);
                    sequenceOfSameElements = builderForSameSequence.ToString();
                }

                else
                {
                    sequenceOfSameElements = builderForSameSequence.ToString();
                    int index = subStringToIndex.LastIndexOf(startCharArray[i]);
                    i = index + 1;

                    
                    if (counterOfSameElements < sequenceOfSameElements.Length)
                    {
                        var count = sequenceOfSameElements.Count(chr => chr == counterOfSameElements);
                        counterOfSameElements = sequenceOfSameElements.Count();
                        fullString = sequenceOfSameElements;
                    }

                    sequenceOfSameElements = "";
                    builderForSameSequence.Clear();
                }
            }
            Console.WriteLine("sequence of same elements: " + fullString +
            "\n Number of same elements: " + counterOfSameElements);
        }
    }
}