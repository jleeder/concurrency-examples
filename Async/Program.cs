using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = Count(10);
            Task.WaitAll(tasks);
            Console.ReadLine();
        }

        static Task[] Count(int number) 
        {
            List<Task> printlist = new List<Task>();
            for (int i = 0; i < number; i++) 
            {
                printlist.Add(PrintAsync(i));                    
            }
            
            return printlist.ToArray();      
        }

        static async Task PrintAsync(int i) 
        {
            Random r = new Random();
            //await Task.Delay(TimeSpan.FromSeconds(r.Next(0, 5)));
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(r.Next(0, 5)));
            Console.WriteLine(i.ToString());
            return;
        }
    }
}
