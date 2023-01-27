using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern
{
    public interface CreaditCards
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
