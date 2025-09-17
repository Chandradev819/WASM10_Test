using System.ComponentModel.DataAnnotations;

namespace BlazorApp28
{
    [ValidatableType]
    public class Emp 
    {
        [Required(ErrorMessage = "First name is required.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string? LastName { get; set; }

        public Address Address { get; set; } = new();

    }
    public class Address
    {
        [Required(ErrorMessage = "Street is required.")]
        public string? Street { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string? City { get; set; }
    }
}
