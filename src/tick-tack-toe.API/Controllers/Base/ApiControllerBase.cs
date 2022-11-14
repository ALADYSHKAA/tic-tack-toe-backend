using Microsoft.AspNetCore.Mvc;

namespace tick_tack_toe.API.Controllers.Base
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public abstract class ApiControllerBase : ControllerBase
    {
    }
}
