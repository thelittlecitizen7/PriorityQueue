using PriorityQueue.Abstract;
using System;

namespace PriorityQueueRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PriorityQueue<char> pp = new PriorityQueue<char>();

            pp.Enqueue(8, 'v');
            pp.Enqueue(2, 'D');
            pp.Enqueue(6, 'G');
            pp.Enqueue(5, 'R');

            pp.Dequeue();
            
            Console.WriteLine(pp.Count);



        }



    }

    
}
