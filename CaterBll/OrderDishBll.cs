using CaterDal;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterBll
{
    public partial class OrderDishBll
    {
        OrderDishDal odDal = new OrderDishDal();

        public List<OrderDetailInfo> GetList(int id)
        {
            return odDal.GetList(id);
        }

        public bool Edit(OrderDetailInfo odi)
        {
            return odDal.Update(odi) > 0;
        }

        public bool Add(OrderDetailInfo odi)
        {
            return odDal.Insert(odi) > 0;
        }

        public bool Remove(OrderDetailInfo odi)
        {
            return odDal.Delete(odi) > 0;
        }
    }
}
