using System;
using System.Threading;

namespace DelegateDemo
{
    public class Tasks
    {
        public void Display1to5()
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine(thread.Name);
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }

        public void Display6to10()
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine(thread.Name);
            for (int i = 6; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
    }
 public class Program
    {
        static void Main(string[] args)
        {
            Tasks task1 = new Tasks();
            Thread t1 = new Thread(new ThreadStart(task1.Display1to5));
            Thread t2 = new Thread(new ThreadStart(task1.Display6to10));
            t1.Name = "Display1-5";
            t2.Name = "Display6-10";
            t1.Start();
            t2.Start();
        }
    }

}
