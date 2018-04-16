using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HodelManagement.Entity
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public Room Room { get; set; }
    }
}
