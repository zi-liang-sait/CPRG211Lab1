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
        public int personId;
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public int age;
        public bool isWorking;

        public Person(int personId_in, string firstName_in, string lastName_in, string favoriteColour_in, int age_in, bool isWorking_in)
        {
            this.personId = personId_in;
            this.firstName = firstName_in;
            this.lastName = lastName_in;
            this.favoriteColour = favoriteColour_in;
            this.age = age_in;
            this.isWorking = isWorking_in;
        }

        public string DisplayPersonInfo()
        {
            return $"{this.personId}: {this.firstName} {this.lastName}'s favorite color is {this.favoriteColour}";
        }

        public void ChangeFavoriteColour(string colour_in)
        {
            this.favoriteColour = colour_in;
        }

        public string GetAgeInTenYears()
        {
            return $"{this.firstName} {this.lastName}'s Age in 10 years is: {this.age + 10}";
        }        

        public override string ToString()
        {
            return $"PersonId: {this.personId}\n" +
                $"FirstName: {this.firstName}\n" +
                $"LastName: {this.lastName}\n" +
                $"FavoriteColour: {this.favoriteColour}\n" +
                $"Age: {this.age}\n" +
                $"IsWorking: {this.isWorking}\n";
        }
    }
}
