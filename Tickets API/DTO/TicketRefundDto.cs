using Tickets_API.Filters.ModelValidation;
using Tickets_API.Validation;

namespace Tickets_API.DTO;
[JsonRefund]
public class TicketRefundDto
{
    public string operation_type { get; set; }
    public string operation_time { get; set; }
    public string operation_place { get; set; }
    [ticket_numberValidation]
    public string ticket_number { get; set; }
}