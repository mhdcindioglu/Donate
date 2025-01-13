using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Donate.Data.Entities;

public class DonationDetail
{
    public int Id { get; set; }

    public int DonationId { get; set; }
    public virtual Donation? Donation { get; set; }

    public int DonationItemId { get; set; }
    public virtual DonationItem? DonationItem { get; set; }

    [NotMapped]
    public int ProjectId { get; set; }
    [NotMapped]
    public Project? Project { get; set; }

    public int Qty { get; set; }

    [MaxLength(512)]
    public string? Notes { get; set; }
    public bool Active { get; set; }
}
