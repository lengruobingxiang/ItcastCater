using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterModel
{
    public partial class OrderDetailInfo
    {
        public int ODId { get; set; }
        public int ODOrderId { get; set; }
        public int ODDishId { get; set; }
        public int ODCount { get; set; }
        public string ODDishTitle { get; set; }
        public decimal ODSinglePrice { get; set; }
        public decimal ODTotalPrice
        {
            get => this.ODSinglePrice * this.ODCount;
        }
    }
}
