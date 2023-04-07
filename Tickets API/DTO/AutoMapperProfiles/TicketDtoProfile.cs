using AutoMapper;
using Tickets_API.Models;

namespace Tickets_API.DTO.AutoMapperProfiles;

public class TicketDtoProfile:Profile
{
    
    public TicketDtoProfile()
    {
        CreateMap<Ticket, TicketDto>().ReverseMap();
    }
}