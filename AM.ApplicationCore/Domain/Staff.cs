using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    internal class Staff :Passenger

    {
        public String Function {  get; set; }
        public DateTime EmployementDate { get; set; }

        [DataType(DataType.Currency, ErrorMessage = "Le format de la valeur salariale n'est pas valide.")]
        [Range(0, double.MaxValue, ErrorMessage = "Le salaire doit être une valeur monétaire positive.")]
       public float Salary { get; set; }

    }
}
