using System.Threading.Tasks;
using TestTemplate2.Common.Interfaces;

namespace TestTemplate2.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TestTemplate2DbContext _dbContext;

        public UnitOfWork(TestTemplate2DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> SaveAsync()
        {
            if (_dbContext.ChangeTracker.HasChanges())
            {
                return await _dbContext.SaveChangesAsync();
            }
            return 0;
        }
    }
}