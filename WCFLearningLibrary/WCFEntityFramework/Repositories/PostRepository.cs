using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Entities;
using EntityFramework.Interfaces;

namespace EntityFramework.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(ForumDBContext context):base(context)
        {

        }

    }
}
