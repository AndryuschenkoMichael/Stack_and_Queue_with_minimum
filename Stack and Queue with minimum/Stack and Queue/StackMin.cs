using System;
using System.Collections.Generic;

namespace StackAndQueueWithMinimum
{
    public class StackMin<T> : IStruct<T> where T : IComparable
    {
        Stack<(T Value, T Minimum)> stack = new Stack<(T Value, T Minimum)>();

        public int Count => stack.Count;
        
        public void Push(T value)
        {
            stack.Push(stack.Count == 0
                ? (Value: value, Minimum: value)
                : (Value: value, Minimum: Min(value, stack.Peek().Minimum)));
        }

        public void Pop() => stack.Pop();

        public T GetMin() => stack.Peek().Minimum;

        public T Peek() => stack.Peek().Value;
        
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

        public StackMin()
        {
            
        }

        public StackMin(T[] values)
        {
            Array.ForEach(values, Push);
        }
    }
}