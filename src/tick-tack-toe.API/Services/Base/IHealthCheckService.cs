namespace tick_tack_toe.API.Services.Base
{
    public interface IHealthCheckService
    {
        public Task<bool> CheckDbConnect();
    }
}
