using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    internal class animal
    {
        public string Name;
        public int Age;
        public string gender;
        public int Nooflegs;
        public void Eat()
        {
            Console.WriteLine("Eat method");
        }
    }
    internal class Dog:animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog bark");
        }
        public static void Main(string[] args) 
        {
            Dog lucie=new Dog();
            lucie.Bark();
            lucie.Name = "";
            lucie.Age = 3;
            lucie.gender = "f";
            lucie.Eat();
        }
    }
}

