

namespace Ecommerce.Core.Entities;
    public class CustomerAddress : BaseEntity
    {
    public CustomerAddress(Guid idCustomer, string recipientName, string streetLine1, string? streetLine2, string city, string state, string zipCode, string district, string country)
    {
        IdCustomer = idCustomer;
        RecipientName = recipientName;
        StreetLine1 = streetLine1;
        StreetLine2 = streetLine2;
        City = city;
        State = state;
        ZipCode = zipCode;
        District = district;
        Country = country;
    }

        public Guid IdCustomer { get; set; }
        public string RecipientName { get; set; } // Name of the person who will receive the order
        public string StreetLine1 { get; set; } = string.Empty;
        public string? StreetLine2 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
