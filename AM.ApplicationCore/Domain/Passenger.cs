using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    internal class Passenger
    {
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Le prénom doit comporter entre 3 et 25 caractères.")]
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String TelNumber { get; set; }
        public String EmailAdress { get; set; }
        public int PassportNumber { get; set; }
        public DateTime BirthDate { get; set; }


    }
}
