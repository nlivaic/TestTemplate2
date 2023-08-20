using System.Collections.Generic;
using TestTemplate2.Core.Entities;
using TestTemplate2.Data;

namespace TestTemplate2.Api.Tests.Helpers
{
    public static class Seeder
    {
        public static void Seed(this TestTemplate2DbContext ctx)
        {
            ctx.Foos.AddRange(
                new List<Foo>
                {
                    new ("Text 1"),
                    new ("Text 2"),
                    new ("Text 3")
                });
            ctx.SaveChanges();
        }
    }
}
