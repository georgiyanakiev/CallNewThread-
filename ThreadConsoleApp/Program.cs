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

            try
            {
                Console.WriteLine("A new child thread will start right now...");
                for (int i = 0; i > 10; i++) { 
                    Thread.Sleep(1000);
                Console.WriteLine(i);
                }
                Console.WriteLine("Child Thread is finally completed.");
            }
            catch(ThreadAbortException e )
            {
                Console.WriteLine("Thread Abort Exception.");
            }
            finally
            {
                Console.WriteLine("Thread isn't catched by Exception");
            }

            //int sleeping = 3000; // the thread will pause for 3 seconds
            //Console.WriteLine("Child Thread will pause for {0} seconds", sleeping / 1000);
            //Thread.Sleep(sleeping);
            //Console.WriteLine("Now the thread is back from sleeping.");

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
