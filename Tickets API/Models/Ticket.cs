using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.EntityFrameworkCore;
using Tickets_API.DTO;

namespace Tickets_API.Models;
[PrimaryKey(nameof(ticket_number), nameof(flight_num))]
public class Ticket
{
    public string operation_type { get; set; }
    public string operation_time { get; set; }
    public string operation_place { get; set; }
    //Passenger
    public string name { get; set; }
    public string surname { get; set; }
    public string patronymic  { get; set; }
    public string doc_type { get; set; }
    public string doc_number { get; set; }
    public string birthdate { get; set;}
    public string gender { get; set; }
    public string passenger_type { get; set; }
    public string ticket_number { get; set; }
    public int ticket_type { get; set; }
    //Routes
    public string airline_code { get; set; }
    public int flight_num { get; set; }
    public string depart_place { get; set; }
    public string depart_datetime { get; set; }
    public string arrive_place { get; set; }
    public string arrive_datetime { get; set; }
    public string pnr_id { get; set; }

    /*public Ticket(TicketDto ticketDto)
    {
        operation_time = ticketDto.operation_time.DateTime.ToUniversalTime();
        depart_datetime = ticketDto.depart_datetime.DateTime.ToUniversalTime();
        arrive_datetime = ticketDto.arrive_datetime.DateTime.ToUniversalTime();
    }*/
}