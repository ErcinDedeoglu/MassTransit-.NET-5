using System;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.Extensions.Logging;

namespace POC.Consumer.Consumers
{
    public class MessageConsumer : IConsumer<DTO.MessageDto>
    {
        readonly ILogger<MessageConsumer> _logger;

        public MessageConsumer(ILogger<MessageConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<DTO.MessageDto> context)
        {
            _logger.LogInformation("Received Text: {Text}", context.Message.Message);
            Console.WriteLine(context.Message.Message);
            return Task.CompletedTask;
        }
    }
}