using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class State
    {
        private Dictionary<char, StateList> hash = new Dictionary<char, StateList>();

        public void Add(char character, State state)
        {
            if (hash.ContainsKey(character))
            {
                hash[character].add(state);
            }
            else
            {
                hash.Add(character, new StateList(state));
            }
        }
        public StateList Get(char character)
        {
            if (hash.ContainsKey(character))
            {
                Console.Out.WriteLine("wywolano stany ze znakiem " + character);
                return hash[character];
            }
            return null;
        }
    }
}
