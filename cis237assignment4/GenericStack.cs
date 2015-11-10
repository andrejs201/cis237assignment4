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

            if (this.Head == null)
            {
                returnNode = null;
            }
            else
            {
                returnNode = this.Head;
                this.Head.Next = this.Head;
                this.Head.Previous = null;
                this.Length--;
            }

            return returnNode;
        }
    }
}
