using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{ 
    class Animal
    {
        public string name;
        public string gender;
        public int age;
        
        public void Eat()
        {
            Console.WriteLine($"This is a {name} he is {gender}");
        }
    }
    class Human
    {
        public string name;
        public int phone;
        public int age;


        public void Run()
        {
            Console.WriteLine($"My name is {name} and my age is {age}");
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.name = "Cat";
        
    
            animal.gender = "male";
            animal.age = 2;
            animal.Eat();

            Human human = new Human();
            human.name = "Affan";
            human.phone = 12341534;
            human.age = 13;
            human.Run();
            



            Console.ReadKey();

        }
    }
}
