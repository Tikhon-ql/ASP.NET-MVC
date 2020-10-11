using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeTask1.Models
{
    public class Bet
    {
        public int Id { get; set; }
        public string OwnerName { get; set; }
        public decimal Money { get; set; } = 0;
        public string SelectCommand { get; set; }
        public DateTime BetsDate { get; set; }
    }
}