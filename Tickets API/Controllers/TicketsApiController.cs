using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update;
using Newtonsoft.Json.Linq;
using Tickets_API;
using Tickets_API.DTO;
using Tickets_API.Filters;
using Tickets_API.Repositories;

namespace Tickets_API.Controllers;

[Route("api/process/sale/")]
[ApiController]
public class TicketsApiController : ControllerBase
{
    private readonly ITicketRepository _service;

    public TicketsApiController(ITicketRepository service)
    {
        _service = service;
    }
    [RequestSizeLimit(2 * 1024)]
    [HttpPost]
    public async  Task <ActionResult<TicketDto>> PostTicket(TicketDto ticketDto)
    {
        _service.PostTicket(ticketDto);
        return Ok();
    }
}