using System;

namespace DEV_3
{
    /// <summary>
    /// This is еру entry point to the program.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                ConverterOfNumber conventer = new ConverterOfNumber(Int32.Parse(args[0]), Int32.Parse(args[1]));
                Console.WriteLine($"{conventer.СonvertDeciminalNumber()}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }           
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
    }
}