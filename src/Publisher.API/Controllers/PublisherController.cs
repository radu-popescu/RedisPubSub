using Microsoft.AspNetCore.Mvc;

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
