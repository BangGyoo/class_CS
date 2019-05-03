using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_2
{
    class Program
    {
        class Zookeeper
        {
            public void Wash(Mammal target)
            {
                Console.WriteLine(target.GetType().Name + "을 wash 합니다.");
            }
        }
        class Mammal { }
        class Dog : Mammal { }
        class Cat : Mammal { }
        class Elephant : Mammal { }
        class Lion : Mammal { }

        static void Main(string[] args)
        {
            Mammal dog = new Dog();
            Mammal cat = new Cat();
            Elephant elephant = new Elephant();
            Lion lion = new Lion();

            Zookeeper keeper = new Zookeeper();
            keeper.Wash(dog);
            keeper.Wash(cat);
            keeper.Wash(elephant);
            keeper.Wash(lion);

        }
    }
}
