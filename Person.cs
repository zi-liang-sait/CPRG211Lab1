//CPRG 211 F Lab 1 - Creating Classes
//Michael (Zi) Liang 000921925
//Jan 17, 2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211Lab1
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColour { get; set; }
        public int Age { get; set; }
        public bool IsWorking { get; set; }

        public Person(int personId_in, string firstName_in, string lastName_in, string favoriteColour_in, int age_in, bool isWorking_in)
        {
            this.PersonId = personId_in;
            this.FirstName = firstName_in;
            this.LastName = lastName_in;
            this.FavoriteColour = favoriteColour_in;
            this.Age = age_in;
            this.IsWorking = isWorking_in;
        }

        public string DisplayPersonInfo()
        {
            return $"{this.PersonId}: {this.FirstName} {this.LastName}'s favorite color is {this.FavoriteColour}";
        }

        public void ChangeFavoriteColour(string colour_in)
        {
            this.FavoriteColour = colour_in;
        }

        public string GetAgeInTenYears()
        {
            return $"{this.FirstName} {this.LastName}'s Age in 10 years is: {this.Age + 10}";
        }        

        public override string ToString()
        {
            return $"PersonId: {this.PersonId}\n" +
                $"FirstName: {this.FirstName}\n" +
                $"LastName: {this.LastName}\n" +
                $"FavoriteColour: {this.FavoriteColour}\n" +
                $"Age: {this.Age}\n" +
                $"IsWorking: {this.IsWorking}\n";
        }
    }
}
