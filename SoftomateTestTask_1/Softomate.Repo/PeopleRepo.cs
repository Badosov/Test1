using Softomate.Data;
using Softomate.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softomate.Repo
{
    public class PeopleRepo
    {
        public List<People> GetPeople()
        {
            using (var dbContext = new SoftomateContext())
            {
                return dbContext.People.ToList();
            }
        }
    }
}
