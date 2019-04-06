using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaterModel;

namespace CaterDal
{
    public partial class OrderPayDal
    {
        string connStr = SqlHelper.GetConnectionString("ItcastCater");

        public int Pay(OrderPayInfo opi)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    SqlTransaction trans = conn.BeginTransaction();
                    cmd.Transaction = trans;
                    // 设置补全订单信息中的付款金额，是否支付
                    string memberStr = string.Empty;
                    // 如果是会员，补全订单信息中的会员信息和折扣
                    if (opi.CMember != null)
                    {
                        memberStr = ", OMemberId = @OMemberId, ODiscount = @ODiscount";
                        cmd.Parameters.AddWithValue("@OMemberId", opi.CMember.MbId);
                        cmd.Parameters.AddWithValue("@ODiscount", opi.CMember.MbDiscount);
                    }
                    cmd.CommandText = "update OrderInfo set OMoney = @OMoney, OIsPay = 1" + memberStr + " where OId = @OId";
                    cmd.Parameters.AddWithValue("@OId", opi.CTable.TOrderId);
                    cmd.Parameters.AddWithValue("@OMoney", opi.CMoney);
                    result += cmd.ExecuteNonQuery();
                    // 如果使用了余额，则扣除余额
                    if (opi.CUseMbMoney)
                    {
                        cmd.CommandText = "update MemberInfo set MbMoney = MbMoney - @CashMoney where MbId = @MbId";
                        cmd.Parameters.Clear(); // 在连续执行sql语句时，后面的每一条sql语句的参数赋值前都应清空
                        cmd.Parameters.AddWithValue("@CashMoney", opi.CMoney);
                        cmd.Parameters.AddWithValue("@MbId", opi.CMember.MbId);
                        result += cmd.ExecuteNonQuery();
                    }
                    // 餐桌状态设为空闲
                    cmd.CommandText = "update TableInfo set TIsFree = 1 where TId = @TId";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@TId", opi.CTable.TId);
                    result += cmd.ExecuteNonQuery();

                    // 提交事务
                    try
                    {
                        trans.Commit();
                    }
                    catch (Exception)
                    {
                        trans.Rollback();
                        result = 0;
                    }
                }
            }
            return result;
        }
    }
}
