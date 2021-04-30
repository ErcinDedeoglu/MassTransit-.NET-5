using MassTransit;
using Microsoft.AspNetCore.Mvc;
using POC.DTO;

namespace POC.Publisher.Controllers
{
    public class ProduceController : Controller
    {
        private readonly IBusControl _busControl;
        private readonly IPublishEndpoint _publishEndpoint;

        public ProduceController(IBusControl busControl, IPublishEndpoint publishEndpoint)
        {
            _busControl = busControl;
            _publishEndpoint = publishEndpoint;
        }

        [HttpGet("publish/{message}")]
        public IActionResult Message(string message)
        {
            _publishEndpoint.Publish(new MessageDto()
            {
                Message = message
            });

            return Json("Message published");
        }
    }
}