using System.Threading.Tasks;

namespace TestTemplate2.Common.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveAsync();
    }
}