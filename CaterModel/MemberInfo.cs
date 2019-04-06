using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterModel
{
    public partial class MemberInfo
    {
        public int MbId { get; set; }
        public int MbTypeId { get; set; }
        public string MbName { get; set; }
        public string MbPhone { get; set; }
        public decimal MbMoney { get; set; }
        public string MbTypeTitle { get; set; }
        public decimal MbDiscount { get; set; }
    }
}
