using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20633930_HW041.Models
{
    public  class NPO
    {
        public string _NPOName;
        public int _Founded;
        public string _Purpose;
        public string _TaxIDNum;
        public string _NPOImage;
        public string _EMail;

        public NPO()
        {

        }

        public NPO(string NPOName, int Founded, string Purpose, string TaxIDNum, string NPOImage, string EMail)
        {
            _NPOName = NPOName;
            _Founded = Founded;
            _Purpose = Purpose;
            _TaxIDNum = TaxIDNum;
            _NPOImage = NPOImage;
            _EMail = EMail;
        }

        



        public string NPOName { get { return _NPOName; } set { _NPOName = value; } }

        public int Founded { get { return _Founded; } set { _Founded = value; } }

        public string Purpose { get { return _Purpose; } set { _Purpose = value; } }

        public string TaxIDNum { get { return _TaxIDNum; } set { _TaxIDNum = value; } }

        public string NPOImage { get { return _NPOImage; } set { _NPOImage = value; } }

        public string EMail { get { return _EMail; } set { _EMail = value; } }


    }
}