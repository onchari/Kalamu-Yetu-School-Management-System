using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kalamu_School_Management_System.Models.Entities
{
    public class School
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }

        [Display(Name = "Primary Phone")]
        [Required]
        public string PhonePrimary { get; set; }

        [Display(Name = "Alternative Phone")]
        public string PhoneAlt { get; set; }

        [Display(Name = "Fax")]
        public string Fax { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Logo")]
        public byte[] Logo { get; set; }
    }
}
