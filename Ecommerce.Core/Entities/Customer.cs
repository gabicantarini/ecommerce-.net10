using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Linq;

namespace Ecommerce.Core.Entities
{
    public class Customer : BaseEntity    
    {

        public Customer(string name, string email, DateTime dateOfBirth, string document)
        {
            Name = name;
            Email = email;
            DateOfBirth = dateOfBirth;
            Document = document;
            Addresses = [];
        }

        //public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Document { get; set; }

        public List<CustomerAddress> Addresses { get; set; }

    }
}
