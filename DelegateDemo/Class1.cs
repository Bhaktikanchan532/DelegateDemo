//using Microsoft.Win32;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////Accept name from user in a constructor and print name if name isempty or null
////then raise an event that"name is require"
//namespace DelegateDemo
//{
//    public delegate void MyDelegate();
//    public class Student
//    {
//        public event MyDelegate Emptyname;
        
//        public string name;

//        public void Acceptname(string nm)
//        {
//            if (string.IsNullOrEmpty(nm))
//            {
//                Emptyname();
//            }
//            else
//            {
//                Console.WriteLine($"Name:{nm}");
//            }
//        }


//        public class Program
//        {
//            static void Message1()
//            {
//                Console.WriteLine("String is Empty");

//            }         
//            static void Main(string[] args)
//            {
//                Student s = new Student();
//                s.Emptyname += new MyDelegate(Message1);
//                    s.Acceptname("Riya");
//            }
//        }
//    }
//}
