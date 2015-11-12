using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericLinkedList<T>
    {
        public GenericNode<T> Tail
        { get; set; }

        public GenericNode<T> Head
        { get; set; }

        public int Length
        { get; set; }

        public GenericLinkedList()
        {
            Head = null;
            Tail = null;
            Length = 0;
        }

        public void Add(T content)
        {
            GenericNode<T> newNode = new GenericNode<T>();
            newNode.Data = content;

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                Length++;
            }
            else
            {
                Head.Previous = newNode;
                newNode.Next = Head;
                Head = newNode;
                Length++;
            }
        }
    }
}
