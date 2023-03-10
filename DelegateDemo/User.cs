//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Remoting.Messaging;
//using System.Text;
//using System.Threading.Tasks;

//namespace DelegateDemo
//{
//    public delegate void MyDelegate();
//    public class Bank
//    {
//        public event MyDelegate Nobal;
//        public event MyDelegate Lowbal;
//        int totalamt;
//        public int bal = 6000;

//        public void credit(int x)
//        {
//            totalamt = bal + x;
//            Console.WriteLine($"updated balance is:{totalamt}");
//        }
//        public void debt(int x)
//        {

//            totalamt = bal - x;
//            if (totalamt == 0)
//            {
//                Nobal();
//            }
//            else if (totalamt > 3000)
//            {
//                Console.WriteLine($"Sufficient Balance:{totalamt}");
//            }
//            else
//            {
//                Lowbal();
//            }
//        }
//    }
//        public class Program
//        {
//            static void Message1()
//            {
//                Console.WriteLine("Balance not available");
//            }
//            static void Message2()
//            {
//                Console.WriteLine("Balance is less than 3000");
//            }

//            static void Main(string[] args)
//            {
//                Bank b = new Bank();
//                b.Nobal += new MyDelegate(Message1);
//                b.Lowbal += new MyDelegate(Message2);
//                b.debt(3000);
//            }
//        }
    
//}
