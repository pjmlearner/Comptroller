using System.ComponentModel.DataAnnotations.Schema;

namespace Comptroller.Server.Data.Entities;

public class Expense
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? ReoccurringInterval { get; set; }
    public long Amount { get; set; }
    public int OccupantId { get; set; }

    [ForeignKey("OccupantId")]
    public Occupant Occupant { get; set; }
    public int GroupdID { get; set; }

    [ForeignKey("GroupdID")]
    public Group Group { get; set; }


}
