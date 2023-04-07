using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore.Update;
using Newtonsoft.Json.Linq;
using Tickets_API;
using Tickets_API.DTO;
using Tickets_API.Repositories;

namespace Tickets_API.Controllers;
[Route("api/process/sale")]
[ApiController]
public class TicketsApiController : ControllerBase
{
    private readonly ITicketRepository _service;
    private readonly ILogger<TicketsApiController> _logger;
    

    public TicketsApiController(ITicketRepository service, ILogger<TicketsApiController> logger)
    {
        _service = service;
        _logger = logger;
    }

    public IActionResult GetByTicketNumber (int ticket_number)
    {
        var ticket = _service.GetTicket(ticket_number);
        if (ticket == null) return NotFound();
        return Ok(ticket);
    }
    [HttpPost]
    //[Filters.SaleJsonFilters]
    public ActionResult<TicketDto> PostTicket(TicketDto ticketDto)
    {
        var ticket = _service.PostTicket(ticketDto);
        return CreatedAtAction("GetByTicketNumber", new { ticket_number = ticket.ticket_number}, ticket);
    }
    /*public ActionResult TestJson()
    {
        System.IO.File.ReadAllText("JsonTestSale.json");
        if (ModelState.IsValid)
        {
            _logger.LogTrace("+");
            return BadRequest();
        }
        else
        {
            _logger.LogTrace("-");
            return NotFound();
        }
    }*/
}

