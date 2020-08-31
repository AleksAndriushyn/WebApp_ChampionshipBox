using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class Storage
    {
        public static void Initialize(ChampionshipContext context)
        {
            context.Database.CreateIfNotExists();

            List<ChampionshipBox> championships = new List<ChampionshipBox>()
            {
            new ChampionshipBox{BoxerWin = "Vitaliy", AmountOfRounds = 3, Date  = new DateTime(1989, 09, 9)},
            new ChampionshipBox{Boxer ="Oleg", AmountOfRounds = 2, Date  = new DateTime(2000, 12, 12)},
            new ChampionshipBox{BoxerWin="Dmitriy", AmountOfRounds = 1, Date  = new DateTime(1995, 06, 4)},
            new ChampionshipBox{Boxer="Vadim", AmountOfRounds = 1, Date  = new DateTime(1986, 10, 25)},
            new ChampionshipBox{BoxerWin="Timophy", AmountOfRounds = 4, Date  = new DateTime(2001, 03, 15)}
            };

            if (context.ChampionshipBoxes.Any())
            {
                return;   // DB has been seeded
            }

            foreach (var cs in championships)
            {
                context.ChampionshipBoxes.Add(cs);
            }

            context.SaveChanges();
        }
    }
}
