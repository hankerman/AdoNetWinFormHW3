using AdoNetWinFormHW3.Constans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetWinFormHW3.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Area { get; set; }
        public PartOfWorld PartOfWorld { get; set; }
        public int? CapitalId { get; set; }
        public virtual City Capital { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
