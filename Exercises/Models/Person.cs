using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Models
{
    public class Person
    {
        public Person(string firstName, string lastName, string city, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Age = age;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public int Age { get; set; }
     }
    
}
