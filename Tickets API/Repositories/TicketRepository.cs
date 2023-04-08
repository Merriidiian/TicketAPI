using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tickets_API.Data;
using Tickets_API.DTO;
using Tickets_API.Models;

namespace Tickets_API.Repositories;

public class TicketRepository : ITicketRepository
{
    private readonly TicketContext _context;
    private readonly IMapper _mapper;

    public TicketRepository(TicketContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public TicketDto GetTicket(int ticket_number)
    {
        return _mapper.Map<TicketDto>(_context.Segments.FirstOrDefault(m => int.Parse(m.ticket_number) == ticket_number));
    }
    public TicketDto PostTicket(TicketDto ticketDto)
    {
        /*ticketDto.arrive_datetime = ticketDto.arrive_datetime.Date.ToUniversalTime();
        ticketDto.depart_datetime = ticketDto.depart_datetime.Date.ToUniversalTime();
        ticketDto.operation_time = ticketDto.operation_time.Date.ToUniversalTime();*/
        var ticket = _mapper.Map<Ticket>(ticketDto);
        _context.Segments.Add(ticket);
        _context.SaveChanges();
        return _mapper.Map<TicketDto>(ticket);
    }
    
}