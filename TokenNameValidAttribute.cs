using Portfolio_Krypto.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_Krypto
{
    public class TokenNameValidAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value , ValidationContext validationContext)
        {
            var _context = (ApplicationDbContext)validationContext
                           .GetService(typeof(ApplicationDbContext));
            try
            {
                var idss = from tokenname in _context.TokenName where tokenname.name == value.ToString() select tokenname.name;
                if(idss.Any())
                return ValidationResult.Success;
                else
                    return new ValidationResult("Nie prawidłowa nazwa");
            }
            catch (Exception e)
            {
                return new ValidationResult("blad sprawdzania");

            }



        }
    }
}