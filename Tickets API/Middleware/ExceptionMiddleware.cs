using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Tickets.Middleware.Exceptions;

namespace Tickets.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (BadHttpRequestException)
            {
                context.Response.StatusCode = 400;
            }
            catch (RefundTicketNumberIsNotFound ex)
            {
                context.Response.StatusCode = 409;
                await context.Response.WriteAsync(ex.Message);
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException is PostgresException {SqlState: PostgresErrorCodes.UniqueViolation})
                {
                    context.Response.StatusCode = 409;
                    await context.Response.WriteAsync("Exception DataBase");
                }
                else
                {
                    context.Response.StatusCode = 400;
                    await context.Response.WriteAsync("Exception");
                }
            }
        }
    }
}