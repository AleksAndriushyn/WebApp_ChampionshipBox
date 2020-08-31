using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class ChampionshipBox
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int AmountOfRounds { get; set; }
        public string BoxerWin { get; set; }
        public string Boxer { get; set; }
        public int RefereePoints { get; set; }
        public bool Result { get; set; }
    }
}