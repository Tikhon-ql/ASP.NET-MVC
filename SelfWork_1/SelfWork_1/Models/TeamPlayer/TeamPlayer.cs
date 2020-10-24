using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfWork_1.Models.TeamPlayer
{
    public class TeamPlayer
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CommandName { get; set; }
        public string Position { get; set; }
        public int Weight { get; set; }
        public double Height { get; set; }
        public DateTime Bithday { get; set; }
    }
}