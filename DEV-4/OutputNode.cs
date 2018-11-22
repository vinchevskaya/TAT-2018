using System;
using System.Text;

namespace DEV_4
{
    /// <summary>
    /// This class to output nodes elements.
    /// </summary>
    public class OutputNode
    {
        /// <summary>
        /// This method to output nodes elements.
        /// </summary>
        /// <param name="node">Node with element.</param>
        /// <param name="XMLFile">Parsed XMLFile.</param>
        /// <returns>Returns string with nodes elements.</returns>
        public string PrintNode(Node node)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (node.Value != null)
            {
                stringBuilder.Append(node.Tag);
                stringBuilder.Append('-');
                stringBuilder.Append(node.Value);
                Console.WriteLine(stringBuilder);
            }

            if (node.Attributes != null && node.Attributes != null)
            {
                stringBuilder.Append(node.Tag);
                stringBuilder.Append('-');
                stringBuilder.Append(node.Attributes);
                stringBuilder.Append('-');
                stringBuilder.Append(node.AttributeValue);
                Console.WriteLine(stringBuilder);
            }

            for (int i = 0; i < node.ChildrenNodes.Count; i++)
            {
                PrintNode(node.ChildrenNodes[i]);
            }
            return stringBuilder.ToString();
        }
    }
}