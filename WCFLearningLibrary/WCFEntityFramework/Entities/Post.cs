using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Repository.Entities;

namespace EntityFramework.Entities
{
    public class Post:EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //This is required to have the db automatically generate the GUID primary key
        public override Guid ID { get; set; }

        public string Content { get; set; }

        public DateTime? CreationDate { get; set; }

        public Guid? CreatorId { get; set; }
        public virtual User Creator { get; set; }

        public Guid ThreadId { get; set; }
        public virtual Thread Thread { get; set; }

    }
}