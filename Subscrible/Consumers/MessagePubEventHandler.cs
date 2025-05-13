using MassTransit;
using rabbitmq_message;

namespace Subscrible.Consumers
{
    public class MessagePubEventHandler(ILogger<MessagePubEventHandler> logger) : IConsumer<MessagePub>
    {
        public async Task Consume(ConsumeContext<MessagePub> context)
        {
            logger.LogInformation(context.Message.Message);
            await Task.CompletedTask;
        }
    }
}
