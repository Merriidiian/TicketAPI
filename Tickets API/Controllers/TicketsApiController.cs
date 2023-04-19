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

[ApiController]
[ApiVersion("2.0")]
public class TicketsApiController : ControllerBase
{
    private readonly ITicketRepository _service;

    public TicketsApiController(ITicketRepository service)
    {
        _service = service;
    }
    [Route("api/v{version:apiVersion}/process/sale/")]
    [RequestSizeLimit(2 * 1024)]
    [HttpPost]
    public async Task <ActionResult<TicketSaleDto>> PostTicketSale(TicketSaleDto ticketSaleDto)
    {
        await _service.PostTicketSale(ticketSaleDto);
        return Ok();
    }
    
    
    [RequestSizeLimit(2 * 1024)]
    [HttpPost]
    [Route("api/v{version:apiVersion}/process/refund/")]
    public async Task<ActionResult<TicketRefundDto>> PostTicketRefund(TicketRefundDto ticketRefundDto)
    {
        await _service.PostTicketRefund(ticketRefundDto);
        return Ok();
    }
}