using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class Moniter
    {
        public IBorder border;
        public Moniter(IBorder border)
        {
            this.border = border;
        }
        public void start()
        {
            border.WriteBorder();
        }
    }

    public interface IBorder
    {
        void WriteBorder();
    }
    public class Star : IBorder
    {
        public void WriteBorder()
        {
            Console.WriteLine("**************");
            Console.WriteLine("*Hello World!*");
            Console.WriteLine("**************");
        }
    }
    public class Slash : IBorder
    {
        public void WriteBorder()
        {
            Console.WriteLine("//////////////");
            Console.WriteLine("/Hello World!/");
            Console.WriteLine("//////////////");
        }
    }
    public class Wave : IBorder
    {
        public void WriteBorder()
        {
            Console.WriteLine("~~~~~~~~~~~~~~");
            Console.WriteLine("~Hello World!~");
            Console.WriteLine("~~~~~~~~~~~~~~");
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            Wave wave = new Wave();
            Moniter hello1 = new Moniter(wave);
            hello1.start();
            Moniter hello2 = new Moniter(new Star());
            hello2.start();
            Moniter hello3 = new Moniter(new Slash());
            hello3.start();

        }
    }
}
