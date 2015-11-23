using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheBettingSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(Bruger bruger)
        {
            if (bruger.navn != null)
            {
                ViewBag.list = Service.getWagers();
                return View(bruger);
            }
            else
            {
                ViewBag.list = Service.getWagers();
                return View();
            }
            
        }
        [HttpPost]
        public ActionResult Index(Bruger bruger, int wid, int bet)
        {
            

                if (bruger != null)
                {
                    ViewBag.list = Service.getWagers();
                    ViewBag.wager = Service.findWager(wid);
                    ViewBag.bet = bet;
                    return View(bruger);
                }
                else
                {
                    ViewBag.list = Service.getWagers();
                    ViewBag.wager = Service.findWager(wid);
                    ViewBag.bet = bet;
                    return View();
                }
            
        }
        public ActionResult makeBet()
        {
            return View();
        }
        
        public ActionResult userProfile(Bruger bruger)
        {
                return View(bruger);
            
        }
    }
}