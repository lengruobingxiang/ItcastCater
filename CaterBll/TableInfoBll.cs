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

        public bool Add(TableInfo di)
        {
            return tiDal.Insert(di) > 0;
        }

        public bool Edit(TableInfo di)
        {
            return tiDal.Update(di) > 0;
        }

        public bool Remove(int id)
        {
            return tiDal.Delete(id) > 0;
        }
    }
}
