//References to other libraries
using System;

/// <summary>
/// This is a namespace. Think of it as the drawers of your wardrobe.
/// It serves as a way to keep your types organised.
/// </summary>
namespace Examples2
{
    /// <summary>
    /// Defines a new Calculator type
    /// </summary>
    public class Calculator
    {
        //This defines two properties of numeric decimal type to hold numbers.
        public decimal X { get; set; }
        public decimal Y { get; set; }

        //This is a default constructor
        public Calculator()
        {
            //And currently is doing nothing and can be removed
        }

        //This is a custom constructor method
        //Note the input parameters
        public Calculator(decimal x, decimal y)
        {
            //This gets the values coming with the parameters
            //and set these values to our properties.
            //This way the values can be used later by other operations
            X = x;
            Y = y;
        }

        //Defines a custom method that executes some operations
        public void PrintSum()
        {
            //Defines a variable to hold the sum of X and Y
            //Note the use of the arithmetic operator +
            var sum = X + Y;
            //Outputs the sum
            Console.WriteLine("The sum of X and Y is: {0}", sum);
        }

        //Defines another method to execute some more operations
        public void PrintSubtraction()
        {
            //Note the use of the arithmetic operator -
            var subtraction = X - Y;
            //Outputs the subtraction
            Console.WriteLine("The subtraction of Y from X is: {0}", subtraction);
        }
    }
}