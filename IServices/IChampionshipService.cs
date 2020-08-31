using Entities;
using IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    public interface IChampionshipService : IChampionshipRepository
    {
        List<ChampionshipBox> List();
        IEnumerable<ChampionshipBox> FindByBoxerName(string Name);
        IEnumerable<ChampionshipBox> GetResult(bool result);
    }
}
