using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TemplatedHelperMethods.Models
{
    [MetadataType(typeof(CustomerWithAttributes))]
    public partial class Customer
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public Address Address { get; set; }

        public Role Role { get; set; }
    }

    
    [DisplayName("Customer")]
    public partial class CustomerWithAttributes
    {
        [HiddenInput(DisplayValue = false)]
        public int CustomerId { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
    }
}