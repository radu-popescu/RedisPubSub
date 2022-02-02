using Microsoft.AspNetCore.Mvc;
using System.Timers;

namespace Publisher.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PublisherController : ControllerBase
    {
        [HttpPost]
        public void PublishMessage()
        {
            PublisherClass.PublishMessage();
        }
    }
}
