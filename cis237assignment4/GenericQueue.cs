using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericQueue<T> : GenericLinkedList<T>
    {
        public T Dequeue()
        {
            T returnData = default(T);
            GenericNode<T> tempNode = new GenericNode<T>();

            if (this.Tail != null)
            {
                returnData = this.Tail.Data;
                tempNode = Tail;
                this.Tail = this.Tail.Previous;
                if (this.Tail != null)
                {
                    this.Tail.Next = null;
                }
                tempNode.Previous = null;
                this.Length--;
            }

            return returnData;
        }
    }
}
