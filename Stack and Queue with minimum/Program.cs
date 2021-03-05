using System;
using StackAndQueueWithMinimum;

namespace Stack_and_Queue_with_minimum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IStruct<int> kek = new QueueMin<int>(new []
            {
                13, 25, 31, 34, 25, 16, 27, 8
            });

            Console.WriteLine(kek.Peek());

            kek.Pop();

            Console.WriteLine(kek.Peek());

            kek.Push(9);

            Console.WriteLine(kek.Peek());
        }
    }
}