

namespace Ecommerce.Core.Entities;
    public class CustomerAddress : BaseEntity
    {
    public CustomerAddress(string streetLine1, string? streetLine2, string city, string state, string zipCode, string district, string country)
    {
        StreetLine1 = streetLine1;
        StreetLine2 = streetLine2;
        City = city;
        State = state;
        ZipCode = zipCode;
        District = district;
        Country = country;
    }

    //public int Id { get; set; }
    public string StreetLine1 { get; set; } = string.Empty;
        public string? StreetLine2 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
