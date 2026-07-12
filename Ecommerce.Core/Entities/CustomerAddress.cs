using Ecommerce.Core.Entities;

public class CustomerAddress : BaseEntity
{
    //public int Id { get; set; }
    public string StreetLine1 { get; set; } = string.Empty;
    public string StreetLine2 { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public string District { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
}
