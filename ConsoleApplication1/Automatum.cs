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
        private StateList initialStates, currentStates;

        public Automatum()
        {
            InitializeAutomatum();
        }

        public bool CheckString(string word)
        {
            Reset();
            char[] array = word.ToArray();
            bool result = false;
            foreach (char character in array)
            {
                result = DoTransition(character);
            }
            return result;
        }

        private void Reset()
        {
            currentStates = new StateList(initialStates);
        }

        private bool DoTransition(char character)
        {
            StateList newStates = new StateList();
            foreach (State state in currentStates.GetList())
            {
                newStates.add(state.Get(character));
            }
            currentStates = newStates;
            if (currentStates == null)
            {
                throw new InvalidOperationException();
            }
            return currentStates.GetList().Any(state => finalStates.Contains(state));
        }

        private void InitializeAutomatum()
        {
            initialStates = new StateList();

            State state0 = new State();
            State state1 = new State();
            //State state2 = new State();
            //State state4 = new State();
            //State state5 = new State();
            //State state6 = new State();
            //State state7 = new State();
            //State state8 = new State();

            state0.Add('a', state0);
            state0.Add('b', state0);
            state0.Add('b', state1);
            //state1.Add('a', state2);
            //state1.Add('b', state0);
            //state2.Add('a', state0);
            //state2.Add('b', state2);
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

            initialStates.add(state0);
            finalStates.Add(state1);
        }
    }
}