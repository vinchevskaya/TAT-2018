using System;
using NUnit.Framework;

namespace DEV_3.Tests
{
    [TestFixture]
    public class ConvertDecimalNumberTests
    {
        [TestCase(10, 2, "1010")]
        [TestCase(6, 3, "20")]
        [TestCase(125, 4, "1331")]
        [TestCase(6, 4, "12")]
        [TestCase(13678, 5, "414203")]
        [TestCase(888, 9, "1186")]
        [TestCase(30, 19, "1B")]
        public void ConvertDecimalToAnotherSystem(int decimalNumber, int convertNumber, string expected)
        {
            ConverterOfNumber conv = new ConverterOfNumber(decimalNumber, convertNumber);
            string actual = conv.СonvertDeciminalNumber();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(20, -1)]
        [TestCase(20, 1)]
        [TestCase(10, -21)]
        [TestCase(10, 21)]
        public void TheDesiredRangeOfValues( int decimalNumber, int convertNumber)
        {
            ConverterOfNumber converter = new ConverterOfNumber(decimalNumber, convertNumber);
            Assert.Throws<Exception>(() => converter.СonvertDeciminalNumber());
        }
    }
}