using Microsoft.EntityFrameworkCore;
using tick_tack_toe.API.Services;
using tick_tack_toe.API.Services.Base;
using tick_tack_toe.Database;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(configuration.GetConnectionString("DbContext")));

builder.Services.AddScoped<IHealthCheckService, HealthCheckService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMvc();
builder.Services.AddSignalR();


var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

// Migration after start
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
    db.Database.Migrate();
}

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});


app.Run();
