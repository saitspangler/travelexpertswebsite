using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelExperts.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    [Required(ErrorMessage = "First name is required")]
    [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters")]
    public string? CustFirstName { get; set; } = null!;

    [Required(ErrorMessage = "Last name is required")]
    [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters")]
    public string? CustLastName { get; set; } = null!;

    [Required(ErrorMessage = "Address is required")]
    [StringLength(100, ErrorMessage = "Address cannot be longer than 100 characters")]
    public string? CustAddress { get; set; } = null!;

    [Required(ErrorMessage = "City is required")]
    [StringLength(50, ErrorMessage = "City cannot be longer than 50 characters")]
    public string? CustCity { get; set; } = null!;

    [Required(ErrorMessage = "Province/State is required")]
    public string? CustProv { get; set; } = null!;

    [Required(ErrorMessage = "Postal code is required")]
    //[RegularExpression(@"^[A-Za-z]\d[A-Za-z][ -]?\d[A-Za-z]\d$", ErrorMessage = "Postal code must be in the format: A1A 1A1")]
    public string? CustPostal { get; set; } = null!;

    [Required(ErrorMessage = "Country is required")]
    public string? CustCountry { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    //[Phone(ErrorMessage = "Invalid phone number")]
    public string? CustHomePhone { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    public string? CustBusPhone { get; set; } = null!;

    [Required(ErrorMessage = "Email is required")]
    //[EmailAddress(ErrorMessage = "Invalid email address")]
    public string? CustEmail { get; set; } = null!;

    public int? AgentId { get; set; }

    [Required(ErrorMessage = "Username is required")]
    [StringLength(50, ErrorMessage = "Username cannot be longer than 50 characters")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Confirm password is required")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string? Password { get; set; }

    public virtual Agent? Agent { get; set; }

    public virtual ICollection<Booking>? Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<CreditCard>? CreditCards { get; set; } = new List<CreditCard>();

    public virtual ICollection<CustomersReward>? CustomersRewards { get; set; } = new List<CustomersReward>();
}
