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
    public class Relation
    {
        private RelationType RelationshipType;

        public Relation(RelationType relation_in)
        {
            this.RelationshipType = relation_in;
        }

        public string ShowRelationship(Person person1, Person person2)
        {
            return $"Relationship between {person1.firstName} and {person2.firstName} is: {this.RelationshipType}hood";
        }
    }
}

public enum RelationType
{
    Sister, Brother, Mother, Father
}