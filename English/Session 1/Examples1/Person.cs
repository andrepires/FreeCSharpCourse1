//References to other libraries
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// This is a namespace. Think of it as the drawers of your wardrobe.
/// It serves as a way to keep your types organised.
/// </summary>
namespace Examples1
{
    /// <summary>
    /// Defines a new Person type
    /// </summary>
    public class Person
    {
        public string FirstName { get; internal set; }
        public string Surname { get; internal set; }
        public int Age { get; internal set; }
    }
}