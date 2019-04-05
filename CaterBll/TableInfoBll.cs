using CaterDal;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterBll
{
    public partial class TableInfoBll
    {
        TableInfoDal tiDal = new TableInfoDal();

        public List<TableInfo> GetList(Dictionary<string, string> para)
        {
            return tiDal.GetList(para);
        }

        public bool Add(TableInfo ti)
        {
            return tiDal.Insert(ti) > 0;
        }

        public bool Edit(TableInfo ti)
        {
            return tiDal.Update(ti) > 0;
        }

        public bool Remove(int id)
        {
            return tiDal.Delete(id) > 0;
        }

        public bool ChangeState(int tableId)
        {
            return tiDal.ChangeState(tableId) > 0;
        }
    }
}
