using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNet_MVC_Session.Models
{
    public class Member
    {
        [Required]
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last name")]
        public string LastName { get; set; }
        
        [Required]
        [RegularExpression("M|F|X")]
        public char Gender { get; set; }

        [Required]
        [DisplayName("Date of birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [DisplayName("Birth place")]
        public string BirthPlace { get; set; }
        
        [Required]
        [DisplayName("Start date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        
        [Required]
        [DisplayName("End date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }
}