using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20633930_HW041.Models
{
    public class Clothes : PovertyFighter
    {
        public string _SeasonClothes;
        public string _Cosmetics;
        public int _Quantity;

        public Clothes() : base ()
        {

        }

        public Clothes(string Name, string Surname, string Gender,  int Age,int DType, int SDGID, string SDGNAME,string SeasonClothes,string Cosmetics,int Quantity) : base(Name, Surname, Gender, Age, SDGID, SDGNAME,DType)
        {
            _SeasonClothes = SeasonClothes;
            _Cosmetics = Cosmetics;
            _Quantity = Quantity;       
        }

        public override string DonationType()
        {
            return "Thank you very much" + this.Name  +  this.Surname + " Age : " + this.Age + "  Gender :  " + this.Gender + 
                " for your kind donation of " + this.SeasonClothes + " x " +
               this.Quantity  + " made out of " + this.Cosmetics + "! \n" + "Our Team at World Relief appretiates your'e contribution towards our cause. \n" +
               "WELCOME TO THe POVERTYFIGHTER TEAM!"+
                "Together we will defeat SDG Number " + this.SDGID + ": " + this.SDGNAME; ;
        }

        public override string Confirmation()
        {
            return "Confirmation of donation in " + Convert.ToString(CConfirmation()) + " hours.";
        }

        private int CConfirmation()
        {
            Random hours = new Random();
            int hour = hours.Next(0, 4);
            return hour;
        }


        public string SeasonClothes { get { return _SeasonClothes; } set { _SeasonClothes = value; } }

        public string Cosmetics { get { return _Cosmetics; } set { _Cosmetics = value; } }

        public int Quantity { get { return _Quantity; } set { _Quantity = value; } }
    }

}