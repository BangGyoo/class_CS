using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class program
    {
        delegate int? MyDivide(int a, int b);
        delegate void MyDivide2(int a, int b);

        static void Main(string[] args)
        {
            MyDivide myFunc = delegate (int a, int b)
            {
                if (b == 0)
                {
                    return null;
                }

                return a / b;
            };
            MyDivide2 myFunc2 = delegate (int a, int b)
            {
                if (b == 0)
                {
                    Console.WriteLine("{0}/{1} == {2}", a, b, null);
                }
                else
                {
                    Console.WriteLine("{0}/{1} == {2}", a, b, a / b);
                }
            };
            Console.WriteLine("------------Func delegete----------");
            Console.WriteLine("{0}/{1} == {2}", 10, 2, myFunc(10,2));
            Console.WriteLine("{0}/{1} == {2}", 10, 0, myFunc(10, 0));
            Console.WriteLine("-----------Action Delegate---------");
            myFunc2(10 , 2);
            myFunc2(10 , 0);


            // 여기에 10 / 2 == 5     와 같이 출력되도록 write 문 완성할 것.
            // 여기에 10 / 0 ==        와 같이 출력되도록 write 문 완성할 것.

        }
    }

}
