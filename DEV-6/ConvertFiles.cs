using System;
using System.IO;
using System.Text.RegularExpressions;

namespace DEV_6
{
    /// <summary>
    /// The class converts a JSON file to an XML file or an XML file to a JSON.
    /// </summary>
    public class ConvertFiles
    {
        public string ParseToXml(string sourceJsonString)
        {
            FileStream s = File.Open(sourceJsonString, FileMode.Open);
            StreamReader streamReader = new StreamReader(s);
            string jsonString = streamReader.ReadToEnd();
            int tempIndexDeclimer;
            int tempIndex;
            if (jsonString.StartsWith("{") && jsonString.EndsWith("}"))
            {
                jsonString = Regex.Replace(jsonString, "(\"(?:[^\"\\\\]|\\\\.)*\")|\\s+", "$1");
                tempIndex = jsonString.IndexOf("{");
                tempIndexDeclimer = jsonString.IndexOf("[");
                if (tempIndex < tempIndexDeclimer)
                {

                    jsonString = jsonString.Replace("{\"", "<");
                    tempIndex = jsonString.IndexOf("\"");
                    string tempString = jsonString.Substring(1, tempIndex - 2);
                    jsonString = jsonString.Replace("\":[", ">");

                    tempIndex = jsonString.IndexOf(">");
                    jsonString = jsonString.Insert(tempIndex + 1, "<" + tempString + ">");

                    jsonString = jsonString.Replace("\",\"", "<");

                    while (jsonString.Contains("\":\""))
                    {
                        char[] jsonCharArray = jsonString.ToCharArray();
                        int elementOfChar = jsonString.IndexOf("\"");
                        int elementCounter = 0;

                        while (jsonCharArray[elementOfChar - elementCounter - 1] != '<')
                        {
                            elementCounter++;
                        }

                        string tempStringIncide = jsonString.Substring(elementOfChar - elementCounter, elementCounter);

                        while (jsonCharArray[elementCounter].ToString() != "\"")
                        {
                            elementCounter++;
                        }

                        jsonString = jsonString.Replace("\":\"", ">").Replace("\":", ">").Replace(",\"", "<");
                        jsonString = jsonString.Replace("\"},", "</" + tempString + "><" + tempString + ">");
                        jsonString = jsonString.Replace("\"}]}", "</" + tempString + "s>");
                    }
                }
            }
            return jsonString;
        }

        public string ParseToJson(string sourceXmlString)
        {
            FileStream s = File.Open(sourceXmlString, FileMode.Open);
            StreamReader streamReader = new StreamReader(s);
            string xmlString = streamReader.ReadToEnd();
            int tempIndexDeclimer;
            int tempIndex;

            if (xmlString.StartsWith("<") && xmlString.EndsWith(">"))
            {
                xmlString = Regex.Replace(xmlString, (@" >\s *< "), "$1");
                tempIndex = xmlString.IndexOf("<");
                tempIndexDeclimer = xmlString.IndexOf("><");

                if (tempIndex < tempIndexDeclimer)
                {
                    xmlString = xmlString.Replace("<", "{\"");
                    tempIndex = xmlString.IndexOf(">");
                    string tempString = xmlString.Substring(1, tempIndex - 2);
                    xmlString = xmlString.Replace(">", "\":[");

                    tempIndex = xmlString.IndexOf(">");
                    xmlString = xmlString.Insert(tempIndex + 1, "{\"" + tempString + "\":[");

                    xmlString = xmlString.Replace("<", "\",\"").Replace(">", "\":").Replace(">", "\",");
                    xmlString = xmlString.Replace("</" + tempString + ">", "\",");
                }
                Console.WriteLine(xmlString);
            }
            return xmlString;
        }
    }
}