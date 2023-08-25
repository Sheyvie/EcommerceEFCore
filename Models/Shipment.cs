using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Shipment
    {

        public int ShipmentId { get; set; }

        public string ShipmentAddress { get; set; }

        public DateTime ShipmentDate {  get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
