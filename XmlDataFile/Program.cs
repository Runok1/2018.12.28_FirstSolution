using System;

namespace XmlDataFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var xml = XmlHelpers.CreateXml("Data/XmlTestFile.xml");

            var ids = xml.GetElementsByTagName("Id").Count;

            Console.WriteLine(ids);

            //var nodeZero = XmlHelpers.GetNodeByTagName("Node1", xml);

            //var node = XmlHelpers.GetNodeByTagName("Node1", "Data/XmlTestFile.xml");

            //var nodeText = XmlHelpers.GetNodeText("Test");

            //Console.WriteLine(nodeZero == node);

            Console.ReadKey();
        }
    }
}
