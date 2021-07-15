using SolidPrinciples.SR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibility
{
    class PersonDAO
    {
        public bool InsertPerson(Person person)
        {
            // Insert person in a database table.
            return true;
        }
    }
}
