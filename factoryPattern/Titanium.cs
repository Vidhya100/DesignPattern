using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern
{
    public class Titanium :CreaditCards
    {
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
}
