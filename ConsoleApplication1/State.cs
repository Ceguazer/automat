using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class State
    {
        private Dictionary<char, StateList> hash = new Dictionary<char, StateList>();

        public void Add(char character, State state)
        {
            if (hash.ContainsKey(character))
            {
                hash[character].Add(state);
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
                return hash[character];
            }
            return null;
        }
    }
}
