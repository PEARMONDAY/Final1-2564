using System;

namespace Final_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input skill name : ");
            string name = Console.ReadLine();
            while (name != "?")
            {
                Node node1 = new Node(name);
                Console.Write("Add dependency for {0} ? (Y/N) : ", name);
                char YesorNo = char.Parse(Console.ReadLine());
                if (YesorNo == 'Y' || YesorNo == 'y')
                {
                    Console.Write("Input skill name : ");
                    name = Console.ReadLine();
                    node1.nextNode = node1;
                }
                else if (YesorNo == 'N' || YesorNo == 'n')
                {
                    Console.WriteLine("No");
                }
                else
                    ;

            }

        }
    }
    class Node
    {
        public string name;
        public Node nextNode;

        public Node(string nameValue)
        {

            name = nameValue;
            nextNode = null;

        }
    }
}
