using Softomate.Repo;
using Softomate.Data;
using Softomate.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SotomateColsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleRepo = new PeopleRepo().GetPeople();
            foreach(var person in peopleRepo)
            {
                Console.WriteLine(person.LastName + " " + person.FirstName + " " + person.Patronymic);
            }
            Console.ReadLine();
        }
    }
}
