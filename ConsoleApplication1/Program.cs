using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Automatum automatum = new Automatum();
            Console.WriteLine(automatum.checkString("babbbbb"));
            Console.WriteLine(automatum.checkString("bab"));
            Console.WriteLine(automatum.checkString("baaba"));
            Console.ReadLine();
        }
    }
}
