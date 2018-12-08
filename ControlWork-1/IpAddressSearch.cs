using System;
using System.Text;
using System.Net;

namespace ControlWork_1
{
    public class IPAddressSearch
    {
        public void LookingForIPAddressInString(string[] args)
        {
            StringBuilder builderForStartString = new StringBuilder();

            foreach (var a in args)
            {
                builderForStartString.Append(a).Append(" ");
            }
            string startString = builderForStartString.ToString();

            if (startString.Length == 0)
            {
                Console.WriteLine("Please enter an IP address.");
                return;
            }
            else
                startString = args[0];

            parse(startString);

            void parse(string ipString)
            {
                try
                {
                    IPAddress address = IPAddress.Parse(ipString);
                    Console.WriteLine("Parsing your input string: " + "\"" + ipString +
                        "\"" + " produces this address: " + address.ToString());
                }

                catch (ArgumentNullException e)
                {
                    Console.WriteLine("ArgumentNullException");
                    Console.WriteLine("Source : " + e.Source);
                    Console.WriteLine("Message : " + e.Message);
                }
            }

            string[] parts = startString.Split('.');
            if (parts.Length < 4)
            {
                // not a IPv4 string in X.X.X.X format
            }
            else
            {
                foreach (string a in parts)
                {
                    byte checkPart = 0;
                    if (!byte.TryParse(a, out checkPart))
                    {
                        // not a valid IPv4 string in X.X.X.X format
                    }
                }
                // it is a valid IPv4 string in X.X.X.X format
            }
        }
    }
}