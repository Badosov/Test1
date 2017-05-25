using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softomate.Entity
{
    public class PeopleMongo
    {
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public System.String _id { get; set; }
        public System.String FirstName { get; set; }
        public System.String LastName { get; set; }
        public System.String Patronymic { get; set; }
    }

    public class PeopleMongoMap : EntityTypeConfiguration<PeopleMongo>
    {
        public PeopleMongoMap()
        {
            this.ToTable("softomate");
            this.HasKey(PeopleMongo => PeopleMongo._id);
            this.Property(PeopleMongo => PeopleMongo.FirstName);
            this.Property(PeopleMongo => PeopleMongo.LastName);
            this.Property(PeopleMongo => PeopleMongo.Patronymic);
        }
    }
}
