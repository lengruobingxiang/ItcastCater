using CaterDal;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterBll
{
    public partial class OrderPayBll
    {
        OrderPayDal opDal = new OrderPayDal();
        public bool Pay(OrderPayInfo opi)
        {
            return opDal.Pay(opi) > 0;
        }
    }
}
