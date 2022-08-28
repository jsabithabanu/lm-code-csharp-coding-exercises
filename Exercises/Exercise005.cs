using System;
using System.Drawing;
using System.Linq;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            const string ALPHABETS = "abcdefghijklmnopqrstuvwxyz";

            //Checks if the input is null or empty and also whether it is a panagram
            return !string.IsNullOrEmpty(input) &&  ALPHABETS.All(input.ToLower().Contains) ;
                     
        }
    }
}
