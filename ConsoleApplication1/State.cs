using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class State
    {
        private Dictionary<char, State> hash = new Dictionary<char, State>();

        public void add(char character, State state)
        {
            if (hash.ContainsKey(character))
            {
                hash[character] = state;
            }
            else
            {
                hash.Add(character, state);
            }
        }
        public State get(char character)
        {
            if (hash.ContainsKey(character))
            {
                Console.Out.WriteLine("wywolano stan ze znakiem " + character);
                return hash[character];
            }
            return null;
        }
    }
}
