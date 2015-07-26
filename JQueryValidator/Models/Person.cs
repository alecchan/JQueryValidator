using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace JQueryValidator.Models
{
    public class Person
    {
        [Required]
        public string FirstName { get; set; }

[MaxLength(3)]
        public string LastName { get; set; }
    }
}
