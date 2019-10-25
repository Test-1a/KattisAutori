using System;
using System.Linq;

namespace KattisAutori
{
    class Program
    {
        static void Main(string[] args)
        {
            Array.ForEach(Console.ReadLine().Split('-'), (word) => Console.Write(word.First()));
        }
    }
}
