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
    public class User:EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //This is required to have the db automatically generate the GUID primary key
        public override Guid ID { get; set; }

        public string Username { get; set; }

        public UserTypeEnum UserType { get; set; }

        public DateTime? JoinDate { get; set; }

        public virtual List<Post> Posts { get; set; }

        public virtual List<Thread> Threads { get; set; }
    }
}
