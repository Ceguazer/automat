using System.Collections.Generic;

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

        public void Add(State state)
        {
            if (!list.Contains(state))
            {
                list.Add(state);
            }
        }
        public void Add(StateList stateList)
        {
            if (stateList == null) return;
            foreach (State state in stateList.GetList())
            {
                Add(state);
            }   
        }
        public List<State> GetList()
        {
            return list;
        }

        public int GetSize()
        {
            return list.Count;
        }
    }
}
