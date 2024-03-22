using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Airplane
{
    [Key]
    public int AirplaneId { get; set; }

    [Required]
    public string Model { get; set; }

    [Required]
    public string Type { get; set; }

    public int MaxPassengers { get; set; }

    [Required]
    public string Country { get; set; }

    public virtual ICollection<Flight> Flights { get; set; }
}

public class Flight
{
    [Key]
    public int FlightId { get; set; }

    [Required]
    public string Number { get; set; }

    [ForeignKey("Airplane")]
    public int AirplaneId { get; set; }
    public virtual Airplane Airplane { get; set; }

    public virtual ICollection<Client> Clients { get; set; }

    [Required]
    public DateTime DepartureDateTime { get; set; }

    [Required]
    public string DepartureLocation { get; set; }

    [Required]
    public string ArrivalLocation { get; set; }
}

public class Client
{
    [Key]
    public int ClientId { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Gender { get; set; }
    public virtual ICollection<Flight> Flights { get; set; }

    public virtual Account Account { get; set; }
}

public class Account
{
    [Key]
    public int AccountId { get; set; }

    [Required]
    public string Login { get; set; }

    [Required]
    public string Password { get; set; }

    [ForeignKey("Client")]
    public int ClientId { get; set; }
    public virtual Client Client { get; set; }
}
