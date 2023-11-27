using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingDemo
{
    class ThreadClassDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thread class demostration!");
            Thread currentThread = Thread.CurrentThread;
            currentThread.Name = "PrimaryThread";
            Console.WriteLine($"ID of current thread: {currentThread.ManagedThreadId}");
            Console.WriteLine($"Thread name: {currentThread.Name}");
            Console.WriteLine($"Has thread start?: {currentThread.IsAlive}");
            Console.WriteLine($"Priority level: {currentThread.Priority}");
            Console.WriteLine($"Thread state: {currentThread.ThreadState}");

        }
    }
}
