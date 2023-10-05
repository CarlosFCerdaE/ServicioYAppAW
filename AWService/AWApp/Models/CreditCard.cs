using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AWApp.Models
{
    public class CreditCard
    {
        [Display(Name = "ID")]
        public int ID { get; set; }
        [Display(Name = "Card Type")]
        public string CardType { get; set; }
        [Display(Name ="Card Number")]
        public string CardNumber { get; set; }
        [Display(Name ="Expiration Month")]
        public string CardExpirationMonth { get; set; }
        [Display(Name = "Expiration Year")]
        public string CardExpirationYear { get; set; }


    }
}