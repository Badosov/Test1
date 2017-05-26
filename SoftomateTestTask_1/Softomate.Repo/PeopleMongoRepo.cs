//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Softomate.Data;
//using System.Runtime.Remoting.Contexts;
//using System.Data.Entity;
//using System.Web.UI.WebControls;
//using Softomate.Entity;

//namespace Softomate.Repo
//{
//    public class PeopleMongoRepo
//    {
//        public object GetPeople()
//        {
//            SoftomateMongoContext context = new SoftomateMongoContext();
//            context.Configuration.UseDatabaseNullSemantics = true;
//            var query = from line in context.PeopleMongo select line;
//            return context.PeopleMongo;
//            return query;
//        }
      
//    }
//}
