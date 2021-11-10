using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_Krypto.Models
{
    public class Token
    {
        public int id { get; set; }
        public string id_geco { get; set; }
        public string userName { get; set; }

        [TokenNameValid]
        public string tokenName { get; set; }
      
        public double price_buy { get; set; }
        public double amount { get; set; }

        [BindProperty, DataType(DataType.Date)]
        public  DateTime date_buy { get; set; }

    }
}
