using System;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person=new Human("Jenifer","Lopez",25,"Brown");

            person.Introduce();
            person.AddNumbers(person.Age,100);
        }
    }


}
