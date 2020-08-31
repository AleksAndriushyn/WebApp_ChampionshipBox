using IServices;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class ChampionShipBoxesController : Controller
    {
        public ChampionShipBoxesController() { }
        private readonly IChampionshipService _championshipService;
        
        public ChampionShipBoxesController(IChampionshipService championshipService)
        {
            _championshipService = championshipService;
        }
        public ActionResult Index(string searchString/*, bool searchresult*/)
        {
            var championships = _championshipService.List();
            if (!String.IsNullOrEmpty(searchString))
            {
                championships = _championshipService.FindByBoxerName(searchString).ToList();
            }
            //if (searchresult == true)
            //{
            //    championships = _championshipService.GetResult(searchresult).ToList();
            //}
            return View(championships);
        }
    }
}