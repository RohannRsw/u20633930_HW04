using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20633930_HW041.Models;

namespace u20633930_HW041.Controllers
{
    public class PFController : Controller
    {
        // GET: PF

        public static List<Money> Mlist = new List<Money>();
        public static List<Clothes> Clist = new List<Clothes>();
        public static List<Food> Flist = new List<Food>();
        public static List<NPO> NPOList = new List<NPO>();

        private void InitialisePF()
        {
            if (PFDB.Count() == 0)
            {
                Mlist.Add(new Money("Rohann", "Rossouw", "Male", 
                                    21,1, 1, "No Poverty", 3500.50, "Rand"));

                Mlist.Add(new Money("Liza", "Oosthuisen", "Female",
                                    19, 1, 1, "No Poverty", 4150.50, "Dollar"));

                Mlist.Add(new Money("Ethan", "Keeling", "Male",
                                    26, 1, 1, "No Poverty", 850.50, "Euro"));

                Clist.Add(new Clothes("Rohann", "Rossouw", "Male",
                                   21, 2, 1, "No Poverty","Winter","Cotton",5));

                Clist.Add(new Clothes("Rie", "Rossouw", "Female",
                                   28, 2, 1, "No Poverty", "Summer", "Cotton", 5));

                Flist.Add(new Food("Andre", "Oelofse", "Male",
                                  18, 3, 1, "No Poverty", 6.2, "Frozen"));

                Flist.Add(new Food("Denton", "Van Wyk", "Male",
                                  24, 3, 1, "No Poverty",2.5,"Canned"));

                PFDB.AddRange(Mlist);
                PFDB.AddRange(Clist);
                PFDB.AddRange(Flist);
            }
            else
            {
                PFDB.Clear();
                PFDB.AddRange(Mlist);
                PFDB.AddRange(Clist);
                PFDB.AddRange(Flist);
                return;
            }
        }

        public static List<PovertyFighter> PFDB = new List<PovertyFighter>();
        public ActionResult PovertyFighter()
        {
            InitialisePF();
            return View(PFDB);
        }


        //ALL FOR MONEY////////////////////////////////////////////////////////////////////////
        [HttpGet]
        public ActionResult MoneyIndex()
        {
            return View(Mlist);
        }
        //CREATE VIEW
        [HttpGet]
        public ActionResult AddMoney()
        {
            return View();
        }
        //CREATE ACTION
        [HttpPost]
        public ActionResult AddMoney(Money Mdata)
        {
            Mlist.Add(Mdata);
            return RedirectToAction("PovertyFighter");
        }

        //EDIT VIEW
        [HttpGet]
        public ActionResult EditM(int Id)
        {
            Money findeditm = Mlist.Where(x => x._DType == Id).FirstOrDefault();
            return View(findeditm);
        }
        //EDIT POSTING ACTION
        [HttpPost]
        public ActionResult EditM(int Id, Money editm)
        {
            //FIND
            Money findeditm = Mlist.Where(x => x._DType == Id).FirstOrDefault();

            //UPDATE
            findeditm = editm;

            //UPDATE ALTERNATIVE
            findeditm.Name = editm.Name;
            findeditm.Surname = editm.Surname;
            findeditm.Gender = editm.Gender;
            findeditm.Age = editm.Age;
            findeditm.SDGID = editm.SDGID;
            findeditm.SDGNAME = editm.SDGNAME;
            findeditm._DType = editm._DType;

            //REDIRECT BACK
            return RedirectToAction("MoneyIndex");
        }

        //DELETE VIEW
        [HttpGet]
        public ActionResult DeleteM(int Id)
        {
            Money findeditm = Mlist.Where(x => x._DType == Id).FirstOrDefault();
            return View(findeditm);
        }

        //DELETE POSTING ACTION
        [HttpDelete]
        public ActionResult DeleteMInList(int Id)
        {
            Money findeditm = Mlist.Where(x => x._DType == Id).FirstOrDefault();
            Mlist.Remove(findeditm);
            return RedirectToAction("MoneyIndex");
        }
        //////////////////////////////////////////////////////////////////////////////////////////// 
        ///




        //ALL FOR CLOTHES!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        [HttpGet]
        public ActionResult ClothesIndex()
        {
            return View(Clist);
        }
        [HttpGet]
        public ActionResult AddClothes()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddClothes(Clothes Cdata)
        {
            Clist.Add(Cdata);
            return RedirectToAction("PovertyFighter");
        }

        //EDIT VIEW
        [HttpGet]
        public ActionResult EditC(int Id)
        {
            Clothes findeditc = Clist.Where(x => x._DType == Id).FirstOrDefault();
            return View(findeditc);
        }
        //EDIT POSTING ACTION
        [HttpPost]
        public ActionResult EditC(int Id, Clothes editc)
        {
            //FIND
            Clothes findeditc = Clist.Where(x => x._DType == Id).FirstOrDefault();

            //UPDATE
            findeditc = editc;

            //UPDATE ALTERNATIVE
            findeditc.Name = editc.Name;
            findeditc.Surname = editc.Surname;
            findeditc.Gender = editc.Gender;
            findeditc.Age = editc.Age;
            findeditc.SDGID = editc.SDGID;
            findeditc.SDGNAME = editc.SDGNAME;
            findeditc._DType = editc._DType;

            //REDIRECT BACK
            return RedirectToAction("ClothesIndex");
        }

        //DELETE VIEW
        [HttpGet]
        public ActionResult DeleteC(int Id)
        {
            Clothes findeditc = Clist.Where(x => x._DType == Id).FirstOrDefault();
            return View(findeditc);
        }

        //DELETE POSTING ACTION
        [HttpDelete]
        public ActionResult DeleteCInList(int Id)
        {
            Clothes findeditc = Clist.Where(x => x._DType == Id).FirstOrDefault();
            Clist.Remove(findeditc);
            return RedirectToAction("ClothesIndex");
        }









        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!




        //?????????????????????????????????????????????????????????????????????????????????????????????
        //ALL FOR FOOD
        [HttpGet]
        public ActionResult FoodIndex()
        {
            return View(Flist);
        }
        [HttpGet]
        public ActionResult AddFood()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFood(Food Fdata)
        {
            Flist.Add(Fdata);
            return RedirectToAction("PovertyFighter");
        }

        //EDIT VIEW
        [HttpGet]
        public ActionResult EditF(int Id)
        {
            Food findeditf = Flist.Where(x => x._DType == Id).FirstOrDefault();
            return View(findeditf);
        }
        //EDIT POSTING ACTION
        [HttpPost]
        public ActionResult EditF(int Id, Food editf)
        {
            //FIND
            Food findeditf = Flist.Where(x => x._DType == Id).FirstOrDefault();

            //UPDATE
            findeditf = editf;

            //UPDATE ALTERNATIVE
            findeditf.Name = editf.Name;
            findeditf.Surname = editf.Surname;
            findeditf.Gender = editf.Gender;
            findeditf.Age = editf.Age;
            findeditf.SDGID = editf.SDGID;
            findeditf.SDGNAME = editf.SDGNAME;
            findeditf._DType = editf._DType;

            //REDIRECT BACK
            return RedirectToAction("FoodIndex");
        }

        //DELETE VIEW
        [HttpGet]
        public ActionResult DeleteF(int Id)
        {
            Food findeditf = Flist.Where(x => x._DType == Id).FirstOrDefault();
            return View(findeditf);
        }

        //DELETE POSTING ACTION
        [HttpDelete]
        public ActionResult DeleteFInList(int Id)
        {
            Food findeditf = Flist.Where(x => x._DType == Id).FirstOrDefault();
            Flist.Remove(findeditf);
            return RedirectToAction("FoodIndex");
        }




        //????????????????????????????????????????????????????????????????????????????????????????????????







    }
}