using Freelancer.Data.Infrastructure;
using Freelancer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Data.Repositories
{
    class JobRepository : RepositoryBase<job>, IJobRepository
    {
        public JobRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }

    }
    public interface IJobRepository : IRepository<job> { }
}
