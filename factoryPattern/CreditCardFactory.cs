using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern
{
    public class CreditCardFactory
    {
        public static CreaditCards GetCreditCard(string cardType)
        {
            CreaditCards cardDetails = null;
            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            return cardDetails;
        }
    }
}
