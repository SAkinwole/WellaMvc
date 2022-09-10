using System.ComponentModel.DataAnnotations;

namespace WellaMvc.Models
{
    public class UserData
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string PhoneNumber { get; set; } 
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}