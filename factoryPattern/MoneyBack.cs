using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern
{
    public class MoneyBack : CreaditCards
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
