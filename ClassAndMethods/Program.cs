using System;
using ClassAndMethods;

namespace ClassAndMethods
{
    public class Person
    {
        public string Name;
        public int Age;
        public bool HasPet;

        public void Greeting()
        {
            Console.WriteLine("Hi! My name is " + Name + " and my age is " + Age);
        }

        /*public int Calc(int x, int y)
        {
            int number = x + y;
            return number;

        }*/
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "John";
            person.Age = 28;
            person.HasPet = true;

            person.Greeting();
        }
    }


}
