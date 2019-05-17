using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    abstract class AbstractDisplay
    {
        //protected virtual void Print() { }
        //protected virtual void Open() { }
        //protected virtual void Close() { }

        protected abstract void Print();
        protected abstract void Open();
        protected abstract void Close();

        public void Write(char ch)
        {
            for (int i = 0; i < 5; i++)
                Console.Write(ch);
        }
        public void Write(string str)
        {
            Console.Write(str);
        }
        public void Display()     // 탬플릿 메소드 패턴 
        {
            Open();
            Print();
            Close();
            
        }

    }
    class CharDisplay : AbstractDisplay
    {
        private char ch;
        public CharDisplay(char ch)
        {
            this.ch = ch;
        }
        protected override void Open() { Write("<<"); }
        protected override void Print() { Write(ch); }
        protected override void Close() { Write(">>"); }

    }
    class StringDisplay : AbstractDisplay
    {
        private string str;
        private int width;
        public StringDisplay(string str)
        {
            this.str = str;
            this.width = str.Length;
        }
        protected override void Open() { PrintLine(); }
        protected override void Print() { Write("|" + str + "|"); }
        protected override void Close() { PrintLine();  }
        void PrintLine()
        {
            Write("+");
            for(int i = 0; i < width; i++)
            {
                Write("-");
            }
            Write("+");
            
        }
        
    }


    class Program
    {

        static void Main(string[] args)
        {
            AbstractDisplay d1 = new CharDisplay('H');
            AbstractDisplay d2 = new StringDisplay("Hello, world!");
            d1.Display();
            d2.Display();
        }
    }
}
