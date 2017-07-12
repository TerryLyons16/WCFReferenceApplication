using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public abstract class EntityBase
    {
        public virtual Guid ID { get; set; }
    }
}
