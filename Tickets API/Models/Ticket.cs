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

[PrimaryKey(nameof(ticket_number), nameof(serial_number))]
public class Ticket
{
    public int serial_number { get; set; }
    [Required]
    public string operation_type { get; set; }
    [Required]
    public DateTime operation_time{ get; set; }
    [Required]
    public Int16 operation_time_timezone { get; set; }
    [Required]
    public string operation_place { get; set; }
    [Required]
    public string name { get; set; }
    [Required]
    public string surname { get; set; }
    [Required]
    public string patronymic { get; set; }
    [Required]
    public string doc_type { get; set; }
    [Required]
    public string doc_number { get; set; }
    [Required]
    public DateOnly birthdate { get; set; }
    [Required]
    public string gender { get; set; }
    [Required]
    public string passenger_type { get; set; }
    public string ticket_number { get; set; }
    [Required]
    public int ticket_type { get; set; }
    [Required]
    public string airline_code { get; set; }
    [Required]
    public int flight_num { get; set; }
    [Required]
    public string depart_place { get; set; }
    [Required]
    public DateTime depart_datetime { get; set; }
    [Required]
    public Int16 depart_datetime_timezone { get; set; }
    [Required]
    public string arrive_place { get; set; }
    [Required]
    public DateTime arrive_datetime { get; set; }
    [Required]
    public Int16 arrive_datetime_timezone { get; set; }
    [Required]
    public string pnr_id { get; set; }
}