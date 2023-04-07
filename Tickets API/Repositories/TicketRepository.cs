using AutoMapper;
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
        return _mapper.Map<TicketDto>(_context.Segments.FirstOrDefault(m => m.ticket_number == ticket_number));
    }
    public TicketDto PostTicket(TicketDto ticketDto)
    {
        var ticket = _context.Add(_mapper.Map<Ticket>(ticketDto)).Entity;
        _context.SaveChangesAsync();
        return _mapper.Map<TicketDto>(ticket);
    }
}