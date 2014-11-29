using Freelancer.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Data.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IClaimRepository ClaimRepository { get; }
        IBankRepository BankRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IJobRepository JobRepository { get; }
        ISouscategoryRepository SouscategoryRepository { get; }
        IPaymentRepository PaymentRepository { get; }
        void Commit();
    }
}
