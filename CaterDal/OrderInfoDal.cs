using CaterModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;

namespace CaterDal
{
    public partial class OrderInfoDal
    {
        string connStr = SqlHelper.GetConnectionString("ItcastCater");

        public OrderInfo GetOrder(int orderId)
        {
            OrderInfo oi = null;
            string sqlText = "select * from OrderInfo where ODelFlag = 0 and OId = @OId and OIsPay = 0";
            SqlParameter para = new SqlParameter("@OId", orderId);
            DataTable dt = SqlHelper.ExecuteDataTable(connStr, sqlText, para);
            foreach (DataRow row in dt.Rows)
            {
                oi = new OrderInfo()
                {
                    Oid = ToInt32(row["Oid"]),
                    OMemberId = row["OMemberId"] == Convert.DBNull ? 0 : ToInt32(row["OMemberId"]),
                    ODate = ToDateTime(row["ODate"]),
                    OMoney = ToDecimal(row["OMoney"]),
                    OIsPay = ToBoolean(row["OIsPay"]),
                    OTableId = ToInt32(row["OTableId"]),
                    ODiscount = ToDecimal(row["ODiscount"])
                };
            }
            return oi;
        }

        public int PlaceOrder(int tableId)
        {
            string sqlText = "insert into [OrderInfo]([OTableId]) values (@OTableId)";
            SqlParameter para = new SqlParameter("@OTableId", tableId);
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, para);
        }

        public int GetOrderIdByTableId(int tableId)
        {
            string sqlText = "select OId from OrderInfo where OTableId = @OTableId and OIsPay = 0";
            SqlParameter para = new SqlParameter("@OTableId", tableId);
            return SqlHelper.ExecuteScalar<int>(connStr, sqlText, para);
        }

        public int SetOrderMoney(int id, decimal money)
        {
            string sqlText = "update OrderInfo set OMoney = @OMoney where OId = @OId";
            SqlParameter[] paras =
            {
                new SqlParameter("@OMoney", money),
                new SqlParameter("@OId", id)
            };
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, paras);
        }
    }
}
