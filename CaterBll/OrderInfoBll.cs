using CaterDal;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterBll
{
    public partial class OrderInfoBll
    {
        OrderInfoDal oiDal = new OrderInfoDal();
        public bool PlaceOrder(int tableId)
        {
            return oiDal.PlaceOrder(tableId) > 0;
        }

        public int GetOrderIdByTableId(int tableId)
        {
            return oiDal.GetOrderIdByTableId(tableId);
        }

        public bool SetOrderMoney(int id, decimal money)
        {
            return oiDal.SetOrderMoney(id, money) > 0;
        }

        public OrderInfo GetOrder(int orderId)
        {
            return oiDal.GetOrder(orderId);
        }
    }
}
