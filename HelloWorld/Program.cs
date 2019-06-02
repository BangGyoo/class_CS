using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

    class Program
    {
        public class Base
        {
            protected internal string name;
            public Base()
            {
                this.name = "good";
            }

        }
        class Der : Base
        {
            public Der(string name) : base()
            {
                Console.WriteLine(name);
            }
        }

        static void Main(string[] args)
        {
            int x=50;
            Console.WriteLine("hello world");

            Der y = new Der("hello world ~~~");


        }
        public static int Swap(int a=1,int b=1,int c=1, int result=10)
        {
            c = 2;
            int temp;
            temp = a;
            a = b;
            b = temp;
            result = 5;
            return a;
        }
        public static int Add(params int[] args)
        {
            int temp = 0;
            foreach(int arg in args)
            {
                temp += arg;
            }
            return temp;
        }
    }
    
}
