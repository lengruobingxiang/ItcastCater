using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterModel
{
    public partial class OrderPayInfo
    {
        public TableInfo CTable { get; set; }
        public MemberInfo CMember { get; set; }
        public bool CUseMbMoney { get; set; }
        public decimal CMoney { get; set; }
    }
}
