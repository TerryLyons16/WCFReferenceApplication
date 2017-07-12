using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Entities;
using EntityFramework.Interfaces;

namespace EntityFramework.Repositories
{
    public class ThreadRepository: Repository<Thread>,IThreadRepository
    {
        public ThreadRepository(ForumDBContext context):base(context)
        {

        }
    }
}
