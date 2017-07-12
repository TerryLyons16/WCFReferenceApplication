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
    public class Thread:EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //This is required to have the db automatically generate the GUID primary key
        public override Guid ID { get; set; }

        public string Title { get; set; }

        public DateTime? CreationDate { get; set; } //Must be nullable to prevent datetime conversion error

        public Guid? CreatorId { get; set; } //Set to nullable to prevent cascading delete exception
        public virtual User Creator { get; set; }


        public virtual List<Post> Posts { get; set; }

    }
}
