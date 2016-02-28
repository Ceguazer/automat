using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Automatum
    {
        private HashSet<State> finalStates = new HashSet<State>();
        private State initialState, currentState;

        public Automatum()
        {
            initializeAutomatum();
        }
        public bool checkString(string word)
        {
            reset();
            char[] array = word.ToArray();
            bool result = false;
            foreach (char character in array)
            {
                result = doTransition(character);
            }
            return result;
        }

        private void reset()
        {
            currentState = initialState;
        }

        private bool doTransition(char character)
        {
            currentState = currentState.get(character);
            if (currentState == null)
            {
                throw new InvalidOperationException();
            }
            return finalStates.Contains(currentState);
        }
        private void initializeAutomatum()
        {
            State state0 = new State();
            State state1 = new State();
            State state2 = new State();
            //State state4 = new State();
            //State state5 = new State();
            //State state6 = new State();
            //State state7 = new State();
            //State state8 = new State();

            state0.add('a', state0);
            state0.add('b', state1);
            state1.add('a', state2);
            state1.add('b', state0);
            state2.add('a', state0);
            state2.add('b', state2);
            //state3.add('b', state8);
            //state3.add('a', state6);
            //state4.add('b', state1);
            //state4.add('a', state5);
            //state5.add('b', state1);
            //state5.add('a', state6);
            //state6.add('b', state1);
            //state6.add('a', state7);
            //state7.add('b', state1);
            //state7.add('a', state7);
            //state8.add('b', state1);
            //state8.add('a', state2);

            initialState = state0;

            finalStates.Add(state2);
        }
    }
}
