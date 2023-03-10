//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DelegateDemo
//{
//    public delegate int MyDelegate(int a, int b);
//    public class user
//    {
//        public int Add(int a, int b)
//        {
//            return a + b;
//        }
//        public int Sub(int a, int b)
//        {
//            return a - b;
//        }
//        public int Mul(int a, int b)
//        {
//            return a * b;
//        }

//    }

//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            user u = new user();
//            MyDelegate myDelegate = new MyDelegate(u.Add);
//            myDelegate += new MyDelegate(u.Sub);
//            myDelegate += new MyDelegate(u.Mul);
//            Delegate[] list = myDelegate.GetInvocationList();
//            foreach (Delegate item in list)
//            {
//                Console.WriteLine(item.Method);
//                object result = item.DynamicInvoke(25, 30);
//                Console.WriteLine(result.ToString());
//            }
//        }

//    }
//}
