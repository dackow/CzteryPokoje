using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CzteryPokoje.Models
{
    public class Contact
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public Address Address { get; set; }
    }
}