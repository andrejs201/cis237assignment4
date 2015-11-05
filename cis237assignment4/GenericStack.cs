using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericStack<T> : GenericLinkedList<T>
    {
        public GenericNode<T> Pop()
        {
            GenericNode<T> returnNode = new GenericNode<T>();

            return returnNode;
        }
    }
}
