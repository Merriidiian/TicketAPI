using AutoMapper;
using Tickets_API.Models;

namespace Tickets_API.DTO.AutoMapperProfiles;

public class TicketDtoProfile:Profile
{
    
    public TicketDtoProfile()
    {
        CreateMap<TicketDto, Ticket>().ReverseMap();
        
        /*var configuration = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<string, int>().ConvertUsing(s => Convert.ToInt32(s));
            cfg.CreateMap<int, string>().ConvertUsing(s => Convert.ToString(s));
            cfg.CreateMap<TicketDto, Ticket>().ReverseMap();
        });
        configuration.AssertConfigurationIsValid();*/
    }
}