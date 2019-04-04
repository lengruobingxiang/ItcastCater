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
    public partial class HallInfoDal
    {
        string connStr = SqlHelper.GetConnectionString("ItcastCater");

        public List<HallInfo> GetList()
        {
            string sqlText = "select * from HallInfo where HDelFlag = 0";
            DataTable dt = SqlHelper.ExecuteDataTable(connStr, sqlText);
            List<HallInfo> list = new List<HallInfo>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new HallInfo()
                {
                    HId = ToInt32(row["HId"]),
                    HTitle = row["HTitle"].ToString()
                });
            }
            return list;
        }

        public int Insert(HallInfo hi)
        {
            string sqlText = "insert into HallInfo(HTitle) values (@HTitle)";
            SqlParameter para = new SqlParameter("@HTitle", hi.HTitle);
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, para);
        }

        public int Update(HallInfo hi)
        {
            string sqlText = "update HallInfo set HTitle = @HTitle where HId = @HId";
            SqlParameter[] paras =
            {
                new SqlParameter("@HTitle", hi.HTitle),
                new SqlParameter("@HId", hi.HId)
            };
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, paras);
        }

        public int Delete(int id)
        {
            string sqlText = "update HallInfo set HDelFlag = 1 where HId = @HId";
            SqlParameter para = new SqlParameter("@HId", id);
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, para);
        }
    }
}
