using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace CarPark.Model
{
    public class CarParkDb : DbContext
    {

        public DbSet<Ticket> Tickets { get; set; }

    }
}