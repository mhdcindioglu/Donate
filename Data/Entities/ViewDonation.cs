namespace Donate.Data.Entities;

public class ViewDonation
{
    public int Id { get; set; }

    public int DonorId { get; set; }
    public string? Donor { get; set; }

    public DateTime DonationDate { get; set; } 

    public string? Notes { get; set; }

    public int Rows { get; set; }
    public int Qty { get; set; }
    public decimal Total { get; set; }
    public bool Active { get; set; }
}
