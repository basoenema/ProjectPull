using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Treatment : IList<Treatment>
    {
        public string Name;
        public List<Treatment> After;

        public int Count => ((IList<Treatment>)After).Count;

        public bool IsReadOnly => ((IList<Treatment>)After).IsReadOnly;

        public Treatment this[int index] { get => ((IList<Treatment>)After)[index]; set => ((IList<Treatment>)After)[index] = value; }


       public Treatment(string name)
        {
            Name = name;
            After = new List<Treatment>();
        }

        public int IndexOf(Treatment item)
        {
            return ((IList<Treatment>)After).IndexOf(item);
        }

        public void Insert(int index, Treatment item)
        {
            ((IList<Treatment>)After).Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            ((IList<Treatment>)After).RemoveAt(index);
        }

        public void Add(Treatment item)
        {
            ((IList<Treatment>)After).Add(item);
        }

        public void Clear()
        {
            ((IList<Treatment>)After).Clear();
        }

        public bool Contains(Treatment item)
        {
            return ((IList<Treatment>)After).Contains(item);
        }

        public void CopyTo(Treatment[] array, int arrayIndex)
        {
            ((IList<Treatment>)After).CopyTo(array, arrayIndex);
        }

        public bool Remove(Treatment item)
        {
            return ((IList<Treatment>)After).Remove(item);
        }

        public IEnumerator<Treatment> GetEnumerator()
        {
            return ((IList<Treatment>)After).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IList<Treatment>)After).GetEnumerator();
        }
    }
}
