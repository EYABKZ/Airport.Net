using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    internal class PlaneConfiguration

    {
        [Key]
        public int PlaneId { get; set; }
    }
}
