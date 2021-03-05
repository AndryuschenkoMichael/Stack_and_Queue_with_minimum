using System;
using System.Linq;

namespace StackAndQueueWithMinimum
{
    public class QueueMin<T> : IStruct<T> where T : IComparable
    {
        StackMin<T> forAdd = new StackMin<T>();
        StackMin<T> forRemove = new StackMin<T>();

        public int Count => forAdd.Count + forRemove.Count;

        public void Push(T value) => forAdd.Push(value);

        public void Pop()
        {
            if (forRemove.Count == 0)
            {
                T[] list = new T[forAdd.Count];

                while (forAdd.Count > 0)
                {
                    list[forAdd.Count - 1] = forAdd.Peek();
                    forAdd.Pop();
                }
                
                Array.Reverse(list);
                forRemove = new StackMin<T>(list);

                forRemove.Pop();
            }
            else
            {
                forRemove.Pop();
            }
        }

        public T GetMin()
        {
            if (forAdd.Count == 0)
            {
                return forRemove.GetMin();
            }

            if (forRemove.Count == 0)
            {
                return forAdd.GetMin();
            }

            return Min(forAdd.GetMin(), forRemove.GetMin());
        }

        public T Peek()
        {
            if (forRemove.Count == 0)
            {
                T[] list = new T[forAdd.Count];

                while (forAdd.Count > 0)
                {
                    list[forAdd.Count - 1] = forAdd.Peek();
                    forAdd.Pop();
                }
                
                Array.Reverse(list);
                forRemove = new StackMin<T>(list);

                return forRemove.Peek();
            }
            else
            {
                return forRemove.Peek();
            }
        }
        
        private T Min(T first, T second)
        {
            if (first.CompareTo(second) > 0)
            {
                return second;
            }
            else
            {
                return first;
            }
        }

        public QueueMin()
        {
            
        }

        public QueueMin(T[] values)
        {
            Array.ForEach(values, Push);
        }
    }
}