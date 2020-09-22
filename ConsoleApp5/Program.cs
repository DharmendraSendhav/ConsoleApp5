using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static Stopwatch stopwatch = new Stopwatch();
        static void Main(string[] args)
        {
            
            Program p = new Program();
            p.DispTask();
           
            Console.WriteLine("Pull request dharmendra" + Thread.CurrentThread.ManagedThreadId);

            Console.ReadLine();
        }

        public void DispTask()
        {

            Console.WriteLine("disp" + Thread.CurrentThread.ManagedThreadId);
            Task t = test();
         //   t.Wait(100077);
           
            // using await control will go to caller method and here it will suspend . once task completed again control will be here.
            //await t;
            
            Console.WriteLine("disp after vali "+Thread.CurrentThread.ManagedThreadId);
        }

        public async Task test()
        {
           // stopwatch.Start();
            // using await control will go to caller method (DispTask) and here it will suspend . once task completed again control will be here.
            await Task.Delay(5000);
            stopwatch.Stop();
            Console.WriteLine("test "+Thread.CurrentThread.ManagedThreadId+" elapsed time"+stopwatch.ElapsedMilliseconds);
        }

    }
}
