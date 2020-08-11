using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class CirclularLinkedListValidator 
    {
        public bool isLinkedListInfinite<T>(LinkedList<T> linkedList)
        {
            LinkedListNode<T> position1 = linkedList.First;
            LinkedListNode<T> position2 = (linkedList.First);
            while (position1 != null && position2 != null && position2.Next != null)
            {
                position1 = position1.Next;
                position2 = position2.Next.Next;
                if (position1 == position2)
                    return true;
            }
            return false;
        }
        public bool IsCircular<T>(LinkedList<T> linkedList)
        {
            throw new NotImplementedException();
        }
    }
}
