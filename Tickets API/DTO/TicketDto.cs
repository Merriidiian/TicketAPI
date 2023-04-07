using System.ComponentModel.DataAnnotations;

namespace Tickets_API.DTO;

public class TicketDto
{
    public string operation_type { get; set; }
    public DateTimeOffset operation_time { get; set; }
    public string operation_place { get; set; }
    //Passenger
    public string name { get; set; }
    public string surname { get; set; }
    public string patronymic  { get; set; }
    public string doc_type { get; set; }
    public string doc_number { get; set; }
    [DataType(DataType.Date)]
    public DateTime birthdate { get; set;}
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
    public DateTime arrive_datetime { get; set; }
    public string pnr_id { get; set; }
}