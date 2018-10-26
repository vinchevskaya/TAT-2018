using System;

namespace DEV_3
{
    /// <summary>
    /// This class converts a decimal number to another number system from 2 to 20.
    /// </summary>
    class ConverterOfNumber
    {
        int ConvertNumber;
        int radix;
        /// <summary>
        /// Constructor instance.
        /// </summary>
        public ConverterOfNumber(int decimalValues, int radixNumber)
        {
            if (decimalValues < 0)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            else
            {
                ConvertNumber = decimalValues;
            }
            if (radixNumber < 2 || radixNumber > 20)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            else
            {
                radix = radixNumber;
            }
        }
        /// <summary>
        /// This method converts a decimal number to a new number system.
        /// </summary>
        /// <returns>Return a converted number in another number system.</returns>
        public string СonvertDeciminalNumber()
        {
            string resultNumber = "";
            int rest;//ostatok
            int decimalNumber = ConvertNumber;

            while (decimalNumber > 0)
            {
                rest = decimalNumber % radix;
                if (rest < 9)
                {
                    resultNumber += rest;
                }
                else
                {
                    char newRadixNumber = (char)('A' + rest - 10);
                    resultNumber += newRadixNumber;
                }
                decimalNumber /= radix;
            }
            return (Сonverse(resultNumber));
        }
        /// <summary>
        /// This method returns a value.
        /// </summary>
        /// <returns>Converse string.</returns>
        private string Сonverse(string CounterString)
        {
            char[] ConvertString = CounterString.ToCharArray();
            Array.Reverse(ConvertString);
            return new string(ConvertString);
        }
    }
}