using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadConsoleApp
{
    class Program
    {   
        public static void CallNewThread()
        {
            Console.WriteLine("A new child thread will start right now...");

            int sleeping = 1000; // the thread will pause for 1 second
            Console.WriteLine("Child Thread will pause for {0} seconds", sleeping / 1000);
            Thread.Sleep(sleeping);
            Console.WriteLine("Now the thread is back from sleeping.");

        }
            
        static void Main(string[] args)
        {
            ThreadStart child = new ThreadStart(CallNewThread);
            Console.WriteLine("Main Method: A child thread is being created...");
            Thread childThread = new Thread(child);
            childThread.Start();
            Console.ReadKey();

        }
    }
}
