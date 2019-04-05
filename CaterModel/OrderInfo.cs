using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterModel
{
    public partial class OrderInfo
    {
        public int Oid { get; set; }
        public int OMemberId { get; set; }
        public DateTime ODate { get; set; }
        public decimal OMoney { get; set; }
        public bool OIsPay { get; set; }
        public int OTableId { get; set; }
        public decimal ODiscount { get; set; }
    }
}
