using Freelancer.Data.Models;
using Freelancer.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private pidevContext dataContext;
        IDatabaseFactory dbFactory;

        private IUserRepository userRepository;
        private IClaimRepository claimRepository;
        private IBankRepository bankRepository;
        private ICategoryRepository categoryRepository;
        private IJobRepository jobRepository;
        private ISouscategoryRepository souscategoryRepository;
        private IPaymentRepository paymentRepository;



        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public IUserRepository UserRepository
        {
            get { return userRepository = new UserRepository(dbFactory); }
        }

        protected pidevContext DataContext
        {
            get
            {
                return dataContext = dbFactory.DataContext;
            }
        }
        public void Commit()
        {
            DataContext.SaveChanges();
        }
        public void Dispose()
        {
            dbFactory.Dispose();
        }

        public IClaimRepository ClaimRepository
        {
            get { return claimRepository = new ClaimRepository(dbFactory); }
        }

        public IBankRepository BankRepository
        {
            get { return bankRepository = new BankRepository(dbFactory); }
        }

        public ICategoryRepository CategoryRepository
        {
            get { return categoryRepository = new CategoryRepository(dbFactory); }
        }

        public IJobRepository JobRepository
        {
            get { return jobRepository = new JobRepository(dbFactory); }
        }

        public ISouscategoryRepository SouscategoryRepository
        {
            get { return souscategoryRepository = new SouscategoryRepository(dbFactory); }
        }

        public IPaymentRepository PaymentRepository
        {
            get { return paymentRepository = new PaymentRepository(dbFactory); }
        }
    }
}
