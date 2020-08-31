using Entities;
using IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ChampionshipRepository : GenericRepository<ChampionshipBox>, IChampionshipRepository
    {
        public ChampionshipRepository(ChampionshipContext context) : base(context)
        {

        }
    }
}
