using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimpleThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart start = new ThreadStart(Counting);
            Thread first = new Thread(start);
            Thread second = new Thread(start);
            first.Start();
            second.Start();
            first.Join();
            second.Join();
            Console.Read();
        }

        static void Counting()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Line : {0}, Thread id : {1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
        }
    }
}
