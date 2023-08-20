using System.Threading.Tasks;
using MassTransit;
using TestTemplate2.Core.Events;

namespace TestTemplate2.WorkerServices.FooService
{
    public class FooConsumer : IConsumer<IFooEvent>
    {
        public Task Consume(ConsumeContext<IFooEvent> context) =>
            Task.CompletedTask;
    }
}
