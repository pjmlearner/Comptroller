using System.ComponentModel.DataAnnotations;

namespace Comptroller.Server.Data.Entities;

public class Occupant
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime CreatedDate { get; set; }
    public long Income { get; set; }
    public string? DepositInterval { get; set; }
    public string? Email {  get; set; }

}
