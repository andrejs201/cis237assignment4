using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericStack<T> : GenericLinkedList<T>
    {
        public T Pop()
        {
            T returnData = default(T);
            GenericNode<T> tempNode = new GenericNode<T>();

            if (this.Head != null)
            {
                returnData = this.Head.Data;
                tempNode = Head;
                this.Head = this.Head.Next;
                if (this.Head != null)
                {
                    this.Head.Previous = null;
                }
                tempNode.Next = null;
                this.Length--;
            }

            return returnData;
        }
    }
}
