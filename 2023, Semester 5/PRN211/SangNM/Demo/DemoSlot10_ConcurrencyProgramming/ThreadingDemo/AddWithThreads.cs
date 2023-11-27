using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingDemo
{
    class AddParams
    {
        public int a, b;
        public AddParams(int numb1, int numb2)
        {
            a = numb1;
            b = numb2;
        }
        
    }
    class AddWithThreads
    {
        static void Main(string[] args)
        {
            AutoResetEvent _waitHandle = new AutoResetEvent(false);
            Console.WriteLine("***** Adding with Thread objects *****");
            Console.WriteLine("ID of thread in Main(): {0}",
            Thread.CurrentThread.ManagedThreadId);
            AddParams ap1 = new AddParams(10, 10);
            Thread t1 = new Thread(new ParameterizedThreadStart(Add));
            t1.Start(ap1);
            // Wait here until you are notified!
            _waitHandle.WaitOne();
            Console.WriteLine("Other thread is done!");
            Console.ReadLine();

            void Add(object data)
            {
                if (data is AddParams ap)
                {
                    //Add in sleep to show the background thread getting terminated
                    Thread.Sleep(10);

                    Console.WriteLine("ID of thread in Add(): {0}",
                        Thread.CurrentThread.ManagedThreadId);

                    Console.WriteLine("{0} + {1} is {2}",
                        ap.a, ap.b, ap.a + ap.b);

                    // Tell other thread we are done.
                    _waitHandle.Set();
                }
            }
        }

    }
}
