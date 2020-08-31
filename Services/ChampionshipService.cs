using Entities;
using IServices;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ChampionshipService: ChampionshipRepository, IChampionshipService
    {
        public ChampionshipService(ChampionshipContext context) : base(context)
        {

        }
        public List<ChampionshipBox> List()
        {
            return this.EntityList().Select(obj => obj).ToList();
        }
        public void Insert(ChampionshipBox championshipBox)
        {
            this.EntityInsert(championshipBox);
        }

        public ChampionshipBox Get(int id)
        {
            return this.GetEntity(id);
        }

        public void Update(ChampionshipBox model)
        {
            this.UpdateEntity(model);
        }
        public IEnumerable<ChampionshipBox> FindByBoxerName(string Name)
        {
            var boxers = this.List();
            boxers = boxers.Where(s => s.BoxerWin.Contains(Name)).ToList();
            return boxers;
        }
        public IEnumerable<ChampionshipBox> GetResult(bool result)
        {
            var boxers = this.List();
            boxers = boxers.Where(s => s.Result.Equals(result)).ToList();
            return boxers;
        }
    }
}
