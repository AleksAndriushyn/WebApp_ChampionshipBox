using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ChampionshipContext : DbContext
    {
        public ChampionshipContext() : base("name = ChampionshipContext") { }

        public DbSet<ChampionshipBox> ChampionshipBoxes { get; set; }
    }
}
