using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharitence
{ class Animal
    {
        public string name;
        public int age;
        public void Eat()
        {
            Console.WriteLine($"My Animal is strong");
        }
    }
    class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine($"my dog is {name} and he is {age} year old");
        }
    }
    class Cat : Animal
    {
        public void meow()
        {
            Console.WriteLine($"my cat age is {age} and she says meow meow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            dog.name = "bulldog";
            dog.age = 3;
            cat.age = 4;
            dog.bark();
            cat.meow();
            Console.ReadKey();
        }
    }
}
