using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Automatum automatum = new Automatum();
            Console.WriteLine(automatum.CheckString("babbbbb"));
            Console.WriteLine(automatum.CheckString("bab"));
            Console.WriteLine(automatum.CheckString("baaba"));
            Console.ReadLine();
        }
    }
}
