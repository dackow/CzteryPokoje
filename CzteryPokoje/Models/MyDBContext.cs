using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CzteryPokoje.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("CzteryPokojeDBEntities")
        {

        }

        public virtual DbSet<Offer> Offers { get; set; }
    }
}