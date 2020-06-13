using System;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person=new Human();
            person.Name = "Jenifer";
            person.Surname = "Lopez";
            person.Age = 25;
            person.EyeColor = "Brown";
            person.Introduce();
            person.Name = "Anna";
            person.Introduce();
        }
    }


}
