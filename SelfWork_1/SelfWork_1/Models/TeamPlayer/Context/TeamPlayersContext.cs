using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SelfWork_1.Models.TeamPlayer.Context
{
    public class TeamPlayersContext:DbContext
    {
        public DbSet<TeamPlayer> TeamPlayers { get; set; }
    }
}