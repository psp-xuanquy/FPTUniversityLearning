﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingDemo
{
    class MultiThreadPrinting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Synchronizing Threads *****\n");

            Printer p = new Printer();

            // Make 10 threads that are all pointing to the same
            // method on the same object.
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ThreadStart(p.PrintNumbers))
                {
                    Name = $"Worker thread #{i}"
                };
            }

            // Now start each one.
            foreach (Thread t in threads)
            {
                t.Start();
            }

            System.Console.WriteLine("Using Interlocked");
            int intVal = 5;
            object myLockToken = new();
            lock (myLockToken)
            {
                intVal++;
            }
            System.Console.WriteLine(intVal);
            Interlocked.Increment(ref intVal);
            System.Console.WriteLine(intVal);

            Console.ReadLine();
        }
    }

    public class Printer1
    {
        // Lock token.
        private object threadLock = new object();

        public void PrintNumbers()
        {
            //use lock tokent
            //lock (threadLock)
            Monitor.Enter(threadLock);
            try
            {
                // Display Thread info.
                Console.WriteLine("-> {0} is executing PrintNumbers()",
                    Thread.CurrentThread.Name);

                // Print out numbers.
                for (int i = 0; i < 10; i++)
                {
                    // Put thread to sleep for a random amount of time.
                    Random r = new Random();
                    Thread.Sleep(1000 * r.Next(5));
                    Console.Write("{0}, ", i);
                }

                Console.WriteLine();
            }
            finally
            {
                Monitor.Exit(threadLock);
            }
        }
    }
}
