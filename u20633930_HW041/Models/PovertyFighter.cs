using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20633930_HW041.Models
{
    public abstract class PovertyFighter
    {
        public List<Money> Mlist = new List<Money>();
        public List<Clothes> Clist = new List<Clothes>();
        public List<Food> Flist = new List<Food>();
        public string _Name;
        public string _Surname;
        public string _Gender;
        public int _Age;
        public int _SDGID;
        public string _SDGNAME;
        public int _DType;

        public PovertyFighter()
        {

        }

        public PovertyFighter(string Name, string Surname, string Gender,  int Age, int SDGID, string SDGNAME,int DType)
        {
            _Name = Name;
            _Surname = Surname;
            _Gender = Gender;
            _Age = Age;
            _SDGID = SDGID;
            _SDGNAME = SDGNAME;
            _DType = DType;


        }

        public abstract string DonationType();

        public abstract string Confirmation();


       



        public string Name { get { return _Name; } set { _Name = value; } }

        public string Surname { get { return _Surname; } set { _Surname = value; } }

        public string Gender { get { return _Gender; } set { _Gender = value; } }


        public int Age { get { return _Age; } set { _Age = value; } }

        public int SDGID { get { return _SDGID; } set { _SDGID = value; } }

        public string SDGNAME { get { return _SDGNAME; } set { _SDGNAME = value; } }







    }
}