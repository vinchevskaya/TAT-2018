namespace DEV_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathXMLFile = args[0];
            XMLParser parser = new XMLParser();
            string XMLFile = parser.ReadXMLFile(pathXMLFile);
            Node node = new Node();
            node = parser.ParseXMLFile(XMLFile);
            OutputNode outputNode = new OutputNode();
            outputNode.PrintNode(node);
        }
    }
}