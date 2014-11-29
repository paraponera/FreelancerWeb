using Freelancer.Data.Infrastructure;
using Freelancer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Data.Repositories
{
    class SouscategoryRepository : RepositoryBase<sous_categories>, ISouscategoryRepository
    {
        public SouscategoryRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }

    }
    public interface ISouscategoryRepository : IRepository<sous_categories> { }
}
