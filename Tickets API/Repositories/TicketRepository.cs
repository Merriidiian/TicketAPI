using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tickets_API.Data;
using Tickets_API.DTO;
using Tickets_API.Models;
using Route = Tickets_API.DTO.Route;

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

    
    public async Task <TicketDto> PostTicket(TicketDto ticketDto)
    {
        var ticket = _mapper.Map<Ticket>(ticketDto);
        foreach (var t in ticketDto.routes)
        {
            ticket = _mapper.Map<Ticket>(ticketDto);
            ticket.airline_code = t.airline_code;
            ticket.flight_num = t.flight_num;
            ticket.depart_place = t.depart_place;
            ticket.depart_datetime = DateTime.Parse(t.depart_datetime).ToUniversalTime();
            ticket.depart_datetime_timezone = (short)(DateTimeOffset.Parse(t.depart_datetime).Offset.Hours * -1);
            ticket.arrive_place = t.arrive_place;
            ticket.arrive_datetime = DateTime.Parse(t.arrive_datetime).ToUniversalTime();
            ticket.arrive_datetime_timezone = (short)(DateTimeOffset.Parse(t.arrive_datetime).Offset.Hours * -1);
            ticket.pnr_id = t.pnr_id;
            _context.Segments.AddAsync(ticket);
        }
        await _context.SaveChangesAsync();

        return ticketDto;
    }
}