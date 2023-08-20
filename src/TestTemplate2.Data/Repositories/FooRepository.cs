using TestTemplate2.Core.Entities;
using TestTemplate2.Core.Interfaces;

namespace TestTemplate2.Data.Repositories
{
    public class FooRepository : Repository<Foo>, IFooRepository
    {
        public FooRepository(TestTemplate2DbContext context)
            : base(context)
        {
        }
    }
}
