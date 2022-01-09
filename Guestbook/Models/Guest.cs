using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Guestbook.Models
{
    public class Guest
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
        public string Website { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [MaxLength(255)]
        public string Message { get; set; }

        [NotMapped]
        [Display(Name = "Name")]
        public string FullName { get { return $"{LastName}, {FirstName}"; } }

        [NotMapped]
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageType { get; set; }
        public int Id { get; set; }
    }
}
