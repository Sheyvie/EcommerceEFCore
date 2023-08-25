using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Order
    {

        public int OrderId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ShipmentId { get; set; }
        public Shipment Shipment{ get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
