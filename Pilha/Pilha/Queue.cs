using System;

namespace Pilha
{
    public class Queue
    {
        Position first;

        public void StackUp(object item) 
        {
            first = new Position(first, item);
        }

        public object UnStack() 
        {
            if(first == null)
            {
                throw new InvalidOperationException();
            }

            object resultado = first.item;
            first = first.Next;
            return resultado;

        }

        class Position
        {
            public Position Next;

            public object item;

            public Position(Position Next, object item)
            {
                this.Next = Next;
                this.item = item;
            }   
        }
    }
}