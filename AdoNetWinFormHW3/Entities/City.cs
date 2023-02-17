using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetWinFormHW3.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Population { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
