using Freelancer.Data.Infrastructure;
using Freelancer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Data.Repositories
{
    class PaymentRepository : RepositoryBase<payment>, IPaymentRepository
    {
        public PaymentRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }

    }
    public interface IPaymentRepository : IRepository<payment> { }
}
