using AutoMapper;
using Tickets_API.Models;

namespace Tickets_API.DTO.AutoMapperProfiles;

public class TicketDtoProfile : Profile
{
    public TicketDtoProfile()
    {
        CreateMap<TicketSaleDto, Ticket>().ReverseMap();
        CreateMap<TicketSaleDto, Ticket>()
            .ForMember(dest => dest.operation_time, opt => opt.MapFrom(src => DateTime.Parse(src.operation_time).ToUniversalTime()))
            .ForMember(dest => dest.operation_time_timezone,
                opt => opt.MapFrom(src => DateTimeOffset.Parse(src.operation_time).Offset.Hours * (-1)))
            //.ForMember(dest => dest.operation_time, opt => opt.MapFrom(src => DateTime.Parse(src.operation_time)))
            .ForMember(dest => dest.name, opt => opt.MapFrom(src => src.passenger.name))
            .ForMember(dest => dest.surname, opt => opt.MapFrom(src => src.passenger.surname))
            .ForMember(dest => dest.patronymic, opt => opt.MapFrom(src => src.passenger.patronymic))
            .ForMember(dest => dest.doc_type, opt => opt.MapFrom(src => src.passenger.doc_type))
            .ForMember(dest => dest.doc_number, opt => opt.MapFrom(src => src.passenger.doc_number))
            .ForMember(dest => dest.birthdate, opt => opt.MapFrom(src => DateOnly.Parse(src.passenger.birthdate)))
            .ForMember(dest => dest.gender, opt => opt.MapFrom(src => src.passenger.gender))
            .ForMember(dest => dest.passenger_type, opt => opt.MapFrom(src => src.passenger.passenger_type))
            .ForMember(dest => dest.ticket_number, opt => opt.MapFrom(src => src.passenger.ticket_number))
            //.ForMember(dest => dest.airline_code, opt => opt.MapFrom(src => src.routes))
            .ForMember(dest => dest.ticket_type, opt => opt.MapFrom(src => src.passenger.ticket_type));


        CreateMap<TicketRefundDto, Ticket>().ReverseMap();
    }
}