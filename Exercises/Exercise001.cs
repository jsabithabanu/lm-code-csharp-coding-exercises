using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {           
            return word is null ? null 
                : word == " " ? " " 
                : word == string.Empty ? string.Empty
                //Capitalizing the first character of the first word and appending the rest to it
                : string.Concat(word[0].ToString().ToUpper(), word.AsSpan(1).ToString());
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            /* Capitalizing the first character of firstname, lastname
            and adding a "." between them */
            return firstName.Substring(0, 1) + "." + lastName.Substring(0, 1);
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            //Checking if original price is -ve
            if (originalPrice < 0)
            {
                throw new ArgumentException("Price cannot be negative. Please enter a valid price.");
            }
            //Checking if vat rate is -ve
            else if (vatRate < 0)
            {
                throw new ArgumentException("VAT cannot be negative. Please enter a valid VAT.");
            }
            else
            {
                //Calculating vat percentage and vat included price
                var vatPercentage = Math.Round((originalPrice * vatRate) / 100, 2);
                var vatIncludedPrice = originalPrice + vatPercentage;
                return vatIncludedPrice;
            }            
        }

        public string Reverse(string sentence)
        {
            if (sentence is null) //Sentence is null
                return null;
            else if (sentence == " ") //Sentence is a whitespace " "
                return " ";
            else
            {
                //Reversing the sentence or word 
                char[] charArrayOfSentence = sentence.ToCharArray();
                Array.Reverse(charArrayOfSentence);
                return new string(charArrayOfSentence);
            }

        }

        public int CountLinuxUsers(List<User> users)
        {
            var linuxUserCount = 0;
            if (users == null || (!users.Any()))
            {
                //Linux user count is Null or Empty
                return linuxUserCount;
            }
            else
            {
                //Finding the users count whose Type is "Linux" (i.e) Linux users
                users.ForEach (i => 
                { if (i.Type.Equals("Linux"))
                        linuxUserCount++;
                } );
                return linuxUserCount;
            }
        }
    }
}
