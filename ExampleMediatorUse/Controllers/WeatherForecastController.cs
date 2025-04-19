using ExampleMediatorUse.Features.Queries;
using Microsoft.AspNetCore.Mvc;
using MyCustomerMediator;

namespace ExampleMediatorUse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController(Mediator _mediator): ControllerBase
    {

        [HttpGet("welcome")]
        public async Task<IActionResult>GetWelcomMessage([FromQuery]string name)
        {
            var query = new WelcomMessageQuery { Name= name };

            var reqult = await _mediator.Send(query);
            return Ok(reqult);
        }
    }
}
