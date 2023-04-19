using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Tickets_API.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Tickets_API.Repositories;
using Tickets.Middleware;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TicketContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("TicketConnection")));
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllers();
builder.Services.AddApiVersioning();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTransient<ITicketRepository, TicketRepository>();


var app = builder.Build();
app.UseMiddleware<ExceptionMiddleware>();
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();
app.Run();