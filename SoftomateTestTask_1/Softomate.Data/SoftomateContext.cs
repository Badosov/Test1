using Softomate.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softomate.Data
{
    public class SoftomateContext : DbContext
    {
        public SoftomateContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB; Integrated Security=True")
        {

        }

        public virtual DbSet<People> People { get; set; }
    }
}
