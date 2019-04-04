using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterModel
{
    public partial class DishInfo
    {
        public int DId { get; set; }
        public string DTitle { get; set; }
        public string DPinyin { get; set; }
        public int DTypeId { get; set; }
        public string DTypeTitle { get; set; }
        public decimal DPrice { get; set; }
    }
}
