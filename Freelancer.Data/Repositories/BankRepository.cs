using Freelancer.Data.Infrastructure;
using Freelancer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Data.Repositories
{
    class BankRepository : RepositoryBase<bank>, IBankRepository
    {
        public BankRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }

    }
    public interface IBankRepository : IRepository<bank> { }
}
