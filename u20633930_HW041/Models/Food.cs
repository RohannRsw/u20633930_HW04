using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20633930_HW041.Models
{
    public class Food : PovertyFighter
    {
        public double _Weight;
        public string _Type;

        public Food() : base()
        {

        }

        public Food(string Name, string Surname, string Gender, int Age,int DType, int SDGID, string SDGNAME,double Weight,string Type) : base(Name, Surname, Gender,  Age, SDGID, SDGNAME,DType)
        {
            _Weight = Weight;
            _Type = Type;
        }

        public override string DonationType()
        {
            return "Thank you very much" + this.Name  +  this.Surname + " Age : " + this.Age + "  Gender : " + this.Gender + 
                " for your kind donation of  " + this.Type + " of " +
               this._Weight + "kg!" + " \n" + "Our Team at World Relief appretiates your'e contribution towards our cause. \n" +
               "WELCOME TO THe POVERTYFIGHTER TEAM!"+
                "Together we will defeat SDG Number " + this.SDGID + ": " + this.SDGNAME; ;
        }

        public override string Confirmation()
        {
            return "Confirmation of donation in " + Convert.ToString(FConfirmation()) + " hours.";
        }

        private int FConfirmation()
        {
            Random hours = new Random();
            int hour = hours.Next(0, 24);
            return hour;
        }

        public double Cosmetics { get { return _Weight; } set { _Weight = value; } }

        public string Type { get { return _Type; } set {Type = value; } }

    }
}