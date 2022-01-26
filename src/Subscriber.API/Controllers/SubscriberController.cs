using Microsoft.AspNetCore.Mvc;

namespace Subscriber.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SubscriberController : ControllerBase
    {
        [HttpGet]
        public void Subscriber() 
        {
            SubscriberClass.Subscriber();
        }
    }
}
