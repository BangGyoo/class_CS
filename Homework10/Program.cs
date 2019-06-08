using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Homework10
//{
//    delegate void MyDelegate(int a);

//    class Market
//    {
//        public event MyDelegate CustomerEvent;

//        public void BuySomething(int CustomerNo)
//        {
//            if (CustomerNo == 30)
//                CustomerEvent(CustomerNo);
//        }
//    }

//    class Program
//    {
//        private static void Event(int a)        // 해당 추가
//        {
//            Console.WriteLine(a);
//        }

//        static void Main(string[] args)
//        {

//            Market market = new Market();
//            market.CustomerEvent += new MyDelegate(Event);

//            for (int customerNo = 0; customerNo < 100; customerNo += 10)
//                market.BuySomething(customerNo);
//        }
//    }
//}



namespace Homework10
{
    public class EventForm : Form
    {
        public EventForm()
        {
            this.Click += new EventHandler(ClickReceive);

        }
        private void ClickReceive(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new EventForm());
        }
    }
}

