using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

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

        
        public void Display()     // 탬플릿 메소드 패턴 
        {
            Open();
            for(int i=0; i<5; i++) Print();
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
        protected override void Close() { Write(">>\n"); }

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
        protected override void Print() { Write("|" + str + "|\n"); }
        protected override void Close() { PrintLine();  }
        void PrintLine()
        {
            Write("+");
            for(int i = 0; i < width; i++)
            {
                Write("-");
            }
            Write("+\n");
            
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
