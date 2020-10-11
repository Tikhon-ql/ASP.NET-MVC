using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HomeTask1.Models
{
    public class BookmakerContext:DbContext
    {
        public DbSet<Bet> Bets { get; set; }
    }
}