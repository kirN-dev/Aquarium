
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public class Child<T> : Parent
    {
        public T Word;
        public Child()
        {
            ///1-3-4
            ///1-2-3-4
            ///134
            List<int> list = new();
            LinkedList<int> l = new();
            var i = new int[10];

            list.AddRange(i);
            list.AddRange(list);
        }
    }
}
