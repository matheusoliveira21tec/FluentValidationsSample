namespace FluentValidationsSample.Models;

public class CreateCustomerModel
{
    public string FullName { get; set; }
    public DateTime Birthday { get; set; }
    public string Document { get; set; }
    public bool IsReferral { get; set; }
    public string? ReferralCode { get; set; }
}
