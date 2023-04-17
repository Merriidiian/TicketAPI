using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.CompilerServices;
using Tickets_API.DTO;

namespace Tickets_API.Models;

[PrimaryKey(nameof(ticket_number), nameof(flight_num))]
public class Ticket
{
    public string operation_type { get; set; }
    public DateTime operation_time{ get; set; }
    public Int16 operation_time_timezone { get; set; }
    public string operation_place { get; set; }
    public string name { get; set; }
    public string surname { get; set; }
    public string patronymic { get; set; }
    public string doc_type { get; set; }
    public string doc_number { get; set; }
    public DateOnly birthdate { get; set; }
    public string gender { get; set; }
    public string passenger_type { get; set; }
    public string ticket_number { get; set; }
    public int ticket_type { get; set; }
    public string airline_code { get; set; }
    public int flight_num { get; set; }
    public string depart_place { get; set; }
    public DateTime depart_datetime { get; set; }
    public Int16 depart_datetime_timezone { get; set; }
    public string arrive_place { get; set; }
    public DateTime arrive_datetime { get; set; }
    public Int16 arrive_datetime_timezone { get; set; }
    public string pnr_id { get; set; }
}