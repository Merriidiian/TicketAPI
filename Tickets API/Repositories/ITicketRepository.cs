using Tickets_API.DTO;

namespace Tickets_API.Repositories;

public interface ITicketRepository
{
    Task <TicketDto> PostTicket(TicketDto ticketDto);
}