using Softomate.Data;
using Softomate.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Softomate.Repo
{
    // класс для работы с данными. не зависимо от куда мы их берем,
    //в контроллер мы получим коллекцию типа People

    public class PeopleRepo  
    {
        SoftomateContext dbContext = new SoftomateContext();
        public PeopleRepo()
        { }
        public List<People> GetPeople()
        {
            //using (var dbContext = new SoftomateContext())
            //{
                return dbContext.People;
            //}
        }

        public void AddPeople(People people)
        {
            //using (var dbContext = new SoftomateContext())
            //{
                dbContext.People.Add(people);
               // dbContext.SaveChanges();
            //}
        }
    }
}
