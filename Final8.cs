using System;

namespace Final8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number : ");
            int A = int.Parse(Console.ReadLine());
            char[] Number = new char[A];

            Console.WriteLine("Input char : ");
            for (int i = 0; i < A; i++)
            {
                Console.Write("{0}.", i + 1);
                Number[i] = char.Parse(Console.ReadLine());
            }
            int Index;
            for (int i = 0; i < A; i++)
            {
                Index = i;
                for (int j = i; j < A; j++)
                {
                    Index = j;
                }
                Swap(ref Number, i, Index);
            }
            Console.Write("Summation : ");
            for (int i = 0; i < A; i++)
            {
                Console.Write("{0},", Number[i]);
            }
        }
        static void Swap(ref char[] number, int index1, int index2)
        {
            char tmp = number[index1];
            number[index1] = number[index2];
            number[index2] = tmp;
        }
    }
}
