using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Service;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebAPIController : ControllerBase
    {
        [HttpPost]
        [Route("cardrequest")]
        public ActionResult<CardResponse> CardRequest(CardRequest request)
        {
            return new CardRequestService().CreateCardRequest(request);
        }
    }
}