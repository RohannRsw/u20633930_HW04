using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20633930_HW041.Models;

namespace u20633930_HW041.Controllers
{
    public abstract class NPOController : Controller
    {
        public static List<NPO> NPOList = new List<NPO>();
        public static List<NPO> NPODB = new List<NPO>();

        
        private void InitialiseNPO()
        {
            if (NPODB.Count() == 0)
            {
                NPOList.Add(new NPO("World Relief", 1944, "Relief and Development", "23-6393344",
                    "~/Content/Images/World-Relief-logo.png", "worldrelief@wr.org"));

                NPODB.AddRange(NPOList);
            }
            else
            {
                return;
            }
        }
        
        public ActionResult NPOShow()
        {
            InitialiseNPO();
            return View(NPODB);
        }

        [HttpGet]
        public ActionResult NPOIndex()
        {
            return View(NPOList);
        }
        [HttpGet]
        public ActionResult AddNPO()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNPO(NPO npodata)
        {
            NPOList.Add(npodata);
            return RedirectToAction("NPO");
        }


    }
}