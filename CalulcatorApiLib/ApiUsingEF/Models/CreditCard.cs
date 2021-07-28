using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiUsingEF.Models
{
    public class CreditCard
    {
        public int CreditCardId { get; set; }
        public string CardHoldeName { get; set; }
        public string CardNumber { get; set; }
        public int CVV { get; set; }
        public string ExpireDate { get; set; }
        public string CardType { get; set; }
    }
}
