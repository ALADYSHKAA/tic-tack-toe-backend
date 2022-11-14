using Microsoft.AspNetCore.Mvc;
using tick_tack_toe.API.Controllers.Base;
using tick_tack_toe.API.Services.Base;
using tick_tack_toe.Models.Base;

namespace tick_tack_toe.API.Controllers.Api
{
    public class HealthCheckController : ApiControllerBase
    {
        private readonly IHealthCheckService _healthCheckService;

        public HealthCheckController(IHealthCheckService healthCheckService)
        {
            _healthCheckService = healthCheckService;
        }

        [HttpGet]
        public async Task<ActionResult<Response<HealthCheckResponse>>> Check()
        {
            var canDbConnect = await _healthCheckService.CheckDbConnect();

            var response = new Response<HealthCheckResponse>
            {
                Error   = null,
                Success = true,
                Result  = new HealthCheckResponse
                {
                    CanConnectToDb = canDbConnect,
                    DoesItWork     = true,
                }
            };

            return Ok(response);
        }
    }
}
