using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sol_Demo.Controllers
{
    // https://docs.microsoft.com/en-us/aspnet/core/web-api/advanced/analyzers?view=aspnetcore-3.1&tabs=visual-studio
    // https://docs.microsoft.com/en-us/aspnet/core/web-api/advanced/conventions?view=aspnetcore-3.1#create-web-api-conventions

    [Produces("application/json")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Route("api/demo")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("ondemo/name/{name}")]
        public IActionResult OnDemo(string name)
        {
            if (name == null) return base.BadRequest();
            else
            {
                return base.Ok((object)name);
            }
        }
    }
}