using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softomate.Entity
{
    [Table("People")]
    public class People
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string Patronymic { get; set; }

        public People()
        { }

        public People(string LastName, string FirstName, string Patronymic)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Patronymic = Patronymic;
        }
    }
}
