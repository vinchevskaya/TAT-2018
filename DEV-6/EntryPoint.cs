using System;

namespace DEV_6
{
    class EntryPoint
    {       
        private static void Main(string[] args)
        {
            try
            {
                ConvertFiles convertFiles = new ConvertFiles();
                string[] sourceFile = args[0].Split('.');
                if (sourceFile[1] == "JSON")
                {
                    Console.WriteLine(convertFiles.ParseToXml(args[0]));
                }
                else if (sourceFile[1] == "XML")
                {
                    Console.WriteLine(convertFiles.ParseToJson(args[0]));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }    
}