using System;

namespace StackAndQueueWithMinimum
{
    public interface IStruct<T> where T : IComparable
    {
        void Push(T value);
        
        void Pop();

        T GetMin();

        T Peek();
        
        int Count { get; }
    }
}