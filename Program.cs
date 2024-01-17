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
    class Program
    {
        static void Main(string[] args)
        {
            //Create people
            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            //Display Gina's info as a sentence
            Console.WriteLine(person2.DisplayPersonInfo());

            //Display Mike's info as a list
            Console.WriteLine(person3);

            //Change Ian's favorite colour to white then display Ian's info as a sentence
            person1.ChangeFavoriteColour("White");
            Console.WriteLine(person1.DisplayPersonInfo());

            //Display Mary's age in 10 years
            Console.WriteLine(person4.GetAgeInTenYears());

            //Create relations
            Relation relation1 = new Relation(RelationType.Sister);
            Relation relation2 = new Relation(RelationType.Brother);

            //Display relations
            Console.WriteLine(relation1.ShowRelationship(person2, person4));
            Console.WriteLine(relation2.ShowRelationship(person1, person3));

            //Add people to list
            List<Person> ListOfPeople = new List<Person>
            {
                person1,
                person2,
                person3,
                person4,
            };

            //Display average age
            float sumAges = 0; //float to enable non-inter division
            float numPeople = 0;
            for (int i = 0; i < ListOfPeople.Count; i++)
            {
                sumAges += ListOfPeople[i].age;
                numPeople++;
            }
            float averageAge = sumAges / numPeople;
            Console.WriteLine($"Average age is: {averageAge}");

            //Display youngest and oldest people
            int youngestAge = Int32.MaxValue;  //https://learn.microsoft.com/en-us/dotnet/api/system.int32.maxvalue?view=net-8.0
            Person youngestPerson = null; //Initialize to null - from ChatGPT
            int oldestAge = 0;
            Person oldestPerson = null; //Initialize to null - from ChatGPT
            for (int i = 0; i < ListOfPeople.Count; i++)
            {
                if (ListOfPeople[i].age < youngestAge)
                {
                    youngestAge = ListOfPeople[i].age;
                    youngestPerson = ListOfPeople[i];
                }
                if (ListOfPeople[i].age > oldestAge)
                {
                    oldestAge = ListOfPeople[i].age;
                    oldestPerson = ListOfPeople[i];
                }
            }
            Console.WriteLine($"The youngest person is: {youngestPerson.firstName}");
            Console.WriteLine($"The youngest person is: {oldestPerson.firstName}");

            //Display people whose first names start with M
            for (int i = 0; i < ListOfPeople.Count; i++)
            {
                if (ListOfPeople[i].firstName.StartsWith("M"))
                {
                    Console.WriteLine(ListOfPeople[i]);
                }
            }

            //Display people who likes Blue
            for (int i = 0; i < ListOfPeople.Count; i++)
            {
                if (ListOfPeople[i].favoriteColour == "Blue")
                {
                    Console.WriteLine(ListOfPeople[i]);
                }
            }
        }
    }
}
