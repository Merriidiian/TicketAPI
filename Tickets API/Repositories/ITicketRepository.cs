using Tickets_API.DTO;

namespace Tickets_API.Repositories;

public interface ITicketRepository
{
    TicketDto GetTicket(int ticket_number);
    TicketDto PostTicket(TicketDto ticketDto);
}