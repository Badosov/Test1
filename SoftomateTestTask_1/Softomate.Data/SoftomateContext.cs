using Softomate.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softomate.Data
{

    //класс просто что бы вытащитьданные из базы
    
    public class SoftomateContext //: DbContext
    {
        static List<People> data;
        public SoftomateContext() //: base(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=DataDirectory\SOFTOMATEDB.MDF;Integrated Security=True")
        {
            if (data == null)
            {
                People = new List<People>();
                data = People;
            }
            else
                People = data;
        }
        
        public virtual List<People> People { get; set; } //это типо хранилище данных

    //this from connect SQL base
    //public SoftomateContext() //: base(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=DataDirectory\SOFTOMATEDB.MDF;Integrated Security=True")
    //{

    //}

    // public virtual DbSet<People> People { get; set; }


    }
}
