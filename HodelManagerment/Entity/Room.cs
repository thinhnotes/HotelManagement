using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HodelManagement.Entity
{
    public class Room
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public List<Image> Image { get; set; }
        public DateTime BlockFrom { get; set; }
        public DateTime BlockEnd { get; set; }
        public List<Inventory> Inventories { get;set; }
        public List<Services> Serviceses { get; set; }
    }
}
