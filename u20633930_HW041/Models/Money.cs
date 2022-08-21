using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20633930_HW041.Models
{
    public class Money : PovertyFighter
    {
        public double _Amount;
        public string _Currency;

        public Money() : base()
        {

        }

        public Money(string Name, string Surname, string Gender, int Age,int DType, int SDGID, string SDGNAME, double Amount, string Currency) : base(Name,Surname,Gender,Age,SDGID,SDGNAME,DType)
        {
            _Amount = Amount;
            _Currency = Currency;
        }

        public override string DonationType()
        {
            return "Thank you very much" + this.Name  +  this.Surname + " Age : " + this.Age  + "  Gender : " +  this.Gender   +
                "for your kind donation of " + this.Amount  + 
                this.Currency + "! \n" + "Our Team at World Relief appretiates your'e contribution towards our cause. \n" +
                "WELCOME TO THe POVERTYFIGHTER TEAM! \n" +
                "Together we will defeat SDG Number " + this.SDGID + ": " + this.SDGNAME ; 
        }

        public override string Confirmation()
        {
            return "Confirmation of donation in " + Convert.ToString(MConfirmation()) + " hours." ;
        }

        private int MConfirmation()
        {
            Random hours = new Random();
           int hour = hours.Next(0, 5);
            return hour;
        }

        public double Amount { get { return _Amount; } set { _Amount = value; } }

        public string Currency { get { return _Currency; } set { _Currency = value; } }
    }
}