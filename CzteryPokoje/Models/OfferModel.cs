using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CzteryPokoje.Models
{
    public class Offer
    {
        [Required]
        public int  ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string Status { get; set; }
        

    }
}