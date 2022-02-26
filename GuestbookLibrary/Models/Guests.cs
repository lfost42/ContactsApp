using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuestbookLibrary.Models
{
    public class Guests
    {
        [Required]
        [Display(Name = "First")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Html)]
        [Display(Name = "LinkedIn")]
        public string Linkedin { get; set; }

        [DataType(DataType.Html)]
        [Display(Name = "Twitter")]
        public string Twitter { get; set; }

        [DataType(DataType.Html)]
        public string Website { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date => DateTime.Now;

        [MaxLength(255)]
        public string Message { get; set; }

        [NotMapped]
        [Display(Name = "Name")]
        public string FullName => $"{LastName}, {FirstName}";
    }
}
