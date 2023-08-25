using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Payment
    {
        
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }

        public string Amount { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
