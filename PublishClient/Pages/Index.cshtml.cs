using MassTransit;
using Microsoft.AspNetCore.Mvc.RazorPages;
using rabbitmq_message;

namespace PublishClient.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IPublishEndpoint _publishEndpoint;

        public IndexModel(ILogger<IndexModel> logger, IPublishEndpoint publishEndpoint)
        {
            _logger = logger;
            _publishEndpoint = publishEndpoint;
        }

        public void OnGet()
        {
            for (int i = 0; i < 10; i++)
            {
                var massage = "Testing " + i;
                _publishEndpoint.Publish(new MessagePub() { MessageId = i, Message = massage });

                _logger.LogInformation(massage);
            }
        }
    }
}
