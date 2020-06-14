using System;

namespace Examples1
{

    class Program
    {
        /// <summary>
        /// This is the main entry point of the app.
        /// It's where the app starts its execution.
        /// </summary>
        static void Main(string[] args)
        {
            //Creates a new person object
            var person = new Person();
            //Greetings to the user
            Console.WriteLine("Hello!");
            //Ask for the user to input data wait for it
            Console.WriteLine("Please enter your first name:");
            var name = Console.ReadLine();
            //Ask for the user to input data wait for it
            Console.WriteLine("Please enter your surname:");
            var surname = Console.ReadLine();
            //Ask for the user to input data wait for it
            Console.WriteLine("Now enter your age:");
            var age = Console.ReadLine();
            //Use the input data to set the object state
            person.FirstName = name;
            person.Surname = surname;
            //This line converts the age (text type) to an integer number
            person.Age = Convert.ToInt32(age);
            //Outputs the data to the user in a nice way :)
            Console.WriteLine("Nice to meet you {0} {1}. You said your age is {2}",
                person.FirstName, person.Surname, person.Age);
            //Keeps the program alive and wating for the user to type something
            //When the user does so, the program closes
            Console.Read();
        }
    }
}