using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StateList
    {
        private List<State> list;

        public StateList()
        {
            list = new List<State>();
        }
        public StateList(State state) : this()
        {
            list.Add(state);
        }

        public StateList(StateList copy) : this()
        {
            foreach (State state in copy.GetList())
            {
                list.Add(state);
            }           
        }

        public void add(State state)
        {
            list.Add(state);
        }
        public void add(StateList stateList)
        {
            if (stateList == null) return;
            foreach (State state in stateList.GetList())
            {
                if (!list.Contains(state))
                {
                    list.Add(state);
                }
            }   
        }
        public List<State> GetList()
        {
            return list;
        }
    }
}
