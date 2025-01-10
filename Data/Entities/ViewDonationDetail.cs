namespace Donate.Data.Entities;

public class ViewDonationDetail
{
    public int Id { get; set; }

    public int DonationId { get; set; }
    public string? Donation { get; set; }

    public int DonationItemId { get; set; }
    public string? DonationItem { get; set; }

    public int Qty { get; set; }
    public decimal Price { get; set; }
    public decimal Total { get; set; }

    public string? Notes { get; set; }
    public bool Active { get; set; }
}
