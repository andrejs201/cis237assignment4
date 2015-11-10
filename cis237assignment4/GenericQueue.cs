using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericQueue<T> : GenericLinkedList<T>
    {
        public GenericNode<T> Dequeue()
        {
            GenericNode<T> returnNode = new GenericNode<T>();

            if (this.Tail == null)
            {
                returnNode = null;
            }
            else
            {
                returnNode = this.Tail;
                this.Tail.Previous = this.Tail;
                this.Tail.Next = null;
                this.Length--;
            }

            return returnNode;
        }
    }
}
