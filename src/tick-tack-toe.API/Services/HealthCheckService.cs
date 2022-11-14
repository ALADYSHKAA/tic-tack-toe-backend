using tick_tack_toe.API.Services.Base;
using tick_tack_toe.Database;

namespace tick_tack_toe.API.Services
{
    public class HealthCheckService : IHealthCheckService
    {
        private readonly DatabaseContext _context;

        public HealthCheckService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<bool> CheckDbConnect() => await _context.Database.CanConnectAsync();
    }
}
