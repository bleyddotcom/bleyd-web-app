using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BleydSample.Models
{
    public class Contact
    {
        [Required]
        string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        string Email { get; set; }
        [Display(Name = "Belyd")]
        string CompanyName { get; set; }
        [Required]
        string Message { get; set; }
    }
}
