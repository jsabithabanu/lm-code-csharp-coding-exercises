using System;
using Exercises.Models;
namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person person)

           /* If person is null -> false
            *  person is from Manchester -> true
            *  person is not from Manchester -> false */

           => person != null && person.City == "Manchester";
       

        public bool CanWatchFilm(Person person, int ageLimit)

            //People with age equal to or above the age limit can watch film
            => person.Age >= ageLimit;

    }
}
