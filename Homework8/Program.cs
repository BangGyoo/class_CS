using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;

        public MyList()
        {
            array = new int[3];
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if(index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");

                }
                array[index] = value;
            }
        }

        public object Current
        {
            get
            {
                return array[position];
            }
        }

        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
            }
        }
    }
    class Indexer
    {
        private int[] array;
        public Indexer()
        {
            array = new int[3];
        }
        
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine("Array Resized : {0}", array.Length);
                }
                array[index] = value; 
            }
            
        }
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new Homework8.MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;


            foreach (int e in list)
                Console.WriteLine(e);

            Console.WriteLine("\n");
            ////////////////////////////////////// 8-1///////////////////////////////
            IEnumerator it = list.GetEnumerator();
            while (it.MoveNext())
            {
                //object x = list.GetEnumerator();
                //Console.WriteLine(x);
                Console.WriteLine(it.Current);
            }
            Console.WriteLine("\n");
            ///////////////////////////////////////8-2////////////////////////////////

            ArrayList ds1 = new ArrayList();
            ds1.Add(1);
            ds1.Add(2);
            ds1.Add(3);

            int cnt = ds1.Count;

            for(int i=0;i< cnt; i++)
            {
                Console.WriteLine(ds1[i]);
            }
            Console.WriteLine("\n");
            Stack ds2 = new Stack();
            ds2.Push(1);
            ds2.Push(2);
            ds2.Push(3);
            IEnumerator tmp = ds2.GetEnumerator();
            while (tmp.MoveNext())
            {
                Console.WriteLine(tmp.Current);
            }
            Console.WriteLine("\n");

            Queue ds3 = new Queue();
            ds3.Enqueue(1);
            ds3.Enqueue(2);
            ds3.Enqueue(3);
            tmp = ds3.GetEnumerator();
            while (tmp.MoveNext())
            {
                Console.WriteLine(tmp.Current);
            }
            Console.WriteLine("\n");

            Hashtable ds4 = new Hashtable();
            ds4.Add(1, "apple");
            ds4.Add(2, "banana");
            ds4.Add(3, "melon");
            IDictionaryEnumerator tmp2 = ds4.GetEnumerator();
            while (tmp2.MoveNext())
            {
                Console.WriteLine("Key : " + tmp2.Key + " Value : " + tmp2.Value);
            } 
            Console.WriteLine("\n");


            ///////////////////////////////////////8-3////////////////////////////////////////
            Indexer idx = new Indexer();
            for (int i = 0; i < 5; i++)
                idx[i] = i;
            //foreach (int e in idx)
            //    Console.WriteLine(e);
        }
    }
}
