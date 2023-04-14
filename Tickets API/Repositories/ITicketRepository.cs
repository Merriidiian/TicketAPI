using Tickets_API.DTO;

namespace Tickets_API.Repositories;

public interface ITicketRepository
{
    TicketDto PostTicket(TicketDto ticketDto);
}