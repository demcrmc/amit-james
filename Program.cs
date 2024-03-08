using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Animal animal1 = new Animal();
            animal1.Name = "Dog";
            animal1.Traits = "Friendly";
            animal1.Teeth = "Sharp";
            animal1.WhoAmI();


        Rectangle r1 = new Rectangle (34, 43);
        r1.CalculatePerimeter();


        }
    }


    class Animal
    {
        public string? Name { get; set; }
        public string? Traits { get; set; }
        public string? Teeth {get; set; } 

        //methods
        public void WhoAmI(){
            Console.WriteLine("I am Dog", Name);
            Console.WriteLine("My traits are Friendly", Traits);
            Console.WriteLine("I have a sharp teeth", Teeth);
        }

        public string Message(){
            return "this is my message";
        }
    }
}