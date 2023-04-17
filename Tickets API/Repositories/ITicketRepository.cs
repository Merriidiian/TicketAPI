using Tickets_API.DTO;

namespace Tickets_API.Repositories;

public interface ITicketRepository
{
    Task <TicketSaleDto> PostTicketSale(TicketSaleDto ticketDto);
    Task<TicketRefundDto> PostTicketRefund(TicketRefundDto ticketRefundDto);
}