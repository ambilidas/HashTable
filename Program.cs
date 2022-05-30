using System;

namespace HashTable
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome to Hash Table Program");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value: " + hash5);
            Console.WriteLine("-----------------------------");
            MyMapNode<string,string> myMapNode = new MyMapNode<string,string>(19);
            myMapNode.Add("0", "paranoids");
            myMapNode.Add("1", "are");
            myMapNode.Add("2", "not");
            myMapNode.Add("3", "paranoid");
            myMapNode.Add("4", "because");
            myMapNode.Add("5", "they");
            myMapNode.Add("6", "are");
            myMapNode.Add("7", "paranoid");
            myMapNode.Add("8", "but");
            myMapNode.Add("9", "because");
            myMapNode.Add("10", "they");
            myMapNode.Add("11", "keep");
            myMapNode.Add("12", "putting");
            myMapNode.Add("13", "themselves");
            myMapNode.Add("14", "deliberately");
            myMapNode.Add("15", "into");
            myMapNode.Add("16", "paranoid");
            myMapNode.Add("17", "avoidable");
            myMapNode.Add("18", "situations");
            string hash14 = myMapNode.Get("14");
            Console.WriteLine("14th index value: " + hash14);
            Console.ReadKey();
        }
    }
}
